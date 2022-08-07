using System;
using System.Windows.Forms;

namespace LineChartApp
{
    public partial class FormZero : Form
    {
        public bool Zeroing = false;
        //public double[] Offset = new double[8] { 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0 };
        delegate void SetTextCallback(string text);
        delegate void SetEnabledCallback(bool enabled);

        public FormZero()
        {
            InitializeComponent();
        }

        private void FormZero_Load(object sender, EventArgs e)
        {
            button_zero_control.Enabled = true;
            button_zero_control.Text = "NEXT";
        }

        private void button_zero_control_Click(object sender, EventArgs e)
        {
            if (!Zeroing)
            {
                Zeroing = true;
                button_zero_control.Enabled = false;
            }
            else
            {
                this.Close();
            }
        }

        public void SetHeaderandText(string header, string text)
        {
            SetHeaderLabel(header);
            SetTextLabel(text);
        }

        public void SetEnabledButton(Boolean Enable)
        {
            if (this.button_zero_control.InvokeRequired)
            {
                SetEnabledCallback sec = new SetEnabledCallback(SetEnabledButton);
                this.Invoke(sec, new object[] { Enable });
            }
            else
            {
                this.button_zero_control.Enabled = Enable;
            }
        }

        public void SetTextButton(string text)
        {
            if (this.button_zero_control.InvokeRequired)
            {
                SetTextCallback stc = new SetTextCallback(SetTextButton);
                this.Invoke(stc, new object[] { text });
            }
            else
            {
                this.button_zero_control.Text = text;
            }
        }

        private void SetHeaderLabel(string text)
        {
            if (this.label_header.InvokeRequired)
            {
                SetTextCallback stc = new SetTextCallback(SetHeaderLabel);
                this.Invoke(stc, new object[] { text });
            }
            else
            {
                this.label_header.Text = text;
            }
        }

        private void SetTextLabel(string text)
        {
            if (this.label_instruction.InvokeRequired)
            {
                SetTextCallback stc = new SetTextCallback(SetTextLabel);
                this.Invoke(stc, new object[] { text });
            }
            else
            {
                this.label_instruction.Text = text;
            }
        }
    }
}
