using CustomForms;
using SoulsFormats;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Text;
using System.Text.Json;
using System.Windows.Forms;
using Utilities;

namespace ParamDbpEditor
{
    public partial class MainForm : Form
    {
        /// <summary>
        /// A list of dbps with pathing information.
        /// Refreshed when LoadDbps is called.
        /// </summary>
        private List<DbpWrapper> Dbps = new List<DbpWrapper>();

        /// <summary>
        /// A list of DbpParams for databinding.
        /// </summary>
        private BindingList<DbpParamWrapper> DbpParams = new BindingList<DbpParamWrapper>();

        public MainForm()
        {
            InitializeComponent();

            // Set custom renderer for dark mode colors
            SelectableColorToolStripRenderer menuRenderer = new SelectableColorToolStripRenderer();
            MainFormMenu.Renderer = menuRenderer;
            MainFormToolStrip.Renderer = menuRenderer;
            ContextMenuFile.Renderer = menuRenderer;

            // Hide image margins on all menuitems containing submenus.
            ((ToolStripDropDownMenu)MenuFile.DropDown).ShowImageMargin = false;
            ((ToolStripDropDownMenu)MenuImport.DropDown).ShowImageMargin = false;
            ((ToolStripDropDownMenu)MenuImportDbp.DropDown).ShowImageMargin = false;
            ((ToolStripDropDownMenu)MenuExport.DropDown).ShowImageMargin = false;
            ((ToolStripDropDownMenu)MenuExportDbp.DropDown).ShowImageMargin = false;
            ((ToolStripDropDownMenu)MenuExportParam.DropDown).ShowImageMargin = false;
            ((ToolStripDropDownMenu)MenuExportTxt.DropDown).ShowImageMargin = false;
            ((ToolStripDropDownMenu)MenuExportTxtXml.DropDown).ShowImageMargin = false;
            ((ToolStripDropDownMenu)MenuExportXml.DropDown).ShowImageMargin = false;
            ((ToolStripDropDownMenu)MenuExportXmlTxt.DropDown).ShowImageMargin = false;
            ((ToolStripDropDownMenu)MenuConvert.DropDown).ShowImageMargin = false;
            ((ToolStripDropDownMenu)MenuConvertDbp.DropDown).ShowImageMargin = false;
            ((ToolStripDropDownMenu)MenuConvertDbpEndian.DropDown).ShowImageMargin = false;
            ((ToolStripDropDownMenu)MenuOther.DropDown).ShowImageMargin = false;
            ContextMenuFile.ShowImageMargin = false;

            // Get the supported dbp games
            string gamesPath = $"{PathUtil.ResourcesFolderPath}\\Games.txt";
            if (!File.Exists(gamesPath))
            {
                string[] gameStrs = new string[] { "AC4", "ACFA", "ACV", "ACVD", "Custom" };
                File.WriteAllLines(gamesPath, gameStrs);
            }

            // Get the dbps for the chosen game
            GameComboBox.Items.AddRange(File.ReadAllLines(gamesPath));
            GameComboBox.SelectedIndex = 0;
            LoadDbps();

            // Set up databinding
            FileDGV.AutoGenerateColumns = false;
            FileDGV.DataSource = DbpParams;
            FileDGV.Columns[0].DataPropertyName = "Name";
        }

        #region FileIO

        private void MenuOpen_Click(object sender, EventArgs e)
        {
            string[] paths = PathUtil.GetFilePaths("C:\\Users", "Open Dbp Params", "Dbp Params (*.bin)|*.bin|All files (*.*)|*.*");
            if (paths == null)
            {
                StatusLabel.Text = "Canceled opening files.";
                return;
            }

            FileHandler(paths);
        }

