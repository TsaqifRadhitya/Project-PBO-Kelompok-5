using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pet_Care.View
{
    public partial class V_Ubah_Tambah_Pelanggan : Form
    {
        public V_Ubah_Tambah_Pelanggan()
        {
            InitializeComponent();
        }

        private void Batal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Batal_MouseEnter(object sender, EventArgs e)
        {
            Batal.BackgroundImage = Properties.Resources.Batal_Hover;
        }
        private void Batal_MouseLeave(object sender, EventArgs e)
        {
            Batal.BackgroundImage = Properties.Resources.Batal;
        }
        private void Batal_MouseHover(object sender, EventArgs e)
        {
            Batal.Cursor = Cursors.Hand;
        }
        private void Simpan_Click(object sender, EventArgs e)
        {

        }
        private void Simpan_MouseHover(object sender, EventArgs e)
        {
            Simpan.Cursor = Cursors.Hand;
        }

        private void Simpan_MouseEnter(object sender, EventArgs e)
        {
            Simpan.BackgroundImage = Properties.Resources.Simpan_Hover;
        }

        private void Simpan_MouseLeave(object sender, EventArgs e)
        {
            Simpan.BackgroundImage = Properties.Resources.Simpan;
        }
    }
}
