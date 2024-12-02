using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;
using Pet_Care.Contoller;

namespace Pet_Care.View
{
    public partial class V_Kamera : Form
    {
        C_Kamera controller;
        List<string> source;
        public V_Kamera(C_Kamera controller, List<string> source)
        {
            InitializeComponent();
            this.controller = controller;
            this.source = source;
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
            this.controller.start(0);
            comboBox1.DataSource = source;
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

        public void VideoSource_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            Bitmap foto = (Bitmap)eventArgs.Frame.Clone();
            //foto.RotateFlip(RotateFlipType.RotateNoneFlipX);
            frame_foto.Image = foto;
        }

        private void frame_foto_Paint(object sender, PaintEventArgs e)
        {
            if (!(Shutter.Enabled) && frame_foto.Image != null) Shutter.Enabled = true;
            if (Shutter.Enabled && frame_foto.Image == null) Shutter.Enabled = false;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            frame_foto.Image = null;
            controller.swicth_camera(comboBox1.SelectedIndex);
        }
    }
}
