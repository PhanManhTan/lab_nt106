using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3Bai01
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void butUDPsv_Click(object sender, EventArgs e)
        {
            UDP_Server serverForm = new UDP_Server();
            serverForm.Show();
        }

        private void butUDPcl_Click(object sender, EventArgs e)
        {
            UDP_Client clientForm = new UDP_Client();
            clientForm.Show();
        }
    }
}
