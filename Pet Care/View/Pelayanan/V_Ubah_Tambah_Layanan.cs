using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Pet_Care.Model;

namespace Pet_Care.View
{
    public partial class V_Ubah_Tambah_Layanan : Form
    {
        bool EditMode;
        public V_Ubah_Tambah_Layanan()
        {
            InitializeComponent();
        }
        public V_Ubah_Tambah_Layanan(Data_Layanan data)
        {
            InitializeComponent();
            EditMode = true;
            Nama_Layanan.Text = data.name;
            Harga.Text = data.harga.ToString();
            if (data.quantity_berdasarkan_hari)
            {
                radioButton2.Checked = true;
            }
            else
            {
                radioButton1.Checked = true;
            }
        }

        private void Batal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Simpan_Click(object sender, EventArgs e)
        {

        }

        private void Batal_MouseHover(object sender, EventArgs e)
        {
            Batal.Cursor = Cursors.Hand;
        }

        private void Batal_MouseEnter(object sender, EventArgs e)
        {
            Batal.BackgroundImage = Properties.Resources.Batal;
        }

        private void Batal_MouseLeave(object sender, EventArgs e)
        {
            Batal.BackgroundImage = Properties.Resources.Batal_Hover;
        }

        private void Simpan_MouseEnter(object sender, EventArgs e)
        {
            Simpan.BackgroundImage = Properties.Resources.Simpan;
        }

        private void Simpan_MouseHover(object sender, EventArgs e)
        {
            Simpan.Cursor = Cursors.Hand;
        }

        private void Simpan_MouseLeave(object sender, EventArgs e)
        {
            Simpan.BackgroundImage = Properties.Resources.Simpan_Hover;
        }
    }
}
