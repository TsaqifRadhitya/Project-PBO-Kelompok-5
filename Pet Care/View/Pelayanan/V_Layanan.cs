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
    public partial class V_Layanan : UserControl
    {
        C_MainMenu Controller;
        public V_Layanan(C_MainMenu controller)
        {
            InitializeComponent();
            Controller = controller;
        }
    }
}
