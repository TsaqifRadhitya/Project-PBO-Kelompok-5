using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;
using Pet_Care.View;
using Pet_Care.Model;

namespace Pet_Care.Controller
{
    public class C_Kamera : C_Message_Box
    {
        V_Kamera view;
        FilterInfoCollection captureDevice = new FilterInfoCollection(FilterCategory.VideoInputDevice);
        VideoCaptureDevice videoSource;
        public byte[]? foto;
        Data_Transaksi data;

        public C_Kamera()
        {
            List<string> data_kamera = new List<string>();
            if (captureDevice.Count<0)
            {
                show_message_box("Camera Tidak Terdeteksi");
                return;
            }
            foreach (FilterInfo category in captureDevice) 
            {
                data_kamera.Add(category.Name);
            }
            view = new V_Kamera(this,data_kamera);
            view.ShowDialog();

        }
        public void swicth_camera(int index)
        {
            stop();
            start(index);
        }
        public void start(int index)
        {
            videoSource = new VideoCaptureDevice(captureDevice[index].MonikerString);
            videoSource.NewFrame += new NewFrameEventHandler(view.VideoSource_NewFrame);
            videoSource.Start();
        }
        public void stop()
        { 
            videoSource.SignalToStop();
            videoSource.WaitForStop();
        }
    }
}
