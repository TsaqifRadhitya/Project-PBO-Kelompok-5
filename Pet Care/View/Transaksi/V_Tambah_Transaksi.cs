﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Pet_Care.Contoller;
using Pet_Care.Model;

namespace Pet_Care.View
{
    public partial class V_Tambah_Transaksi : UserControl
    {
        C_Transaksi controller;
        C_Kamera kamera;
        Data_Transaksi data_transaksi;
        public V_Tambah_Transaksi(C_Transaksi controller)
        {
            InitializeComponent();
            this.controller = controller;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            kamera = new C_Kamera();
            if (kamera.foto != null)
            {
                pictureBox1.Image = new Bitmap(new MemoryStream(kamera.foto));
            }
        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            pictureBox1.Cursor = Cursors.Hand;
        }

        private void Batal_Click(object sender, EventArgs e)
        {
            controller.Transaksi_baru = null;
            controller.Frame_Transaksi.Close();
        }

        private void Batal_MouseHover(object sender, EventArgs e)
        {
            Batal.Cursor = Cursors.Hand;
        }

        private void Batal_MouseLeave(object sender, EventArgs e)
        {
            Batal.BackgroundImage = Properties.Resources.Batal_Hover;
        }

        private void Batal_MouseEnter(object sender, EventArgs e)
        {
            Batal.BackgroundImage = Properties.Resources.Batal;
        }

        private void Lanjut_Click(object sender, EventArgs e)
        {
            controller.Transaksi_baru = null;
            controller.Transaksi_baru = new Data_Transaksi 
            {
                Foto_Kucing = (byte[])new ImageConverter().ConvertTo(pictureBox1.Image, typeof(byte[])),
                Id_pelanggan = int.Parse(ID_Pelanggan.Text.Substring(1, (ID_Pelanggan.Text.Length) - 1)),
                Nama_Kucing = Nama_Kucing.Text
            };
            controller.Frame_Transaksi.Controls.Clear();
            controller.Frame_Transaksi.Controls.Add(new V_Form_Transaksi(controller));
        }

        private void Lanjut_MouseEnter(object sender, EventArgs e)
        {
            Lanjut.BackgroundImage = Properties.Resources.Lanjut_Hover;
        }

        private void Lanjut_MouseHover(object sender, EventArgs e)
        {
            Lanjut.Cursor = Cursors.Hand;
        }

        private void Lanjut_MouseLeave(object sender, EventArgs e)
        {
            Lanjut.BackgroundImage = Properties.Resources.Lanjut;
        }

        private void V_Tambah_Transaksi_Load(object sender, EventArgs e)
        {
            if(controller.Transaksi_baru != null)
            {
                pictureBox1.Image = new Bitmap(new MemoryStream(controller.Transaksi_baru.Foto_Kucing));
                Nama_Kucing.Text = controller.Transaksi_baru.Nama_Kucing;
                ID_Pelanggan.Text = "#" + controller.Transaksi_baru.Id_pelanggan.ToString();
            }
        }
    }
}