        private void MenuSave_Click(object sender, EventArgs e)
        {
            if (FileDGV.CurrentRow == null)
                return;

            bool question = FormUtil.ShowQuestionDialog("Are you sure you want to save the currently selected params?", "Save Selected Params");
            if (!question)
                return;

            int saved = 0;
            int dbpSaved = 0;
            int notModified = 0;
            foreach (DataGridViewRow row in FileDGV.SelectedRows)
            {
                var param = (DbpParamWrapper)row.DataBoundItem;
                if (param.Modified)
                {
                    PathUtil.Backup(param.Path);
                    param.Write();
                    param.Modified = false;
                    saved++;
                }
                else
                {
                    notModified++;
                }

                if (param.DbpModified)
                {
                    PathUtil.Backup(param.DbpPath);
                    param.WriteDbp();
                    dbpSaved++;
                }
            }

            StatusLabel.Text = $"Saved {saved} dbp params, {notModified} dbp params were not modified; Saved {dbpSaved} modified dbps to Resources\\{GameComboBox.Text}\\dbp.";
        }

        private void MenuSaveAll_Click(object sender, EventArgs e)
        {
            if (FileDGV.CurrentRow == null)
                return;

            bool question = FormUtil.ShowQuestionDialog("Are you sure you want to save all open params?", "Save All Params");
            if (!question)
                return;

            int saved = 0;
            int dbpSaved = 0;
            int notModified = 0;
            foreach (var param in DbpParams)
            {
                if (param.Modified)
                {
                    PathUtil.Backup(param.Path);
                    param.Write();
                    param.Modified = false;
                    saved++;
                }
                else
                {
                    notModified++;
                }

                if (param.DbpModified)
                {
                    PathUtil.Backup(param.DbpPath);
                    param.WriteDbp();
                    dbpSaved++;
                }
            }

            StatusLabel.Text = $"Saved {saved} dbp params, {notModified} dbp params were not modified; Saved {dbpSaved} modified dbps to Resources\\{GameComboBox.Text}\\dbp.";
        }

        private void MenuClose_Click(object sender, EventArgs e)
        {
            if (FileDGV.CurrentRow == null)
                return;

            bool question = FormUtil.ShowQuestionDialog("Are you sure you want to close the currently selected params?", "Close Selected Params");
            if (!question)
                return;

            int count = FileDGV.SelectedRows.Count;
            foreach (DataGridViewRow row in FileDGV.SelectedRows)
            {
                var param = (DbpParamWrapper)row.DataBoundItem;
                DbpParams.Remove(param);
            }

            if (FileDGV.Rows.Count == 0)
                CellDGV.DataSource = null;

            StatusLabel.Text = $"Closed {count} dbp params.";
        }

        private void MenuCloseAll_Click(object sender, EventArgs e)
        {
            if (FileDGV.CurrentRow == null)
                return;

            bool question = FormUtil.ShowQuestionDialog("Are you sure you want to close open all params?", "Close All Params");
            if (!question)
                return;

            DbpParams.Clear();
            CellDGV.DataSource = null;

            StatusLabel.Text = "Closed all open dbp params.";
        }

        private void ContextMenuFileSave_Click(object sender, EventArgs e)
        {
            MenuSave_Click(sender, e);
        }

        private void ContextMenuFileClose_Click(object sender, EventArgs e)
        {
            MenuClose_Click(sender, e);
        }

        #endregion FileIO

        #region Import

        private void MenuImportDbpDescriptions_Click(object sender, EventArgs e)
        {
            if (FileDGV.CurrentRow == null)
                return;

            string path = PathUtil.GetFilePath("C:\\Users\\", "Select a txt file with descriptions to import into the current dbp", "Txt (*.txt)|*.txt|All files (*.*)|*.*");
            if (path == null)
            {
                StatusLabel.Text = "Canceled importing dbp descriptions.";
                return;
            }

            var encoding = Encoding.GetEncoding(932); // Shift-JIS
            string[] lines = File.ReadAllLines(path, encoding);

            var dbp = ((DbpParamWrapper)FileDGV.CurrentRow.DataBoundItem).AppliedDbp;
            int fieldCount = dbp.Fields.Count;

            if (fieldCount != lines.Length)
            {
                StatusLabel.Text = $"Line count {lines.Length} does not match field count {fieldCount} in dbp.";
                return;
            }

            try
            {
                PARAMDBP.TxtSerializer.DeserializeDescriptions(dbp, path);
                DbpParams[FileDGV.CurrentRow.Index].AppliedDbp = dbp;
            }
            catch
            {
                StatusLabel.Text = "Failed to import descriptions for an unknown reason, canceling.";
                return;
            }

            CellDGV.Refresh();
            StatusLabel.Text = $"Finished importing {lines.Length} into {fieldCount} fields.";
        }

