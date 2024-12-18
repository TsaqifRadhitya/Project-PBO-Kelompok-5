﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pet_Care.View;
using Pet_Care.Model;
using System.Windows.Forms;
using static Npgsql.Replication.PgOutput.Messages.RelationMessage;
using System.Globalization;
namespace Pet_Care.Controller
{
    public class C_Dashboard
    {
        C_MainMenu C_mainMenu;
        V_Dashboard Dashboard;
        M_Transaksi M_Transaksi = new M_Transaksi();
        M_Layanan M_Layanan = new M_Layanan();

        public C_Dashboard(C_MainMenu C_MainMenu)
        {
            C_mainMenu = C_MainMenu;
            Dashboard = new V_Dashboard(this);
            C_mainMenu.move_view(Dashboard);
        }
        public void load()
        {
            List<Data_Transaksi> transaksiList = M_Transaksi.Get().OfType<Data_Transaksi>().ToList();
            Dashboard.TabelTransaksi.DataSource = transaksiList;
            Dashboard.TabelTransaksi.Columns["tele"].Visible = false;
            Dashboard.TabelTransaksi.Columns["Waktu"].Visible = false;
            Dashboard.TabelTransaksi.Columns["Tanggal"].Visible = false;
            Dashboard.TabelTransaksi.Columns["id_pelanggan"].Visible = false;
            Dashboard.TabelTransaksi.Columns["id_akun"].Visible = false;
            Dashboard.TabelTransaksi.Columns["nominal"].Visible = false;
            Dashboard.TabelTransaksi.Columns["id"].Visible = false;
            Dashboard.TabelTransaksi.Columns["Foto_Kucing"].Visible = false;
            Dashboard.TabelTransaksi.Columns["Metode_Pembayaran"].HeaderText = "Metode Pembayaran";
            Dashboard.TabelTransaksi.Columns["Nama_Pelanggan"].HeaderText = "Nama Pelanggan";
            Dashboard.TabelTransaksi.Columns["Nama_Kucing"].HeaderText = "Nama Kucing";
            Dashboard.TabelTransaksi.Columns["durasi_penitipan"].HeaderText = "Durasi";
            Dashboard.TabelTransaksi.Columns["Nomor_hp"].HeaderText = "Nomor HP";
            Dashboard.TabelTransaksi.Columns["display_price"].HeaderText = "Nominal Transaksi";
            Dashboard.kucing.Text = $"{transaksiList.Count} Kucing";
            Dashboard.Layanan.Text = $"{M_Layanan.Get().Count} Layanan";
            object pendapatan_raw = M_Transaksi.Get_Pendapatan();
            int pendapatan = (pendapatan_raw != DBNull.Value) ? Convert.ToInt32(pendapatan_raw) : 0;
            Dashboard.Pendapatan.Text = $"Rp{pendapatan.ToString("n2", CultureInfo.GetCultureInfo("id-ID"))}";
        }
    }
}