using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Dynamic;
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
        Data_Transaksi datas;
        bool status_transaksi;
        C_Transaksi controller;
        public V_Detail_Transaksi(Data_Transaksi data, bool status_transaksi, C_Transaksi controller)
        {
            InitializeComponent();
            this.controller = controller;
            this.datas = data;
            this.status_transaksi = status_transaksi;
        }

        private void V_Detail_Transaksi_Load(object sender, EventArgs e)
        {
            if (status_transaksi)
            {
                status.Image = Properties.Resources.Status_Process;
            }
            else
            {
                status.Image = Properties.Resources.Status_Selesai;
            };
            Alamat.Text = datas.Alamat;
            Nama_Kucing.Text = datas.Nama_Kucing;
            Nama_Pemilik.Text = datas.Nama_Pelanggan;
            Durasi.Text = datas.durasi_penitipan;
            jumlah_layanan.Text = $"{datas.Layanan.Count} Layanan";
            Nomor_Hp.Text = datas.Nomor_hp;
            Metode_Pemabayaran.Text = datas.Metode_Pembayaran;
            Tanggal.Text = datas.Tanggal;
            Nominal.Text = "Rp" + datas.nominal.ToString("n2", CultureInfo.GetCultureInfo("id-ID"));
            Tabel_Layanan.ColumnCount = 3;
            Tabel_Layanan.Columns[0].Name = "Layanan";
            Tabel_Layanan.Columns[1].Name = "Quantity";
            Tabel_Layanan.Columns[2].Name = "Total Harga";
            foreach (dynamic[] data in datas.Layanan)
            {
                Tabel_Layanan.Rows.Add(data);
            }
            Layanan_Tab.Visible = false;
            panel_layanan.Visible = false;
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
            panel_layanan.Visible = false;
        }

        private void Layanan_Click(object sender, EventArgs e)
        {
            Informasi_Tab.Visible = false;
            Layanan_Tab.Visible = true;
            panel_informasi.Visible = false;
            panel_layanan.Visible = true ;
        }
    }
}