        #endregion Import

        #region Export

        #region DbpExport

        private void MenuExportDbpTxt_Click(object sender, EventArgs e)
        {
            int count = Exporter.ExportDbpToUserPath(Exporter.ExportType.Txt);

            if (count == -1)
                StatusLabel.Text = $"Export operation canceled.";
            else if (count != 0)
                StatusLabel.Text = $"Exported {count} dbps to txt from the chosen files.";
            else
                StatusLabel.Text = $"Failed to export any of the selected files to txt.";
        }

        private void MenuExportDbpXml_Click(object sender, EventArgs e)
        {
            int count = Exporter.ExportDbpToUserPath(Exporter.ExportType.Xml);

            if (count == -1)
                StatusLabel.Text = $"Export operation canceled.";
            else if (count != 0)
                StatusLabel.Text = $"Exported {count} dbps to xml from the chosen files.";
            else
                StatusLabel.Text = $"Failed to export any of the selected files to xml.";
        }

        private void MenuExportDbpJson_Click(object sender, EventArgs e)
        {
            int count = Exporter.ExportDbpToUserPath(Exporter.ExportType.Json);

            if (count == -1)
                StatusLabel.Text = $"Export operation canceled.";
            else if (count != 0)
                StatusLabel.Text = $"Exported {count} dbps to json from the chosen files.";
            else
                StatusLabel.Text = $"Failed to export any of the selected files to json.";
        }

        private void MenuExportDbpParam_Click(object sender, EventArgs e)
        {
            int count = Exporter.ExportDbpToUserPath(Exporter.ExportType.Param);

            if (count == -1)
                StatusLabel.Text = $"Export operation canceled.";
            else if (count != 0)
                StatusLabel.Text = $"Exported {count} dbps to param from the chosen files.";
            else
                StatusLabel.Text = $"Failed to export any of the selected files to param.";
        }

        #endregion DbpExport

        #region ParamExport

        private void MenuExportParamTxt_Click(object sender, EventArgs e)
        {
            int count = Exporter.ExportParamToUserPath(Exporter.ExportType.Txt, Dbps);

            if (count == -1)
                StatusLabel.Text = $"Export operation canceled.";
            else if (count != 0)
                StatusLabel.Text = $"Exported {count} params to txt from the chosen files.";
            else
                StatusLabel.Text = $"Failed to export any of the selected files to txt.";
        }

        private void MenuExportParamXml_Click(object sender, EventArgs e)
        {
            int count = Exporter.ExportParamToUserPath(Exporter.ExportType.Xml, Dbps);

            if (count == -1)
                StatusLabel.Text = $"Export operation canceled.";
            else if (count != 0)
                StatusLabel.Text = $"Exported {count} params to xml from the chosen files.";
            else
                StatusLabel.Text = $"Failed to export any of the selected files to xml.";
        }

        private void MenuExportParamJson_Click(object sender, EventArgs e)
        {
            int count = Exporter.ExportParamToUserPath(Exporter.ExportType.Json, Dbps);

            if (count == -1)
                StatusLabel.Text = $"Export operation canceled.";
            else if (count != 0)
                StatusLabel.Text = $"Exported {count} params to json from the chosen files.";
            else
                StatusLabel.Text = $"Failed to export any of the selected files to json.";
        }

