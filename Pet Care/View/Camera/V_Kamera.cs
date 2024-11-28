using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Pet_Care.Contoller;

namespace Pet_Care.View
{
    public partial class V_Kamera : Form
    {
        C_Kamera controller;
        public V_Kamera(C_Kamera controller)
        {
            InitializeComponent();
            this.controller = controller;
            this.controller.start();
        }

        private void Shutter_Click(object sender, EventArgs e)
        {
            controller.stop();
            ImageConverter imageConverter = new ImageConverter();
            controller.foto = (byte[])(imageConverter.ConvertTo(frame_foto.Image, typeof(byte[])));
            this.Close();

        }

        private void Shutter_MouseHover(object sender, EventArgs e)
        {
            Shutter.Cursor = Cursors.Hand;
        }

        private void Shutter_MouseEnter(object sender, EventArgs e)
        {
            Shutter.BackgroundImage = Properties.Resources.Shutter_Hover;
        }

        private void Shutter_MouseLeave(object sender, EventArgs e)
        {
            Shutter.BackgroundImage = Properties.Resources.Shutter;
        }

        private void Kamera_Load(object sender, EventArgs e)
        {
            
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            controller.stop();
            this.Close();
        }

        private void Exit_MouseHover(object sender, EventArgs e)
        {
            Exit.Cursor = Cursors.Hand;
        }

        private void Exit_MouseLeave(object sender, EventArgs e)
        {
            Exit.BackgroundImage = Properties.Resources.Close_camera;
        }

        private void Exit_MouseEnter(object sender, EventArgs e)
        {
            Exit.BackgroundImage = Properties.Resources.Close_Camera_Hover;
        }
    }
}
