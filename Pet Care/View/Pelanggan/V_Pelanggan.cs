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
    public partial class V_Pelanggan : UserControl
    {
        C_Pelanggan C_Pelanggan;
        public V_Pelanggan(C_Pelanggan controller)
        {
            InitializeComponent();
            C_Pelanggan = controller;
        }

        private void SearchBar_Enter(object sender, EventArgs e)
        {
            if (SearchBar.Text == "Search")
            {
                SearchBar.Text = "";
                SearchBar.ForeColor = Color.Black;
            }
        }

        private void SearchBar_Leave(object sender, EventArgs e)
        {
            if (SearchBar.Text == "" || SearchBar.Text == "Search")
            {
                SearchBar.ForeColor = Color.FromArgb(210, 218, 221);
                SearchBar.Text = "Search";
            }
        }

        private void SearchBar_TextChanged(object sender, EventArgs e)
        {
            if (SearchBar.Text != "" || SearchBar.Text == "Search")
            {

            }
            else
            {

            }
        }

        private void V_Pelanggan_Load(object sender, EventArgs e)
        {
            C_Pelanggan.load_data();
        }
    }
}
