namespace Pet_Care.View
{
    partial class V_Pelanggan
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
            SearchBar = new TextBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            panel1 = new Panel();
            id = new Label();
            label1 = new Label();
            Nomor_Hp = new Label();
            Nama = new Label();
            button1 = new Button();
            button2 = new Button();
            flowLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // SearchBar
            // 
            SearchBar.BackColor = Color.White;
            SearchBar.BorderStyle = BorderStyle.None;
            SearchBar.Font = new Font("Montserrat SemiBold", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SearchBar.ForeColor = Color.FromArgb(210, 218, 221);
            SearchBar.Location = new Point(570, 112);
            SearchBar.Name = "SearchBar";
            SearchBar.Size = new Size(357, 25);
            SearchBar.TabIndex = 0;
            SearchBar.Text = "Search";
            SearchBar.TextChanged += SearchBar_TextChanged;
            SearchBar.Enter += SearchBar_Enter;
            SearchBar.Leave += SearchBar_Leave;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.BackColor = Color.Transparent;
            flowLayoutPanel1.Controls.Add(panel1);
            flowLayoutPanel1.Location = new Point(15, 166);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(985, 554);
            flowLayoutPanel1.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.BackgroundImage = Properties.Resources.Red_card;
            panel1.Controls.Add(button2);
            panel1.Controls.Add(id);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(Nomor_Hp);
            panel1.Controls.Add(Nama);
            panel1.Location = new Point(26, 26);
            panel1.Margin = new Padding(26);
            panel1.Name = "panel1";
            panel1.Size = new Size(188, 260);
            panel1.TabIndex = 0;
            // 
            // id
            // 
            id.Font = new Font("Montserrat", 11F);
            id.Location = new Point(14, 161);
            id.Margin = new Padding(0);
            id.Name = "id";
            id.Size = new Size(158, 22);
            id.TabIndex = 3;
            id.Text = "#1";
            id.TextAlign = ContentAlignment.TopCenter;
            // 
            // label1
            // 
            label1.Font = new Font("Montserrat", 11F);
            label1.Location = new Point(14, 211);
            label1.Margin = new Padding(0);
            label1.Name = "label1";
            label1.Size = new Size(158, 22);
            label1.TabIndex = 2;
            label1.Text = "Jl.Manggar No.127";
            // 
            // Nomor_Hp
            // 
            Nomor_Hp.Font = new Font("Montserrat", 11F);
            Nomor_Hp.Location = new Point(14, 186);
            Nomor_Hp.Margin = new Padding(0);
            Nomor_Hp.Name = "Nomor_Hp";
            Nomor_Hp.Size = new Size(158, 22);
            Nomor_Hp.TabIndex = 1;
            Nomor_Hp.Text = "085156360779";
            // 
            // Nama
            // 
            Nama.Font = new Font("Montserrat SemiBold", 18F, FontStyle.Bold);
            Nama.Location = new Point(0, 128);
            Nama.Margin = new Padding(0);
            Nama.Name = "Nama";
            Nama.Size = new Size(188, 38);
            Nama.TabIndex = 0;
            Nama.Text = "Tsaqif";
            Nama.TextAlign = ContentAlignment.TopCenter;
            // 
            // button1
            // 
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button1.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(15, 15);
            button1.Name = "button1";
            button1.Size = new Size(14, 18);
            button1.TabIndex = 1;
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button2.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Location = new Point(153, 15);
            button2.Name = "button2";
            button2.Size = new Size(20, 20);
            button2.TabIndex = 4;
            button2.UseVisualStyleBackColor = true;
            // 
            // V_Pelanggan
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Pelanggan1;
            Controls.Add(flowLayoutPanel1);
            Controls.Add(SearchBar);
            Name = "V_Pelanggan";
            Size = new Size(1000, 720);
            Load += V_Pelanggan_Load;
            flowLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox SearchBar;
        private Panel panel1;
        private Label Nomor_Hp;
        private Label Nama;
        private Label label1;
        public FlowLayoutPanel flowLayoutPanel1;
        private Label id;
        private Button button1;
        private Button button2;
    }
}
