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
    public partial class V_landing_Page : UserControl
    {
        C_Landing_Page Controller;
        public V_landing_Page(C_Landing_Page c_Landing_Page)
        {
            InitializeComponent();
            Controller = c_Landing_Page;
        }
    }
}
