using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Pet_Care.Controller;

namespace Pet_Care.View
{
    public partial class V_Login : UserControl
    {
        C_Landing_Page Controller;
        bool password_state;
        public V_Login(C_Landing_Page c_Landing_Page)
        {
            InitializeComponent();
            Controller = c_Landing_Page;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Controller.login_validation();
        }


        private void LoginButton_MouseEnter(object sender, EventArgs e)
        {
            LoginButton.BackgroundImage = Properties.Resources.Button_Login_Hover;
        }

        private void LoginButton_MouseLeave(object sender, EventArgs e)
        {
            LoginButton.BackgroundImage = Properties.Resources.Login_Button;
        }

        private void Register_Click(object sender, EventArgs e)
        {
            Controller.V_Register = new V_Register(Controller);
            Controller.switch_view(Controller.V_Register);
        }

        private void show_hide_password_Click(object sender, EventArgs e)
        {
            if (password_state)
            {
                password_state = false;
                show_hide_password.BackgroundImage = Properties.Resources.Hide_Password_;
                Password.PasswordChar = '●';
            }
            else
            {
                password_state = true;
                show_hide_password.BackgroundImage = Properties.Resources.Show_Password;
                Password.PasswordChar = '\0';
            }
        }
    }
}
