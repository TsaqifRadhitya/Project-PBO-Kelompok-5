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
    public partial class Custom_Message_Box_2_Button : Form
    {
        C_Message_Box controller;
        string message;
        public Custom_Message_Box_2_Button(C_Message_Box controller,string message)
        {
            InitializeComponent();
            this.controller = controller;
            this.message = message;
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Confirm_Click(object sender, EventArgs e)
        {
            controller.confirmed = true;
            this.Close();
        }

        private void Cancel_MouseEnter(object sender, EventArgs e)
        {
            Cancel.BackgroundImage = Properties.Resources.Cancel_Hover1;
        }

        private void Cancel_MouseHover(object sender, EventArgs e)
        {
            Cancel.Cursor = Cursors.Hand;
        }

        private void Cancel_MouseLeave(object sender, EventArgs e)
        {
            Cancel.BackgroundImage = Properties.Resources.Cancel;
        }

        private void Confirm_MouseEnter(object sender, EventArgs e)
        {
            Confirm.BackgroundImage = Properties.Resources.Confirm_Hover;
        }

        private void Confirm_MouseHover(object sender, EventArgs e)
        {
            Confirm.Cursor = Cursors.Hand;
        }

        private void Confirm_MouseLeave(object sender, EventArgs e)
        {
            Confirm.BackgroundImage = Properties.Resources.Confirm;
        }

        private void Custom_Message_Box_2_Button_Load(object sender, EventArgs e)
        {
            Message.Text = message;
        }
    }
}
