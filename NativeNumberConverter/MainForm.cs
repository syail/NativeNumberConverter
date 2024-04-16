namespace NativeNumberConverter
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        ValueType GetFromType()
        {
            if (rdoFromFloat32.Checked)
            {
                return ValueType.Float32;
            }
            if (rdoFromUint32.Checked)
            {
                return ValueType.UInt32;
            }
            throw new InvalidOperationException();
        }

        ValueType GetToType()
        {
            if (rdoToFloat32.Checked)
            {
                return ValueType.Float32;
            }
            if (rdoToUint32.Checked)
            {
                return ValueType.UInt32;
            }
            throw new InvalidOperationException();
        }

        static byte[] ParseValue(ValueType type, string text)
        {
            return type switch
            {
                ValueType.UInt32 => BitConverter.GetBytes(uint.Parse(text)),
                ValueType.Float32 => BitConverter.GetBytes(float.Parse(text)),
                _ => throw new InvalidOperationException(),
            };
        }

        static string FormatValue(ValueType type, byte[] value)
        {
            return type switch
            {
                ValueType.UInt32 => BitConverter.ToUInt32(value, 0).ToString(),
                ValueType.Float32 => BitConverter.ToSingle(value, 0).ToString(),
                _ => throw new InvalidOperationException(),
            };
        }

        private void UpdateOutput()
        {
            try
            {
                var fromType = GetFromType();
                var toType = GetToType();

                byte[] b = ParseValue(fromType, txtInput.Text);
                txtOutput.Text = FormatValue(toType, b);
            }
            catch
            {
                txtOutput.Text = "Invalid input";
            }
        }

        private void txtInput_TextChanged(object sender, EventArgs e)
        {
            UpdateOutput();
        }

        private void rdoFromUint32_CheckedChanged(object sender, EventArgs e)
        {
            UpdateOutput();
        }

        private void rdoFromFloat32_CheckedChanged(object sender, EventArgs e)
        {
            UpdateOutput();
        }

        private void rdoToUint32_CheckedChanged(object sender, EventArgs e)
        {
            UpdateOutput();
        }

        private void rdoToFloat32_CheckedChanged(object sender, EventArgs e)
        {
            UpdateOutput();
        }
    }

    enum ValueType
    {
        UInt32,
        Float32,
    }
}
