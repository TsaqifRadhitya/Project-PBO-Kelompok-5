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
            SuspendLayout();
            // 
            // Button_Register
            // 
            Button_Register.BackgroundImageLayout = ImageLayout.Stretch;
            Button_Register.FlatAppearance.BorderSize = 0;
            Button_Register.FlatAppearance.MouseDownBackColor = Color.Transparent;
            Button_Register.FlatAppearance.MouseOverBackColor = Color.Transparent;
            Button_Register.FlatStyle = FlatStyle.Flat;
            Button_Register.BackgroundImage = Properties.Resources.Register_Button;
            Button_Register.Location = new Point(123, 505);
            Button_Register.Name = "Button_Register";
            Button_Register.Size = new Size(212, 58);
            Button_Register.TabIndex = 0;
            Button_Register.UseVisualStyleBackColor = true;
            Button_Register.Click += Button_Register_Click;
            Button_Register.MouseEnter += Button_Register_MouseEnter;
            Button_Register.MouseLeave += Button_Register_MouseLeave;
            Button_Register.MouseHover += Button_Register_MouseHover;
            // 
            // Login
            // 
            Login.AutoSize = true;
            Login.Font = new Font("Montserrat SemiBold", 14F, FontStyle.Bold);
            Login.ForeColor = Color.FromArgb(131, 94, 146);
            Login.Location = new Point(298, 576);
            Login.Name = "Login";
            Login.Size = new Size(66, 26);
            Login.TabIndex = 6;
            Login.Text = "Login";
            Login.Click += Login_Click;
            Login.MouseHover += Login_MouseHover;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Montserrat SemiBold", 14F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(251, 213, 197);
            label1.Location = new Point(94, 576);
            label1.Name = "label1";
            label1.Size = new Size(210, 26);
            label1.TabIndex = 5;
            label1.Text = "Sudah Punya Akun?";
            // 
            // V_Register
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            BackgroundImage = Properties.Resources.Register;
            BackgroundImageLayout = ImageLayout.Stretch;
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
    }
}
