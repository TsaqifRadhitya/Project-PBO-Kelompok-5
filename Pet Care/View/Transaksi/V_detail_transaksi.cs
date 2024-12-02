using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Pet_Care.Contoller;
using Pet_Care.Model;

namespace Pet_Care.View.Transaksi
{
    public partial class V_Detail_Transaksi : UserControl
    {
        Data_Transaksi data;
        bool status_transaksi;
        C_Transaksi controller;
        public V_Detail_Transaksi(Data_Transaksi data, bool status_transaksi, C_Transaksi controller)
        {
            InitializeComponent();
            this.controller = controller;
            this.data = data;
            this.status_transaksi = status_transaksi;
        }

        private void V_Detail_Transaksi_Load(object sender, EventArgs e)
        {
            Layanan_Tab.Visible = false;
            if (status_transaksi)
            {
                status.Image = Properties.Resources.Status_Process;
            }
            else
            {
                status.Image = Properties.Resources.Status_Selesai;
            };
            Alamat.Text = data.Alamat;
            Nama_Kucing.Text = data.Nama_Kucing;
            Nama_Pemilik.Text = data.Nama_Pelanggan;
            Durasi.Text = data.durasi_penitipan;
            jumlah_layanan.Text = $"{data.Layanan.Count} Layanan";
            Nomor_Hp.Text = data.Nomor_hp;
            Metode_Pemabayaran.Text = data.Metode_Pembayaran;
            Tanggal.Text = data.Tanggal;
            Nominal.Text = "Rp" + data.nominal.ToString("n2", CultureInfo.GetCultureInfo("id-ID"));

        }

        private void exit_Click(object sender, EventArgs e)
        {
            controller.Frame_Transaksi.Close();
        }

        private void informasi_Click(object sender, EventArgs e)
        {
            Layanan_Tab.Visible = false;
            Informasi_Tab.Visible = true;
            panel_informasi.Visible = true;
        }

        private void Layanan_Click(object sender, EventArgs e)
        {
            Informasi_Tab.Visible = false;
            Layanan_Tab.Visible = true;
            panel_informasi.Visible = false;
        }
    }
}