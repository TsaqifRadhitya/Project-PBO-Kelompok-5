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
            tambah.Location = new Point(Screen.FromControl(V_Layanan).Bounds.Location.X + 800, Screen.FromControl(V_Layanan).Bounds.Location.Y + 310);
            tambah.ShowDialog();
        }

        public dynamic[] save(Data_Layanan data, bool edit_state)
        {
            if (edit_state)
            {
                try
                {
                    model.Update(data, data.id);
                    return [true,data.name,edit_state];
                }
                catch
                {
                    return [false,data.name,edit_state];
                }
                
            }
            else 
            {
                try
                {
                    model.Insert(data);
                    return [true,data.name,edit_state];
                }
                catch
                {
                    return [false,data.name,edit_state];
                }    
            }
        }
        public void show_form_edit(Data_Layanan data)
        {
            V_Ubah_Tambah_Layanan edit = new V_Ubah_Tambah_Layanan(data,this);
            edit.Location = new Point(Screen.FromControl(V_Layanan).Bounds.Location.X + 800, Screen.FromControl(V_Layanan).Bounds.Location.Y + 310); ;
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
