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
    public partial class V_Frame_Transaksi : Form
    {
        C_Transaksi controller;
        public V_Frame_Transaksi(C_Transaksi contoller,UserControl view)
        {
            InitializeComponent();
            this.controller = contoller;
            this.Controls.Add(view);
        }
    }
}
