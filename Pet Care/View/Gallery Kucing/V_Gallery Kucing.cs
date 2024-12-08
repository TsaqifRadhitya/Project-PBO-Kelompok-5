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
    public partial class V_Gallery_Kucing : UserControl
    {
        C_Galerry_Kucing controller;
        public V_Gallery_Kucing(C_Galerry_Kucing controller)
        {
            InitializeComponent();
            this.controller = controller;
        }

        private void V_Gallery_Kucing_Load(object sender, EventArgs e)
        {
            controller.load_photo();
        }
    }
}
