using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Pet_Care.Model;
using Pet_Care.View;
using Pet_Care.View.Transaksi;
using static System.Runtime.InteropServices.JavaScript.JSType;
using iText.Kernel.Pdf;
using iText.Layout.Element;
using static iText.Layout.Document;
using iText.Layout;
using MailKit.Net.Smtp;
using MailKit;
using MimeKit;
using iText.Layout.Properties;
using iText.Commons.Utils;
using System.Security.Policy;
using iText.Kernel.Font;
using iText.IO.Font.Constants;


namespace Pet_Care.Contoller
{
    public class C_Transaksi : C_Message_Box
    {
        Dictionary<string, Data_Layanan> Daftar_Harga = new Dictionary<string, Data_Layanan>();
        C_MainMenu controller;
        V_Transaksi V_Transaksi;
        public V_Frame_Transaksi? Frame_Transaksi;
        M_Layanan model_layanan = new M_Layanan();
        M_Transaksi model_transaksi = new M_Transaksi();
        M_Pelanggan mode_pelanggan = new M_Pelanggan();
        public dynamic[]? data_pesan;
        public Data_Transaksi Transaksi_baru;
        Data_Pelanngan data_Pelanngan = new Data_Pelanngan { ID = 0 };
        public V_Transaksi_Berlangsung V_Transaksi_Berlangsung;
        public bool status_transaksi;
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

        public bool buat_transaksi(V_Form_Transaksi view)
        {
            if (string.IsNullOrEmpty(view.Durasi.Text))
            {
                show_message_box("Harap Mengisi Seluruh Isi Form");
                return false;
            }
            foreach (RadioButton radioButton in view.Metode_Pembayaran.Controls)
            {
                if (radioButton.Checked) Transaksi_baru.Metode_Pembayaran = radioButton.Text;
            }

            if (string.IsNullOrEmpty(Transaksi_baru.Metode_Pembayaran))
            {
                show_message_box("Harap Mengisi Seluruh Isi Form");
                return false;
            }
            model_transaksi.Insert(Transaksi_baru);
            show_message_box("Berhasil Membuat Transaksi");
            
            return true;
        }

        public int Refresh_Total_Harga(V_Form_Transaksi view)
        {
            int harga = Daftar_Harga["Penitipan"].harga * ((!string.IsNullOrEmpty(view.Durasi.Text)) ? int.Parse(view.Durasi.Text) : 0);
            Transaksi_baru.durasi_penitipan = (harga / Daftar_Harga["Penitipan"].harga).ToString();
            Transaksi_baru.Layanan = new List<dynamic[]>();
            Transaksi_baru.Layanan.Add([(!string.IsNullOrEmpty(view.Durasi.Text)) ? int.Parse(view.Durasi.Text) : 0, Daftar_Harga["Penitipan"].id, "Penitipan", Daftar_Harga["Penitipan"].harga, harga]);
            foreach (CheckBox checkBox in view.flowLayoutPanel1.Controls)
            {
                if (checkBox.Checked)
                {
                    if (Daftar_Harga[checkBox.Text].quantity_berdasarkan_hari)
                    {
                        harga += Daftar_Harga[checkBox.Text].harga * ((!string.IsNullOrEmpty(view.Durasi.Text)) ? int.Parse(view.Durasi.Text) : 0);
                        Transaksi_baru.Layanan.Add([(!string.IsNullOrEmpty(view.Durasi.Text)) ? int.Parse(view.Durasi.Text) : 0, Daftar_Harga[checkBox.Text].id, checkBox.Text, Daftar_Harga[checkBox.Text].harga, Daftar_Harga[checkBox.Text].harga * ((!string.IsNullOrEmpty(view.Durasi.Text)) ? int.Parse(view.Durasi.Text) : 0)]);
                    }
                    else
                    {
                        if (!string.IsNullOrEmpty(view.Durasi.Text)) harga += Daftar_Harga[checkBox.Text].harga;
                        Transaksi_baru.Layanan.Add([1, Daftar_Harga[checkBox.Text].id, checkBox.Text, Daftar_Harga[checkBox.Text].harga, Daftar_Harga[checkBox.Text].harga]);
                    }
                }
            }
            view.Total_Pembayaran.Text = $"Total Pembayaran : Rp{harga.ToString("n", CultureInfo.GetCultureInfo("id-ID"))}";
            Transaksi_baru.nominal = harga;
            return harga;
        }

