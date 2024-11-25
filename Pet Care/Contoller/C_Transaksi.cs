using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pet_Care.View;

namespace Pet_Care.Contoller
{
    public class C_Transaksi
    {
        C_MainMenu controller;
        V_Transaksi V_Transaksi;
        public C_Transaksi(C_MainMenu controller) 
        {
            this.controller = controller;
            V_Transaksi = new V_Transaksi(this);
            controller.move_view(V_Transaksi);
            switch_view(new V_Transaksi_Berlangsung(this));
        }

        public void switch_view(UserControl view)
        {
            V_Transaksi.Panel_Transaksi.Controls.Clear();
            V_Transaksi.Panel_Transaksi.Controls.Add(view);
        }
    }
}
