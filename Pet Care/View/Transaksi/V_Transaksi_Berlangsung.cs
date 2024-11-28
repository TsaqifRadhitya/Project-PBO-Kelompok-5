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
    public partial class V_Transaksi_Berlangsung : UserControl
    {
        C_Transaksi Controller;
        public V_Transaksi_Berlangsung(C_Transaksi controller)
        {
            InitializeComponent();
            Controller = controller;
        }

        private void Delete_Click(object sender, EventArgs e)
        {

        }

        private void Delete_MouseHover(object sender, EventArgs e)
        {
            Delete.Cursor = Cursors.Hand;
        }

        private void Delete_MouseEnter(object sender, EventArgs e)
        {
            Delete.BackgroundImage = Properties.Resources.Cancel_Card_Hover;
        }

        private void Delete_MouseLeave(object sender, EventArgs e)
        {
            Delete.BackgroundImage = Properties.Resources.Cancel1;
        }

        private void Selesai_Click(object sender, EventArgs e)
        {

        }

        private void Selesai_MouseEnter(object sender, EventArgs e)
        {
            Selesai.BackgroundImage = Properties.Resources.Selesai_Card_Hover;
        }

        private void Selesai_MouseHover(object sender, EventArgs e)
        {
            Selesai.Cursor = Cursors.Hand;
        }

        private void Selesai_MouseLeave(object sender, EventArgs e)
        {
            Selesai.BackgroundImage = Properties.Resources.Selesai_Card;
        }

        private void Pesan_MouseEnter(object sender, EventArgs e)
        {
            Pesan.BackgroundImage = Properties.Resources.Message_Hover;
        }

        private void Pesan_MouseHover(object sender, EventArgs e)
        {
            Pesan.Cursor = Cursors.Hand;
        }

        private void Pesan_MouseLeave(object sender, EventArgs e)
        {
            Pesan.BackgroundImage = Properties.Resources.Message;
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.Cursor = Cursors.Hand;
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            button1.BackgroundImage = Properties.Resources.Detail_Hover;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackgroundImage = Properties.Resources.Detail;
        }

        private void V_Transaksi_Berlangsung_Load(object sender, EventArgs e)
        {

            Controller.load_card();
        }
    }
}