        private void ContextMenuFileExport_Click(object sender, EventArgs e)
        {
            if (FileDGV.CurrentRow == null)
                return;

            string filetype = FormUtil.ShowComboBoxDialog("Select a file type to export to", "Export", Exporter.GetExportTypes(), ComboBoxStyle.DropDownList);
            if (filetype == "")
                return;

            int total = FileDGV.SelectedRows.Count;
            int count = 0;
            foreach (DataGridViewRow row in FileDGV.SelectedRows)
            {
                var param = (DbpParamWrapper)row.DataBoundItem;

                try
                {
                    var type = (Exporter.ExportType)Enum.Parse(typeof(Exporter.ExportType), filetype);
                    PathUtil.Backup($"{Path.GetDirectoryName(param.Path)}\\{Path.GetFileNameWithoutExtension(param.Path)}.{type.GetExtension()}");
                    if (Exporter.Export(param.Param, param.Path, type))
                        count++;
                }
                catch { }
            }

            if (count != 0)
                StatusLabel.Text = $"Exported {count} params to the type {filetype.ToLower()} out of {total} selected params.";
            else
                StatusLabel.Text = $"Failed to export any params to the type \"{filetype.ToLower()}\".";
        }

        #endregion ParamExport

        #region TxtExport

        private void MenuExportTxtDbp_Click(object sender, EventArgs e)
        {
            string[] paths = PathUtil.GetFilePaths("C:\\Users", "Select txt dbps to export to dbp", "Txt (*.txt)|*.txt|All files (*.*)|*.*");
            if (paths == null)
                return;

            int count = 0;
            foreach (string path in paths)
            {
                if (!File.Exists(path))
                    continue;
                try
                {
                    string outPath = $"{Path.GetDirectoryName(path)}\\{Path.GetFileNameWithoutExtension(path)}.dbp";
                    PathUtil.Backup(outPath);
                    PARAMDBP.TxtSerializer.DeserializeDbp(path).Write(outPath);
                    count++;
                }
                catch{}
            }

            StatusLabel.Text = $"Exported {count} txt dbps out of {paths.Length} files to dbps.";
        }

        private void MenuExportTxtParam_Click(object sender, EventArgs e)
        {
            string[] paths = PathUtil.GetFilePaths("C:\\Users", "Select txt params to export to params", "Txt (*.txt)|*.txt|All files (*.*)|*.*");
            if (paths == null)
                return;

            int count = 0;
            foreach (string path in paths)
            {
                if (!File.Exists(path))
                    continue;
                try
                {
                    string outPath = $"{Path.GetDirectoryName(path)}\\{Path.GetFileNameWithoutExtension(path)}.bin";
                    PathUtil.Backup(outPath);
                    PARAMDBP.TxtSerializer.DeserializeParam(path).Write(outPath);
                    count++;
                }
                catch { }
            }

            StatusLabel.Text = $"Exported {count} txt params out of {paths.Length} files to params.";
        }

        private void MenuExportTxtXmlDbp_Click(object sender, EventArgs e)
        {
            string[] paths = PathUtil.GetFilePaths("C:\\Users", "Select txt dbps to export to xml dbps", "Txt (*.txt)|*.txt|All files (*.*)|*.*");
            if (paths == null)
                return;

            int count = 0;
            foreach (string path in paths)
            {
                if (!File.Exists(path))
                    continue;
                try
                {
                    string outPath = $"{Path.GetDirectoryName(path)}\\{Path.GetFileNameWithoutExtension(path)}.xml";
                    PathUtil.Backup(outPath);
                    PARAMDBP.XmlSerializer.Serialize(PARAMDBP.TxtSerializer.DeserializeDbp(path), outPath);
                    count++;
                }
                catch{}
            }

            StatusLabel.Text = $"Exported {count} txt dbps out of {paths.Length} files to xml dbps.";
        }

        private void MenuExportTxtXmlParam_Click(object sender, EventArgs e)
        {
            string[] paths = PathUtil.GetFilePaths("C:\\Users", "Select txt params to export to xml params", "Txt (*.txt)|*.txt|All files (*.*)|*.*");
            if (paths == null)
                return;

            int count = 0;
            foreach (string path in paths)
            {
                if (!File.Exists(path))
                    continue;
                try
                {
                    string outPath = $"{Path.GetDirectoryName(path)}\\{Path.GetFileNameWithoutExtension(path)}.xml";
                    PathUtil.Backup(outPath);
                    PARAMDBP.XmlSerializer.Serialize(PARAMDBP.TxtSerializer.DeserializeParam(path), outPath);
                    count++;
                }
                catch{}
            }

            StatusLabel.Text = $"Exported {count} txt params out of {paths.Length} files to xml params.";
        }

