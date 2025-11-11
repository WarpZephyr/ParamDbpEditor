using SoulsFormats;
using System;
using System.IO;
using System.Text.Encodings.Web;
using System.Text.Json;

namespace ParamDbpEditor
{
    /// <summary>
    /// A class containing methods for exporting files to different formats.
    /// </summary>
    internal static class Exporter
    {
        /// <summary>
        /// The file type to export to.
        /// </summary>
        internal enum ExportType
        {
            /// <summary>
            /// Export to txt.
            /// </summary>
            Txt,

            /// <summary>
            /// Export to xml.
            /// </summary>
            Xml,

            /// <summary>
            /// Export to json.
            /// </summary>
            Json,

            /// <summary>
            /// Export to dbp.
            /// </summary>
            Dbp,

            /// <summary>
            /// Export to param.
            /// </summary>
            Param
        }

        /// <summary>
        /// Export a dbp.
        /// </summary>
        /// <param name="dbp">The dbp to export.</param>
        /// <param name="path">The path to export to.</param>
        /// <param name="type">The file type to export to.</param>
        /// <returns>Whether or not the export was successful.</returns>
        internal static bool Export(this PARAMDBP dbp, string path, ExportType type)
        {
            try
            {
                switch (type)
                {
                    case ExportType.Txt:
                        PARAMDBP.TxtSerializer.SerializeDbp(dbp, $"{Path.GetDirectoryName(path)}\\{Path.GetFileNameWithoutExtension(path)}.txt");
                        return true;
                    case ExportType.Xml:
                        PARAMDBP.XmlSerializer.SerializeDbp(dbp, $"{Path.GetDirectoryName(path)}\\{Path.GetFileNameWithoutExtension(path)}.xml");
                        return true;
                    case ExportType.Json:
                        var options = new JsonSerializerOptions();
                        options.WriteIndented = true;
                        options.Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping;
                        string json = JsonSerializer.Serialize(dbp, options);
                        File.WriteAllText($"{Path.GetDirectoryName(path)}\\{Path.GetFileNameWithoutExtension(path)}.json", json);
                        return true;
                    case ExportType.Param:
                        new DBPPARAM(dbp).Write($"{Path.GetDirectoryName(path)}\\{Path.GetFileNameWithoutExtension(path)}.bin");
                        return true;
                    case ExportType.Dbp:
                        dbp.Write();
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

        /// <summary>
        /// Export a param.
        /// </summary>
        /// <param name="param">The param to export.</param>
        /// <param name="path">The path to export to.</param>
        /// <param name="type">The file type to export to.</param>
        /// <returns>Whether or not the export was successful.</returns>
        internal static bool Export(this DBPPARAM param, string path, ExportType type)
        {
            if (!param.DbpApplied)
                return false;

            try
            {
                switch (type)
                {
                    case ExportType.Txt:
                        PARAMDBP.TxtSerializer.SerializeParam(param, $"{Path.GetDirectoryName(path)}\\{Path.GetFileNameWithoutExtension(path)}.txt");
                        return true;
                    case ExportType.Xml:
                        PARAMDBP.XmlSerializer.SerializeParam(param, $"{Path.GetDirectoryName(path)}\\{Path.GetFileNameWithoutExtension(path)}.xml");
                        return true;
                    case ExportType.Json:
                        var options = new JsonSerializerOptions();
                        options.WriteIndented = true;
                        options.IgnoreReadOnlyProperties = true;
                        options.Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping;
                        string json = JsonSerializer.Serialize(param, options);
                        File.WriteAllText($"{Path.GetDirectoryName(path)}\\{Path.GetFileNameWithoutExtension(path)}.json", json);
                        return true;
                    case ExportType.Param:
                        param.Write();
                        return true;
                    case ExportType.Dbp:
                        param.AppliedParamDbp.Write($"{Path.GetDirectoryName(path)}\\{Path.GetFileNameWithoutExtension(path)}.dbp");
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

        internal static string[] GetExportTypes()
        {
            return Enum.GetNames(typeof(ExportType));
        }

        internal static string GetExtension(this ExportType type)
        {
            switch (type)
            {
                case ExportType.Txt:
                    return "txt";
                case ExportType.Xml:
                    return "xml";
                case ExportType.Json:
                    return "json";
                case ExportType.Param:
                    return "bin";
                case ExportType.Dbp:
                    return "dbp";
                default:
                    return null;
            }
        }
    }
}
