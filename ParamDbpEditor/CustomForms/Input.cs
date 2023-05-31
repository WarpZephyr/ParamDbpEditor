using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace CustomForms
{
    public partial class Input : UserControl
    {
        [Category("Appearance")]
        [Description("The text to be displayed on the Label of the input.")]
        public string LabelText
        {
            get { return Label.Text; }
            set { Label.Text = value; }
        }

        [Category("Layout")]
        [Description("The size of the Label of the input.")]
        public Size LabelSize
        {
            get { return Label.Size; }
            set { Label.Size = value; }
        }

        [Category("Layout")]
        [Description("Whether or not to autosize the Label of the input.")]
        public bool LabelAutoSize
        {
            get { return Label.AutoSize; }
            set { Label.AutoSize = value; }
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
        [Description("The size of the InputBox of the input.")]
        public Size InputBoxSize
        {
            get { return InputBox.Size; }
            set { InputBox.Size = value; }
        }

        [Category("Layout")]
        [Description("The size of the InputBox of the input.")]
        public Point InputBoxLocation
        {
            get { return InputBox.Location; }
            set { InputBox.Location = value; }
        }

        [Category("Layout")]
        [Description("Where to dock the InputBox of the input.")]
        public DockStyle InputBoxDock
        {
            get { return InputBox.Dock; }
            set { InputBox.Dock = value; }
        }

        [Category("Behavior")]
        [Description("The maximum amount of characters a user can input into the InputBox of the input.")]
        public int InputBoxMaxLength
        {
            get { return InputBox.MaxLength; }
            set { InputBox.MaxLength = value; }
        }

        long _InputBoxMaxValue;

        [Category("Behavior")]
        [Description("The largest numvalue the user can input into the InputBox up to the signed long limit.")]
        public long InputBoxMaxValue
        {
            get { return _InputBoxMaxValue; }
            set { _InputBoxMaxValue = value; }
        }

        long _InputBoxMinValue;

        [Category("Behavior")]
        [Description("The smallest numvalue the user can input into this InputBox up to the signed long limit.")]
        public long InputBoxMinValue
        {
            get { return _InputBoxMinValue; }
            set { _InputBoxMinValue = value; }
        }

        [Category("Appearance")]
        [Description("The text in the InputBox of the input.")]
        public string InputBoxText
        {
            get { return InputBox.Text; }
            set { InputBox.Text = value; }
        }

        [Category("Appearance")]
        [Description("The background color of the InputBox of the input.")]
        public Color InputBoxBackColor
        {
            get { return InputBox.BackColor; }
            set { InputBox.BackColor = value; }
        }

        [Category("Appearance")]
        [Description("The foreground color of the InputBox of the input.")]
        public Color InputBoxForeColor
        {
            get { return InputBox.ForeColor; }
            set { InputBox.ForeColor = value; }
        }

        [Category("Appearance")]
        [Description("The border style of the InputBox of the input.")]
        public BorderStyle InputBoxBorderStyle
        {
            get { return InputBox.BorderStyle; }
            set { InputBox.BorderStyle = value; }
        }

        [Category("Data")]
        [Description("Gets or sets the object that contains data about the InputBox.")]
        public object InputBoxTag
        {
            get { return InputBox.Tag; }
            set { InputBox.Tag = value; }
        }

        [Browsable(true)]
        [Category("Property Changed")]
        [Description("Invoked when InputBox numvalue changes")]
        public event EventHandler InputTextChanged;
        public void InputBox_InputTextChanged(object sender, EventArgs e)
        {
            if (InputBox.Text.Length > 0)
            {
                char value = InputBox.Text[InputBox.Text.Length - 1];
                if (_NumericOnly && char.IsDigit(value))
                {
                    long numvalue = Convert.ToInt64(InputBox.Text);
                    if (numvalue < _InputBoxMinValue)
                    {
                        InputBox.Text = $"{_InputBoxMinValue}";
                    }
                    else if (numvalue > _InputBoxMaxValue)
                    {
                        InputBox.Text = $"{_InputBoxMaxValue}";
                    }
                }
            }
            InputTextChanged?.Invoke(this, e);
        }

        private bool _NumericOnly;

        [Category("Behavior")]
        [Description("Whether or not the InputBox accepts only numbers.")]
        public bool NumericOnly
        {
            get { return _NumericOnly; }
            set { _NumericOnly = value; }
        }

        private bool _NumericNegative;
        private bool _NumericZero;

        private void InputBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (_NumericOnly && e.KeyCode != Keys.OemMinus) _NumericNegative = false;
            else if (_NumericOnly && e.KeyCode == Keys.OemMinus)
            {
                if (InputBox.Text.Length < 1) _NumericNegative = true;
                else _NumericNegative = false;
            }
            else if (_NumericOnly && e.KeyCode != Keys.D0 || _NumericOnly && e.KeyCode != Keys.NumPad0) _NumericZero = false;
            else if (_NumericOnly && e.KeyCode == Keys.D0 || _NumericOnly && e.KeyCode == Keys.NumPad0)
            {
                if (InputBox.Text.Length < 1) _NumericZero = true;
                else _NumericZero = false;
            }
        }

        private void InputBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (_NumericOnly && !char.IsDigit(e.KeyChar) && !_NumericNegative && !_NumericZero && !char.IsControl(e.KeyChar)) e.Handled = true;
        }

        public Input()
        {
            InitializeComponent();
        }

        private void InputBox_Leave(object sender, EventArgs e)
        {
            if (InputBox.Text.Length == 0 && _NumericOnly)
            {
                InputBox.Text = $"{_InputBoxMinValue}";
            }
        }
    }
}
