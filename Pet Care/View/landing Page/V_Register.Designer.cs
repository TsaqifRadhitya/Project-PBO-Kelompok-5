namespace Pet_Care.View
{
    partial class V_Register
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
            Button_Register = new Button();
            Login = new Label();
            label1 = new Label();
            Username = new TextBox();
            Nama_Lengkap = new TextBox();
            Nomor_HP = new TextBox();
            Email = new TextBox();
            Password = new TextBox();
            Konfirmasi_Password = new TextBox();
            show_hide_password_1 = new Button();
            show_hide_password_2 = new Button();
            SuspendLayout();
            // 
            // Button_Register
            // 
            Button_Register.BackgroundImage = Properties.Resources.Register_Button;
            Button_Register.BackgroundImageLayout = ImageLayout.Stretch;
            Button_Register.Cursor = Cursors.Hand;
            Button_Register.FlatAppearance.BorderSize = 0;
            Button_Register.FlatAppearance.MouseDownBackColor = Color.Transparent;
            Button_Register.FlatAppearance.MouseOverBackColor = Color.Transparent;
            Button_Register.FlatStyle = FlatStyle.Flat;
            Button_Register.Location = new Point(123, 509);
            Button_Register.Name = "Button_Register";
            Button_Register.Size = new Size(212, 58);
            Button_Register.TabIndex = 0;
            Button_Register.UseVisualStyleBackColor = true;
            Button_Register.Click += Button_Register_Click;
            Button_Register.MouseEnter += Button_Register_MouseEnter;
            Button_Register.MouseLeave += Button_Register_MouseLeave;
            // 
            // Login
            // 
            Login.AutoSize = true;
            Login.Cursor = Cursors.Hand;
            Login.Font = new Font("Montserrat SemiBold", 12F, FontStyle.Bold);
            Login.ForeColor = Color.FromArgb(131, 94, 146);
            Login.Location = new Point(285, 576);
            Login.Name = "Login";
            Login.Size = new Size(57, 22);
            Login.TabIndex = 6;
            Login.Text = "Login";
            Login.Click += Login_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Montserrat SemiBold", 12F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(251, 213, 197);
            label1.Location = new Point(114, 576);
            label1.Name = "label1";
            label1.Size = new Size(176, 22);
            label1.TabIndex = 5;
            label1.Text = "Sudah Punya Akun?";
            // 
            // Username
            // 
            Username.BackColor = Color.FromArgb(240, 193, 174);
            Username.BorderStyle = BorderStyle.None;
            Username.Font = new Font("Montserrat SemiBold", 16F, FontStyle.Bold);
            Username.ForeColor = Color.FromArgb(176, 142, 128);
            Username.Location = new Point(66, 96);
            Username.Name = "Username";
            Username.Size = new Size(323, 27);
            Username.TabIndex = 7;
            Username.Text = "Username";
            Username.Enter += Username_Enter;
            Username.Leave += Username_Leave;
            // 
            // Nama_Lengkap
            // 
            Nama_Lengkap.BackColor = Color.FromArgb(240, 193, 174);
            Nama_Lengkap.BorderStyle = BorderStyle.None;
            Nama_Lengkap.Font = new Font("Montserrat SemiBold", 16F, FontStyle.Bold);
            Nama_Lengkap.ForeColor = Color.FromArgb(176, 142, 128);
            Nama_Lengkap.Location = new Point(66, 166);
            Nama_Lengkap.Name = "Nama_Lengkap";
            Nama_Lengkap.Size = new Size(323, 27);
            Nama_Lengkap.TabIndex = 8;
            Nama_Lengkap.Text = "Nama Lengkap";
            Nama_Lengkap.Enter += Nama_Lengkap_Enter;
            Nama_Lengkap.Leave += Nama_Lengkap_Leave;
            // 
            // Nomor_HP
            // 
            Nomor_HP.BackColor = Color.FromArgb(240, 193, 174);
            Nomor_HP.BorderStyle = BorderStyle.None;
            Nomor_HP.Font = new Font("Montserrat SemiBold", 16F, FontStyle.Bold);
            Nomor_HP.ForeColor = Color.FromArgb(176, 142, 128);
            Nomor_HP.Location = new Point(66, 236);
            Nomor_HP.MaxLength = 13;
            Nomor_HP.Name = "Nomor_HP";
            Nomor_HP.Size = new Size(323, 27);
            Nomor_HP.TabIndex = 9;
            Nomor_HP.Text = "Nomor Hp";
            Nomor_HP.TextChanged += Nomor_HP_TextChanged;
            Nomor_HP.Enter += Nomor_HP_Enter;
            Nomor_HP.Leave += Nomor_HP_Leave;
            // 
            // Email
            // 
            Email.BackColor = Color.FromArgb(240, 193, 174);
            Email.BorderStyle = BorderStyle.None;
            Email.Font = new Font("Montserrat SemiBold", 16F, FontStyle.Bold);
            Email.ForeColor = Color.FromArgb(176, 142, 128);
            Email.Location = new Point(66, 306);
            Email.Name = "Email";
            Email.Size = new Size(323, 27);
            Email.TabIndex = 10;
            Email.Text = "Email";
            Email.Enter += Email_Enter;
            Email.Leave += Email_Leave;
            // 
            // Password
            // 
            Password.BackColor = Color.FromArgb(240, 193, 174);
            Password.BorderStyle = BorderStyle.None;
            Password.Font = new Font("Montserrat SemiBold", 16F, FontStyle.Bold);
            Password.ForeColor = Color.FromArgb(176, 142, 128);
            Password.Location = new Point(66, 376);
            Password.Name = "Password";
            Password.Size = new Size(276, 27);
            Password.TabIndex = 11;
            Password.Text = "Password";
            Password.Enter += Password_Enter;
            Password.Leave += Password_Leave;
            // 
            // Konfirmasi_Password
            // 
            Konfirmasi_Password.BackColor = Color.FromArgb(240, 193, 174);
            Konfirmasi_Password.BorderStyle = BorderStyle.None;
            Konfirmasi_Password.Font = new Font("Montserrat SemiBold", 16F, FontStyle.Bold);
            Konfirmasi_Password.ForeColor = Color.FromArgb(176, 142, 128);
            Konfirmasi_Password.Location = new Point(66, 446);
            Konfirmasi_Password.Name = "Konfirmasi_Password";
            Konfirmasi_Password.Size = new Size(282, 27);
            Konfirmasi_Password.TabIndex = 12;
            Konfirmasi_Password.Text = "Konfirmasi Password";
            Konfirmasi_Password.Enter += Konfirmasi_Password_Enter;
            Konfirmasi_Password.Leave += Konfirmasi_Password_Leave;
            // 
            // show_hide_password_1
            // 
            show_hide_password_1.BackgroundImage = Properties.Resources.Hide_Password_;
            show_hide_password_1.BackgroundImageLayout = ImageLayout.Stretch;
            show_hide_password_1.Cursor = Cursors.Hand;
            show_hide_password_1.FlatAppearance.BorderSize = 0;
            show_hide_password_1.FlatAppearance.MouseDownBackColor = Color.Transparent;
            show_hide_password_1.FlatAppearance.MouseOverBackColor = Color.Transparent;
            show_hide_password_1.FlatStyle = FlatStyle.Flat;
            show_hide_password_1.Location = new Point(354, 374);
            show_hide_password_1.Name = "show_hide_password_1";
            show_hide_password_1.Size = new Size(35, 35);
            show_hide_password_1.TabIndex = 13;
            show_hide_password_1.UseVisualStyleBackColor = true;
            show_hide_password_1.Click += show_hide_password_Click;
            // 
            // show_hide_password_2
            // 
            show_hide_password_2.BackgroundImage = Properties.Resources.Hide_Password_;
            show_hide_password_2.BackgroundImageLayout = ImageLayout.Stretch;
            show_hide_password_2.Cursor = Cursors.Hand;
            show_hide_password_2.FlatAppearance.BorderSize = 0;
            show_hide_password_2.FlatAppearance.MouseDownBackColor = Color.Transparent;
            show_hide_password_2.FlatAppearance.MouseOverBackColor = Color.Transparent;
            show_hide_password_2.FlatStyle = FlatStyle.Flat;
            show_hide_password_2.Location = new Point(354, 445);
            show_hide_password_2.Name = "show_hide_password_2";
            show_hide_password_2.Size = new Size(35, 35);
            show_hide_password_2.TabIndex = 14;
            show_hide_password_2.UseVisualStyleBackColor = true;
            show_hide_password_2.Click += show_hide_password_2_Click;
            // 
            // V_Register
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            BackgroundImage = Properties.Resources.Register;
            BackgroundImageLayout = ImageLayout.Stretch;
            Controls.Add(show_hide_password_2);
            Controls.Add(show_hide_password_1);
            Controls.Add(Konfirmasi_Password);
            Controls.Add(Password);
            Controls.Add(Email);
            Controls.Add(Nomor_HP);
            Controls.Add(Nama_Lengkap);
            Controls.Add(Username);
            Controls.Add(Login);
            Controls.Add(label1);
            Controls.Add(Button_Register);
            DoubleBuffered = true;
            Name = "V_Register";
            Size = new Size(454, 634);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Button_Register;
        private Label Login;
        private Label label1;
        public TextBox Username;
        public TextBox Nama_Lengkap;
        public TextBox Nomor_HP;
        public TextBox Email;
        public TextBox Password;
        public TextBox Konfirmasi_Password;
        private Button show_hide_password_1;
        private Button show_hide_password_2;
    }
}
