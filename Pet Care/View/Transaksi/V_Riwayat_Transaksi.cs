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
using static System.Runtime.InteropServices.JavaScript.JSType;

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
            if (e.ColumnIndex == Tabel_Riwayat.Columns["Detail"].Index) Controller.load_detail((int)Tabel_Riwayat.Rows[e.RowIndex].Cells["id"].Value,false);
        }

        private void V_Riwayat_Transaksi_Load(object sender, EventArgs e)
        {
            Controller.load_riwayat(this);
        }
    }
}
