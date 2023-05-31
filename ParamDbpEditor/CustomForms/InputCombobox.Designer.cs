namespace CustomForms
{
    partial class InputCombobox
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.DropdownBox = new System.Windows.Forms.ComboBox();
            this.Label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // DropdownBox
            // 
            this.DropdownBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.DropdownBox.Dock = System.Windows.Forms.DockStyle.Right;
            this.DropdownBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DropdownBox.ForeColor = System.Drawing.SystemColors.Control;
            this.DropdownBox.FormattingEnabled = true;
            this.DropdownBox.Location = new System.Drawing.Point(47, 0);
            this.DropdownBox.Name = "DropdownBox";
            this.DropdownBox.Size = new System.Drawing.Size(124, 21);
            this.DropdownBox.TabIndex = 0;
            // 
            // Label
            // 
            this.Label.AutoSize = true;
            this.Label.Dock = System.Windows.Forms.DockStyle.Left;
            this.Label.Location = new System.Drawing.Point(0, 0);
            this.Label.Name = "Label";
            this.Label.Size = new System.Drawing.Size(29, 13);
            this.Label.TabIndex = 1;
            this.Label.Text = "label";
            // 
            // InputCombobox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.Controls.Add(this.Label);
            this.Controls.Add(this.DropdownBox);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.Name = "InputCombobox";
            this.Size = new System.Drawing.Size(171, 21);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox DropdownBox;
        private System.Windows.Forms.Label Label;
    }
}
