using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Pet_Care.Contoller;

namespace Pet_Care.View
{
    public partial class V_Custom_Message_Box : Form
    {
        C_MainFrame controller;
        public V_Custom_Message_Box(C_MainFrame controller, string message)
        {
            InitializeComponent();
            Message.Text = message;
            this.controller = controller;
        }

        private void Okey_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Okey_MouseHover(object sender, EventArgs e)
        {
            Okey.Cursor = Cursors.Hand;
        }

        private void Okey_MouseEnter(object sender, EventArgs e)
        {
            Okey.BackgroundImage = Properties.Resources.Button_Hover;
        }

        private void Okey_MouseLeave(object sender, EventArgs e)
        {
            Okey.BackgroundImage = Properties.Resources.Button;
        }
    }
}
