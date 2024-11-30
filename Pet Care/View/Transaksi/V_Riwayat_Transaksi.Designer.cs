namespace Pet_Care.View
{
    partial class V_Riwayat_Transaksi
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
            Tabel_Riwayat = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)Tabel_Riwayat).BeginInit();
            SuspendLayout();
            // 
            // Tabel_Riwayat
            // 
            Tabel_Riwayat.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            Tabel_Riwayat.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            Tabel_Riwayat.BackgroundColor = Color.FromArgb(131, 94, 146);
            Tabel_Riwayat.BorderStyle = BorderStyle.None;
            Tabel_Riwayat.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Tabel_Riwayat.GridColor = Color.White;
            Tabel_Riwayat.Location = new Point(10, 3);
            Tabel_Riwayat.Name = "Tabel_Riwayat";
            Tabel_Riwayat.ReadOnly = true;
            Tabel_Riwayat.RowHeadersVisible = false;
            Tabel_Riwayat.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            Tabel_Riwayat.ScrollBars = ScrollBars.Vertical;
            Tabel_Riwayat.Size = new Size(830, 516);
            Tabel_Riwayat.TabIndex = 0;
            Tabel_Riwayat.CellContentClick += dataGridView1_CellContentClick;
            // 
            // V_Riwayat_Transaksi
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            BackgroundImage = Properties.Resources.BG_Selesai;
            BackgroundImageLayout = ImageLayout.Stretch;
            Controls.Add(Tabel_Riwayat);
            DoubleBuffered = true;
            Name = "V_Riwayat_Transaksi";
            Size = new Size(850, 521);
            Load += V_Riwayat_Transaksi_Load;
            ((System.ComponentModel.ISupportInitialize)Tabel_Riwayat).EndInit();
            ResumeLayout(false);
        }

        #endregion

        public DataGridView Tabel_Riwayat;
    }
}
