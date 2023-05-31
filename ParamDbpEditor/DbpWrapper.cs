using SoulsFormats;
using System.Collections.Generic;

namespace ParamDbpEditor
{
    /// <summary>
    /// A wrapper to manage dbp editing and saving.
    /// </summary>
    internal class DbpWrapper
    {
        /// <summary>
        /// The underlying dbp.
        /// </summary>
        internal PARAMDBP Dbp { get; set; }

        /// <summary>
        /// The file path to the Dbp.
        /// </summary>
        internal string Path { get; set; }

        /// <summary>
        /// Create a new DbpWrapper with a blank dbp and no path.
        /// </summary>
        internal DbpWrapper()
        {
            Dbp = new PARAMDBP();
        }

        /// <summary>
        /// Create a new DbpWrapper with a blank dbp and path.
        /// </summary>
        /// <param name="path">The file path to the new dbp.</param>
        internal DbpWrapper(string path)
        {
            Dbp = new PARAMDBP();
            Path = path;
        }

        /// <summary>
        /// Create a new DbpWrapper setting just the Dbp.
        /// </summary>
        /// <param name="dbp">The dbp to wrap.</param>
        internal DbpWrapper(PARAMDBP dbp)
        {
            Dbp = dbp;
        }

        /// <summary>
        /// Create a new DbpWrapper setting the Dbp and the path to the Dbp.
        /// </summary>
        /// <param name="dbp">The dbp to wrap.</param>
        /// <param name="path">The file path to the dbp.</param>
        internal DbpWrapper(PARAMDBP dbp, string path)
        {
            Dbp = dbp;
            Path = path;
        }

        internal void Write()
        {
            Dbp.Write(Path);
        }

        /// <summary>
        /// Return a list of the Dbps themselves.
        /// </summary>
        /// <param name="dbps">A list of DbpWrappers.</param>
        /// <returns>A list of Dbps.</returns>
        internal static List<PARAMDBP> UnwrapDbps(IEnumerable<DbpWrapper> dbps)
        {
            List<PARAMDBP> paramdbps = new List<PARAMDBP>();
            foreach (DbpWrapper dbp in dbps)
                paramdbps.Add(dbp.Dbp);
            return paramdbps;
        }
    }
}