using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Pet_Care.Controller;

namespace Pet_Care.View
{
    public partial class V_Register : UserControl
    {
        C_Landing_Page controller;
        bool password_state, confirm_password_state;
        public V_Register(C_Landing_Page controller)
        {
            InitializeComponent();
            this.controller = controller;
        }

        private void Login_Click(object sender, EventArgs e)
        {
            controller.v_Login = new V_Login(controller);
            controller.v_Login.Location = new Point(0, 102);
            controller.switch_view(controller.v_Login);
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
            controller.register_validation();
        }

        private void Nomor_HP_TextChanged(object sender, EventArgs e)
        {
            if (!(BigInteger.TryParse(Nomor_HP.Text, out _))) Nomor_HP.Text = "";
        }

        private void show_hide_password_Click(object sender, EventArgs e)
        {
            if (password_state)
            {
                password_state = false;
                show_hide_password_1.BackgroundImage = Properties.Resources.Hide_Password_;
                Password.PasswordChar = '●';
            }
            else
            {
                password_state = true;
                show_hide_password_1.BackgroundImage = Properties.Resources.Show_Password;
                Password.PasswordChar = '\0';
            }
        }

        private void show_hide_password_2_Click(object sender, EventArgs e)
        {
            if (confirm_password_state)
            {
                confirm_password_state = false;
                show_hide_password_2.BackgroundImage = Properties.Resources.Hide_Password_;
                Konfirmasi_Password.PasswordChar = '●';
            }
            else
            {
                confirm_password_state = true;
                show_hide_password_2.BackgroundImage = Properties.Resources.Show_Password;
                Konfirmasi_Password.PasswordChar = '\0';
            }
        }
    }
}
