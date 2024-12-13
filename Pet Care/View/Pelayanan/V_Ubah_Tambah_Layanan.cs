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
using Pet_Care.Model;

namespace Pet_Care.View
{
    public partial class V_Ubah_Tambah_Layanan : Form
    {
        bool EditMode;
        C_Layanan controller;
        Data_Layanan data;
        public V_Ubah_Tambah_Layanan(C_Layanan controller)
        {
            InitializeComponent();
            this.controller = controller;
        }
        public V_Ubah_Tambah_Layanan(Data_Layanan data,C_Layanan controller)
        {
            InitializeComponent();
            this.controller = controller;
            this.data = data;
            EditMode = true;
        }

        private void Batal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Simpan_Click(object sender, EventArgs e)
        {
            if ((!(radioButton1.Checked) && !(radioButton2.Checked)) || string.IsNullOrEmpty(Nama_Layanan.Text) || string.IsNullOrEmpty(Harga.Text))
            {
                controller.show_message_box("Harap Melengkapi Form !");
                return;
            };
            if (int.TryParse(Harga.Text, out _))
            {
                bool quantity_tipe = (radioButton2.Checked) ? true : false;
                dynamic[] result = controller.save(new Data_Layanan
                {
                    quantity_berdasarkan_hari = quantity_tipe,
                    name = Nama_Layanan.Text,
                    harga = int.Parse(Harga.Text),
                    id = (data != null) ? data.id : 0,
                },
                EditMode);
                if (result[0] && result[2]){
                    controller.show_message_box($"Berhasil Memperbarui Layanan {result[1]}");
                    controller.load();
                    this.Close();
                }else if (result[0])
                {
                    controller.show_message_box($"Berhasil Menambahkan Layanan {result[1]}");
                    controller.load();
                    this.Close();
                }
                else
                {
                    controller.show_message_box($"Layanan {result[1]} Sudah Tersedia !");
                }
            }
        }

        private void Batal_MouseEnter(object sender, EventArgs e)
        {
            Batal.BackgroundImage = Properties.Resources.Batal;
        }

        private void Batal_MouseLeave(object sender, EventArgs e)
        {
            Batal.BackgroundImage = Properties.Resources.Batal_Hover;
        }
        private void Simpan_MouseEnter(object sender, EventArgs e)
        {
            Simpan.BackgroundImage = Properties.Resources.Simpan;
        }

        private void Simpan_MouseLeave(object sender, EventArgs e)
        {
            Simpan.BackgroundImage = Properties.Resources.Simpan_Hover;
        }

        private void Harga_TextChanged(object sender, EventArgs e)
        {
            if (!(int.TryParse(Harga.Text, out _))) Harga.Text = "";
        }

        private void V_Ubah_Tambah_Layanan_Load(object sender, EventArgs e)
        {
            if (EditMode)
            {
                Header.Text = "Ubah Layanan";
                Nama_Layanan.Text = data.name;
                Harga.Text = data.harga.ToString();
                if (data.quantity_berdasarkan_hari)
                {
                    radioButton2.Checked = true;
                }
                else
                {
                    radioButton1.Checked = true;
                }
                if(data.name == "Penitipan")
                {
                    radioButton1.Enabled = false;
                    radioButton2.Enabled = false;
                    Nama_Layanan.Enabled = false;
                }
            }
        }
    }
}
