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
    public partial class V_Send_Message : UserControl
    {
        public bool status;
        C_Transaksi controller;
        C_Kamera kamera;
        public V_Send_Message(C_Transaksi contoller)
        {
            InitializeComponent();
            this.controller = contoller;
        }

        private void Kembali_Click(object sender, EventArgs e)
        {
            controller.Frame_Transaksi.Close();
        }

        private void Batal_MouseEnter(object sender, EventArgs e)
        {
            Batal.BackgroundImage = Properties.Resources.Batal;
        }
        private void Batal_MouseLeave(object sender, EventArgs e)
        {
            Batal.BackgroundImage = Properties.Resources.Batal_Hover;
        }

        private void Kirim_Click(object sender, EventArgs e)
        {
            if(kamera == null || string.IsNullOrEmpty(Pesan.Text))
            {
                controller.show_message_box("Form Wajib diIsi Semua !");
                return;
            }
            controller.Frame_Transaksi.Close();
            controller.data_pesan = [kamera.foto , Pesan.Text];
            status = true;
        }

        private void Kirim_MouseEnter(object sender, EventArgs e)
        {
            Kirim.BackgroundImage = Properties.Resources.Kirim_Hover;
        }
        private void Kirim_MouseLeave(object sender, EventArgs e)
        {
            Kirim.BackgroundImage = Properties.Resources.Kirim;
        }

        private void foto_Click(object sender, EventArgs e)
        {
            kamera = new C_Kamera();
            if (kamera.foto != null)
            {
                foto.Image = new Bitmap(new MemoryStream(kamera.foto));
            }
        }
    }
}
