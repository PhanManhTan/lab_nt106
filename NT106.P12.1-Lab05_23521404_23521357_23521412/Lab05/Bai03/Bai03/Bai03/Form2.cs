using MimeKit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai03
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        public Form2(MimeMessage m)
        {
            InitializeComponent();
            labelFrom.Text = m.From.ToString();
            labelSubject.Text = m.Subject.ToString();
            string htmlBody = m.HtmlBody;
            webBrowser1.DocumentText = htmlBody;

        }
    }
}
