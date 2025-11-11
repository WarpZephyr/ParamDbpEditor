using CustomForms;
using SoulsFormats;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Windows.Forms;
using Utilities;

namespace ParamDbpEditor
{
    public partial class MainForm : Form
    {
        /// <summary>
        /// A list of dbps with pathing information.<br/>
        /// Refreshed when LoadDbps is called.
        /// </summary>
        private readonly List<DbpInfo> Dbps;

        /// <summary>
        /// A list of params for databinding.
        /// </summary>
        private readonly BindingList<ParamInfo> DbpParams;

        /// <summary>
        /// Whether or not events are currently locked.
        /// </summary>
        private bool EventsLocked = false;

        public MainForm()
        {
            InitializeComponent();
            Dbps = [];
            DbpParams = [];

            // Set custom renderer for dark mode colors
            SelectableColorToolStripRenderer menuRenderer = new SelectableColorToolStripRenderer();
            MainFormMenu.Renderer = menuRenderer;
            MainFormToolStrip.Renderer = menuRenderer;
            ContextMenuFile.Renderer = menuRenderer;

            // Hide image margins on all menuitems containing submenus.
            ((ToolStripDropDownMenu)MenuFile.DropDown).ShowImageMargin = false;
            ((ToolStripDropDownMenu)MenuOther.DropDown).ShowImageMargin = false;
            ContextMenuFile.ShowImageMargin = false;

            // Refresh games
            RefreshDbpGames();

            // Load dbps
            LoadDbps();

            // Set up databinding
            FileDGV.AutoGenerateColumns = false;
            FileDGV.DataSource = DbpParams;
            FileDGV.Columns[0].DataPropertyName = "Name";
        }

        #region Menu File

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
                var param = (ParamInfo)row.DataBoundItem;
                if (param.Modified)
                {
                    PathUtil.Backup(param.FilePath);
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
                    PathUtil.Backup(param.FilePath);
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
                var param = (ParamInfo)row.DataBoundItem;
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

        #endregion

        #region Menu Other

        private void MenuOtherOpenResDir_Click(object sender, EventArgs e)
        {
            Directory.CreateDirectory(PathUtil.ResourcesFolderPath);
            if (PathUtil.OpenResources())
                StatusLabel.Text = "Successfully opened the Resources folder.";
            else
                StatusLabel.Text = "Failed to open the Resources folder.";
        }

        #endregion

        #region Menu Refresh

        private void MenuRefresh_Click(object sender, EventArgs e)
        {
            RefreshDbpGames();
            LoadDbps();

            CellDGV.Refresh();
            FileDGV.Refresh();
            StatusLabel.Text = "Refreshed editor.";
        }

        #endregion

        #region Context Menu File

        private void ContextMenuFileSave_Click(object sender, EventArgs e)
        {
            MenuSave_Click(sender, e);
        }

        private void ContextMenuFileClose_Click(object sender, EventArgs e)
        {
            MenuClose_Click(sender, e);
        }

        #endregion

        #region Game ComboBox

        private void GameComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadDbps();
        }

        #endregion

        #region Data Grid Views

