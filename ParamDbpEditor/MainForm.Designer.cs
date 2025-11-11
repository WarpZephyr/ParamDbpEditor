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
            components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            MainFormMenu = new System.Windows.Forms.MenuStrip();
            MenuFile = new System.Windows.Forms.ToolStripMenuItem();
            MenuOpen = new System.Windows.Forms.ToolStripMenuItem();
            MenuSave = new System.Windows.Forms.ToolStripMenuItem();
            MenuClose = new System.Windows.Forms.ToolStripMenuItem();
            MenuSaveAll = new System.Windows.Forms.ToolStripMenuItem();
            MenuCloseAll = new System.Windows.Forms.ToolStripMenuItem();
            MenuOther = new System.Windows.Forms.ToolStripMenuItem();
            MenuOtherOpenResDir = new System.Windows.Forms.ToolStripMenuItem();
            MenuRefresh = new System.Windows.Forms.ToolStripMenuItem();
            MainFormToolStrip = new System.Windows.Forms.ToolStrip();
            StatusLabel = new System.Windows.Forms.ToolStripLabel();
            MainSplitContainer = new System.Windows.Forms.SplitContainer();
            FileDGV = new System.Windows.Forms.DataGridView();
            filename = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ContextMenuFile = new System.Windows.Forms.ContextMenuStrip(components);
            ContextMenuFileSave = new System.Windows.Forms.ToolStripMenuItem();
            ContextMenuFileClose = new System.Windows.Forms.ToolStripMenuItem();
            CellDGV = new System.Windows.Forms.DataGridView();
            celltype = new System.Windows.Forms.DataGridViewTextBoxColumn();
            celldescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            cellvalue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            GameComboBox = new System.Windows.Forms.ToolStripComboBox();
            MainFormMenu.SuspendLayout();
            MainFormToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)MainSplitContainer).BeginInit();
            MainSplitContainer.Panel1.SuspendLayout();
            MainSplitContainer.Panel2.SuspendLayout();
            MainSplitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)FileDGV).BeginInit();
            ContextMenuFile.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)CellDGV).BeginInit();
            SuspendLayout();
            // 
            // MainFormMenu
            // 
            MainFormMenu.BackColor = System.Drawing.Color.FromArgb(41, 41, 41);
            MainFormMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { MenuFile, MenuOther, MenuRefresh, GameComboBox });
            MainFormMenu.Location = new System.Drawing.Point(0, 0);
            MainFormMenu.Name = "MainFormMenu";
            MainFormMenu.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            MainFormMenu.Size = new System.Drawing.Size(933, 27);
            MainFormMenu.TabIndex = 0;
            MainFormMenu.Text = "menuStrip1";
            // 
            // MenuFile
            // 
            MenuFile.BackColor = System.Drawing.Color.FromArgb(40, 40, 40);
            MenuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { MenuOpen, MenuSave, MenuClose, MenuSaveAll, MenuCloseAll });
            MenuFile.ForeColor = System.Drawing.SystemColors.Control;
            MenuFile.Name = "MenuFile";
            MenuFile.Size = new System.Drawing.Size(37, 23);
            MenuFile.Text = "File";
            // 
            // MenuOpen
            // 
            MenuOpen.BackColor = System.Drawing.Color.FromArgb(40, 40, 40);
            MenuOpen.ForeColor = System.Drawing.SystemColors.Control;
            MenuOpen.Name = "MenuOpen";
            MenuOpen.ShortcutKeys = System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O;
            MenuOpen.Size = new System.Drawing.Size(194, 22);
            MenuOpen.Text = "Open";
            MenuOpen.Click += MenuOpen_Click;
            // 
            // MenuSave
            // 
            MenuSave.BackColor = System.Drawing.Color.FromArgb(40, 40, 40);
            MenuSave.ForeColor = System.Drawing.SystemColors.Control;
            MenuSave.Name = "MenuSave";
            MenuSave.ShortcutKeys = System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S;
            MenuSave.Size = new System.Drawing.Size(194, 22);
            MenuSave.Text = "Save";
            MenuSave.ToolTipText = "Save all currently selected params.";
            MenuSave.Click += MenuSave_Click;
            // 
            // MenuClose
            // 
            MenuClose.BackColor = System.Drawing.Color.FromArgb(40, 40, 40);
            MenuClose.ForeColor = System.Drawing.SystemColors.Control;
            MenuClose.Name = "MenuClose";
            MenuClose.ShortcutKeys = System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D;
            MenuClose.Size = new System.Drawing.Size(194, 22);
            MenuClose.Text = "Close";
            MenuClose.ToolTipText = "Close all currently selected params.";
            MenuClose.Click += MenuClose_Click;
            // 
            // MenuSaveAll
            // 
            MenuSaveAll.BackColor = System.Drawing.Color.FromArgb(40, 40, 40);
            MenuSaveAll.ForeColor = System.Drawing.SystemColors.Control;
            MenuSaveAll.Name = "MenuSaveAll";
            MenuSaveAll.ShortcutKeys = System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift | System.Windows.Forms.Keys.S;
            MenuSaveAll.Size = new System.Drawing.Size(194, 22);
            MenuSaveAll.Text = "Save All";
            MenuSaveAll.ToolTipText = "Save all open params.";
            MenuSaveAll.Click += MenuSaveAll_Click;
            // 
            // MenuCloseAll
            // 
            MenuCloseAll.BackColor = System.Drawing.Color.FromArgb(40, 40, 40);
            MenuCloseAll.ForeColor = System.Drawing.SystemColors.Control;
            MenuCloseAll.Name = "MenuCloseAll";
            MenuCloseAll.ShortcutKeys = System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift | System.Windows.Forms.Keys.D;
            MenuCloseAll.Size = new System.Drawing.Size(194, 22);
            MenuCloseAll.Text = "Close All";
            MenuCloseAll.ToolTipText = "Close all open params.";
            MenuCloseAll.Click += MenuCloseAll_Click;
            // 
            // MenuOther
            // 
            MenuOther.BackColor = System.Drawing.Color.FromArgb(40, 40, 40);
            MenuOther.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { MenuOtherOpenResDir });
            MenuOther.ForeColor = System.Drawing.SystemColors.Control;
            MenuOther.Name = "MenuOther";
            MenuOther.Size = new System.Drawing.Size(49, 23);
            MenuOther.Text = "Other";
            MenuOther.ToolTipText = "Misc things.";
            // 
            // MenuOtherOpenResDir
            // 
            MenuOtherOpenResDir.BackColor = System.Drawing.Color.FromArgb(40, 40, 40);
            MenuOtherOpenResDir.ForeColor = System.Drawing.SystemColors.Control;
            MenuOtherOpenResDir.Name = "MenuOtherOpenResDir";
            MenuOtherOpenResDir.Size = new System.Drawing.Size(195, 22);
            MenuOtherOpenResDir.Text = "Open Resources Folder";
            MenuOtherOpenResDir.ToolTipText = "Open the Resources folder.";
            MenuOtherOpenResDir.Click += MenuOtherOpenResDir_Click;
            // 
            // MenuRefresh
            // 
            MenuRefresh.BackColor = System.Drawing.Color.FromArgb(41, 41, 41);
            MenuRefresh.ForeColor = System.Drawing.SystemColors.Control;
            MenuRefresh.Name = "MenuRefresh";
            MenuRefresh.Size = new System.Drawing.Size(58, 23);
            MenuRefresh.Text = "Refresh";
            MenuRefresh.ToolTipText = "Refresh the DatGridView controls.";
            MenuRefresh.Click += MenuRefresh_Click;
            // 
            // MainFormToolStrip
            // 
            MainFormToolStrip.BackColor = System.Drawing.Color.FromArgb(41, 41, 41);
            MainFormToolStrip.Dock = System.Windows.Forms.DockStyle.Bottom;
            MainFormToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { StatusLabel });
            MainFormToolStrip.Location = new System.Drawing.Point(0, 494);
            MainFormToolStrip.Name = "MainFormToolStrip";
            MainFormToolStrip.Size = new System.Drawing.Size(933, 25);
            MainFormToolStrip.TabIndex = 1;
            // 
            // StatusLabel
            // 
            StatusLabel.Name = "StatusLabel";
            StatusLabel.Size = new System.Drawing.Size(0, 22);
            // 
            // MainSplitContainer
            // 
            MainSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            MainSplitContainer.Location = new System.Drawing.Point(0, 27);
            MainSplitContainer.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            MainSplitContainer.Name = "MainSplitContainer";
            // 
            // MainSplitContainer.Panel1
            // 
            MainSplitContainer.Panel1.Controls.Add(FileDGV);
            // 
            // MainSplitContainer.Panel2
            // 
            MainSplitContainer.Panel2.Controls.Add(CellDGV);
            MainSplitContainer.Size = new System.Drawing.Size(933, 467);
            MainSplitContainer.SplitterDistance = 310;
            MainSplitContainer.SplitterWidth = 5;
            MainSplitContainer.TabIndex = 2;
            // 
            // FileDGV
            // 
            FileDGV.AllowUserToAddRows = false;
            FileDGV.AllowUserToDeleteRows = false;
            FileDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            FileDGV.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            FileDGV.BackgroundColor = System.Drawing.Color.FromArgb(47, 47, 47);
            FileDGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            FileDGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(55, 55, 55);
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(75, 75, 75);
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            FileDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            FileDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            FileDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { filename });
            FileDGV.ContextMenuStrip = ContextMenuFile;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(50, 50, 50);
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(70, 70, 70);
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            FileDGV.DefaultCellStyle = dataGridViewCellStyle2;
            FileDGV.Dock = System.Windows.Forms.DockStyle.Fill;
            FileDGV.EnableHeadersVisualStyles = false;
            FileDGV.GridColor = System.Drawing.Color.FromArgb(36, 36, 36);
            FileDGV.Location = new System.Drawing.Point(0, 0);
            FileDGV.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            FileDGV.Name = "FileDGV";
            FileDGV.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(55, 55, 55);
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(75, 75, 75);
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            FileDGV.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            FileDGV.RowTemplate.Height = 24;
            FileDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            FileDGV.Size = new System.Drawing.Size(310, 467);
            FileDGV.TabIndex = 1;
            FileDGV.SelectionChanged += FileDGV_SelectionChanged;
            // 
            // filename
            // 
            filename.HeaderText = "Name";
            filename.Name = "filename";
            filename.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ContextMenuFile
            // 
            ContextMenuFile.BackColor = System.Drawing.Color.FromArgb(40, 40, 40);
            ContextMenuFile.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { ContextMenuFileSave, ContextMenuFileClose });
            ContextMenuFile.Name = "ContextMenuFile";
            ContextMenuFile.Size = new System.Drawing.Size(104, 48);
            // 
            // ContextMenuFileSave
            // 
            ContextMenuFileSave.ForeColor = System.Drawing.SystemColors.Control;
            ContextMenuFileSave.Name = "ContextMenuFileSave";
            ContextMenuFileSave.Size = new System.Drawing.Size(103, 22);
            ContextMenuFileSave.Text = "Save";
            ContextMenuFileSave.ToolTipText = "Save all currently selected params.";
            ContextMenuFileSave.Click += ContextMenuFileSave_Click;
            // 
            // ContextMenuFileClose
            // 
            ContextMenuFileClose.ForeColor = System.Drawing.SystemColors.Control;
            ContextMenuFileClose.Name = "ContextMenuFileClose";
            ContextMenuFileClose.Size = new System.Drawing.Size(103, 22);
            ContextMenuFileClose.Text = "Close";
            ContextMenuFileClose.ToolTipText = "Close all currently selected params.";
            ContextMenuFileClose.Click += ContextMenuFileClose_Click;
            // 
            // CellDGV
            // 
            CellDGV.AllowUserToAddRows = false;
            CellDGV.AllowUserToDeleteRows = false;
            CellDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            CellDGV.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            CellDGV.BackgroundColor = System.Drawing.Color.FromArgb(47, 47, 47);
            CellDGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            CellDGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(55, 55, 55);
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(75, 75, 75);
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            CellDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            CellDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            CellDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { celltype, celldescription, cellvalue });
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(55, 55, 55);
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(75, 75, 75);
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            CellDGV.DefaultCellStyle = dataGridViewCellStyle5;
            CellDGV.Dock = System.Windows.Forms.DockStyle.Fill;
            CellDGV.EnableHeadersVisualStyles = false;
            CellDGV.GridColor = System.Drawing.Color.FromArgb(36, 36, 36);
            CellDGV.Location = new System.Drawing.Point(0, 0);
            CellDGV.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            CellDGV.Name = "CellDGV";
            CellDGV.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(55, 55, 55);
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(75, 75, 75);
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            CellDGV.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            CellDGV.RowTemplate.Height = 24;
            CellDGV.Size = new System.Drawing.Size(618, 467);
            CellDGV.TabIndex = 1;
            CellDGV.CellValueChanged += CellDGV_CellValueChanged;
            // 
            // celltype
            // 
            celltype.FillWeight = 76.14214F;
            celltype.HeaderText = "Type";
            celltype.Name = "celltype";
            celltype.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // celldescription
            // 
            celldescription.FillWeight = 111.9289F;
            celldescription.HeaderText = "Description";
            celldescription.Name = "celldescription";
            celldescription.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // cellvalue
            // 
            cellvalue.FillWeight = 111.9289F;
            cellvalue.HeaderText = "Value";
            cellvalue.Name = "cellvalue";
            cellvalue.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // GameComboBox
            // 
            GameComboBox.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            GameComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            GameComboBox.Name = "GameComboBox";
            GameComboBox.Size = new System.Drawing.Size(121, 23);
            GameComboBox.SelectedIndexChanged += GameComboBox_SelectedIndexChanged;
            // 
            // MainForm
            // 
            AllowDrop = true;
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(35, 35, 35);
            ClientSize = new System.Drawing.Size(933, 519);
            Controls.Add(MainSplitContainer);
            Controls.Add(MainFormToolStrip);
            Controls.Add(MainFormMenu);
            ForeColor = System.Drawing.SystemColors.Control;
            MainMenuStrip = MainFormMenu;
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Name = "MainForm";
            Text = "Param Dbp Editor";
            FormClosing += MainForm_FormClosing;
            DragDrop += MainForm_DragDrop;
            DragEnter += MainForm_DragEnter;
            MainFormMenu.ResumeLayout(false);
            MainFormMenu.PerformLayout();
            MainFormToolStrip.ResumeLayout(false);
            MainFormToolStrip.PerformLayout();
            MainSplitContainer.Panel1.ResumeLayout(false);
            MainSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)MainSplitContainer).EndInit();
            MainSplitContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)FileDGV).EndInit();
            ContextMenuFile.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)CellDGV).EndInit();
            ResumeLayout(false);
            PerformLayout();

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
        private System.Windows.Forms.ContextMenuStrip ContextMenuFile;
        private System.Windows.Forms.ToolStripMenuItem ContextMenuFileSave;
        private System.Windows.Forms.ToolStripMenuItem ContextMenuFileClose;
        private System.Windows.Forms.ToolStripMenuItem MenuOther;
        private System.Windows.Forms.ToolStripMenuItem MenuOtherOpenResDir;
        private System.Windows.Forms.ToolStripMenuItem MenuRefresh;
        private System.Windows.Forms.DataGridViewTextBoxColumn celltype;
        private System.Windows.Forms.DataGridViewTextBoxColumn celldescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn cellvalue;
        private System.Windows.Forms.ToolStripComboBox GameComboBox;
    }
}

