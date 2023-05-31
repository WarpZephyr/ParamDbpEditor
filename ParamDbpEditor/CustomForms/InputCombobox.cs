using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace CustomForms
{
    public partial class InputCombobox : UserControl
    {
        [Category("Appearance")]
        [Description("The text to be displayed on the label of the input.")]
        public string LabelText
        {
            get { return Label.Text; }
            set { Label.Text = value; }
        }

        [Category("Appearance")]
        [Description("The background color of the Label of the input.")]
        public Color LabelBackColor
        {
            get { return Label.BackColor; }
            set { Label.BackColor = value; }
        }

        [Category("Appearance")]
        [Description("The foreground color of the Label of the input.")]
        public Color LabelForeColor
        {
            get { return Label.ForeColor; }
            set { Label.ForeColor = value; }
        }

        [Category("Appearance")]
        [Description("The border style of the Label of the input.")]
        public BorderStyle LabelBorderStyle
        {
            get { return Label.BorderStyle; }
            set { Label.BorderStyle = value; }
        }

        [Category("Appearance")]
        [Description("The flat style of the Label of the input.")]
        public FlatStyle LabelFlatStyle
        {
            get { return Label.FlatStyle; }
            set { Label.FlatStyle = value; }
        }

        [Category("Layout")]
        [Description("The size of the Label of the input.")]
        public Size LabelSize
        {
            get { return Label.Size; }
            set { Label.Size = value; }
        }

        [Category("Layout")]
        [Description("The size of the Label of the input.")]
        public Point LabelLocation
        {
            get { return Label.Location; }
            set { Label.Location = value; }
        }

        [Category("Layout")]
        [Description("Where to dock the Label of the input.")]
        public DockStyle LabelDock
        {
            get { return Label.Dock; }
            set { Label.Dock = value; }
        }

        [Category("Layout")]
        [Description("Whether or not to autosize the Label of the input.")]
        public bool LabelAutoSize
        {
            get { return Label.AutoSize; }
            set { Label.AutoSize = value; }
        }

        [Category("Appearance")]
        [Description("The text to be displayed on the ComboBox of the input.")]
        public string DropdownBoxText
        {
            get { return DropdownBox.Text; }
            set { DropdownBox.Text = value; }
        }

        [Category("Appearance")]
        [Description("The background color of the ComboBox of the input.")]
        public Color DropdownBoxBackColor
        {
            get { return DropdownBox.BackColor; }
            set { DropdownBox.BackColor = value; }
        }

        [Category("Appearance")]
        [Description("The foreground color of the ComboBox of the input.")]
        public Color DropdownBoxForeColor
        {
            get { return DropdownBox.ForeColor; }
            set { DropdownBox.ForeColor = value; }
        }

        [Category("Appearance")]
        [Description("The flat style of the ComboBox of the input.")]
        public FlatStyle DropdownBoxFlatStyle
        {
            get { return DropdownBox.FlatStyle; }
            set { DropdownBox.FlatStyle = value; }
        }

        [Category("Appearance")]
        [Description("The dropdown style of the ComboBox of the input.")]
        public ComboBoxStyle DropDownStyle
        {
            get { return DropdownBox.DropDownStyle; }
            set { DropdownBox.DropDownStyle = value; }
        }

        [Category("Layout")]
        [Description("The size of the Combobox of the input.")]
        public Size DropdownBoxSize
        {
            get { return DropdownBox.Size; }
            set { DropdownBox.Size = value; }
        }

        [Category("Layout")]
        [Description("The size of the Combobox of the input.")]
        public Point DropdownBoxLocation
        {
            get { return DropdownBox.Location; }
            set { DropdownBox.Location = value; }
        }

        [Category("Layout")]
        [Description("Where to dock the Combobox of the input.")]
        public DockStyle DropdownBoxDock
        {
            get { return DropdownBox.Dock; }
            set { DropdownBox.Dock = value; }
        }

        [Category("Layout")]
        [Description("Whether or not to autosize the Combobox of the input.")]
        public bool DropdownBoxAutoSize
        {
            get { return DropdownBox.AutoSize; }
            set { DropdownBox.AutoSize = value; }
        }

        [Category("Behavior")]
        [Description("The dropdown height the Combobox of the input.")]
        public int DropDownHeight
        {
            get { return DropdownBox.DropDownHeight; }
            set { DropdownBox.DropDownHeight = value; }
        }

        [Category("Behavior")]
        [Description("The dropdown width the Combobox of the input.")]
        public int DropDownWidth
        {
            get { return DropdownBox.DropDownWidth; }
            set { DropdownBox.DropDownWidth = value; }
        }

        public InputCombobox()
        {
            InitializeComponent();
        }
    }
}
