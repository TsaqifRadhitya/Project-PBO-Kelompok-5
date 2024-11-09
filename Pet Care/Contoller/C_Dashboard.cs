using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pet_Care.View;
using Pet_Care.Model;
using System.Windows.Forms;
namespace Pet_Care.Contoller
{
    public class C_Dashboard
    {
        V_Dashboard Dashboard;
        M_Transaksi M_Transaksi = new M_Transaksi();
        public C_Dashboard(V_Dashboard v_Dashboard)
        {
            Dashboard = v_Dashboard;
            load();
        }
        public void load()
        {
            List<Data_Transaksi> transaksiList = M_Transaksi.Get().OfType<Data_Transaksi>().ToList();
            Dashboard.TabelTransaksi.DataSource = transaksiList;
        }
    }
}