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

namespace ProjetoLojaABC
{
    public partial class frmWebCam : Form
    {
        private bool DeviceExist = false;
        private FilterInfoCollection videoDevices;
        private VideoCaptureDevice videoSouce = null;

        public frmWebCam()
        {
            InitializeComponent();
        }

        public void video_NewFrame(Object sender, NewFrameEventArgs eventArgs)
        {
            Bitmap img = (Bitmap)eventArgs.Frame.Clone();
            pctCaptura.Image = img;
        }

        private void frmWebCam_Load(object sender, EventArgs e)
        {
            try
            {
                videoDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);//filtrando o drive 
                cbbDispositivos.Items.Clear();
                if (videoDevices.Count == 0)
                {
                    throw new ApplicationException();
                }

                DeviceExist = true;
                foreach (FilterInfo device in videoDevices)
                {
                    cbbDispositivos.Items.Add(device.Name);
                }
                cbbDispositivos.SelectedIndex = 0;
            }
            catch (ApplicationException)
            {
                DeviceExist = false;
                cbbDispositivos.Items.Add("Nenhum dispositivo encontrado!");
            }


        }

        private void btnCapturar_Click(object sender, EventArgs e)
        {
            if (btnCapturar.Text == "Capturar")
            {
                if (DeviceExist)
                {
                    videoSouce = new VideoCaptureDevice(videoDevices[cbbDispositivos.SelectedIndex].MonikerString);
                    videoSouce.NewFrame += new NewFrameEventHandler(video_NewFrame);

                    if (!(videoSouce == null))
                    {
                        if (videoSouce.IsRunning)
                        {
                            videoSouce.SignalToStop();
                            videoSouce = null;
                        }

                        videoSouce.DesiredSnapshotSize = new Size(160, 160);
                        videoSouce.DesiredFrameRate = 10;
                        videoSouce.Start();

                        btnCapturar.Text = "Gravar";

                    }
                }
                else
                {
                    MessageBox.Show("Nenhum despositivo encontrado!");
                }
            }
            else
            {
                if (!(videoSouce == null))
                {
                    if (videoSouce.IsRunning)
                    {
                        videoSouce.SignalToStop();
                        videoSouce = null;

                        sfdSalvarImagem.Filter = "JPEG (*.jpg;*.jpeg;*.jpeg|*.jpg;*.jpeg;*.jpeg;*.jfif)";
                        DialogResult res = sfdSalvarImagem.ShowDialog();
                        if (res == DialogResult.OK)
                        {
                            pctCaptura.Image.Save(sfdSalvarImagem.FileName, System.Drawing.Imaging.ImageFormat.Jpeg);
                        }
                    }

                }
            }
        }

        private void btnAbrir_Click(object sender, EventArgs e)
        {
            OpenFileDialog BuscarIMG = new OpenFileDialog();
            BuscarIMG.InitialDirectory = ("C:\\imagens\\");
            BuscarIMG.FileName = "Imagem";
            BuscarIMG.Title = "Procurar Imagem";
            BuscarIMG.Filter = ("*jpg|*.jpg|*png|*.png|*bmp|.bmp|*tif|*.tif");
            BuscarIMG.ShowDialog();
            pctCaptura.ImageLocation = (BuscarIMG.FileName);
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            pctCaptura.Image = null;
        }
    }
}
