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

namespace Pet_Care.View.Transaksi
{
    public partial class V_Detail_Transaksi : UserControl
    {
        C_Transaksi Controller;
        int id;
        public V_Detail_Transaksi(C_Transaksi controller, int id)
        {
            InitializeComponent();
            this.id = id;
            this.Controller = controller;
        }

        private void V_Detail_Transaksi_Load(object sender, EventArgs e)
        {
            label1.Text = id.ToString();
            Controller.load_detail(id, this);
        }
    }
}
