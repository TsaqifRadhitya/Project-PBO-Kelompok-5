using Pet_Care.Contoller;

namespace Pet_Care.View
{
    partial class V_Dashboard
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            nama = new Label();
            kucing = new Label();
            Layanan = new Label();
            label1 = new Label();
            TabelTransaksi = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)TabelTransaksi).BeginInit();
            SuspendLayout();
            // 
            // nama
            // 
            nama.BackColor = Color.Transparent;
            nama.Font = new Font("Montserrat SemiBold", 16F, FontStyle.Bold);
            nama.ImageAlign = ContentAlignment.TopCenter;
            nama.Location = new Point(504, 54);
            nama.Name = "nama";
            nama.Size = new Size(436, 40);
            nama.TabIndex = 0;
            nama.Text = "label1";
            nama.TextAlign = ContentAlignment.TopRight;
            // 
            // kucing
            // 
            kucing.AutoSize = true;
            kucing.BackColor = Color.Transparent;
            kucing.Font = new Font("Montserrat", 16F);
            kucing.ForeColor = Color.FromArgb(255, 255, 255);
            kucing.Location = new Point(78, 306);
            kucing.Name = "kucing";
            kucing.Size = new Size(95, 30);
            kucing.TabIndex = 1;
            kucing.Text = "30 ekor";
            // 
            // Layanan
            // 
            Layanan.AutoSize = true;
            Layanan.BackColor = Color.Transparent;
            Layanan.Font = new Font("Montserrat", 16F);
            Layanan.ForeColor = Color.FromArgb(255, 255, 255);
            Layanan.Location = new Point(387, 306);
            Layanan.Name = "Layanan";
            Layanan.Size = new Size(139, 30);
            Layanan.TabIndex = 2;
            Layanan.Text = "67 Layanan";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Montserrat", 16F);
            label1.ForeColor = Color.FromArgb(255, 255, 255);
            label1.Location = new Point(698, 306);
            label1.Name = "label1";
            label1.Size = new Size(142, 30);
            label1.TabIndex = 3;
            label1.Text = "Rp3500000";
            // 
            // TabelTransaksi
            // 
            TabelTransaksi.AllowUserToDeleteRows = false;
            TabelTransaksi.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            TabelTransaksi.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            TabelTransaksi.BackgroundColor = Color.FromArgb(253, 233, 218);
            TabelTransaksi.BorderStyle = BorderStyle.None;
            TabelTransaksi.CellBorderStyle = DataGridViewCellBorderStyle.None;
            TabelTransaksi.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            TabelTransaksi.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            TabelTransaksi.ColumnHeadersVisible = false;
            TabelTransaksi.GridColor = Color.FromArgb(253, 233, 218);
            TabelTransaksi.Location = new Point(69, 472);
            TabelTransaksi.MultiSelect = false;
            TabelTransaksi.Name = "TabelTransaksi";
            TabelTransaksi.ReadOnly = true;
            TabelTransaksi.RowHeadersVisible = false;
            TabelTransaksi.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            TabelTransaksi.Size = new Size(871, 174);
            TabelTransaksi.TabIndex = 4;
            TabelTransaksi.DefaultCellStyle.BackColor = Color.FromArgb(253, 233, 218);
            TabelTransaksi.DefaultCellStyle.Font = new Font("Montserrat", 12F);
            TabelTransaksi.DefaultCellStyle.Padding = new Padding(3);
            TabelTransaksi.CellContentClick += TabelTransaksi_CellContentClick;
            // 
            // V_Dashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Dashboard1;
            Controls.Add(TabelTransaksi);
            Controls.Add(label1);
            Controls.Add(Layanan);
            Controls.Add(kucing);
            Controls.Add(nama);
            Name = "V_Dashboard";
            Size = new Size(1000, 720);
            Load += V_Dashboard_Load;
            ((System.ComponentModel.ISupportInitialize)TabelTransaksi).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public Label nama;
        private Label kucing;
        private Label Layanan;
        private Label label1;
        public DataGridView TabelTransaksi;
    }
}
