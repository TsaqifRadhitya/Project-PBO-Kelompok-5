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
            Dashboard.TabelTransaksi.DataSource = transaksiList;
            Dashboard.TabelTransaksi.Columns["Waktu"].Visible = false;
            Dashboard.TabelTransaksi.Columns["id"].Visible = false;
            Dashboard.TabelTransaksi.Columns["Foto_Kucing"].Visible = false ;
            Dashboard.TabelTransaksi.DefaultCellStyle.BackColor = Color.FromArgb(253, 233, 218);
            Dashboard.kucing.Text = $"{M_Transaksi.Get("Now").Count} Kucing";
            Dashboard.Layanan.Text = $"{M_Layanan.Get().Count} Layanan";
            Dashboard.Pendapatan.Text = $"Rp{M_Transaksi.Get_Pendapatan().ToString("n", CultureInfo.GetCultureInfo("id-ID"))}";
        }
    }
}