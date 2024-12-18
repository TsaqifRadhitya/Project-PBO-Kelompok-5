﻿using System;
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
    public partial class V_Form_Transaksi : UserControl
    {
        C_Transaksi controller;
        public V_Form_Transaksi(C_Transaksi controller)
        {
            InitializeComponent();
            this.controller = controller;
        }

        private void Kembali_Click(object sender, EventArgs e)
        {
            controller.Frame_Transaksi.Controls.Clear();
            controller.Frame_Transaksi.Controls.Add(new V_Tambah_Transaksi(controller));
        }
        private void Kembali_MouseEnter(object sender, EventArgs e)
        {
            Kembali.BackgroundImage = Properties.Resources.Kembali_Hover;
        }
        private void Kembali_MouseLeave(object sender, EventArgs e)
        {
            Kembali.BackgroundImage = Properties.Resources.Kembali;
        }

        private void Lanjut_Click(object sender, EventArgs e)
        {
            if (controller.buat_transaksi(this))
            {
                controller.status_transaksi = true;
                controller.Frame_Transaksi.Close();
            };
        }

        private void Lanjut_MouseEnter(object sender, EventArgs e)
        {
            Lanjut.BackgroundImage = Properties.Resources.Lanjut_Hover;
        }
        private void Lanjut_MouseLeave(object sender, EventArgs e)
        {
            Lanjut.BackgroundImage = Properties.Resources.Lanjut;
        }
        private void ID_Pelanggan_TextChanged(object sender, EventArgs e)
        {
            if (!(int.TryParse(Durasi.Text, out _)))
            { 
                Durasi.Text = ""; 
            }else 
            { 
                controller.Refresh_Total_Harga(this); 
            }
        }
        private void V_Form_Transaksi_Load(object sender, EventArgs e)
        {
            controller.load_data_Layanan(this);
        }
    }
}
