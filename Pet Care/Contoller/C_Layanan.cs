using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pet_Care.View;
using Pet_Care.Model;
using System.DirectoryServices;

namespace Pet_Care.Contoller
{
    public class C_Layanan : C_Message_Box
    {
        C_MainMenu C_MainMenu;
        V_Layanan V_Layanan;
        M_Layanan model = new M_Layanan();
        public C_Layanan(C_MainMenu controller) 
        { 
            C_MainMenu = controller;
            V_Layanan = new V_Layanan(this);
            controller.move_view(V_Layanan);
        }
        public void show_form_tambah()
        {
            V_Ubah_Tambah_Layanan tambah = new V_Ubah_Tambah_Layanan(this);
            tambah.Location = new Point(800, 310);
            tambah.ShowDialog();
        }

        public void save(Data_Layanan data, bool edit_state)
        {
            if (edit_state)
            { 
                model.Update(data,data.id);
            }
            else 
            {
                model.Insert(data);
            }
            load();
        }
        public void show_form_edit(Data_Layanan data)
        {
            V_Ubah_Tambah_Layanan edit = new V_Ubah_Tambah_Layanan(data,this);
            edit.Location = new Point(800, 310);
            edit.ShowDialog();
        }
        public void load()
        {
            V_Layanan.Tabel_Layanan.DataSource = null;
            V_Layanan.Tabel_Layanan.Columns.Clear();
            DataGridViewButtonColumn Delete = new DataGridViewButtonColumn
            {
                Name = "Delete",
                UseColumnTextForButtonValue = true,
                Text = "Delete"
            };
            DataGridViewButtonColumn Edit = new DataGridViewButtonColumn
            {
                Name = "Edit",
                UseColumnTextForButtonValue = true,
                Text = "Edit",
            };
            V_Layanan.Tabel_Layanan.DataSource = model.Get();
            
            if(V_Layanan.Tabel_Layanan.Rows.Count > 0)
            {
                V_Layanan.Tabel_Layanan.Columns.Add(Edit);
                V_Layanan.Tabel_Layanan.Columns.Add(Delete);
                V_Layanan.Tabel_Layanan.Columns["quantity_berdasarkan_hari"].HeaderText = "Berdasarkan Hari";
                V_Layanan.Tabel_Layanan.Columns["name"].HeaderText = "Nama Layanan";
                V_Layanan.Tabel_Layanan.Columns["display_price"].HeaderText = "Harga";
                V_Layanan.Tabel_Layanan.Columns["display_price"].HeaderText = "Harga";
                V_Layanan.Tabel_Layanan.Columns["Edit"].HeaderText = "";
                V_Layanan.Tabel_Layanan.Columns["Delete"].HeaderText = "";
                V_Layanan.Tabel_Layanan.Columns["id"].Visible = false;
                V_Layanan.Tabel_Layanan.Columns["Harga"].Visible = false;
                V_Layanan.Tabel_Layanan.DefaultCellStyle.BackColor = Color.FromArgb(253, 233, 218);
                V_Layanan.Tabel_Layanan.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(253, 233, 218);
            }
        }

        public void delete_layanan(string layanan,int id)
        {
            if (show_confirm_message_box($"Apakah Anda Mau Menghapus Layanan {layanan} ?")) {
                model.Delete(id);
                load();
            };
        }
    }
}
