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
    public partial class V_Pelanggan : UserControl
    {
        C_Pelanggan C_Pelanggan;
        public V_Pelanggan(C_Pelanggan controller)
        {
            InitializeComponent();
            C_Pelanggan = controller;
        }

        private void V_Pelanggan_Load(object sender, EventArgs e)
        {
            C_Pelanggan.load_data();
        }

        private void Tambah_Pelanggan_MouseEnter(object sender, EventArgs e)
        {
            Tambah_Pelanggan.BackgroundImage = Properties.Resources.Tambah_Pelanggan;
        }

        private void Tambah_Pelanggan_MouseLeave(object sender, EventArgs e)
        {
            Tambah_Pelanggan.BackgroundImage = Properties.Resources.Tambah_Pelanggan_Hover1;
        }

        private void Tambah_Pelanggan_Click(object sender, EventArgs e)
        {
            C_Pelanggan.Form_tambah_pelanggan();
        }

        private void Search_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(SearchBar.Text))
            {
                C_Pelanggan.load_data();
                return;
            }
            C_Pelanggan.Search(SearchBar.Text);
        }
    }
}   
