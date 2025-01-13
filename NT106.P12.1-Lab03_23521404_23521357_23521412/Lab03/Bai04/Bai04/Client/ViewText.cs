using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace Client
{
    public partial class ViewText : Form
    {
        public ViewText()
        {
            InitializeComponent();
        }
        public string s = string.Empty;
        public ViewText(byte[] x)
        {
            InitializeComponent();
            s = ConvertByte(x);

        }
        private static string ConvertByte(byte[] b)
        {
            return Encoding.UTF8.GetString(b);
        }
        private void ShowFileText(string text)
        {

            if (tbVT.InvokeRequired)
            {
                tbVT.BeginInvoke((MethodInvoker)(() => tbVT.Text = text));
            }
            else
            {
                tbVT.Text = text;
            }
        }
        public bool sw { get; private set; } = false;

        private void ViewText_Load(object sender, EventArgs e)
        {
            ShowFileText(s);
            //sw = true;
        }
        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }


        private void ViewText_FormClosed(object sender, FormClosedEventArgs e)
        {
            sw = false;
        }

        private void ViewText_FormClosing(object sender, FormClosingEventArgs e)
        {
            sw = false;
        }
    }
}
