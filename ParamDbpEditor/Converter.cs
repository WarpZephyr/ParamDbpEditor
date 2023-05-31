using SoulsFormats;

namespace ParamDbpEditor
{
    /// <summary>
    /// A class containing methods for converting data in a file format.
    /// </summary>
    internal static class Converter
    {
        /// <summary>
        /// What conversion to perform.
        /// </summary>
        internal enum ConvertType
        {
            /// <summary>
            /// Convert endianness to big endian.
            /// </summary>
            BigEndian,

            /// <summary>
            /// Convert endianness to little endian.
            /// </summary>
            LittleEndian
        }

        /// <summary>
        /// Convert a dbp.
        /// </summary>
        /// <param name="dbp">The dbp to convert</param>
        /// <param name="path">The path to save the conversion to.</param>
        /// <param name="type">The conversion to perform.</param>
        /// <returns>Whether or not the conversion was successful.</returns>
        internal static bool Convert(this PARAMDBP dbp, string path, ConvertType type)
        {
            try
            {
                switch (type)
                {
                    case ConvertType.BigEndian:
                        dbp.WriteBigEndian = true;
                        dbp.Write(path);
                        return true;
                    case ConvertType.LittleEndian:
                        dbp.WriteBigEndian = false;
                        dbp.Write(path);
                        return true;
                    default:
                        return false;
                }
            }
            catch
            {
                return false;
            }
        }
    }
}
