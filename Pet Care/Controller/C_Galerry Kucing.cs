using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Pet_Care.View;
using Pet_Care.Model;

namespace Pet_Care.Controller
{
    public class C_Galerry_Kucing
    {
        C_MainMenu c_MainMenu;
        V_Gallery_Kucing view;
        M_Transaksi m_transaksi = new M_Transaksi();
        public C_Galerry_Kucing(C_MainMenu controller) 
        {
            c_MainMenu = controller;
            view = new V_Gallery_Kucing(this);
            c_MainMenu.move_view(view);
        }

        public void load_photo()
        {
            List<Data_Transaksi> data_Transaksis = m_transaksi.Get_Foto_Kucing().OfType<Data_Transaksi>().ToList();
            ImageConverter img = new ImageConverter();
 
            foreach (Data_Transaksi data in data_Transaksis)
            {
                create_card(data.Nama_Kucing, data.Foto_Kucing);
            }
        }
        public void create_card(string name, byte[] foto)
        {
            Panel panel = new Panel
            {
                BackgroundImage = Properties.Resources.Background_Card_Gallery,
                Location = new Point(3, 3),
                Name = "panel1",
                Size = new Size(260, 199),
                TabIndex = 0,
                TabStop = true,
            };
            PictureBox picture_box = new PictureBox
            {
                Location = new Point(4, 0),
                Name = "pictureBox1",
                Size = new Size(251, 141),
                TabIndex = 0,
                TabStop = false,
                Image = new Bitmap(new MemoryStream(foto)),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            Label header = new Label
            {
                BackColor = Color.Transparent,
                Font = new Font("Montserrat", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0),
                Location = new Point(4, 144),
                Name = "Kucing",
                Size = new Size(251, 45),
                TabIndex = 1,
                Text = name,
                TextAlign = ContentAlignment.MiddleCenter
            };
            panel.Controls.Add(header);
            panel.Controls.Add(picture_box);
            view.flowLayoutPanel1.Controls.Add(panel);
        }
    }
}
