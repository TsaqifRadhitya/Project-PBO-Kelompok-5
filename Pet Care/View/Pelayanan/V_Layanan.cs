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
using Pet_Care.Contoller;
using Pet_Care.Model;

namespace Pet_Care.View
{
    public partial class V_Layanan : UserControl
    {
        C_Layanan C_Layanan;
        C_MainMenu Controller;
        public V_Layanan(C_Layanan controller)
        {
            InitializeComponent();
            C_Layanan = controller;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == Tabel_Layanan.Columns["Edit"].Index)
            {
                C_Layanan.show_form_edit(new Data_Layanan
                {
                    harga = (int)Tabel_Layanan.Rows[e.RowIndex].Cells["Harga"].Value,
                    name = Tabel_Layanan.Rows[e.RowIndex].Cells["name"].Value.ToString(),
                    quantity_berdasarkan_hari = (bool)Tabel_Layanan.Rows[e.RowIndex].Cells["quantity_berdasarkan_hari"].Value
                });
                return;
            }
            if(e.ColumnIndex == Tabel_Layanan.Columns["Delete"].Index)
            {
                C_Layanan.delete_layanan(Tabel_Layanan.Rows[e.RowIndex].Cells["name"].Value.ToString(), (int)Tabel_Layanan.Rows[e.RowIndex].Cells["id"].Value);
            }
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void V_Layanan_Load(object sender, EventArgs e)
        {

            DataGridViewImageColumn dataGridViewImageColumn = new DataGridViewImageColumn
            {
                Image = Properties.Resources.Batal,
                ImageLayout = DataGridViewImageCellLayout.Zoom,
                Name = "Test",
            };
            DataGridViewButtonColumn button = new DataGridViewButtonColumn
            {
                Name = "Delete",
                UseColumnTextForButtonValue = true,
                Text = "Delete"
            };
            DataGridViewButtonColumn button_1 = new DataGridViewButtonColumn
            {
                Name = "Edit",
                UseColumnTextForButtonValue = true,
                Text = "Edit",
            };
            List<Data_Layanan> data = new List<Data_Layanan>();
            Data_Layanan layanan = new Data_Layanan
            {
                id = 1,
                harga = 100000,
                name = "Penitipan",
                quantity_berdasarkan_hari = true
            };
            layanan.display_price = $"Rp{layanan.harga.ToString("n", CultureInfo.GetCultureInfo("id-ID"))}";
            for (int i = 0; i < 100; i++)
            {
                data.Add(layanan);
            }
            Tabel_Layanan.DataSource = data;
            Tabel_Layanan.Columns.Add(button);
            Tabel_Layanan.Columns.Add(button_1);
            //Tabel_Layanan.Columns.Add(dataGridViewImageColumn);
            Tabel_Layanan.Columns["quantity_berdasarkan_hari"].HeaderText = "Berdasarkan Hari";
            Tabel_Layanan.Columns["name"].HeaderText = "Nama Layanan";
            Tabel_Layanan.Columns["display_price"].HeaderText = "Harga";
            Tabel_Layanan.Columns["Edit"].HeaderText = "";
            Tabel_Layanan.Columns["Delete"].HeaderText = "";
            Tabel_Layanan.Columns["id"].Visible = false;
            Tabel_Layanan.Columns["Harga"].Visible = false;
            Tabel_Layanan.DefaultCellStyle.BackColor = Color.FromArgb(253, 233, 218);
            //Tabel_Layanan.EnableHeadersVisualStyles = false;
            Tabel_Layanan.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(253, 233, 218);
        }

        private void Tambah_Click(object sender, EventArgs e)
        {
            C_Layanan.show_form_tambah();
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