        private void FileDGV_SelectionChanged(object sender, EventArgs e)
        {
            if (FileDGV.CurrentRow == null)
                return;

            CellDGV.AutoGenerateColumns = false;
            CellDGV.DataSource = ((ParamInfo)FileDGV.CurrentRow.DataBoundItem).Cells;
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

        #endregion

        #region Refresh

        private void RefreshDbpGames()
        {
            LockEvents();

            // Create folder just in case it doesn't exist
            Directory.CreateDirectory(PathUtil.ResourcesFolderPath);

            // Gather game folder paths
            string[] gamenames = Directory.GetDirectories(PathUtil.ResourcesFolderPath);

            // Get folder names
            for (int i = 0; i < gamenames.Length; i++)
                gamenames[i] = Path.GetFileName(gamenames[i]);

            // Clear old names
            foreach (string item in GameComboBox.Items)
                if (!gamenames.Contains(item))
                    GameComboBox.Items.Remove(item);

            // Add new names
            for (int i = 0; i < gamenames.Length; i++)
                if (!GameComboBox.Items.Contains(gamenames[i]))
                    GameComboBox.Items.Add(gamenames[i]);

            // Ensure valid index is selected
            if (GameComboBox.SelectedIndex < 0)
            {
                GameComboBox.SelectedIndex = 0;
            }
            else if (GameComboBox.SelectedIndex >= GameComboBox.Items.Count)
            {
                GameComboBox.SelectedIndex = GameComboBox.Items.Count - 1;
            }

            UnlockEvents();
        }

        #endregion

        #region Drag and Drop

        private void MainForm_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop)) e.Effect = DragDropEffects.Copy;
        }

        private void MainForm_DragDrop(object sender, DragEventArgs e)
        {
            FileHandler((string[])e.Data.GetData(DataFormats.FileDrop));
        }

        #endregion

        #region Key Events

        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.O) MenuOpen_Click(sender, e);
            else if (e.Control && e.KeyCode == Keys.S) MenuSave_Click(sender, e);
            else if (e.Control && e.KeyCode == Keys.C) MenuClose_Click(sender, e);
            else if (e.Control && e.Shift && e.KeyCode == Keys.S) MenuSaveAll_Click(sender, e);
            else if (e.Control && e.Shift && e.KeyCode == Keys.C) MenuCloseAll_Click(sender, e);
        }

        #endregion

        #region Form Events

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            int count = 0;
            foreach (DataGridViewRow row in FileDGV.Rows)
            {
                var param = (ParamInfo)row.DataBoundItem;
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

        #endregion

        #region Helper Methods

        private void LoadDbps()
        {
            Dbps.Clear();
            string gamepath = $"{PathUtil.ResourcesFolderPath}\\{GameComboBox.Text}\\dbp";
            if (!Directory.Exists(gamepath))
            {
                StatusLabel.Text = "Curent dbp selection doesn't exist, refreshing dbp games.";
                RefreshDbpGames();
                LoadDbps();
                return;
            }
            
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

                    Dbps.Add(new DbpInfo(dbp, path));
                    count++;
                }
                catch{}
            }

            StatusLabel.Text = $"Loaded {count} dbps out of {total} given dbps in Resources\\{GameComboBox.Text}\\dbp.";
        }

        private DbpInfo DbpApplyHandlerStrict(ref DBPPARAM param, string name)
        {
            foreach (var dbp in Dbps)
                if (!name.EndsWith(".dbp")
                    && name.StartsWith(Path.GetFileNameWithoutExtension(dbp.Path), StringComparison.CurrentCultureIgnoreCase)
                    && param.ApplyParamDbp(dbp.Dbp))
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
                string name = Path.GetFileName(path);
                DbpInfo dbp;
                dbp = DbpApplyHandlerStrict(ref dbpparam, name);
                if (dbp != null)
                {
                    DbpParams.Add(new ParamInfo(dbpparam, path, dbp.Path));
                    count++;
                }
            }

            StatusLabel.Text = $"Loaded {count} dbp params out of {paths.Length} files.";
        }

        private void LockEvents()
        {
            if (EventsLocked)
            {
                throw new InvalidOperationException("Events are already locked.");
            }

            GameComboBox.SelectedIndexChanged -= new EventHandler(GameComboBox_SelectedIndexChanged);
            EventsLocked = true;
        }

        private void UnlockEvents()
        {
            if (!EventsLocked)
            {
                throw new InvalidOperationException("Events are not locked yet.");
            }

            GameComboBox.SelectedIndexChanged += new EventHandler(GameComboBox_SelectedIndexChanged);
            EventsLocked = false;
        }

        #endregion
    }
}
