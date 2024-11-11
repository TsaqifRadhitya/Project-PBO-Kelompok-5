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

namespace Pet_Care.View
{
    public partial class V_Gallery_Kucing : UserControl
    {
        public V_Gallery_Kucing()
        {
            InitializeComponent();
        }

        private void V_Gallery_Kucing_Load(object sender, EventArgs e)
        {
            C_Galerry_Kucing controller = new C_Galerry_Kucing(this);
        }
    }
}
