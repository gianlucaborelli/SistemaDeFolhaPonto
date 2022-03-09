using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using AForge;
using AForge.Imaging;
using AForge.Video;
using AForge.Video.DirectShow;
using System.Drawing.Imaging;

namespace SistemaFaltas.Recursos.CapturaDeImagens
{
    public partial class FormCapturaDeImagem : Form
    {
        private VideoCaptureDevice videoSource;

        public Bitmap image;

        

        public FormCapturaDeImagem()
        {
            InitializeComponent();
            
            //videoSource.Start();
        }
        //Cria evento de arrastar o formulário principal

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        
        private void BarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void VideoSource_NewFrame(object sender, AForge.Video.NewFrameEventArgs eventArgs)
        {
            if (pbWebCam.Image != null)
                pbWebCam.Image.Dispose();
            pbWebCam.Image = (Bitmap)eventArgs.Frame.Clone();
        }

        private void pbClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormCapturaDeImagem_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (videoSource != null && videoSource.IsRunning)
            {
                videoSource.SignalToStop();
                videoSource.WaitForStop();
                videoSource = null;
            }
        }

        private void btnCapturar_Click(object sender, EventArgs e)
        {
            using (Bitmap bmp = new Bitmap(pbWebCam.Image))
            {
                int x = (bmp.Width - pbCaptura.Width) /2;
                int y = (bmp.Height - pbCaptura.Height) / 2;
                var newImg = bmp.Clone(
                    new Rectangle { X = x , Y = y, Width = pbCaptura.Width , Height = pbCaptura.Height },
                    bmp.PixelFormat);
                pbCaptura.Image = newImg;
                image = new Bitmap(pbCaptura.Image);
            }          
            
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (pbCaptura.Image != null)
            {
                DialogResult = DialogResult.OK;                                             
            }
        }

        private void FormCapturaDeImagem_Load(object sender, EventArgs e)
        {
            
        }

        private void FormCapturaDeImagem_Shown(object sender, EventArgs e)
        {
            var videoSources = new FilterInfoCollection(FilterCategory.VideoInputDevice);

            if (videoSources != null && videoSources.Count > 0)
            {
                videoSource = new VideoCaptureDevice(videoSources[0].MonikerString);
                videoSource.NewFrame += VideoSource_NewFrame;
            }
            if (!videoSource.IsRunning)
            {
                
                videoSource.Start();
            }

        }
    }
}