        #endregion TxtExport

        #region XmlExport

        private void MenuExportXmlDbp_Click(object sender, EventArgs e)
        {
            string[] paths = PathUtil.GetFilePaths("C:\\Users", "Select xml dbps to export to dbps", "Xml (*.xml)|*.xml|All files (*.*)|*.*");
            if (paths == null)
                return;

            int count = 0;
            foreach (string path in paths)
            {
                if (!File.Exists(path))
                    continue;
                try
                {
                    string outPath = $"{Path.GetDirectoryName(path)}\\{Path.GetFileNameWithoutExtension(path)}.dbp";
                    PathUtil.Backup(outPath);
                    PARAMDBP.XmlSerializer.DeserializeDbp(path).Write(outPath);
                    count++;
                }
                catch { }
            }

            StatusLabel.Text = $"Exported {count} xml dbps out of {paths.Length} files to dbps.";
        }

        private void MenuExportXmlParam_Click(object sender, EventArgs e)
        {
            string[] paths = PathUtil.GetFilePaths("C:\\Users", "Select xml params to export to params", "Xml (*.xml)|*.xml|All files (*.*)|*.*");
            if (paths == null)
                return;

            int count = 0;
            foreach (string path in paths)
            {
                if (!File.Exists(path))
                    continue;
                try
                {
                    string outPath = $"{Path.GetDirectoryName(path)}\\{Path.GetFileNameWithoutExtension(path)}.bin";
                    PathUtil.Backup(outPath);
                    PARAMDBP.XmlSerializer.DeserializeParam(path).Write(outPath);
                    count++;
                }
                catch { }
            }

            StatusLabel.Text = $"Exported {count} xml params out of {paths.Length} files to params.";
        }

        private void MenuExportXmlTxtDbp_Click(object sender, EventArgs e)
        {
            string[] paths = PathUtil.GetFilePaths("C:\\Users", "Select xml dbps to export to txt dbps", "Xml (*.xml)|*.xml|All files (*.*)|*.*");
            if (paths == null)
                return;

            int count = 0;
            foreach (string path in paths)
            {
                if (!File.Exists(path))
                    continue;
                try
                {
                    string outPath = $"{Path.GetDirectoryName(path)}\\{Path.GetFileNameWithoutExtension(path)}.txt";
                    PathUtil.Backup(outPath);
                    PARAMDBP.TxtSerializer.Serialize(PARAMDBP.XmlSerializer.DeserializeDbp(path), outPath);
                    count++;
                }
                catch{}
            }

            StatusLabel.Text = $"Exported {count} xml dbps out of {paths.Length} files to txt dbps.";
        }

        private void MenuExportXmlTxtParam_Click(object sender, EventArgs e)
        {
            string[] paths = PathUtil.GetFilePaths("C:\\Users", "Select xml params to export to txt params", "Xml (*.xml)|*.xml|All files (*.*)|*.*");
            if (paths == null)
                return;

            int count = 0;
            foreach (string path in paths)
            {
                if (!File.Exists(path))
                    continue;
                try
                {
                    string outPath = $"{Path.GetDirectoryName(path)}\\{Path.GetFileNameWithoutExtension(path)}.txt";
                    PathUtil.Backup(outPath);
                    PARAMDBP.TxtSerializer.Serialize(PARAMDBP.XmlSerializer.DeserializeParam(path), outPath);
                    count++;
                }
                catch{}
            }

            StatusLabel.Text = $"Exported {count} txt params out of {paths.Length} files to xml params.";
        }

        #endregion XmlExport

        #region JsonExport

