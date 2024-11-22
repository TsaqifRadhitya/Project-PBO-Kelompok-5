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
            V_Ubah_Tambah_Layanan tambah = new V_Ubah_Tambah_Layanan();
            tambah.Location = new Point(800, 310);
            tambah.ShowDialog();
        }

        public dynamic[] save(Data_Layanan data, bool edit_state)
        {
            if(data.harga == 0 || string.IsNullOrEmpty(data.name)) return [false];
            if (edit_state)
            { 

            }
            else 
            {

            }

            return [true];
        }
        public void show_form_edit(Data_Layanan data)
        {
            V_Ubah_Tambah_Layanan edit = new V_Ubah_Tambah_Layanan(data);
            edit.Location = new Point(800, 310);
            edit.ShowDialog();
        }

        public void delete_layanan(string layanan,int id)
        {
            if (show_confirm_message_box($"Apakah Anda Mau Menghapus Layanan {layanan} ?")) model.Delete(id);
        }
    }
}
