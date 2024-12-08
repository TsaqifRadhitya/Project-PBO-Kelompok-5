using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Pet_Care.Controller;
using Pet_Care.Model;

namespace Pet_Care.View
{
    public partial class V_Layanan : UserControl
    {
        C_Layanan Controller;
        public V_Layanan(C_Layanan controller)
        {
            InitializeComponent();
            Controller = controller;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (0 == e.RowIndex && e.ColumnIndex == Tabel_Layanan.Columns["Delete"].Index)
            {
                return;
            }
            if (e.ColumnIndex == Tabel_Layanan.Columns["Edit"].Index)
            {
                Controller.show_form_edit(new Data_Layanan
                {
                    harga = (int)Tabel_Layanan.Rows[e.RowIndex].Cells["Harga"].Value,
                    name = Tabel_Layanan.Rows[e.RowIndex].Cells["name"].Value.ToString(),
                    quantity_berdasarkan_hari = (bool)Tabel_Layanan.Rows[e.RowIndex].Cells["quantity_berdasarkan_hari"].Value,
                    id = (int)Tabel_Layanan.Rows[e.RowIndex].Cells["id"].Value
                });
                return;
            }
            if(e.ColumnIndex == Tabel_Layanan.Columns["Delete"].Index)
            {
                Controller.delete_layanan(Tabel_Layanan.Rows[e.RowIndex].Cells["name"].Value.ToString(), (int)Tabel_Layanan.Rows[e.RowIndex].Cells["id"].Value);
            }
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void V_Layanan_Load(object sender, EventArgs e)
        {
            Controller.load();
        }

        private void Tambah_Click(object sender, EventArgs e)
        {
            Controller.show_form_tambah();
        }

        private void Tambah_MouseEnter(object sender, EventArgs e)
        {
            Tambah.BackgroundImage = Properties.Resources.Tambah_Hover;
        }

        private void Tambah_MouseHover(object sender, EventArgs e)
        {
            Tambah.Cursor = Cursors.Hand;
        }

        private void Tambah_MouseLeave(object sender, EventArgs e)
        {
            Tambah.BackgroundImage = Properties.Resources.Tambah;
        }
    }
}
