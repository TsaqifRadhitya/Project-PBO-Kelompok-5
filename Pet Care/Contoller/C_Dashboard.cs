using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pet_Care.View;
using Pet_Care.Model;
using System.Windows.Forms;
using static Npgsql.Replication.PgOutput.Messages.RelationMessage;
using System.Globalization;
namespace Pet_Care.Contoller
{
    public class C_Dashboard
    {
        C_MainMenu mainMenu;
        V_Dashboard Dashboard;
        M_Transaksi M_Transaksi = new M_Transaksi();
        M_Layanan M_Layanan = new M_Layanan();
        public C_Dashboard(C_MainMenu C_MainMenu)
        {
            mainMenu = C_MainMenu;
            Dashboard = new V_Dashboard(this);
            mainMenu.move_view(Dashboard);
        }
        public void load()
        {
            List<Data_Transaksi> transaksiList = M_Transaksi.Get("Now").OfType<Data_Transaksi>().ToList();
            for(int i = 0; i < 100; i++)
            {
                transaksiList.Add(new Data_Transaksi
                {
                    Nama_Pelanggan = "Tsaqif",
                    Nama_Kucing = "Dori",
                    durasi_penitipan = "5 hari",
                    Nomor_hp = "085156360779",
                    Alamat = "Jl.Manggar No.127",
                    display_price = $"Rp{1000000.ToString("n", CultureInfo.GetCultureInfo("id-ID"))}"
                });
            }
            Dashboard.TabelTransaksi.DataSource = transaksiList;
            Dashboard.TabelTransaksi.ColumnHeadersVisible = true;
            Dashboard.TabelTransaksi.Columns["Waktu"].Visible = false;
            Dashboard.TabelTransaksi.Columns["id_pelanggan"].Visible = false;
            Dashboard.TabelTransaksi.Columns["id_akun"].Visible = false;
            Dashboard.TabelTransaksi.Columns["nominal"].Visible = false;
            Dashboard.TabelTransaksi.Columns["id"].Visible = false;
            Dashboard.TabelTransaksi.Columns["Foto_Kucing"].Visible = false ;
            Dashboard.TabelTransaksi.Columns["Nama_Pelanggan"].HeaderText = "Nama Pelanggan";
            Dashboard.TabelTransaksi.Columns["Nama_Kucing"].HeaderText = "Nama Kucing";
            Dashboard.TabelTransaksi.Columns["durasi_penitipan"].HeaderText = "Durasi";
            Dashboard.TabelTransaksi.Columns["Nomor_hp"].HeaderText = "Nomor HP";
            Dashboard.TabelTransaksi.Columns["display_price"].HeaderText = "Nominal Transaksi";
            Dashboard.TabelTransaksi.DefaultCellStyle.BackColor = Color.FromArgb(253, 233, 218);
            Dashboard.TabelTransaksi.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            Dashboard.kucing.Text = $"{M_Transaksi.Get().Count} Kucing";
            Dashboard.Layanan.Text = $"{M_Layanan.Get().Count} Layanan";
            int pendapatan = (M_Transaksi.Get_Pendapatan() != DBNull.Value)? (int)M_Transaksi.Get_Pendapatan() : 0;
            Dashboard.Pendapatan.Text = $"Rp{pendapatan.ToString("n", CultureInfo.GetCultureInfo("id-ID"))}";
        }
    }
}