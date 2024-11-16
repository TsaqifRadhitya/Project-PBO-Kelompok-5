using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Pet_Care.Model;
using Pet_Care.Contoller;
namespace Pet_Care.View
{
    public partial class V_Ubah_Tambah_Pelanggan : Form
    {
        C_Pelanggan Controller;
        int id_pelanggan;
        bool Edit_Mode;
        public V_Ubah_Tambah_Pelanggan(C_Pelanggan controller)
        {
            InitializeComponent();
            Controller = controller;
        }
        public V_Ubah_Tambah_Pelanggan(C_Pelanggan controller, Data_Pelanngan data)
        {
            InitializeComponent();
            Edit_Mode = true;
            Header.Text = "Edit Profile Pelanggan";
            Nama.Text = data.Name;
            Nomor_Telepon.Text = data.Nomor_HP;
            Alamat.Text = data.Alamat;
            id_pelanggan = data.ID;
            Controller = controller;
        }

        private void Batal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Batal_MouseEnter(object sender, EventArgs e)
        {
            Batal.BackgroundImage = Properties.Resources.Batal; 
        }
        private void Batal_MouseLeave(object sender, EventArgs e)
        {
            Batal.BackgroundImage = Properties.Resources.Batal_Hover;
        }
        private void Batal_MouseHover(object sender, EventArgs e)
        {
            Batal.Cursor = Cursors.Hand;
        }
        private void Simpan_Click(object sender, EventArgs e)
        {
            dynamic[] respons = Controller.save_data(Edit_Mode, new Data_Pelanngan
            {
                Name = Nama.Text,
                Nomor_HP = Nomor_Telepon.Text,
                Alamat = Alamat.Text,
                ID = id_pelanggan,
            });
            if (respons[0]){
                Controller.load_data();
                this.Close();
            }
            else
            {
                Controller.show_message_box(respons[1]);
            }
        }
        private void Simpan_MouseHover(object sender, EventArgs e)
        {
            Simpan.Cursor = Cursors.Hand;
        }

        private void Simpan_MouseEnter(object sender, EventArgs e)
        {
            Simpan.BackgroundImage = Properties.Resources.Simpan;
        }

        private void Simpan_MouseLeave(object sender, EventArgs e)
        {
            Simpan.BackgroundImage = Properties.Resources.Simpan_Hover;
        }
    }
}
