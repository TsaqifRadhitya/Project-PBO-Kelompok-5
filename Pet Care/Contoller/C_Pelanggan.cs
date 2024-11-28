using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pet_Care.View;
using Pet_Care.Model;
using NpgsqlTypes;
using System.Numerics;

namespace Pet_Care.Contoller
{
    public class C_Pelanggan : C_Message_Box
    {
        C_MainMenu C_MainMenu;
        V_Pelanggan view_pelanggan;
        M_Pelanggan M_Pelanggan = new M_Pelanggan();
        public C_Pelanggan(C_MainMenu controller) 
        {
            C_MainMenu = controller;
            view_pelanggan = new V_Pelanggan(this);
            C_MainMenu.move_view(view_pelanggan);
        }
        public void Form_tambah_pelanggan()
        {
            V_Ubah_Tambah_Pelanggan v_Ubah_Tambah_Pelanggan = new V_Ubah_Tambah_Pelanggan(this);
            v_Ubah_Tambah_Pelanggan.StartPosition = FormStartPosition.Manual;
            v_Ubah_Tambah_Pelanggan.Location = new Point(Screen.FromControl(view_pelanggan).Bounds.Location.X + 800, Screen.FromControl(view_pelanggan).Bounds.Location.Y + 245);
            v_Ubah_Tambah_Pelanggan.ShowDialog();
        }
        public dynamic[] save_data(bool edit_state, Data_Pelanngan data)
        {
            if(string.IsNullOrEmpty(data.Name) || string.IsNullOrEmpty(data.Nomor_HP) || string.IsNullOrEmpty(data.Alamat) || string.IsNullOrEmpty(data.Email)) return [false,"Harap Mengisi Seluruh Data !"];
            if (edit_state)
            {
                try
                {
                    M_Pelanggan.Update(data, data.ID);
                    return [true];
                }
                catch
                {
                    return [false,"Nomor Hp Sudah Terdaftar !"];
                }
            }
            else
            {
                try
                {
                    show_message_box($"Berhasil Menambahkan Pelangann dengan ID #{M_Pelanggan.insert(data)}");
                    return [true];
                }
                catch
                {
                    return [false, "Nomor Hp Sudah Terdaftar !"];
                }
            }     
        }
        public void load_data()
        {
            view_pelanggan.flowLayoutPanel1.Controls.Clear();
            List<Data_Pelanngan> daftar_Pelanggan = M_Pelanggan.Get().OfType<Data_Pelanngan>().ToList();
            foreach (Data_Pelanngan data in daftar_Pelanggan)
            {
                create_card(data);
            }
        }

        public void delete_pelanggan(int id)
        {
            if (show_confirm_message_box("Apakah Yakin Mau Menghapus Pelanggan ?"))
            {
                M_Pelanggan.Delete(id);
                load_data();
            }
        }

        public void Form_ubah_data(Data_Pelanngan data)
        {
            V_Ubah_Tambah_Pelanggan v_Ubah = new V_Ubah_Tambah_Pelanggan(this,data);
            v_Ubah.StartPosition = FormStartPosition.Manual;
            v_Ubah.Location = new Point(Screen.FromControl(view_pelanggan).Bounds.Location.X + 800, Screen.FromControl(view_pelanggan).Bounds.Location.Y + 245);
            v_Ubah.ShowDialog();
        }
        public bool Search(string key_word)
        {
            List<Data_Pelanngan> hasil_pencarian = M_Pelanggan.Get(key_word).OfType<Data_Pelanngan>().ToList();
            view_pelanggan.flowLayoutPanel1.Controls.Clear();
            hasil_pencarian.ForEach(data => {create_card(data);});
            return (hasil_pencarian.Count == 0) ? false : true;
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
                Location = new Point(0, 128),
                Margin = new Padding(0),
                Name = "Nama",
                Size = new Size(188, 38),
                TabIndex = 0,
                Text = data.Name,
                TextAlign = ContentAlignment.TopCenter

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
            Label ID = new Label
            {
                Font = new Font("Montserrat", 11F),
                Location = new Point(14, 161),
                Margin = new Padding(0),
                Name = "id",
                Size = new Size(158, 22),
                TabIndex = 3,
                Text = $"#{data.ID}",
                TextAlign = ContentAlignment.TopCenter
            };
            Label Alamat = new Label
            {
                Font = new Font("Montserrat", 11F),
                Location = new Point(14, 223),
                Margin = new Padding(0),
                Name = "label1",
                Size = new Size(158, 22),
                TabIndex = 2,
                Text = data.Alamat
            };
            Label Email = new Label
            {
                Font = new Font("Montserrat", 8F),
                Location = new Point(15, 206),
                Margin = new Padding(0),
                Name = "Email",
                Size = new Size(157, 20),
                TabIndex = 5,
                Text = data.Email,
                TextAlign = ContentAlignment.TopLeft,
            };
            Button Delete = new Button
            {
                FlatStyle = FlatStyle.Flat,
                Location = new Point(15, 15),
                Name = "Delete",
                Size = new Size(14, 18),
                TabIndex = 1,
                UseVisualStyleBackColor = true,
            };
            Delete.FlatAppearance.BorderSize = 0;
            Delete.FlatAppearance.MouseDownBackColor= Color.Transparent;
            Delete.FlatAppearance.MouseOverBackColor= Color.Transparent;
            Delete.MouseHover += (object sender, EventArgs e) => { Delete.Cursor = Cursors.Hand; };
            Delete.Click += (object sender, EventArgs e) => { delete_pelanggan(data.ID); };

            Button Edit = new Button
            {
                FlatStyle = FlatStyle.Flat,
                Location = new Point(153, 15),
                Name = "Ubah",
                Size = new Size(20, 20),
                TabIndex = 4,
                UseVisualStyleBackColor = true,
            };
            Edit.FlatAppearance.BorderSize = 0;
            Edit.FlatAppearance.MouseDownBackColor = Color.Transparent;
            Edit.FlatAppearance.MouseOverBackColor = Color.Transparent;
            Edit.MouseHover += (object sender, EventArgs e) => { Edit.Cursor = Cursors.Hand; };
            Edit.Click += (object sender, EventArgs e) => { Form_ubah_data(data); };
            panel.Controls.Add(Edit);
            panel.Controls.Add(ID);
            panel.Controls.Add(Alamat);
            panel.Controls.Add(Nomor_Hp);
            panel.Controls.Add(Nama);
            panel.Controls.Add(Delete);
            panel.Controls.Add(Email);
            view_pelanggan.flowLayoutPanel1.Controls.Add(panel);
        }
    }
}
