namespace Pet_Care.View
{
    partial class V_Custom_Message_Box
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(V_Custom_Message_Box));
            Message = new Label();
            Okey = new Button();
            SuspendLayout();
            // 
            // Message
            // 
            Message.BackColor = Color.Transparent;
            Message.Font = new Font("Montserrat SemiBold", 18F, FontStyle.Bold);
            Message.Location = new Point(12, 88);
            Message.Name = "Message";
            Message.Size = new Size(476, 66);
            Message.TabIndex = 4;
            Message.Text = "Message";
            Message.TextAlign = ContentAlignment.TopCenter;
            Message.UseCompatibleTextRendering = true;
            // 
            // Okey
            // 
            Okey.BackColor = Color.Transparent;
            Okey.BackgroundImage = Properties.Resources.Button;
            Okey.BackgroundImageLayout = ImageLayout.Stretch;
            Okey.FlatAppearance.BorderSize = 0;
            Okey.FlatAppearance.MouseDownBackColor = Color.Transparent;
            Okey.FlatAppearance.MouseOverBackColor = Color.Transparent;
            Okey.FlatStyle = FlatStyle.Flat;
            Okey.Location = new Point(175, 183);
            Okey.Name = "Okey";
            Okey.Size = new Size(150, 51);
            Okey.TabIndex = 3;
            Okey.UseVisualStyleBackColor = false;
            Okey.Click += Okey_Click;
            Okey.MouseEnter += Okey_MouseEnter;
            Okey.MouseLeave += Okey_MouseLeave;
            Okey.MouseHover += Okey_MouseHover;
            // 
            // V_Custom_Message_Box
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Frame;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(500, 263);
            Controls.Add(Message);
            Controls.Add(Okey);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "V_Custom_Message_Box";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MeowInn";
            ResumeLayout(false);
        }

        #endregion

        private Label Message;
        private Button Okey;
    }
}