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
    public partial class V_Dashboard : UserControl
    {
        C_Dashboard Controller;
        public V_Dashboard(C_Dashboard controller)
        {
            InitializeComponent();
            Controller = controller;
        }

        private void V_Dashboard_Load(object sender, EventArgs e)
        {
            nama.Text = M_Session.session_name;
            Controller.load();
        }

        private void TabelTransaksi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void nama_Click(object sender, EventArgs e)
        {

        }
    }
}
