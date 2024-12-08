using Pet_Care.Controller;

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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            nama = new Label();
            kucing = new Label();
            Layanan = new Label();
            Pendapatan = new Label();
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
            nama.Click += nama_Click;
            // 
            // kucing
            // 
            kucing.BackColor = Color.Transparent;
            kucing.Font = new Font("Montserrat", 16F);
            kucing.ForeColor = Color.FromArgb(255, 255, 255);
            kucing.Location = new Point(78, 306);
            kucing.Name = "kucing";
            kucing.Size = new Size(190, 30);
            kucing.TabIndex = 1;
            // 
            // Layanan
            // 
            Layanan.BackColor = Color.Transparent;
            Layanan.Font = new Font("Montserrat", 16F);
            Layanan.ForeColor = Color.FromArgb(255, 255, 255);
            Layanan.Location = new Point(387, 306);
            Layanan.Name = "Layanan";
            Layanan.Size = new Size(219, 30);
            Layanan.TabIndex = 2;
            // 
            // Pendapatan
            // 
            Pendapatan.BackColor = Color.Transparent;
            Pendapatan.Font = new Font("Montserrat", 16F);
            Pendapatan.ForeColor = Color.FromArgb(255, 255, 255);
            Pendapatan.Location = new Point(698, 306);
            Pendapatan.Name = "Pendapatan";
            Pendapatan.Size = new Size(242, 30);
            Pendapatan.TabIndex = 3;
            // 
            // TabelTransaksi
            // 
            TabelTransaksi.AllowUserToAddRows = false;
            TabelTransaksi.AllowUserToDeleteRows = false;
            TabelTransaksi.AllowUserToResizeColumns = false;
            TabelTransaksi.AllowUserToResizeRows = false;
            TabelTransaksi.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            TabelTransaksi.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            TabelTransaksi.BackgroundColor = Color.FromArgb(253, 233, 218);
            TabelTransaksi.BorderStyle = BorderStyle.None;
            TabelTransaksi.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            TabelTransaksi.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(131, 94, 146);
            dataGridViewCellStyle1.Font = new Font("Montserrat", 9.749999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.Transparent;
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            TabelTransaksi.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            TabelTransaksi.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(253, 233, 218);
            dataGridViewCellStyle2.Font = new Font("Montserrat Medium", 9.749999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.Padding = new Padding(3);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(253, 233, 218);
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            TabelTransaksi.DefaultCellStyle = dataGridViewCellStyle2;
            TabelTransaksi.EnableHeadersVisualStyles = false;
            TabelTransaksi.GridColor = Color.FromArgb(202, 185, 174);
            TabelTransaksi.Location = new Point(69, 472);
            TabelTransaksi.Name = "TabelTransaksi";
            TabelTransaksi.ReadOnly = true;
            TabelTransaksi.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            TabelTransaksi.RowHeadersVisible = false;
            TabelTransaksi.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            TabelTransaksi.ScrollBars = ScrollBars.Vertical;
            TabelTransaksi.SelectionMode = DataGridViewSelectionMode.CellSelect;
            TabelTransaksi.Size = new Size(871, 174);
            TabelTransaksi.TabIndex = 4;
            TabelTransaksi.CellContentClick += TabelTransaksi_CellContentClick;
            // 
            // V_Dashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Dashboard1;
            BackgroundImageLayout = ImageLayout.Stretch;
            Controls.Add(TabelTransaksi);
            Controls.Add(Pendapatan);
            Controls.Add(Layanan);
            Controls.Add(kucing);
            Controls.Add(nama);
            DoubleBuffered = true;
            Name = "V_Dashboard";
            Size = new Size(1000, 720);
            Load += V_Dashboard_Load;
            ((System.ComponentModel.ISupportInitialize)TabelTransaksi).EndInit();
            ResumeLayout(false);
        }

        #endregion

        public Label nama;
        public DataGridView TabelTransaksi;
        public Label kucing;
        public Label Layanan;
        public Label Pendapatan;
    }
}