        public void load_card()
        {
            V_Transaksi_Berlangsung.BackgroundImage = null;
            V_Transaksi_Berlangsung.flowLayoutPanel1.Controls.Clear();
            foreach (Data_Transaksi data in model_transaksi.Get_with_photo())
            {
                create_card(data);
            }
            V_Transaksi_Berlangsung.BackgroundImage = Properties.Resources.BG_Berlangsung;
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

        public void load_data_Layanan(V_Form_Transaksi view)
        {
            List<Data_Layanan> data = model_layanan.Get().OfType<Data_Layanan>().ToList();
            data.ForEach(x => { Daftar_Harga[x.name] = x; });
            data.ForEach(x =>
            {
                if (x.name != "Penitipan")
                {
                    CheckBox radioButton = new CheckBox
                    {
                        BackColor = Color.Transparent,
                        Font = new Font("Montserrat", 8.999999F, FontStyle.Bold, GraphicsUnit.Point, 0),
                        Name = "radioButton",
                        TabIndex = 13,
                        Text = x.name,
                        UseVisualStyleBackColor = false,
                        AutoSize = true 
                    };
                    radioButton.FlatAppearance.BorderColor = Color.FromArgb(217, 217, 217);
                    radioButton.FlatAppearance.BorderSize = 5;
                    radioButton.FlatAppearance.CheckedBackColor = Color.FromArgb(131, 94, 146);
                    radioButton.FlatAppearance.MouseDownBackColor = Color.Transparent;
                    radioButton.FlatAppearance.MouseOverBackColor = Color.Transparent;
                    radioButton.Cursor = Cursors.Hand;
                    radioButton.Click += (object sender, EventArgs e) => { Refresh_Total_Harga(view); };
                    view.flowLayoutPanel1.Controls.Add(radioButton);
                }
            });
        }
        public void load_riwayat(V_Riwayat_Transaksi view)
        {
            List<Data_Transaksi> data = model_transaksi.Get_riwayat().OfType<Data_Transaksi>().ToList();
                view.Tabel_Riwayat.DataSource = data;
                view.Tabel_Riwayat.Columns["id"].Visible = false;
                view.Tabel_Riwayat.Columns["Id_Pelanggan"].Visible = false;
                view.Tabel_Riwayat.Columns["id_akun"].Visible = false;
                view.Tabel_Riwayat.Columns["Foto_Kucing"].Visible = false;
                view.Tabel_Riwayat.Columns["Waktu"].Visible = false;
                view.Tabel_Riwayat.Columns["display_price"].HeaderText = "Nominal Transaksi";
                view.Tabel_Riwayat.Columns["Nama_Pelanggan"].HeaderText = "Nama Pelanggan";
                view.Tabel_Riwayat.Columns["Nama_Kucing"].HeaderText = "Nama Kucing";
                view.Tabel_Riwayat.Columns["durasi_penitipan"].HeaderText = "Durasi";
                view.Tabel_Riwayat.Columns["Nomor_hp"].HeaderText = "Nomor Hp";
                view.Tabel_Riwayat.Columns["nominal"].Visible = false;
                view.Tabel_Riwayat.Columns["Metode_Pembayaran"].HeaderText = "Metode Pembayaran";
                view.Tabel_Riwayat.Columns.Add(new DataGridViewButtonColumn
                {
                    Name = "Detail",
                    HeaderText = "",
                    Text = "Detail",
                    UseColumnTextForButtonValue = true,
                });
                view.Tabel_Riwayat.DefaultCellStyle.BackColor = Color.FromArgb(131, 94, 146);
                view.Tabel_Riwayat.DefaultCellStyle.ForeColor = Color.White;
                view.Tabel_Riwayat.DefaultCellStyle.Font = new Font("Montserrat Bold", 8F);
                view.Tabel_Riwayat.ColumnHeadersDefaultCellStyle.Font = new Font("Montserrat Bold", 8F);
                view.Tabel_Riwayat.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }
        public void load_detail(int id,bool status)
        {
            Data_Transaksi data = model_transaksi.Get_detail(id);
            Frame_Transaksi = new V_Frame_Transaksi(this, new V_Detail_Transaksi(data,status,this));
            Frame_Transaksi.StartPosition = FormStartPosition.Manual;
            Frame_Transaksi.Location = new Point(Screen.FromControl(V_Transaksi).Bounds.Location.X + 800, Screen.FromControl(V_Transaksi).Bounds.Location.Y + 245);
            Frame_Transaksi.ShowDialog();
        }

        public async Task send_nota()
        {
            MemoryStream memoryStream = new MemoryStream();
            PdfWriter writer = new PdfWriter(memoryStream);
            PdfDocument pdf = new PdfDocument(writer);
            Document document = new Document(pdf);

            document.Add(new Paragraph($"Nama Pelanggan      : {data_Pelanngan.Name}").SetMultipliedLeading(0.5f).SetFontSize(12));
            document.Add(new Paragraph($"ID Pelanggan        : #{data_Pelanngan.ID}").SetMultipliedLeading(0.5f).SetFontSize(12));
            document.Add(new Paragraph($"Nama Kucing         : {Transaksi_baru.Nama_Kucing}").SetMultipliedLeading(0.5f).SetFontSize(12));
            document.Add(new Paragraph($"Waktu Transaksi     : {DateTime.UtcNow}").SetMultipliedLeading(0.5f).SetFontSize(12));
            document.Add(new Paragraph($"Kasir               : {M_Session.session_name}").SetMultipliedLeading(0.5f).SetFontSize(12));


            Table tabel = new Table(5).UseAllAvailableWidth();
            tabel.SetAutoLayout();
            tabel.AddHeaderCell(new Paragraph("NO").SetTextAlignment(TextAlignment.CENTER));
            tabel.AddHeaderCell(new Paragraph("LAYANAN").SetTextAlignment(TextAlignment.CENTER));
            tabel.AddHeaderCell(new Paragraph("QTY").SetTextAlignment(TextAlignment.CENTER));
            tabel.AddHeaderCell(new Paragraph("HARGA").SetTextAlignment(TextAlignment.CENTER));
            tabel.AddHeaderCell(new Paragraph("TOTAL").SetTextAlignment(TextAlignment.CENTER));

            for (int i = 0; i < Transaksi_baru.Layanan.Count; i++)
            {
                tabel.AddCell(new Paragraph((i + 1).ToString()).SetTextAlignment(TextAlignment.CENTER));
                tabel.AddCell(new Paragraph((Transaksi_baru.Layanan[i][2]).ToString()).SetTextAlignment(TextAlignment.CENTER));
                tabel.AddCell(new Paragraph((Transaksi_baru.Layanan[i][0]).ToString()).SetTextAlignment(TextAlignment.CENTER));
                tabel.AddCell(new Paragraph((Transaksi_baru.Layanan[i][3]).ToString()).SetTextAlignment(TextAlignment.CENTER));
                tabel.AddCell(new Paragraph((Transaksi_baru.Layanan[i][4]).ToString()).SetTextAlignment(TextAlignment.CENTER));
            }
            tabel.AddFooterCell(new Cell(1, 4).Add(new Paragraph("TOTAL").SetTextAlignment(TextAlignment.CENTER)));
            tabel.AddFooterCell(new Paragraph(Transaksi_baru.nominal.ToString()).SetTextAlignment(TextAlignment.CENTER));
            document.Add(tabel);
            document.Add(new Paragraph($"\nMetode Pembayaran   : {Transaksi_baru.Metode_Pembayaran}").SetMultipliedLeading(0.5f).SetFontSize(12));

            document.Close();
            byte[] pdfBytes = memoryStream.ToArray();
            MimeMessage email = new MimeMessage();

            email.From.Add(new MailboxAddress(EnvLoader.Nama_Email, EnvLoader.Email));
            email.To.Add(new MailboxAddress(data_Pelanngan.Name, data_Pelanngan.Email));
            email.Subject = "[INVOICE PEMBAYARAN]";
            BodyBuilder message = new BodyBuilder
            {
                TextBody = "Terima Kasih Telah Menitipkan Kucing Kesayangan Anda di MeowInn\nUntuk Mendapat Update Kondisi Terkini dari Kucing Anda Silahkan Join Group Telegram Berikut\nLINK TELEGRAM : https://t.me/meowInnNews"
            };

            ContentType contentType = new ContentType("application", "pdf");
            message.Attachments.Add("Invoice.pdf", pdfBytes, contentType);
            email.Body = message.ToMessageBody();
            SmtpClient smtpClient = new SmtpClient();
            await smtpClient.ConnectAsync("smtp.gmail.com", 465, MailKit.Security.SecureSocketOptions.SslOnConnect);
            await smtpClient.AuthenticateAsync(EnvLoader.Email, EnvLoader.Token_Email);
            await smtpClient.SendAsync(email);
            smtpClient.Disconnect(true);
        }
        public void validate_pelanggan(V_Tambah_Transaksi view) 
        {
            if(view.pictureBox1.Image == null || string.IsNullOrEmpty(view.ID_Pelanggan.Text) || string.IsNullOrEmpty(view.Nama_Kucing.Text))
            {
                show_message_box("Harap Isi Seluruh Isi Form");
                return;
            }
            if (this.data_Pelanngan.ID != int.Parse(view.ID_Pelanggan.Text.Substring(1, (view.ID_Pelanggan.Text.Length) - 1)))
            {
                List<Data_Pelanngan> data_Pelanngan = mode_pelanggan.Get(int.Parse(view.ID_Pelanggan.Text.Substring(1, (view.ID_Pelanggan.Text.Length) - 1))).OfType<Data_Pelanngan>().ToList();
                if (data_Pelanngan.Count != 1)
                {
                    show_message_box("ID Pelanggan Belum Terdaftar");
                    return;
                }
                this.data_Pelanngan = data_Pelanngan[0];
            }
            Transaksi_baru = new Data_Transaksi
            {
                Foto_Kucing = (byte[])new ImageConverter().ConvertTo(view.pictureBox1.Image, typeof(byte[])),
                Id_pelanggan = int.Parse(view.ID_Pelanggan.Text.Substring(1, (view.ID_Pelanggan.Text.Length) - 1)),
                Nama_Kucing = view.Nama_Kucing.Text,
                id_akun = M_Session.id_session
            };
            Frame_Transaksi.Controls.Clear();
            Frame_Transaksi.Controls.Add(new V_Form_Transaksi(this));
        }
        public void Buat_Transaksi()
        {
            Frame_Transaksi = new V_Frame_Transaksi(this,new V_Tambah_Transaksi(this));
            Frame_Transaksi.StartPosition = FormStartPosition.Manual;
            Frame_Transaksi.Location = new Point(Screen.FromControl(V_Transaksi).Bounds.Location.X + 800, Screen.FromControl(V_Transaksi).Bounds.Location.Y + 245);
            Frame_Transaksi.ShowDialog();
            if (status_transaksi)
            {
                send_nota();
                status_transaksi = false;
                V_Transaksi_Berlangsung = new V_Transaksi_Berlangsung(this);
                switch_view(V_Transaksi_Berlangsung);
               
            }
        }

        public async void send_message(Data_Transaksi data)
        {
            V_Send_Message send_message = new V_Send_Message(this);
            Frame_Transaksi = new V_Frame_Transaksi(this, send_message);
            Frame_Transaksi.StartPosition = FormStartPosition.Manual;
            Frame_Transaksi.Location = new Point(Screen.FromControl(V_Transaksi).Bounds.Location.X + 800, Screen.FromControl(V_Transaksi).Bounds.Location.Y + 245);
            Frame_Transaksi.ShowDialog();
            if (send_message.status)
            {
                string username = "@meowInnNews";
                string message = $"[BROADCAST HARIAN KUCING MEOWINN]\nOwner : @{data.Tele}\nNama Kucing : {data.Nama_Kucing}\nKegiatan : {data_pesan[1]}";
                HttpClient client = new HttpClient();
                MultipartFormDataContent formData = new MultipartFormDataContent();
                ByteArrayContent fileContent = new ByteArrayContent(data_pesan[0]);
                formData.Add(fileContent, "photo", "foto");
                formData.Add(new StringContent($"{username}"), "chat_id");
                formData.Add(new StringContent(message), "caption");
                await client.PostAsync($"https://api.telegram.org/bot{EnvLoader.Token_Tele}/sendPhoto", formData);
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
            detail.Cursor = Cursors.Hand;
            detail.MouseEnter += (object sender, EventArgs e) => { detail.BackgroundImage = Properties.Resources.Detail_Hover; };
            detail.MouseLeave += (object sender, EventArgs e) => { detail.BackgroundImage = Properties.Resources.Detail; };
            detail.Click += (object sender, EventArgs e) => { this.load_detail(data.id,true); };

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
            Selesai.Cursor = Cursors.Hand;
            Selesai.Click += (object sender,EventArgs e) => { selesai(data);};
            Selesai.MouseEnter += (object sender, EventArgs e) => { Selesai.BackgroundImage = Properties.Resources.Selesai_Card_Hover; };
            Selesai.MouseLeave += (object sender, EventArgs e) => { Selesai.BackgroundImage = Properties.Resources.Selesai_Card; };

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
            Delete.Cursor = Cursors.Hand;
            Delete.Click += (object sender,EventArgs e) => { this.Delete(data.id); };
            Delete.MouseEnter += (object sender,EventArgs e) => { Delete.BackgroundImage = Properties.Resources.Cancel_Card_Hover; };
            Delete.MouseLeave += (object sender, EventArgs e) => { Delete.BackgroundImage = Properties.Resources.Cancel1; };

            Label harga = new Label
            {
                Font = new Font("Montserrat SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0),
                Location = new Point(12, 153),
                Name = "Harga",
                Size = new Size(195, 23),
                TabIndex = 1,
                TextAlign = ContentAlignment.MiddleLeft,
                Text =  $"Rp{data.nominal.ToString("n2", CultureInfo.GetCultureInfo("id-ID"))}"
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
            Pesan.Cursor = Cursors.Hand;
            Pesan.MouseEnter += (object sender, EventArgs e) => { Pesan.BackgroundImage = Properties.Resources.Message_Hover; };
            Pesan.MouseLeave += (object sender, EventArgs e) => { Pesan.BackgroundImage = Properties.Resources.Message; };
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
