using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Pet_Care.Model;
using Pet_Care.View;
using Pet_Care.View.Transaksi;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Pet_Care.Contoller
{
    public class C_Transaksi : C_Message_Box
    {
        Dictionary<string,Data_Layanan> Daftar_Harga = new Dictionary<string, Data_Layanan>();
        C_MainMenu controller;
        V_Transaksi V_Transaksi;
        public V_Frame_Transaksi? Frame_Transaksi;
        M_Layanan model_layanan = new M_Layanan();
        M_Transaksi model_transaksi = new M_Transaksi();
        public dynamic[]? data_pesan;
        public Data_Transaksi Transaksi_baru;
        public V_Transaksi_Berlangsung V_Transaksi_Berlangsung;
        public C_Transaksi(C_MainMenu controller) 
        {
            this.controller = controller;
            V_Transaksi = new V_Transaksi(this);
            controller.move_view(V_Transaksi);
            V_Transaksi_Berlangsung = new V_Transaksi_Berlangsung(this);
            switch_view(V_Transaksi_Berlangsung);
        }

        public void switch_view(UserControl view)
        {
            V_Transaksi.Panel_Transaksi.Controls.Clear();
            V_Transaksi.Panel_Transaksi.Controls.Add(view);
        }

        public void Refresh_Total_Harga(V_Form_Transaksi view)
        {
            int harga = 0;
            foreach(CheckBox checkBox in view.flowLayoutPanel1.Controls)
            {
                if (checkBox.Checked)
                {
                    if (Daftar_Harga[checkBox.Text].quantity_berdasarkan_hari)
                    {
                        harga += Daftar_Harga[checkBox.Text].harga * ((!string.IsNullOrEmpty(view.Durasi.Text)) ? int.Parse(view.Durasi.Text) : 1);
                    }
                    else
                    {
                        harga += Daftar_Harga[checkBox.Text].harga;
                    }
                }
            }
            view.Total_Pembayaran.Text = $"Total Pembayaran : Rp{harga.ToString("n", CultureInfo.GetCultureInfo("id-ID"))}";
        }

        public void load_card()
        {
            V_Transaksi_Berlangsung.flowLayoutPanel1.Controls.Clear();
            for (int i = 0; i < 2; i++) 
            {
                create_card(new Data_Transaksi
                {
                    Foto_Kucing = (byte[])new ImageConverter().ConvertTo(Properties.Resources.Test_Picture, typeof(byte[])),
                    nominal = 50000,
                    Nama_Kucing = $"Richie {i}",
                    id = i
                });
            }
        }
        public void Delete(int id)
        {
            if (show_confirm_message_box("Batalkan Transaksi ?"))
            {
                model_transaksi.Delete(id);
                load_card();
            };
        }
        public void selesai(Data_Transaksi data)
        {
            if (show_confirm_message_box("Selesaikan Transaksi ?")) 
            {
                model_transaksi.Update(data, data.id);
                load_card();
            }
        }

        public List<Data_Layanan> load_data_Layanan()
        {
            List<Data_Layanan> data = model_layanan.Get().OfType<Data_Layanan>().ToList();
            data.ForEach(x => { Daftar_Harga[x.name] = x; });
            return data;
        }
        public void load_detail(int id,V_Detail_Transaksi view)
        {

        }
        public void detail(int id)
        {
            Frame_Transaksi = new V_Frame_Transaksi(this, new V_Detail_Transaksi(this,id));
            Frame_Transaksi.StartPosition = FormStartPosition.Manual; 
            Frame_Transaksi.Location = new Point(Screen.FromControl(V_Transaksi).Bounds.Location.X + 800, Screen.FromControl(V_Transaksi).Bounds.Location.Y + 245);
            Frame_Transaksi.ShowDialog();
        }
        public void Buat_Transaksi()
        {
            Frame_Transaksi = new V_Frame_Transaksi(this,new V_Tambah_Transaksi(this));
            Frame_Transaksi.StartPosition = FormStartPosition.Manual;
            //Frame_Transaksi.Location = 
            Frame_Transaksi.Location = new Point(Screen.FromControl(V_Transaksi).Bounds.Location.X + 800, Screen.FromControl(V_Transaksi).Bounds.Location.Y + 245);
            Frame_Transaksi.ShowDialog();
        }

        public void send_message(Data_Transaksi data)
        {
            V_Send_Message send_message = new V_Send_Message(this);
            Frame_Transaksi = new V_Frame_Transaksi(this, send_message);
            Frame_Transaksi.StartPosition = FormStartPosition.Manual;
            Frame_Transaksi.Location = new Point(Screen.FromControl(V_Transaksi).Bounds.Location.X + 800, Screen.FromControl(V_Transaksi).Bounds.Location.Y + 245);
            Frame_Transaksi.ShowDialog();
            if (send_message.status)
            {
                string username = "@meowInnNews";
                string message = $"[BROADCAST HARIAN KUCING MEOWINN]\nNama Kucing : {data.Nama_Kucing}\nKegiatan : {data_pesan[1]}";
                string token = "7601026397:AAFZD3wLc28O527pAiOqdQiJKs6lL4xO83A";
                HttpClient client = new HttpClient();
                MultipartFormDataContent formData = new MultipartFormDataContent();
                ByteArrayContent fileContent = new ByteArrayContent(data_pesan[0]);
                formData.Add(fileContent, "photo", "foto");
                formData.Add(new StringContent($"{username}"), "chat_id");
                formData.Add(new StringContent(message), "caption");
                client.PostAsync($"https://api.telegram.org/bot{token}/sendPhoto", formData);
                data_pesan = null;
            }
        }
        public void create_card(Data_Transaksi data)
        {
            Panel Card = new Panel
            {
                BackgroundImage = Properties.Resources.BG_Card,
                Margin = new Padding(10, 10, 0, 0),
                Name = "Card",
                Size = new Size(263, 248),
                TabIndex = 0
            };

            Button detail = new Button
            {
                BackgroundImage = Properties.Resources.Detail,
                FlatStyle = FlatStyle.Flat,
                Location = new Point(215, 17),
                Name = "Detail",
                Size = new Size(25, 25),
                TabIndex = 4,
                UseVisualStyleBackColor = true
            };

            detail.FlatAppearance.BorderSize = 0;
            detail.FlatAppearance.MouseDownBackColor = Color.Transparent;
            detail.FlatAppearance.MouseOverBackColor = Color.Transparent;
            detail.MouseEnter += (object sender, EventArgs e) => { detail.BackgroundImage = Properties.Resources.Detail_Hover; };
            detail.MouseLeave += (object sender, EventArgs e) => { detail.BackgroundImage = Properties.Resources.Detail; };
            detail.MouseHover += (object sender,EventArgs e) => { detail.Cursor = Cursors.Hand;} ;
            detail.Click += (object sender, EventArgs e) => { this.detail(data.id); };

            Button Selesai = new Button
            {
                BackgroundImage = Properties.Resources.Selesai_Card,
                FlatStyle = FlatStyle.Flat,
                Location = new Point(136, 186),
                Name = "Selesai",
                Size = new Size(114, 44),
                TabIndex = 2,
                UseVisualStyleBackColor = true
            };
            Selesai.FlatAppearance.BorderSize = 0;
            Selesai.FlatAppearance.MouseDownBackColor = Color.Transparent;
            Selesai.FlatAppearance.MouseOverBackColor = Color.Transparent;
            Selesai.Click += (object sender,EventArgs e) => { selesai(data);};
            Selesai.MouseEnter += (object sender, EventArgs e) => { Selesai.BackgroundImage = Properties.Resources.Selesai_Card_Hover; };
            Selesai.MouseLeave += (object sender, EventArgs e) => { Selesai.BackgroundImage = Properties.Resources.Selesai_Card; };
            Selesai.MouseHover += (object sender, EventArgs e) => { Selesai.Cursor = Cursors.Hand;  };

            Button Delete = new Button
            {
                BackgroundImage = Properties.Resources.Cancel1,
                FlatStyle = FlatStyle.Flat,
                Location = new Point(214, 149),
                Name = "Delete",
                Size = new Size(32, 32),
                TabIndex = 3,
                UseVisualStyleBackColor = true,
            };
            Delete.FlatAppearance.BorderSize = 0;
            Delete.FlatAppearance.MouseDownBackColor = Color.Transparent;
            Delete.FlatAppearance.MouseOverBackColor = Color.Transparent;
            Delete.Click += (object sender,EventArgs e) => { this.Delete(data.id); };
            Delete.MouseEnter += (object sender,EventArgs e) => { Delete.BackgroundImage = Properties.Resources.Cancel_Card_Hover; };
            Delete.MouseLeave += (object sender, EventArgs e) => { Delete.BackgroundImage = Properties.Resources.Cancel1; };
            Delete.MouseHover += (object sender, EventArgs e) => { Delete.Cursor = Cursors.Hand;  };
            // 
            // Harga
            // 
            Label harga = new Label
            {
                Font = new Font("Montserrat SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0),
                Location = new Point(12, 153),
                Name = "Harga",
                Size = new Size(195, 23),
                TabIndex = 1,
                TextAlign = ContentAlignment.MiddleLeft,
                Text =  $"Rp{data.nominal.ToString("n", CultureInfo.GetCultureInfo("id-ID"))}"
            };
            PictureBox foto = new PictureBox
            {
                Image = new Bitmap(new MemoryStream(data.Foto_Kucing)),
                Location = new Point(12, 9),
                Name = "Foto",
                Size = new Size(238, 134),
                SizeMode = PictureBoxSizeMode.StretchImage,
                TabIndex = 1,
                TabStop = false
            };

            Button Pesan = new Button
            {
                BackgroundImage = Properties.Resources.Message,
                FlatStyle = FlatStyle.Flat,
                Location = new Point(12, 186),
                Name = "Pesan",
                Size = new Size(114, 44),
                TabIndex = 1,
                UseVisualStyleBackColor = true
            };
            Pesan.FlatAppearance.BorderSize = 0;
            Pesan.FlatAppearance.MouseDownBackColor = Color.Transparent;
            Pesan.FlatAppearance.MouseOverBackColor = Color.Transparent;
            Pesan.MouseEnter += (object sender, EventArgs e) => { Pesan.BackgroundImage = Properties.Resources.Message_Hover; };
            Pesan.MouseLeave += (object sender, EventArgs e) => { Pesan.BackgroundImage = Properties.Resources.Message; };
            Pesan.MouseHover += (object sender, EventArgs e) => { Pesan.Cursor = Cursors.Hand; };
            Pesan.Click += (object sender, EventArgs e) => { send_message(data); };

            Card.Controls.Add(detail);
            Card.Controls.Add(Selesai);
            Card.Controls.Add(Delete);
            Card.Controls.Add(harga);
            Card.Controls.Add(foto);
            Card.Controls.Add(Pesan);
            V_Transaksi_Berlangsung.flowLayoutPanel1.Controls.Add(Card);
        }
    }
}
