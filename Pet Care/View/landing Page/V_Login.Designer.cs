﻿namespace Pet_Care.View
{
    partial class V_Login
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
            LoginButton = new Button();
            Username_Email = new TextBox();
            Password = new TextBox();
            label1 = new Label();
            Register = new Label();
            show_hide_password = new Button();
            SuspendLayout();
            // 
            // LoginButton
            // 
            LoginButton.BackColor = Color.Transparent;
            LoginButton.BackgroundImage = Properties.Resources.Login_Button;
            LoginButton.BackgroundImageLayout = ImageLayout.Stretch;
            LoginButton.CausesValidation = false;
            LoginButton.Cursor = Cursors.Hand;
            LoginButton.FlatAppearance.BorderSize = 0;
            LoginButton.FlatAppearance.MouseDownBackColor = Color.Transparent;
            LoginButton.FlatAppearance.MouseOverBackColor = Color.Transparent;
            LoginButton.FlatStyle = FlatStyle.Flat;
            LoginButton.Location = new Point(123, 306);
            LoginButton.Name = "LoginButton";
            LoginButton.Size = new Size(212, 58);
            LoginButton.TabIndex = 0;
            LoginButton.UseVisualStyleBackColor = false;
            LoginButton.Click += button1_Click;
            LoginButton.MouseEnter += LoginButton_MouseEnter;
            LoginButton.MouseLeave += LoginButton_MouseLeave;
            // 
            // Username_Email
            // 
            Username_Email.BackColor = Color.FromArgb(240, 193, 174);
            Username_Email.BorderStyle = BorderStyle.None;
            Username_Email.Font = new Font("Montserrat SemiBold", 16F, FontStyle.Bold);
            Username_Email.ForeColor = Color.White;
            Username_Email.Location = new Point(71, 176);
            Username_Email.Name = "Username_Email";
            Username_Email.PlaceholderText = "Username/Email";
            Username_Email.Size = new Size(323, 27);
            Username_Email.TabIndex = 1;
            // 
            // Password
            // 
            Password.BackColor = Color.FromArgb(240, 193, 174);
            Password.BorderStyle = BorderStyle.None;
            Password.Font = new Font("Montserrat SemiBold", 16F, FontStyle.Bold);
            Password.ForeColor = Color.White;
            Password.Location = new Point(71, 245);
            Password.Name = "Password";
            Password.PasswordChar = '●';
            Password.PlaceholderText = "Password";
            Password.Size = new Size(276, 27);
            Password.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Montserrat SemiBold", 12F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(251, 213, 197);
            label1.Location = new Point(100, 372);
            label1.Name = "label1";
            label1.Size = new Size(178, 22);
            label1.TabIndex = 3;
            label1.Text = "Belum Punya Akun?";
            // 
            // Register
            // 
            Register.AutoSize = true;
            Register.Cursor = Cursors.Hand;
            Register.Font = new Font("Montserrat SemiBold", 12F, FontStyle.Bold);
            Register.ForeColor = Color.FromArgb(131, 94, 146);
            Register.Location = new Point(272, 372);
            Register.Name = "Register";
            Register.Size = new Size(80, 22);
            Register.TabIndex = 4;
            Register.Text = "Register";
            Register.Click += Register_Click;
            // 
            // show_hide_password
            // 
            show_hide_password.BackgroundImage = Properties.Resources.Hide_Password_;
            show_hide_password.BackgroundImageLayout = ImageLayout.Stretch;
            show_hide_password.Cursor = Cursors.Hand;
            show_hide_password.FlatAppearance.BorderSize = 0;
            show_hide_password.FlatAppearance.MouseDownBackColor = Color.Transparent;
            show_hide_password.FlatAppearance.MouseOverBackColor = Color.Transparent;
            show_hide_password.FlatStyle = FlatStyle.Flat;
            show_hide_password.Location = new Point(353, 242);
            show_hide_password.Name = "show_hide_password";
            show_hide_password.Size = new Size(35, 35);
            show_hide_password.TabIndex = 5;
            show_hide_password.UseVisualStyleBackColor = true;
            show_hide_password.Click += show_hide_password_Click;
            // 
            // V_Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            BackgroundImage = Properties.Resources.Login1;
            BackgroundImageLayout = ImageLayout.Stretch;
            Controls.Add(show_hide_password);
            Controls.Add(Register);
            Controls.Add(label1);
            Controls.Add(Password);
            Controls.Add(Username_Email);
            Controls.Add(LoginButton);
            DoubleBuffered = true;
            Margin = new Padding(0);
            Name = "V_Login";
            Size = new Size(454, 430);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button LoginButton;
        private Label label1;
        private Label Register;
        public TextBox Username_Email;
        public TextBox Password;
        private Button show_hide_password;
    }
}
