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
    public partial class V_Register : UserControl
    {
        C_Landing_Page controller;
        public V_Register(C_Landing_Page controller)
        {
            InitializeComponent();
            this.controller = controller;
        }

        private void Login_MouseHover(object sender, EventArgs e)
        {
            Login.Cursor = Cursors.Hand;
        }

        private void Login_Click(object sender, EventArgs e)
        {
            controller.switch_view(controller.v_Login);
        }

        private void Button_Register_MouseHover(object sender, EventArgs e)
        {
            Button_Register.Cursor = Cursors.Hand;
        }

        private void Button_Register_MouseEnter(object sender, EventArgs e)
        {
            Button_Register.BackgroundImage = Properties.Resources.Register_Button_Hover;
        }

        private void Button_Register_MouseLeave(object sender, EventArgs e)
        {
            Button_Register.BackgroundImage = Properties.Resources.Register_Button;
        }

        private void Button_Register_Click(object sender, EventArgs e)
        {

        }
    }
}
