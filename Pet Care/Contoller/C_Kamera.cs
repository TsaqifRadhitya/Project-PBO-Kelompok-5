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

namespace Pet_Care.Contoller
{
    public class C_Kamera
    {
        V_Kamera view;
        FilterInfoCollection captureDevice;
        VideoCaptureDevice videoSource;
        public byte[]? foto;
        Data_Transaksi data;

        public C_Kamera()
        {
            view = new V_Kamera(this);

            view.ShowDialog();

        }

        public void start()
        {
            captureDevice = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            videoSource = new VideoCaptureDevice();
            videoSource = new VideoCaptureDevice(captureDevice[0].MonikerString);
            videoSource.NewFrame += new NewFrameEventHandler(view.VideoSource_NewFrame);
            videoSource.Start();
        }
        public void stop()
        { 
            videoSource.SignalToStop();
            videoSource.WaitForStop();
        }
        public void send(byte[]foto,string kegiatan)
        {
            string username = "@meowInnNews";
            string message = $"[BROADCAST HARIAN KUCING MEOWINN]\nNama Kucing : {data.Nama_Kucing}\nKegiatan : {kegiatan}";
            string token = "7601026397:AAFZD3wLc28O527pAiOqdQiJKs6lL4xO83A";
            HttpClient client = new HttpClient();
            MultipartFormDataContent formData = new MultipartFormDataContent();
            ByteArrayContent fileContent = new ByteArrayContent(foto);
            formData.Add(fileContent, "photo", "foto");
            formData.Add(new StringContent($"{username}"), "chat_id");
            formData.Add(new StringContent(message), "caption");
            client.PostAsync($"https://api.telegram.org/bot{token}/sendPhoto",formData);
        }
    }
}
