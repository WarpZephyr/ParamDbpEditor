using SoulsFormats;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using Utilities;

namespace ParamDbpEditor
{
    /// <summary>
    /// A wrapper made to find paths to save DbpParams to easier.
    /// </summary>
    internal class DbpParamWrapper
    {
        /// <summary>
        /// The param itself.
        /// </summary>
        internal DBPPARAM Param { get; set; }

        /// <summary>
        /// The cells in the param.
        /// </summary>
        public List<CellWrapper> Cells
        {
            get => CellWrapper.CellsToWrapper(Param.Cells);
        }

        /// <summary>
        /// The param's applied Dbp.
        /// </summary>
        internal PARAMDBP AppliedDbp
        {
            get => Param.AppliedParamDbp;
            set
            {
                Param.ApplyParamDbp(value ?? throw new InvalidDataException("The dbp to apply cannot be null."));
                DbpModified = true;
            }
        }

        /// <summary>
        /// Used to hold the value of the path of the param file for getting and setting.
        /// </summary>
        private string Field_Path { get; set; }

        /// <summary>
        /// The path the param was loaded from and will be saved to.
        /// </summary>
        internal string Path
        {
            get => Field_Path;
            set
            {
                Field_Path = value;
                Modified = true;
            }
        }

        /// <summary>
        /// Used to hold the value of the path of the applied dbp file for getting and setting.
        /// </summary>
        private string Field_DbpPath { get; set; }

        /// <summary>
        /// The path the param was loaded from and will be saved to.
        /// </summary>
        internal string DbpPath
        {
            get => Field_DbpPath;
            set
            {
                Field_DbpPath = value;
                DbpModified = true;
            }
        }

        /// <summary>
        /// Used to hold the value of the name of the param file for getting and setting.
        /// </summary>
        private string Field_Name { get; set; }

        /// <summary>
        /// The name of the param file.
        /// </summary>
        public string Name
        {
            get => Field_Name;
            set
            {
                if (value == null)
                    throw new InvalidDataException("Name of param file cannot be null.");

                string dir = System.IO.Path.GetDirectoryName(Path);
                string newPath = System.IO.Path.Combine(dir, value);

                foreach (string path in Directory.GetFiles(dir))
                {
                    if (File.Exists(newPath))
                    {
                        newPath = Path;
                        break;
                    }
                }

                Path = newPath;
                Field_Name = value;
                Modified = true;
            }
        }

        /// <summary>
        /// Whether or not the param should be saved or skipped over at save time.
        /// </summary>
        internal bool Modified { get; set; }

        /// <summary>
        /// Whether or not the dbp should be saved or skipped over at save time.
        /// </summary>
        internal bool DbpModified { get; set; }

        /// <summary>
        /// Create a new param wrapper with an empty param and no paths set.
        /// </summary>
        internal DbpParamWrapper()
        {
            var param = new DBPPARAM();
            Param = param;
            Modified = false;
            DbpModified = false;
        }

        /// <summary>
        /// Create a new param wrapper with the chosen param and no paths set.
        /// </summary>
        /// <param name="param">The param to place in the wrapper.</param>
        internal DbpParamWrapper(DBPPARAM param)
        {
            Param = param;
            Modified = false;
            DbpModified = false;
        }

        /// <summary>
        /// Create a new param wrapper with the chosen param and paths.
        /// </summary>
        /// <param name="param">The param to place in the wrapper.</param>
        /// <param name="path">The full file path to the chosen param.</param>
        internal DbpParamWrapper(DBPPARAM param, string path, string dbpPath)
        {
            Param = param;
            Field_Path = path;
            Field_DbpPath = dbpPath;
            Field_Name = System.IO.Path.GetFileName(path);
            Modified = false;
            DbpModified = false;
        }

        /// <summary>
        /// Write the wrapped param's dbp easier.
        /// </summary>
        internal void WriteDbp()
        {
            string extension = System.IO.Path.GetExtension(DbpPath).ToLower();
            switch (extension)
            {
                case ".dbp":
                    AppliedDbp.Write(DbpPath);
                    break;
                case ".txt":
                    PARAMDBP.TxtSerializer.Serialize(AppliedDbp, DbpPath);
                    break;
                case ".xml":
                    PARAMDBP.XmlSerializer.Serialize(AppliedDbp, DbpPath);
                    break;
                case ".json":
                    break; // Not supported yet
            }

            DbpModified = false;
        }

        /// <summary>
        /// Write the wrapped param easier.
        /// </summary>
        internal void Write()
        {
            Param.Write(Path);
        }
    }
}
