﻿using System;
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
    public partial class V_Riwayat_Transaksi : UserControl
    {
        C_Transaksi Controller;
        public V_Riwayat_Transaksi(C_Transaksi controller)
        {
            InitializeComponent();
            Controller = controller;
        }
    }
}
