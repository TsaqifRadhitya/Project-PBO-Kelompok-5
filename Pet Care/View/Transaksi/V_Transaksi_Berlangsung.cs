using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Pet_Care.Controller;

namespace Pet_Care.View
{
    public partial class V_Transaksi_Berlangsung : UserControl
    {
        C_Transaksi Controller;
        public V_Transaksi_Berlangsung(C_Transaksi controller)
        {
            InitializeComponent();
            Controller = controller;
        }

        private void V_Transaksi_Berlangsung_Load(object sender, EventArgs e)
        {

            Controller.load_card();
        }
    }
}
