namespace ParamDbpEditor
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.MainFormMenu = new System.Windows.Forms.MenuStrip();
            this.MenuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuSave = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuClose = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuSaveAll = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuCloseAll = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuFileSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.MenuImport = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuImportDbp = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuImportDbpDescriptions = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuExport = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuExportDbp = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuExportDbpTxt = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuExportDbpXml = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuExportDbpJson = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuExportDbpParam = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuExportParam = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuExportParamTxt = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuExportParamXml = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuExportParamJson = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuExportTxt = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuExportTxtDbp = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuExportTxtParam = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuExportTxtXml = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuExportTxtXmlDbp = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuExportTxtXmlParam = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuExportXml = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuExportXmlDbp = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuExportXmlParam = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuExportXmlTxt = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuExportXmlTxtDbp = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuExportXmlTxtParam = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuExportJson = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuExportJsonDbp = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuConvert = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuConvertDbp = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuConvertDbpEndian = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuConvertDbpEndianBig = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuConvertDbpEndianLittle = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuDump = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuDumpDbp = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuDumpDbpDescriptions = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuDumpParam = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuDumpParamValues = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuDumpParamValuesDescriptions = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuOther = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuOtherOpenResDir = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuRefresh = new System.Windows.Forms.ToolStripMenuItem();
            this.MainFormToolStrip = new System.Windows.Forms.ToolStrip();
            this.StatusLabel = new System.Windows.Forms.ToolStripLabel();
            this.GameComboBox = new System.Windows.Forms.ToolStripComboBox();
            this.MainSplitContainer = new System.Windows.Forms.SplitContainer();
            this.FileDGV = new System.Windows.Forms.DataGridView();
            this.filename = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ContextMenuFile = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ContextMenuFileSave = new System.Windows.Forms.ToolStripMenuItem();
            this.ContextMenuFileClose = new System.Windows.Forms.ToolStripMenuItem();
            this.ContextMenuFileExport = new System.Windows.Forms.ToolStripMenuItem();
            this.CellDGV = new System.Windows.Forms.DataGridView();
            this.celltype = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.celldescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cellvalue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MainFormMenu.SuspendLayout();
            this.MainFormToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MainSplitContainer)).BeginInit();
            this.MainSplitContainer.Panel1.SuspendLayout();
            this.MainSplitContainer.Panel2.SuspendLayout();
            this.MainSplitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FileDGV)).BeginInit();
            this.ContextMenuFile.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CellDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // MainFormMenu
            // 
            this.MainFormMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.MainFormMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuFile,
            this.MenuOther,
            this.MenuRefresh});
            this.MainFormMenu.Location = new System.Drawing.Point(0, 0);
            this.MainFormMenu.Name = "MainFormMenu";
            this.MainFormMenu.Size = new System.Drawing.Size(800, 24);
            this.MainFormMenu.TabIndex = 0;
            this.MainFormMenu.Text = "menuStrip1";
            // 
            // MenuFile
            // 
            this.MenuFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.MenuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuOpen,
            this.MenuSave,
            this.MenuClose,
            this.MenuSaveAll,
            this.MenuCloseAll,
            this.MenuFileSeparator1,
            this.MenuImport,
            this.MenuExport,
            this.MenuConvert,
            this.MenuDump});
            this.MenuFile.ForeColor = System.Drawing.SystemColors.Control;
            this.MenuFile.Name = "MenuFile";
            this.MenuFile.Size = new System.Drawing.Size(37, 20);
            this.MenuFile.Text = "File";
            // 
            // MenuOpen
            // 
            this.MenuOpen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.MenuOpen.ForeColor = System.Drawing.SystemColors.Control;
            this.MenuOpen.Name = "MenuOpen";
            this.MenuOpen.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.MenuOpen.Size = new System.Drawing.Size(194, 22);
            this.MenuOpen.Text = "Open";
            this.MenuOpen.Click += new System.EventHandler(this.MenuOpen_Click);
            // 
            // MenuSave
            // 
            this.MenuSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.MenuSave.ForeColor = System.Drawing.SystemColors.Control;
            this.MenuSave.Name = "MenuSave";
            this.MenuSave.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.MenuSave.Size = new System.Drawing.Size(194, 22);
            this.MenuSave.Text = "Save";
            this.MenuSave.ToolTipText = "Save all currently selected params.";
            this.MenuSave.Click += new System.EventHandler(this.MenuSave_Click);
            // 
            // MenuClose
            // 
            this.MenuClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.MenuClose.ForeColor = System.Drawing.SystemColors.Control;
            this.MenuClose.Name = "MenuClose";
            this.MenuClose.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
            this.MenuClose.Size = new System.Drawing.Size(194, 22);
            this.MenuClose.Text = "Close";
            this.MenuClose.ToolTipText = "Close all currently selected params.";
            this.MenuClose.Click += new System.EventHandler(this.MenuClose_Click);
            // 
            // MenuSaveAll
            // 
            this.MenuSaveAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.MenuSaveAll.ForeColor = System.Drawing.SystemColors.Control;
            this.MenuSaveAll.Name = "MenuSaveAll";
            this.MenuSaveAll.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.MenuSaveAll.Size = new System.Drawing.Size(194, 22);
            this.MenuSaveAll.Text = "Save All";
            this.MenuSaveAll.ToolTipText = "Save all open params.";
            this.MenuSaveAll.Click += new System.EventHandler(this.MenuSaveAll_Click);
            // 
            // MenuCloseAll
            // 
            this.MenuCloseAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.MenuCloseAll.ForeColor = System.Drawing.SystemColors.Control;
            this.MenuCloseAll.Name = "MenuCloseAll";
            this.MenuCloseAll.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.D)));
            this.MenuCloseAll.Size = new System.Drawing.Size(194, 22);
            this.MenuCloseAll.Text = "Close All";
            this.MenuCloseAll.ToolTipText = "Close all open params.";
            this.MenuCloseAll.Click += new System.EventHandler(this.MenuCloseAll_Click);
            // 
            // MenuFileSeparator1
            // 
            this.MenuFileSeparator1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.MenuFileSeparator1.ForeColor = System.Drawing.SystemColors.Control;
            this.MenuFileSeparator1.Name = "MenuFileSeparator1";
            this.MenuFileSeparator1.Size = new System.Drawing.Size(191, 6);
            // 
            // MenuImport
            // 
            this.MenuImport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.MenuImport.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuImportDbp});
            this.MenuImport.ForeColor = System.Drawing.SystemColors.Control;
            this.MenuImport.Name = "MenuImport";
            this.MenuImport.Size = new System.Drawing.Size(194, 22);
            this.MenuImport.Text = "Import";
            this.MenuImport.ToolTipText = "Import data into the editor or current files within the editor.";
            // 
            // MenuImportDbp
            // 
            this.MenuImportDbp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.MenuImportDbp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuImportDbpDescriptions});
            this.MenuImportDbp.ForeColor = System.Drawing.SystemColors.Control;
            this.MenuImportDbp.Name = "MenuImportDbp";
            this.MenuImportDbp.Size = new System.Drawing.Size(96, 22);
            this.MenuImportDbp.Text = "Dbp";
            this.MenuImportDbp.ToolTipText = "Import data into dbps";
            // 
            // MenuImportDbpDescriptions
            // 
            this.MenuImportDbpDescriptions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.MenuImportDbpDescriptions.ForeColor = System.Drawing.SystemColors.Control;
            this.MenuImportDbpDescriptions.Name = "MenuImportDbpDescriptions";
            this.MenuImportDbpDescriptions.Size = new System.Drawing.Size(139, 22);
            this.MenuImportDbpDescriptions.Text = "Descriptions";
            this.MenuImportDbpDescriptions.ToolTipText = "Import new descriptions into a dbp.";
            this.MenuImportDbpDescriptions.Click += new System.EventHandler(this.MenuImportDbpDescriptions_Click);
            // 
            // MenuExport
            // 
            this.MenuExport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.MenuExport.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuExportDbp,
            this.MenuExportParam,
            this.MenuExportTxt,
            this.MenuExportXml,
            this.MenuExportJson});
            this.MenuExport.ForeColor = System.Drawing.SystemColors.Control;
            this.MenuExport.Name = "MenuExport";
            this.MenuExport.Size = new System.Drawing.Size(194, 22);
            this.MenuExport.Text = "Export";
            this.MenuExport.ToolTipText = "Export supported files to various other formats.";
            // 
            // MenuExportDbp
            // 
            this.MenuExportDbp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.MenuExportDbp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuExportDbpTxt,
            this.MenuExportDbpXml,
            this.MenuExportDbpJson,
            this.MenuExportDbpParam});
            this.MenuExportDbp.ForeColor = System.Drawing.SystemColors.Control;
            this.MenuExportDbp.Name = "MenuExportDbp";
            this.MenuExportDbp.Size = new System.Drawing.Size(108, 22);
            this.MenuExportDbp.Text = "Dbp";
            this.MenuExportDbp.ToolTipText = "Export dbps to various supported formats.";
            // 
            // MenuExportDbpTxt
            // 
            this.MenuExportDbpTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.MenuExportDbpTxt.ForeColor = System.Drawing.SystemColors.Control;
            this.MenuExportDbpTxt.Name = "MenuExportDbpTxt";
            this.MenuExportDbpTxt.Size = new System.Drawing.Size(108, 22);
            this.MenuExportDbpTxt.Text = "Txt";
            this.MenuExportDbpTxt.ToolTipText = "Export dbps to txt.";
            this.MenuExportDbpTxt.Click += new System.EventHandler(this.MenuExportDbpTxt_Click);
            // 
            // MenuExportDbpXml
            // 
            this.MenuExportDbpXml.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.MenuExportDbpXml.ForeColor = System.Drawing.SystemColors.Control;
            this.MenuExportDbpXml.Name = "MenuExportDbpXml";
            this.MenuExportDbpXml.Size = new System.Drawing.Size(108, 22);
            this.MenuExportDbpXml.Text = "Xml";
            this.MenuExportDbpXml.ToolTipText = "Export dbps to xml.";
            this.MenuExportDbpXml.Click += new System.EventHandler(this.MenuExportDbpXml_Click);
            // 
            // MenuExportDbpJson
            // 
            this.MenuExportDbpJson.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.MenuExportDbpJson.ForeColor = System.Drawing.SystemColors.Control;
            this.MenuExportDbpJson.Name = "MenuExportDbpJson";
            this.MenuExportDbpJson.Size = new System.Drawing.Size(108, 22);
            this.MenuExportDbpJson.Text = "Json";
            this.MenuExportDbpJson.ToolTipText = "Export dbps to json.";
            this.MenuExportDbpJson.Click += new System.EventHandler(this.MenuExportDbpJson_Click);
            // 
            // MenuExportDbpParam
            // 
            this.MenuExportDbpParam.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.MenuExportDbpParam.ForeColor = System.Drawing.SystemColors.Control;
            this.MenuExportDbpParam.Name = "MenuExportDbpParam";
            this.MenuExportDbpParam.Size = new System.Drawing.Size(108, 22);
            this.MenuExportDbpParam.Text = "Param";
            this.MenuExportDbpParam.ToolTipText = "Export dbps to params with default values.";
            this.MenuExportDbpParam.Click += new System.EventHandler(this.MenuExportDbpParam_Click);
            // 
            // MenuExportParam
            // 
            this.MenuExportParam.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.MenuExportParam.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuExportParamTxt,
            this.MenuExportParamXml,
            this.MenuExportParamJson});
            this.MenuExportParam.ForeColor = System.Drawing.SystemColors.Control;
            this.MenuExportParam.Name = "MenuExportParam";
            this.MenuExportParam.Size = new System.Drawing.Size(108, 22);
            this.MenuExportParam.Text = "Param";
            this.MenuExportParam.ToolTipText = "Export params to various supported formats.";
            // 
            // MenuExportParamTxt
            // 
            this.MenuExportParamTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.MenuExportParamTxt.ForeColor = System.Drawing.SystemColors.Control;
            this.MenuExportParamTxt.Name = "MenuExportParamTxt";
            this.MenuExportParamTxt.Size = new System.Drawing.Size(97, 22);
            this.MenuExportParamTxt.Text = "Txt";
            this.MenuExportParamTxt.ToolTipText = "Export params to txt.";
            this.MenuExportParamTxt.Click += new System.EventHandler(this.MenuExportParamTxt_Click);
            // 
            // MenuExportParamXml
            // 
            this.MenuExportParamXml.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.MenuExportParamXml.ForeColor = System.Drawing.SystemColors.Control;
            this.MenuExportParamXml.Name = "MenuExportParamXml";
            this.MenuExportParamXml.Size = new System.Drawing.Size(97, 22);
            this.MenuExportParamXml.Text = "Xml";
            this.MenuExportParamXml.ToolTipText = "Export params to xml.";
            this.MenuExportParamXml.Click += new System.EventHandler(this.MenuExportParamXml_Click);
            // 
            // MenuExportParamJson
            // 
            this.MenuExportParamJson.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.MenuExportParamJson.ForeColor = System.Drawing.SystemColors.Control;
            this.MenuExportParamJson.Name = "MenuExportParamJson";
            this.MenuExportParamJson.Size = new System.Drawing.Size(97, 22);
            this.MenuExportParamJson.Text = "Json";
            this.MenuExportParamJson.ToolTipText = "Export params to json.";
            this.MenuExportParamJson.Click += new System.EventHandler(this.MenuExportParamJson_Click);
            // 
            // MenuExportTxt
            // 
            this.MenuExportTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.MenuExportTxt.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuExportTxtDbp,
            this.MenuExportTxtParam,
            this.MenuExportTxtXml});
            this.MenuExportTxt.ForeColor = System.Drawing.SystemColors.Control;
            this.MenuExportTxt.Name = "MenuExportTxt";
            this.MenuExportTxt.Size = new System.Drawing.Size(108, 22);
            this.MenuExportTxt.Text = "Txt";
            this.MenuExportTxt.ToolTipText = "Export serialized txt files to their original formats.";
            // 
            // MenuExportTxtDbp
            // 
            this.MenuExportTxtDbp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.MenuExportTxtDbp.ForeColor = System.Drawing.SystemColors.Control;
            this.MenuExportTxtDbp.Name = "MenuExportTxtDbp";
            this.MenuExportTxtDbp.Size = new System.Drawing.Size(108, 22);
            this.MenuExportTxtDbp.Text = "Dbp";
            this.MenuExportTxtDbp.ToolTipText = "Export serialized txt files back to dbps.";
            this.MenuExportTxtDbp.Click += new System.EventHandler(this.MenuExportTxtDbp_Click);
            // 
            // MenuExportTxtParam
            // 
            this.MenuExportTxtParam.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.MenuExportTxtParam.ForeColor = System.Drawing.SystemColors.Control;
            this.MenuExportTxtParam.Name = "MenuExportTxtParam";
            this.MenuExportTxtParam.Size = new System.Drawing.Size(108, 22);
            this.MenuExportTxtParam.Text = "Param";
            this.MenuExportTxtParam.ToolTipText = "Export serialized txt files back to params.";
            this.MenuExportTxtParam.Click += new System.EventHandler(this.MenuExportTxtParam_Click);
            // 
            // MenuExportTxtXml
            // 
            this.MenuExportTxtXml.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.MenuExportTxtXml.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuExportTxtXmlDbp,
            this.MenuExportTxtXmlParam});
            this.MenuExportTxtXml.ForeColor = System.Drawing.SystemColors.Control;
            this.MenuExportTxtXml.Name = "MenuExportTxtXml";
            this.MenuExportTxtXml.Size = new System.Drawing.Size(108, 22);
            this.MenuExportTxtXml.Text = "Xml";
            this.MenuExportTxtXml.ToolTipText = "Export serialized txt files to serialized xml files.";
            // 
            // MenuExportTxtXmlDbp
            // 
            this.MenuExportTxtXmlDbp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.MenuExportTxtXmlDbp.ForeColor = System.Drawing.SystemColors.Control;
            this.MenuExportTxtXmlDbp.Name = "MenuExportTxtXmlDbp";
            this.MenuExportTxtXmlDbp.Size = new System.Drawing.Size(108, 22);
            this.MenuExportTxtXmlDbp.Text = "Dbp";
            this.MenuExportTxtXmlDbp.ToolTipText = "Export serialized dbp txt files to serialized dbp xml files.";
            this.MenuExportTxtXmlDbp.Click += new System.EventHandler(this.MenuExportTxtXmlDbp_Click);
            // 
            // MenuExportTxtXmlParam
            // 
            this.MenuExportTxtXmlParam.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.MenuExportTxtXmlParam.ForeColor = System.Drawing.SystemColors.Control;
            this.MenuExportTxtXmlParam.Name = "MenuExportTxtXmlParam";
            this.MenuExportTxtXmlParam.Size = new System.Drawing.Size(108, 22);
            this.MenuExportTxtXmlParam.Text = "Param";
            this.MenuExportTxtXmlParam.ToolTipText = "Export serialized param txt files to serialized param xml files.";
            this.MenuExportTxtXmlParam.Click += new System.EventHandler(this.MenuExportTxtXmlParam_Click);
            // 
            // MenuExportXml
            // 
            this.MenuExportXml.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.MenuExportXml.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuExportXmlDbp,
            this.MenuExportXmlParam,
            this.MenuExportXmlTxt});
            this.MenuExportXml.ForeColor = System.Drawing.SystemColors.Control;
            this.MenuExportXml.Name = "MenuExportXml";
            this.MenuExportXml.Size = new System.Drawing.Size(108, 22);
            this.MenuExportXml.Text = "Xml";
            this.MenuExportXml.ToolTipText = "Export serialized xml files to their original formats.";
            // 
            // MenuExportXmlDbp
            // 
            this.MenuExportXmlDbp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.MenuExportXmlDbp.ForeColor = System.Drawing.SystemColors.Control;
            this.MenuExportXmlDbp.Name = "MenuExportXmlDbp";
            this.MenuExportXmlDbp.Size = new System.Drawing.Size(108, 22);
            this.MenuExportXmlDbp.Text = "Dbp";
            this.MenuExportXmlDbp.ToolTipText = "Export serialized xml files back to dbps.";
            this.MenuExportXmlDbp.Click += new System.EventHandler(this.MenuExportXmlDbp_Click);
            // 
            // MenuExportXmlParam
            // 
            this.MenuExportXmlParam.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.MenuExportXmlParam.ForeColor = System.Drawing.SystemColors.Control;
            this.MenuExportXmlParam.Name = "MenuExportXmlParam";
            this.MenuExportXmlParam.Size = new System.Drawing.Size(108, 22);
            this.MenuExportXmlParam.Text = "Param";
            this.MenuExportXmlParam.ToolTipText = "Export serialized xml files back to params.";
            this.MenuExportXmlParam.Click += new System.EventHandler(this.MenuExportXmlParam_Click);
            // 
            // MenuExportXmlTxt
            // 
            this.MenuExportXmlTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.MenuExportXmlTxt.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuExportXmlTxtDbp,
            this.MenuExportXmlTxtParam});
            this.MenuExportXmlTxt.ForeColor = System.Drawing.SystemColors.Control;
            this.MenuExportXmlTxt.Name = "MenuExportXmlTxt";
            this.MenuExportXmlTxt.Size = new System.Drawing.Size(108, 22);
            this.MenuExportXmlTxt.Text = "Txt";
            this.MenuExportXmlTxt.ToolTipText = "Export serialized xml files to serialized txt files.";
            // 
            // MenuExportXmlTxtDbp
            // 
            this.MenuExportXmlTxtDbp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.MenuExportXmlTxtDbp.ForeColor = System.Drawing.SystemColors.Control;
            this.MenuExportXmlTxtDbp.Name = "MenuExportXmlTxtDbp";
            this.MenuExportXmlTxtDbp.Size = new System.Drawing.Size(108, 22);
            this.MenuExportXmlTxtDbp.Text = "Dbp";
            this.MenuExportXmlTxtDbp.ToolTipText = "Export serialized dbp xml files to serialized dbp txt files.";
            this.MenuExportXmlTxtDbp.Click += new System.EventHandler(this.MenuExportXmlTxtDbp_Click);
            // 
            // MenuExportXmlTxtParam
            // 
            this.MenuExportXmlTxtParam.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.MenuExportXmlTxtParam.ForeColor = System.Drawing.SystemColors.Control;
            this.MenuExportXmlTxtParam.Name = "MenuExportXmlTxtParam";
            this.MenuExportXmlTxtParam.Size = new System.Drawing.Size(108, 22);
            this.MenuExportXmlTxtParam.Text = "Param";
            this.MenuExportXmlTxtParam.ToolTipText = "Export serialized param xml files to serialized param txt files.";
            this.MenuExportXmlTxtParam.Click += new System.EventHandler(this.MenuExportXmlTxtParam_Click);
            // 
            // MenuExportJson
            // 
            this.MenuExportJson.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.MenuExportJson.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuExportJsonDbp});
            this.MenuExportJson.ForeColor = System.Drawing.SystemColors.Control;
            this.MenuExportJson.Name = "MenuExportJson";
            this.MenuExportJson.Size = new System.Drawing.Size(108, 22);
            this.MenuExportJson.Text = "Json";
            this.MenuExportJson.ToolTipText = "Export serialized json files to their original formats.";
            // 
            // MenuExportJsonDbp
            // 
            this.MenuExportJsonDbp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.MenuExportJsonDbp.ForeColor = System.Drawing.SystemColors.Control;
            this.MenuExportJsonDbp.Name = "MenuExportJsonDbp";
            this.MenuExportJsonDbp.Size = new System.Drawing.Size(96, 22);
            this.MenuExportJsonDbp.Text = "Dbp";
            this.MenuExportJsonDbp.ToolTipText = "Export serialized json files back to dbps.";
            this.MenuExportJsonDbp.Click += new System.EventHandler(this.MenuExportJsonDbp_Click);
            // 
            // MenuConvert
            // 
            this.MenuConvert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.MenuConvert.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuConvertDbp});
            this.MenuConvert.ForeColor = System.Drawing.SystemColors.Control;
            this.MenuConvert.Name = "MenuConvert";
            this.MenuConvert.Size = new System.Drawing.Size(194, 22);
            this.MenuConvert.Text = "Convert";
            this.MenuConvert.ToolTipText = "Convert data within supported file types.";
            // 
            // MenuConvertDbp
            // 
            this.MenuConvertDbp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.MenuConvertDbp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuConvertDbpEndian});
            this.MenuConvertDbp.ForeColor = System.Drawing.SystemColors.Control;
            this.MenuConvertDbp.Name = "MenuConvertDbp";
            this.MenuConvertDbp.Size = new System.Drawing.Size(96, 22);
            this.MenuConvertDbp.Text = "Dbp";
            this.MenuConvertDbp.ToolTipText = "Convert data within dbps.";
            // 
            // MenuConvertDbpEndian
            // 
            this.MenuConvertDbpEndian.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.MenuConvertDbpEndian.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuConvertDbpEndianBig,
            this.MenuConvertDbpEndianLittle});
            this.MenuConvertDbpEndian.ForeColor = System.Drawing.SystemColors.Control;
            this.MenuConvertDbpEndian.Name = "MenuConvertDbpEndian";
            this.MenuConvertDbpEndian.Size = new System.Drawing.Size(133, 22);
            this.MenuConvertDbpEndian.Text = "Endianness";
            this.MenuConvertDbpEndian.ToolTipText = "Convert the endianness of dbps.";
            // 
            // MenuConvertDbpEndianBig
            // 
            this.MenuConvertDbpEndianBig.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.MenuConvertDbpEndianBig.ForeColor = System.Drawing.SystemColors.Control;
            this.MenuConvertDbpEndianBig.Name = "MenuConvertDbpEndianBig";
            this.MenuConvertDbpEndianBig.Size = new System.Drawing.Size(139, 22);
            this.MenuConvertDbpEndianBig.Text = "Big Endian";
            this.MenuConvertDbpEndianBig.ToolTipText = "Convert dbps\' byte order to big endian.";
            this.MenuConvertDbpEndianBig.Click += new System.EventHandler(this.MenuConvertDbpEndianBig_Click);
            // 
            // MenuConvertDbpEndianLittle
            // 
            this.MenuConvertDbpEndianLittle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.MenuConvertDbpEndianLittle.ForeColor = System.Drawing.SystemColors.Control;
            this.MenuConvertDbpEndianLittle.Name = "MenuConvertDbpEndianLittle";
            this.MenuConvertDbpEndianLittle.Size = new System.Drawing.Size(139, 22);
            this.MenuConvertDbpEndianLittle.Text = "Little Endian";
            this.MenuConvertDbpEndianLittle.ToolTipText = "Convert dbps\' byte order to little endian.";
            this.MenuConvertDbpEndianLittle.Click += new System.EventHandler(this.MenuConvertDbpEndianLittle_Click);
            // 
            // MenuDump
            // 
            this.MenuDump.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.MenuDump.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuDumpDbp,
            this.MenuDumpParam});
            this.MenuDump.ForeColor = System.Drawing.SystemColors.Control;
            this.MenuDump.Name = "MenuDump";
            this.MenuDump.Size = new System.Drawing.Size(194, 22);
            this.MenuDump.Text = "Dump";
            this.MenuDump.ToolTipText = "Dump data from supported data types.";
            // 
            // MenuDumpDbp
            // 
            this.MenuDumpDbp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.MenuDumpDbp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuDumpDbpDescriptions});
            this.MenuDumpDbp.ForeColor = System.Drawing.SystemColors.Control;
            this.MenuDumpDbp.Name = "MenuDumpDbp";
            this.MenuDumpDbp.Size = new System.Drawing.Size(108, 22);
            this.MenuDumpDbp.Text = "Dbp";
            this.MenuDumpDbp.ToolTipText = "Dump data from dbps.";
            // 
            // MenuDumpDbpDescriptions
            // 
            this.MenuDumpDbpDescriptions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.MenuDumpDbpDescriptions.ForeColor = System.Drawing.SystemColors.Control;
            this.MenuDumpDbpDescriptions.Name = "MenuDumpDbpDescriptions";
            this.MenuDumpDbpDescriptions.Size = new System.Drawing.Size(139, 22);
            this.MenuDumpDbpDescriptions.Text = "Descriptions";
            this.MenuDumpDbpDescriptions.ToolTipText = "Dump dbp descriptions to a txt file.";
            this.MenuDumpDbpDescriptions.Click += new System.EventHandler(this.MenuDumpDbpDescriptions_Click);
            // 
            // MenuDumpParam
            // 
            this.MenuDumpParam.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.MenuDumpParam.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuDumpParamValues,
            this.MenuDumpParamValuesDescriptions});
            this.MenuDumpParam.ForeColor = System.Drawing.SystemColors.Control;
            this.MenuDumpParam.Name = "MenuDumpParam";
            this.MenuDumpParam.Size = new System.Drawing.Size(108, 22);
            this.MenuDumpParam.Text = "Param";
            this.MenuDumpParam.ToolTipText = "Dump data from params.";
            // 
            // MenuDumpParamValues
            // 
            this.MenuDumpParamValues.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.MenuDumpParamValues.ForeColor = System.Drawing.SystemColors.Control;
            this.MenuDumpParamValues.Name = "MenuDumpParamValues";
            this.MenuDumpParamValues.Size = new System.Drawing.Size(201, 22);
            this.MenuDumpParamValues.Text = "Values";
            this.MenuDumpParamValues.ToolTipText = "Dump param values to a txt file.";
            this.MenuDumpParamValues.Click += new System.EventHandler(this.MenuDumpParamValues_Click);
            // 
            // MenuDumpParamValuesDescriptions
            // 
            this.MenuDumpParamValuesDescriptions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.MenuDumpParamValuesDescriptions.ForeColor = System.Drawing.SystemColors.Control;
            this.MenuDumpParamValuesDescriptions.Name = "MenuDumpParamValuesDescriptions";
            this.MenuDumpParamValuesDescriptions.Size = new System.Drawing.Size(201, 22);
            this.MenuDumpParamValuesDescriptions.Text = "Values with Descriptions";
            this.MenuDumpParamValuesDescriptions.ToolTipText = "Dump param descriptions-to-values to a txt file.";
            this.MenuDumpParamValuesDescriptions.Click += new System.EventHandler(this.MenuDumpParamValuesDescriptions_Click);
            // 
            // MenuOther
            // 
            this.MenuOther.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.MenuOther.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuOtherOpenResDir});
            this.MenuOther.ForeColor = System.Drawing.SystemColors.Control;
            this.MenuOther.Name = "MenuOther";
            this.MenuOther.Size = new System.Drawing.Size(49, 20);
            this.MenuOther.Text = "Other";
            this.MenuOther.ToolTipText = "Misc things.";
            // 
            // MenuOtherOpenResDir
            // 
            this.MenuOtherOpenResDir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.MenuOtherOpenResDir.ForeColor = System.Drawing.SystemColors.Control;
            this.MenuOtherOpenResDir.Name = "MenuOtherOpenResDir";
            this.MenuOtherOpenResDir.Size = new System.Drawing.Size(195, 22);
            this.MenuOtherOpenResDir.Text = "Open Resources Folder";
            this.MenuOtherOpenResDir.ToolTipText = "Open the Resources folder.";
            this.MenuOtherOpenResDir.Click += new System.EventHandler(this.MenuOtherOpenResDir_Click);
            // 
            // MenuRefresh
            // 
            this.MenuRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.MenuRefresh.ForeColor = System.Drawing.SystemColors.Control;
            this.MenuRefresh.Name = "MenuRefresh";
            this.MenuRefresh.Size = new System.Drawing.Size(58, 20);
            this.MenuRefresh.Text = "Refresh";
            this.MenuRefresh.ToolTipText = "Refresh the DatGridView controls.";
            this.MenuRefresh.Click += new System.EventHandler(this.MenuRefresh_Click);
            // 
            // MainFormToolStrip
            // 
            this.MainFormToolStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.MainFormToolStrip.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.MainFormToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StatusLabel,
            this.GameComboBox});
            this.MainFormToolStrip.Location = new System.Drawing.Point(0, 425);
            this.MainFormToolStrip.Name = "MainFormToolStrip";
            this.MainFormToolStrip.Size = new System.Drawing.Size(800, 25);
            this.MainFormToolStrip.TabIndex = 1;
            // 
            // StatusLabel
            // 
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(0, 22);
            // 
            // GameComboBox
            // 
            this.GameComboBox.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.GameComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.GameComboBox.Name = "GameComboBox";
            this.GameComboBox.Size = new System.Drawing.Size(121, 25);
            this.GameComboBox.SelectedIndexChanged += new System.EventHandler(this.GameComboBox_SelectedIndexChanged);
            // 
            // MainSplitContainer
            // 
            this.MainSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainSplitContainer.Location = new System.Drawing.Point(0, 24);
            this.MainSplitContainer.Name = "MainSplitContainer";
            // 
            // MainSplitContainer.Panel1
            // 
            this.MainSplitContainer.Panel1.Controls.Add(this.FileDGV);
            // 
            // MainSplitContainer.Panel2
            // 
            this.MainSplitContainer.Panel2.Controls.Add(this.CellDGV);
            this.MainSplitContainer.Size = new System.Drawing.Size(800, 401);
            this.MainSplitContainer.SplitterDistance = 266;
            this.MainSplitContainer.TabIndex = 2;
            // 
            // FileDGV
            // 
            this.FileDGV.AllowUserToAddRows = false;
            this.FileDGV.AllowUserToDeleteRows = false;
            this.FileDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.FileDGV.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.FileDGV.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.FileDGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.FileDGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.FileDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.FileDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.FileDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.filename});
            this.FileDGV.ContextMenuStrip = this.ContextMenuFile;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.FileDGV.DefaultCellStyle = dataGridViewCellStyle11;
            this.FileDGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FileDGV.EnableHeadersVisualStyles = false;
            this.FileDGV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.FileDGV.Location = new System.Drawing.Point(0, 0);
            this.FileDGV.Name = "FileDGV";
            this.FileDGV.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.FileDGV.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.FileDGV.RowTemplate.Height = 24;
            this.FileDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.FileDGV.Size = new System.Drawing.Size(266, 401);
            this.FileDGV.TabIndex = 1;
            this.FileDGV.SelectionChanged += new System.EventHandler(this.FileDGV_SelectionChanged);
            // 
            // filename
            // 
            this.filename.HeaderText = "Name";
            this.filename.Name = "filename";
            this.filename.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ContextMenuFile
            // 
            this.ContextMenuFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ContextMenuFile.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ContextMenuFileSave,
            this.ContextMenuFileClose,
            this.ContextMenuFileExport});
            this.ContextMenuFile.Name = "ContextMenuFile";
            this.ContextMenuFile.Size = new System.Drawing.Size(109, 70);
            // 
            // ContextMenuFileSave
            // 
            this.ContextMenuFileSave.ForeColor = System.Drawing.SystemColors.Control;
            this.ContextMenuFileSave.Name = "ContextMenuFileSave";
            this.ContextMenuFileSave.Size = new System.Drawing.Size(108, 22);
            this.ContextMenuFileSave.Text = "Save";
            this.ContextMenuFileSave.ToolTipText = "Save all currently selected params.";
            this.ContextMenuFileSave.Click += new System.EventHandler(this.ContextMenuFileSave_Click);
            // 
            // ContextMenuFileClose
            // 
            this.ContextMenuFileClose.ForeColor = System.Drawing.SystemColors.Control;
            this.ContextMenuFileClose.Name = "ContextMenuFileClose";
            this.ContextMenuFileClose.Size = new System.Drawing.Size(108, 22);
            this.ContextMenuFileClose.Text = "Close";
            this.ContextMenuFileClose.ToolTipText = "Close all currently selected params.";
            this.ContextMenuFileClose.Click += new System.EventHandler(this.ContextMenuFileClose_Click);
            // 
            // ContextMenuFileExport
            // 
            this.ContextMenuFileExport.ForeColor = System.Drawing.SystemColors.Control;
            this.ContextMenuFileExport.Name = "ContextMenuFileExport";
            this.ContextMenuFileExport.Size = new System.Drawing.Size(108, 22);
            this.ContextMenuFileExport.Text = "Export";
            this.ContextMenuFileExport.ToolTipText = "Export the currently selected params to various supported formats.";
            this.ContextMenuFileExport.Click += new System.EventHandler(this.ContextMenuFileExport_Click);
            // 
            // CellDGV
            // 
            this.CellDGV.AllowUserToAddRows = false;
            this.CellDGV.AllowUserToDeleteRows = false;
            this.CellDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.CellDGV.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.CellDGV.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.CellDGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CellDGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.CellDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.CellDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CellDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.celltype,
            this.celldescription,
            this.cellvalue});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.CellDGV.DefaultCellStyle = dataGridViewCellStyle8;
            this.CellDGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CellDGV.EnableHeadersVisualStyles = false;
            this.CellDGV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.CellDGV.Location = new System.Drawing.Point(0, 0);
            this.CellDGV.Name = "CellDGV";
            this.CellDGV.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.CellDGV.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.CellDGV.RowTemplate.Height = 24;
            this.CellDGV.Size = new System.Drawing.Size(530, 401);
            this.CellDGV.TabIndex = 1;
            this.CellDGV.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.CellDGV_CellValueChanged);
            // 
            // celltype
            // 
            this.celltype.FillWeight = 76.14214F;
            this.celltype.HeaderText = "Type";
            this.celltype.Name = "celltype";
            this.celltype.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // celldescription
            // 
            this.celldescription.FillWeight = 111.9289F;
            this.celldescription.HeaderText = "Description";
            this.celldescription.Name = "celldescription";
            this.celldescription.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // cellvalue
            // 
            this.cellvalue.FillWeight = 111.9289F;
            this.cellvalue.HeaderText = "Value";
            this.cellvalue.Name = "cellvalue";
            this.cellvalue.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // MainForm
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.MainSplitContainer);
            this.Controls.Add(this.MainFormToolStrip);
            this.Controls.Add(this.MainFormMenu);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.MainMenuStrip = this.MainFormMenu;
            this.Name = "MainForm";
            this.Text = "Param Dbp Editor";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.MainForm_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.MainForm_DragEnter);
            this.MainFormMenu.ResumeLayout(false);
            this.MainFormMenu.PerformLayout();
            this.MainFormToolStrip.ResumeLayout(false);
            this.MainFormToolStrip.PerformLayout();
            this.MainSplitContainer.Panel1.ResumeLayout(false);
            this.MainSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MainSplitContainer)).EndInit();
            this.MainSplitContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.FileDGV)).EndInit();
            this.ContextMenuFile.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CellDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MainFormMenu;
        private System.Windows.Forms.ToolStripMenuItem MenuFile;
        private System.Windows.Forms.ToolStrip MainFormToolStrip;
        private System.Windows.Forms.ToolStripLabel StatusLabel;
        private System.Windows.Forms.ToolStripMenuItem MenuOpen;
        private System.Windows.Forms.ToolStripMenuItem MenuSave;
        private System.Windows.Forms.ToolStripMenuItem MenuClose;
        private System.Windows.Forms.SplitContainer MainSplitContainer;
        private System.Windows.Forms.DataGridView FileDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn filename;
        private System.Windows.Forms.DataGridView CellDGV;
        private System.Windows.Forms.ToolStripMenuItem MenuSaveAll;
        private System.Windows.Forms.ToolStripMenuItem MenuCloseAll;
        private System.Windows.Forms.ToolStripComboBox GameComboBox;
        private System.Windows.Forms.ToolStripMenuItem MenuConvert;
        private System.Windows.Forms.ToolStripSeparator MenuFileSeparator1;
        private System.Windows.Forms.ToolStripMenuItem MenuExport;
        private System.Windows.Forms.ToolStripMenuItem MenuExportDbp;
        private System.Windows.Forms.ToolStripMenuItem MenuExportDbpTxt;
        private System.Windows.Forms.ToolStripMenuItem MenuExportParam;
        private System.Windows.Forms.ToolStripMenuItem MenuExportDbpXml;
        private System.Windows.Forms.ToolStripMenuItem MenuExportDbpParam;
        private System.Windows.Forms.ToolStripMenuItem MenuExportParamTxt;
        private System.Windows.Forms.ToolStripMenuItem MenuExportParamXml;
        private System.Windows.Forms.ToolStripMenuItem MenuConvertDbp;
        private System.Windows.Forms.ToolStripMenuItem MenuConvertDbpEndian;
        private System.Windows.Forms.ToolStripMenuItem MenuConvertDbpEndianBig;
        private System.Windows.Forms.ToolStripMenuItem MenuConvertDbpEndianLittle;
        private System.Windows.Forms.ToolStripMenuItem MenuExportTxt;
        private System.Windows.Forms.ToolStripMenuItem MenuExportTxtParam;
        private System.Windows.Forms.ToolStripMenuItem MenuExportTxtDbp;
        private System.Windows.Forms.ToolStripMenuItem MenuExportTxtXml;
        private System.Windows.Forms.ToolStripMenuItem MenuExportTxtXmlDbp;
        private System.Windows.Forms.ToolStripMenuItem MenuExportTxtXmlParam;
        private System.Windows.Forms.ToolStripMenuItem MenuExportXml;
        private System.Windows.Forms.ToolStripMenuItem MenuExportXmlParam;
        private System.Windows.Forms.ToolStripMenuItem MenuExportXmlDbp;
        private System.Windows.Forms.ToolStripMenuItem MenuExportXmlTxt;
        private System.Windows.Forms.ToolStripMenuItem MenuExportXmlTxtDbp;
        private System.Windows.Forms.ToolStripMenuItem MenuExportXmlTxtParam;
        private System.Windows.Forms.ContextMenuStrip ContextMenuFile;
        private System.Windows.Forms.ToolStripMenuItem ContextMenuFileSave;
        private System.Windows.Forms.ToolStripMenuItem ContextMenuFileClose;
        private System.Windows.Forms.ToolStripMenuItem ContextMenuFileExport;
        private System.Windows.Forms.ToolStripMenuItem MenuExportParamJson;
        private System.Windows.Forms.ToolStripMenuItem MenuExportDbpJson;
        private System.Windows.Forms.ToolStripMenuItem MenuExportJson;
        private System.Windows.Forms.ToolStripMenuItem MenuExportJsonDbp;
        private System.Windows.Forms.ToolStripMenuItem MenuDump;
        private System.Windows.Forms.ToolStripMenuItem MenuDumpDbp;
        private System.Windows.Forms.ToolStripMenuItem MenuDumpDbpDescriptions;
        private System.Windows.Forms.ToolStripMenuItem MenuDumpParam;
        private System.Windows.Forms.ToolStripMenuItem MenuDumpParamValues;
        private System.Windows.Forms.ToolStripMenuItem MenuDumpParamValuesDescriptions;
        private System.Windows.Forms.ToolStripMenuItem MenuImport;
        private System.Windows.Forms.ToolStripMenuItem MenuImportDbp;
        private System.Windows.Forms.ToolStripMenuItem MenuImportDbpDescriptions;
        private System.Windows.Forms.ToolStripMenuItem MenuOther;
        private System.Windows.Forms.ToolStripMenuItem MenuOtherOpenResDir;
        private System.Windows.Forms.ToolStripMenuItem MenuRefresh;
        private System.Windows.Forms.DataGridViewTextBoxColumn celltype;
        private System.Windows.Forms.DataGridViewTextBoxColumn celldescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn cellvalue;
    }
}