        private void MenuExportJsonDbp_Click(object sender, EventArgs e)
        {
            string[] paths = PathUtil.GetFilePaths("C:\\Users", "Select json dbps to export to dbp", "Json (*.json)|*.json|All files (*.*)|*.*");
            if (paths == null)
                return;

            int count = 0;
            foreach (string path in paths)
            {
                if (!File.Exists(path))
                    continue;
                try
                {
                    string outPath = $"{Path.GetDirectoryName(path)}\\{Path.GetFileNameWithoutExtension(path)}.dbp";
                    PathUtil.Backup(outPath);
                    var dbp = JsonSerializer.Deserialize<PARAMDBP>(File.ReadAllText(path));
                    dbp = EditorJsonSerializer.ConvertDataToTypes(dbp);
                    dbp.Write(outPath);
                    count++;
                }
                catch{}
            }

            StatusLabel.Text = $"Exported {count} json dbps out of {paths.Length} files to dbps.";
        }

        #endregion JsonExport

        #endregion Export

        #region Convert

        private void MenuConvertDbpEndianBig_Click(object sender, EventArgs e)
        {
            string[] paths = PathUtil.GetFilePaths("C:\\Users", "Select dbps to convert the endianness of", "Dbp (*.dbp)|*.dbp|All files (*.*)|*.*");
            if (paths == null)
                return;

            int count = 0;
            foreach (string path in paths)
            {
                if (!File.Exists(path))
                    continue;
                try
                {
                    PathUtil.Clone(path, true);
                    if (PARAMDBP.Read(path).Convert(path, Converter.ConvertType.BigEndian))
                        count++;
                } catch{}
            }

            StatusLabel.Text = $"Converted {count} dbps out of {paths.Length} files to the big endian byte order.";
        }

        private void MenuConvertDbpEndianLittle_Click(object sender, EventArgs e)
        {
            string[] paths = PathUtil.GetFilePaths("C:\\Users", "Select dbps to convert the endianness of", "Dbp (*.dbp)|*.dbp|All files (*.*)|*.*");
            if (paths == null)
                return;

            int count = 0;
            foreach (string path in paths)
            {
                if (!File.Exists(path))
                    continue;
                try
                {
                    PathUtil.Clone(path, true);
                    if (PARAMDBP.Read(path).Convert(path, Converter.ConvertType.LittleEndian))
                        count++;
                }
                catch{}
            }

            StatusLabel.Text = $"Converted {count} dbps out of {paths.Length} files to the little endian byte order.";
        }

        #endregion Convert

        #region Dump

        private void MenuDumpDbpDescriptions_Click(object sender, EventArgs e)
        {
            string[] paths = PathUtil.GetFilePaths("C:\\Users", "Select dbps to dump the descriptions of", "Dbp (*.dbp)|*.dbp|All files (*.*)|*.*");
            if (paths == null)
                return;

            int count = 0;
            foreach (string path in paths)
            {
                if (!File.Exists(path))
                    continue;
                try
                {
                    PathUtil.Backup($"{Path.GetDirectoryName(path)}\\{Path.GetFileNameWithoutExtension(path)}.descriptions.txt");
                    PARAMDBP.TxtSerializer.SerializeDescriptions(PARAMDBP.Read(path), path);
                    count++;
                }
                catch{}
            }

            if (count != 0)
                StatusLabel.Text = $"Dumped {count} dbps descriptions to txt out of {paths.Length} files.";
            else
                StatusLabel.Text = $"Failed to dump any dbp descriptions.";
        }

        private void MenuDumpParamValues_Click(object sender, EventArgs e)
        {
            if (Dbps == null || Dbps.Count == 0)
                return;

            string[] paths = PathUtil.GetFilePaths("C:\\Users", $"Select params to dump the values of", "Param (*.bin)|*.bin|All files (*.*)|*.*");
            if (paths == null)
                return;

            int count = 0;
            foreach (string path in paths)
            {
                if (!File.Exists(path))
                    continue;
                try
                {
                    PathUtil.Backup($"{Path.GetDirectoryName(path)}\\{Path.GetFileNameWithoutExtension(path)}.values.txt");
                    var param = DBPPARAM.Read(path);
                    if (param.ApplyParamDbp(DbpWrapper.UnwrapDbps(Dbps)))
                    {
                        PARAMDBP.TxtSerializer.SerializeValues(param, path);
                        count++;
                    }       
                }
                catch{}
            }

            if (count != 0)
                StatusLabel.Text = $"Dumped {count} param values to txt out of {paths.Length} files.";
            else
                StatusLabel.Text = $"Failed to dump any params values.";
        }

