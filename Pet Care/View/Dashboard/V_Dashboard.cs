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
        C_MainMenu Controller;
        C_Dashboard C_Dashboard;
        public V_Dashboard(C_MainMenu controller)
        {
            InitializeComponent();
            Controller = controller;
        }

        private void V_Dashboard_Load(object sender, EventArgs e)
        {
            nama.Text = M_Session.session_name;
            C_Dashboard = new C_Dashboard(this);
        }
    }
}
