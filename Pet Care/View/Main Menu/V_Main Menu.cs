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
    public partial class V_Main_Menu : UserControl
    {
        C_MainMenu controller;
        public V_Main_Menu(C_MainMenu mainMenu)
        {
            InitializeComponent();
            controller = mainMenu;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            controller.logout();
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            Logout.BackgroundImage = Properties.Resources.Log_Out_Hover;
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            Logout.Cursor = Cursors.Hand;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            Logout.BackgroundImage = Properties.Resources.Log_Out;
        }

        private void Dashboard_Click(object sender, EventArgs e)
        {
            controller.menu_focus = typeof(V_Dashboard).Name;
            controller.reset_button_focus();
            Dashboard.BackgroundImage = Properties.Resources.Dasboard_Focus;
            controller.move_view(new V_Dashboard(controller));
        }

        private void Transaksi_Click(object sender, EventArgs e)
        {
            controller.menu_focus = typeof(V_Transaksi).Name;
            controller.reset_button_focus();
            Transaksi.BackgroundImage = Properties.Resources.Transaksi_Focus;
            controller.move_view(new V_Transaksi(controller));
        }

        private void Pelanggan_Click(object sender, EventArgs e)
        {
            controller.menu_focus = typeof(V_Pelanggan).Name;
            controller.reset_button_focus();
            Pelanggan.BackgroundImage = Properties.Resources.Pelanggan_Focus;
            controller.move_view(new V_Pelanggan(controller));
        }

        private void Layanan_Click(object sender, EventArgs e)
        {
            controller.menu_focus = typeof(V_Layanan).Name;
            controller.reset_button_focus();
            Layanan.BackgroundImage = Properties.Resources.Layanan_Focus;
            controller.move_view(new V_Layanan(controller));
        }

        private void Dashboard_MouseHover(object sender, EventArgs e)
        {
            Dashboard.Cursor = Cursors.Hand;
        }

        private void Transaksi_MouseHover(object sender, EventArgs e)
        {
            Transaksi.Cursor = Cursors.Hand;
        }

        private void Pelanggan_MouseHover(object sender, EventArgs e)
        {
            Pelanggan.Cursor = Cursors.Hand;
        }

        private void Layanan_MouseHover(object sender, EventArgs e)
        {
            Layanan.Cursor = Cursors.Hand;
        }

        private void Dashboard_MouseEnter(object sender, EventArgs e)
        {
            if (controller.menu_focus != typeof(V_Dashboard).Name)
            {
                Dashboard.BackgroundImage = Properties.Resources.Dasboard_Hover;
            };
        }

        private void Dashboard_MouseLeave(object sender, EventArgs e)
        {
            if (controller.menu_focus != typeof(V_Dashboard).Name)
            {
                Dashboard.BackgroundImage = Properties.Resources.Dashboard;
            };
        }

        private void Transaksi_MouseEnter(object sender, EventArgs e)
        {
            if (controller.menu_focus != typeof(V_Transaksi).Name)
            {
                Transaksi.BackgroundImage = Properties.Resources.Transaksi_Hover;
            };
        }

        private void Transaksi_MouseLeave(object sender, EventArgs e)
        {
            if (controller.menu_focus != typeof(V_Transaksi).Name)
            {
                Transaksi.BackgroundImage = Properties.Resources.Transaksi;
            };
        }

        private void Pelanggan_MouseEnter(object sender, EventArgs e)
        {
            if (controller.menu_focus != typeof(V_Pelanggan).Name)
            {
                Pelanggan.BackgroundImage = Properties.Resources.Pelanggan_Hover;
            };
        }

        private void Pelanggan_MouseLeave(object sender, EventArgs e)
        {
            if (controller.menu_focus != typeof(V_Pelanggan).Name)
            {
                Pelanggan.BackgroundImage = Properties.Resources.Pelanggan;
            };
        }

        private void Layanan_MouseEnter(object sender, EventArgs e)
        {
            if (controller.menu_focus != typeof(V_Layanan).Name)
            {
                Layanan.BackgroundImage = Properties.Resources.Layanan_Hover;
            };
        }

        private void Layanan_MouseLeave(object sender, EventArgs e)
        {
            if (controller.menu_focus != typeof(V_Layanan).Name)
            {
                Layanan.BackgroundImage = Properties.Resources.Layanan;
            };
        }

        private void Secret_MouseHover(object sender, EventArgs e)
        {
            Secret.Cursor = Cursors.Hand;
        }
    }
}
