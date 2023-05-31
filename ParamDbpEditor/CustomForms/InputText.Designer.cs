namespace CustomForms
{
    partial class InputText
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
            this.Label = new System.Windows.Forms.Label();
            this.InputBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // Label
            // 
            this.Label.AutoSize = true;
            this.Label.Dock = System.Windows.Forms.DockStyle.Top;
            this.Label.Location = new System.Drawing.Point(0, 0);
            this.Label.Name = "Label";
            this.Label.Size = new System.Drawing.Size(29, 13);
            this.Label.TabIndex = 0;
            this.Label.Text = "label";
            // 
            // InputBox
            // 
            this.InputBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.InputBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.InputBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.InputBox.ForeColor = System.Drawing.SystemColors.Control;
            this.InputBox.Location = new System.Drawing.Point(0, 13);
            this.InputBox.Name = "InputBox";
            this.InputBox.Size = new System.Drawing.Size(200, 46);
            this.InputBox.TabIndex = 1;
            this.InputBox.Text = "";
            this.InputBox.TextChanged += new System.EventHandler(this.InputBox_InputTextChanged);
            this.InputBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.InputBox_KeyDown);
            this.InputBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.InputBox_KeyPress);
            this.InputBox.Leave += new System.EventHandler(this.InputBox_Leave);
            // 
            // InputText
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.Controls.Add(this.InputBox);
            this.Controls.Add(this.Label);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.Name = "InputText";
            this.Size = new System.Drawing.Size(200, 59);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Label;
        private System.Windows.Forms.RichTextBox InputBox;
    }
}