        private void MenuDumpParamValuesDescriptions_Click(object sender, EventArgs e)
        {
            if (Dbps == null || Dbps.Count == 0)
                return;

            string[] paths = PathUtil.GetFilePaths("C:\\Users", $"Select params to dump the values of", "Param (*.bin)|*.bin|All files (*.*)|*.*");
            if (paths == null)
                return;

            int count = 0;
            foreach (string path in paths)
            {
                if (!File.Exists(path))
                    continue;
                try
                {
                    string outPath = $"{Path.GetDirectoryName(path)}\\{Path.GetFileNameWithoutExtension(path)}.descriptions.values.txt";
                    PathUtil.Backup(outPath);
                    var param = DBPPARAM.Read(path);
                    if (param.ApplyParamDbp(DbpWrapper.UnwrapDbps(Dbps)))
                    {
                        string[] lines = new string[param.Cells.Count];
                        for (int i = 0; i < param.Cells.Count; i++)
                            lines[i] = $"{(param.Cells[i].DisplayName == "" ? "%NULL%" : param.Cells[i].DisplayName)} = {param.Cells[i].Value}";
                        File.WriteAllLines(outPath, lines);
                        count++;
                    }
                }
                catch{}
            }

            if (count != 0)
                StatusLabel.Text = $"Dumped {count} param descriptions-to-values to txt out of {paths.Length} files.";
            else
                StatusLabel.Text = $"Failed to dump any params descriptions-to-values.";
        }

        #endregion Dump

        #region Other

        private void MenuOtherOpenResDir_Click(object sender, EventArgs e)
        {
            if (!Directory.Exists(PathUtil.ResourcesFolderPath))
            {
                bool question = FormUtil.ShowQuestionDialog("WARNING: Resources folder not found, would you like to have it recreated and go to it?", "Recreate Missing Resources Folder");
                if (!question)
                {
                    StatusLabel.Text = $"Canceled Resources folder recreation.";
                    return;
                }

                Directory.CreateDirectory(PathUtil.ResourcesFolderPath);
            }

            if (PathUtil.OpenResources())
                StatusLabel.Text = "Successfully opened the Resources folder.";
            else
                StatusLabel.Text = "Failed to open the Resources folder.";
        }

        #endregion Other

        #region Events

        #region ControlEvents

        private void GameComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadDbps();
        }

        private void FileDGV_SelectionChanged(object sender, EventArgs e)
        {
            if (FileDGV.CurrentRow == null)
                return;

            CellDGV.AutoGenerateColumns = false;
            CellDGV.DataSource = ((DbpParamWrapper)FileDGV.CurrentRow.DataBoundItem).Cells;
            CellDGV.Columns[0].DataPropertyName = "DisplayType";
            CellDGV.Columns[1].DataPropertyName = "DisplayName";
            CellDGV.Columns[2].DataPropertyName = "Value";
        }

        private void CellDGV_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (FileDGV.CurrentRow == null)
                return;

            int index = FileDGV.CurrentRow.Index;

