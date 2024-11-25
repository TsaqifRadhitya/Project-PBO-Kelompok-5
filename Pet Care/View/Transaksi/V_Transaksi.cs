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
    public partial class V_Transaksi : UserControl
    {
        C_Transaksi C_Transaksi;
        public V_Transaksi(C_Transaksi controller)
        {
            InitializeComponent();
            C_Transaksi = controller;
        }

        private void Berlangsung_Click(object sender, EventArgs e)
        {
            Selesai.BackgroundImage = Properties.Resources.Selesai;
            Berlangsung.BackgroundImage = Properties.Resources.Berlangsung_Focus;
            C_Transaksi.switch_view(new V_Transaksi_Berlangsung(C_Transaksi));
        }

        private void Selesai_Click(object sender, EventArgs e)
        {
            Selesai.BackgroundImage = Properties.Resources.Selesai_Focus;
            Berlangsung.BackgroundImage = Properties.Resources.Berlangsung;
            C_Transaksi.switch_view(new V_Riwayat_Transaksi(C_Transaksi));
        }

        private void Berlangsung_MouseHover(object sender, EventArgs e)
        {
            Berlangsung.Cursor = Cursors.Hand;
        }

        private void Selesai_MouseHover(object sender, EventArgs e)
        {
            Selesai.Cursor = Cursors.Hand;
        }

        private void Tambah_Transaksi_Click(object sender, EventArgs e)
        {

        }

        private void Tambah_Transaksi_MouseEnter(object sender, EventArgs e)
        {
            Tambah_Transaksi.BackgroundImage = Properties.Resources.Tambah_Transaksi_Hover;
        }

        private void Tambah_Transaksi_MouseHover(object sender, EventArgs e)
        {
            Tambah_Transaksi.Cursor = Cursors.Hand;
        }

        private void Tambah_Transaksi_MouseLeave(object sender, EventArgs e)
        {
            Tambah_Transaksi.BackgroundImage = Properties.Resources.Tambah_Transaksi;
        }
    }
}
