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
        V_Dashboard Dashboard;
        M_Transaksi M_Transaksi = new M_Transaksi();
        M_Layanan M_Layanan = new M_Layanan();
        public C_Dashboard(V_Dashboard v_Dashboard)
        {
            Dashboard = v_Dashboard;
            load();
        }
        public void load()
        {
            List<Data_Transaksi> transaksiList = M_Transaksi.Get().OfType<Data_Transaksi>().ToList();
            Dashboard.TabelTransaksi.DataSource = transaksiList;
            Dashboard.TabelTransaksi.Columns["Jam"].Visible = false;
            Dashboard.TabelTransaksi.DefaultCellStyle.BackColor = Color.FromArgb(253, 233, 218);
            Dashboard.kucing.Text = $"{M_Transaksi.Get().Count} Kucing";
            Dashboard.Layanan.Text = $"{M_Layanan.Get().Count} Layanan";
            Dashboard.Pendapatan.Text = $"Rp{M_Transaksi.Get_Pendapatan().ToString("n", CultureInfo.GetCultureInfo("id-ID"))}";
        }
    }
}