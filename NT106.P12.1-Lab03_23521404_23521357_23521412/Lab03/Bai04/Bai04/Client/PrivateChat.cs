using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    public partial class PrivateChat : Form
    {
        public PrivateChat()
        {
            InitializeComponent();
        }
        public PrivateChat(string x)
        {
            InitializeComponent();
            Cont = x;
        }
        public string name;
        public string Cont=string.Empty;
        //public User u;
        private void PrivateChat_Load(object sender, EventArgs e)
        {
            lbName.Text = name;
            tbChat.Text = Cont;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        public delegate void Guidata(string s);
        public Guidata gui;
        private void btnSend_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbMess.Text))
            {
                {
                    string x = tbMess.Text + ";" + lbName.Text;
                    UpdateChatBox(tbMess.Text);
                    tbMess.Text = string.Empty;
                    gui?.Invoke(x);
                    
                }
            }
        }
        private void UpdateChatBox(string text)
        {
            tbChat.Text += "You : " + tbMess.Text + "\n";
        }

    }
}
