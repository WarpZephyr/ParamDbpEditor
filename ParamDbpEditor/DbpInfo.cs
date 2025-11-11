using SoulsFormats;
using System.Collections.Generic;

namespace ParamDbpEditor
{
    /// <summary>
    /// A wrapper to manage dbp editing and saving.
    /// </summary>
    internal class DbpInfo
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
        internal DbpInfo()
        {
            Dbp = new PARAMDBP();
        }

        /// <summary>
        /// Create a new DbpWrapper with a blank dbp and path.
        /// </summary>
        /// <param name="path">The file path to the new dbp.</param>
        internal DbpInfo(string path)
        {
            Dbp = new PARAMDBP();
            Path = path;
        }

        /// <summary>
        /// Create a new DbpWrapper setting just the Dbp.
        /// </summary>
        /// <param name="dbp">The dbp to wrap.</param>
        internal DbpInfo(PARAMDBP dbp)
        {
            Dbp = dbp;
        }

        /// <summary>
        /// Create a new DbpWrapper setting the Dbp and the path to the Dbp.
        /// </summary>
        /// <param name="dbp">The dbp to wrap.</param>
        /// <param name="path">The file path to the dbp.</param>
        internal DbpInfo(PARAMDBP dbp, string path)
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
        internal static List<PARAMDBP> UnwrapDbps(IEnumerable<DbpInfo> dbps)
        {
            List<PARAMDBP> paramdbps = new List<PARAMDBP>();
            foreach (DbpInfo dbp in dbps)
                paramdbps.Add(dbp.Dbp);
            return paramdbps;
        }
    }
}