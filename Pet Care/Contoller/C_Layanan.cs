using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pet_Care.View;

namespace Pet_Care.Contoller
{
    public class C_Layanan : C_Message_Box
    {
        C_MainMenu C_MainMenu;
        V_Layanan V_Layanan;
        public C_Layanan(C_MainMenu controller) 
        { 
            C_MainMenu = controller;
            V_Layanan = new V_Layanan(this);
            controller.move_view(V_Layanan);
            V_Ubah_Tambah_Layanan v = new V_Ubah_Tambah_Layanan(new Model.Data_Layanan
            {
                name = "Penitipan",
                quantity_berdasarkan_hari = true,
                harga = 80000
            });
            v.StartPosition = FormStartPosition.Manual;
            v.Location = new Point(800, 310);
            v.ShowDialog();
        }
    }
}
