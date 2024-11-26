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
using Pet_Care.Model;

namespace Pet_Care.View
{
    public partial class V_Riwayat_Transaksi : UserControl
    {
        C_Transaksi Controller;
        public V_Riwayat_Transaksi(C_Transaksi controller)
        {
            InitializeComponent();
            Controller = controller;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void V_Riwayat_Transaksi_Load(object sender, EventArgs e)
        {
            List<Data_Transaksi> data = new List<Data_Transaksi> ();
            for (int i = 0; i < 100; i++) 
            {
                data.Add(new Data_Transaksi
                {
                    Nama_Kucing = "Dori",
                    Waktu = "26 - 06 - 2024 16:08",
                    Nama_Pelanggan = "Tsaqif",
                    Alamat = "Jl.Manggar No.127",
                    nominal = 50000,
                    durasi_penitipan = "2 Hari",
                    Nomor_hp = "085156360779"
                });
            }
            Tabel_Riwayat.DataSource = data;
            Tabel_Riwayat.Columns["id"].Visible = false;
            Tabel_Riwayat.Columns["Id_Pelanggan"].Visible = false;
            Tabel_Riwayat.Columns["id_akun"].Visible = false;
            Tabel_Riwayat.Columns["Foto_Kucing"].Visible = false;
            Tabel_Riwayat.Columns["display_price"].Visible = false;
            Tabel_Riwayat.Columns["Metode_Pembayaran"].Visible = false;
            Tabel_Riwayat.Columns.Add(new DataGridViewButtonColumn
            {
                Name = "Detail",
                HeaderText = "",
                Text = "Detail",
                UseColumnTextForButtonValue = true,
            });
            Tabel_Riwayat.DefaultCellStyle.BackColor = Color.FromArgb(131, 94,146);
            Tabel_Riwayat.DefaultCellStyle.ForeColor = Color.White;
            Tabel_Riwayat.DefaultCellStyle.Font = new Font("Montserrat Bold", 8F);
            Tabel_Riwayat.ColumnHeadersDefaultCellStyle.Font = new Font("Montserrat Bold", 8F);
            Tabel_Riwayat.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }
    }
}
