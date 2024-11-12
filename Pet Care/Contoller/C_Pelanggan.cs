using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pet_Care.View;
using Pet_Care.Model;

namespace Pet_Care.Contoller
{
    public class C_Pelanggan
    {
        V_Pelanggan view;
        M_Pelanggan M_Pelanggan = new M_Pelanggan();
        public C_Pelanggan(V_Pelanggan view) 
        {
            this.view = view;
            load_data();
        }

        public void load_data()
        {
            view.flowLayoutPanel1.Controls.Clear();
            List<Data_Pelanngan> daftar_Pelanggan = M_Pelanggan.Get().OfType<Data_Pelanngan>().ToList();
            foreach (Data_Pelanngan data in daftar_Pelanggan)
            { 
                create_card(data);
            }
        }

        public void create_card(Data_Pelanngan data)
        {
            Bitmap[] background = [Properties.Resources.Red_card,Properties.Resources.Orange_Card,Properties.Resources.LightPurple_Card,Properties.Resources.Purple_Card];
            Random random = new Random();
            Panel panel = new Panel
            {
                BackgroundImage = background[random.Next(background.Length)],
                Location = new Point(26, 26),
                Margin = new Padding(26,0,26,52),
                Name = "panel1",
                Size = new Size(188, 260),
                TabIndex = 0
            };
            Label Nama = new Label
            {
                Font = new Font("Montserrat SemiBold", 18F, FontStyle.Bold),
                Location = new Point(14, 141),
                Margin = new Padding(0),
                Name = "Nama",
                Size = new Size(100, 38),
                TabIndex = 0,
                Text = data.Name
            };
            Label Nomor_Hp = new Label
            {
                Font = new Font("Montserrat", 11F),
                Location = new Point(14, 183),
                Margin = new Padding(0),
                Name = "Nomor_Hp",
                Size = new Size(158, 22),
                TabIndex = 1,
                Text = data.Nomor_HP
            };
            Label Alamat = new Label
            {
                Font = new Font("Montserrat", 11F),
                Location = new Point(14, 211),
                Margin = new Padding(0),
                Name = "label1",
                Size = new Size(158, 22),
                TabIndex = 2,
                Text = data.Alamat
            };
            panel.Controls.Add(Alamat);
            panel.Controls.Add(Nomor_Hp);
            panel.Controls.Add(Nama);
            view.flowLayoutPanel1.Controls.Add(panel);
        }
    }
}