            if (e.ColumnIndex == 2)
            {
                DbpParams[index].Modified = true;
            }
            else
            {
                DbpParams[index].DbpModified = true;
            }
        }

        private void MenuRefresh_Click(object sender, EventArgs e)
        {
            CellDGV.Refresh();
            FileDGV.Refresh();
            StatusLabel.Text = "Refreshed views.";
        }

        #endregion ControlEvents

        #region FormEvents

        private void MainForm_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop)) e.Effect = DragDropEffects.Copy;
        }

        private void MainForm_DragDrop(object sender, DragEventArgs e)
        {
            FileHandler((string[])e.Data.GetData(DataFormats.FileDrop));
        }

        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.O) MenuOpen_Click(sender, e);
            else if (e.Control && e.KeyCode == Keys.S) MenuSave_Click(sender, e);
            else if (e.Control && e.KeyCode == Keys.C) MenuClose_Click(sender, e);
            else if (e.Control && e.Shift && e.KeyCode == Keys.S) MenuSaveAll_Click(sender, e);
            else if (e.Control && e.Shift && e.KeyCode == Keys.C) MenuCloseAll_Click(sender, e);
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            int count = 0;
            foreach (DataGridViewRow row in FileDGV.Rows)
            {
                var param = (DbpParamWrapper)row.DataBoundItem;
                if (param.Modified || param.DbpModified)
                    count++;
            }

            if (count != 0)
            {
                bool question = FormUtil.ShowQuestionDialog($"You still have {count} unsaved params and/or dbps, are you sure you wish to exit without saving?", "Exit without saving");
                if (!question)
                {
                    e.Cancel = true;
                    StatusLabel.Text = "Canceled exiting form without saving.";
                }
            }
        }

        #endregion FormEvents

        #endregion Events

        #region HelperMethods

        private void LoadDbps()
        {
            Dbps.Clear();
            string gamepath = $"{PathUtil.ResourcesFolderPath}\\{GameComboBox.Text}\\dbp";
            Directory.CreateDirectory(gamepath);
            string[] paths = Directory.GetFiles(gamepath, "*.*", SearchOption.AllDirectories);

            int count = 0;
            int total = paths.Length;
            foreach (string path in paths)
            {
                if (!File.Exists(path))
                    continue;

                string extension = Path.GetExtension(path).ToLower();
                PARAMDBP dbp;

                try
                {
                    switch (extension)
                    {
                        case ".dbp":
                            dbp = PARAMDBP.Read(path);
                            break;
                        case ".txt":
                            dbp = PARAMDBP.TxtSerializer.DeserializeDbp(path);
                            break;
                        case ".xml":
                            dbp = PARAMDBP.XmlSerializer.DeserializeDbp(path);
                            break;
                        case ".json":
                            dbp = EditorJsonSerializer.ConvertDataToTypes(JsonSerializer.Deserialize<PARAMDBP>(File.ReadAllText(path)));
                            break;
                        default:
                            total -= 1;
                            continue;
                    }

                    Dbps.Add(new DbpWrapper(dbp, path));
                    count++;
                }
                catch{}
            }

            StatusLabel.Text = $"Loaded {count} dbps out of {total} given dbps in Resources\\{GameComboBox.Text}\\dbp.";
        }

        private DbpWrapper DbpApplyHandlerStrict(ref DBPPARAM param, string name)
        {
            foreach (var dbp in Dbps)
                if (name.Contains(Path.GetFileNameWithoutExtension(dbp.Path).ToLower()) && param.ApplyParamDbp(dbp.Dbp))
                    return dbp;
            return null;
        }

        private DbpWrapper DbpApplyHandler(ref DBPPARAM param, string name)
        {
            foreach (var dbp in Dbps)
                if (param.ApplyParamDbp(dbp.Dbp))
                    return dbp;
            return null;
        }

        private void FileHandler(string[] paths)
        {
            if (Dbps.Count == 0)
            {
                StatusLabel.Text = "No dbps are currently loaded to read the chosen params with.";
                return;
            }

            int count = 0;
            foreach (string path in paths)
            {
                if (!File.Exists(path))
                    continue;

                DBPPARAM dbpparam = DBPPARAM.Read(path);
                string name = Path.GetFileNameWithoutExtension(path).ToLower();
                DbpWrapper dbp;
                if (GameComboBox.Text != "Custom")
                    dbp = DbpApplyHandlerStrict(ref dbpparam, name);
                else
                    dbp = DbpApplyHandler(ref dbpparam, name);
                if (dbp != null)
                {
                    string pathname = Path.GetFileNameWithoutExtension(path).ToLower();
                    string dbppathname = Path.GetFileNameWithoutExtension(dbp.Path).ToLower();
                    if (pathname != dbppathname && GameComboBox.Text != "Custom")
                        continue;

                    DbpParams.Add(new DbpParamWrapper(dbpparam, path, dbp.Path));
                    count++;
                    continue;
                }
            }

            StatusLabel.Text = $"Loaded {count} dbp params out of {paths.Length} files.";
        }

        #endregion HelperMethods

        private void MenuNew_Click(object sender, EventArgs e)
        {

        }
    }
}
