using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.Structure;

namespace Procesamiento
{
    public partial class VideoForm : Form

    {
        private bool isRendering = false;
        private VideoCapture videoCapture;
        private int actualFrame = 0;
        private int filterNumber;
        private double framesQuantity = 0;
        private double fps = 0;


        private String[] filterName = { "Normal", "Grayscale", "Sepia", "Negative", "Blur", "Black and White", "Mirror", "Noise" };

        Image<Bgr, byte> filter = null;
        Mat matrix = new Mat();


        public VideoForm()
        {
            InitializeComponent();
            loadFilters();
        }

        private void btnAddVideo_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyVideos); // El path default lo defino como el escritorio
            openFile.Title = "Selecciona un video"; // El título de mi ventana
            openFile.Filter = "All Media Files (*.mp4)|*.mp4|All files (*.*)|*.*"; // De esta forma solo se pueden seleccionar videos y gifs

            if (isRendering || videoCapture != null)
            {
                isRendering = false;
                videoCapture = null;
                actualFrame = 0;
            }

            if (openFile.ShowDialog() == DialogResult.OK)
            {
                videoCapture = new VideoCapture(openFile.FileName);
                Mat m = new Mat();
                videoCapture.Read(m);
                pbVideo.Image = m.Bitmap;

                framesQuantity = videoCapture.GetCaptureProperty(Emgu.CV.CvEnum.CapProp.FrameCount);
                fps = videoCapture.GetCaptureProperty(Emgu.CV.CvEnum.CapProp.Fps);
            }


        }

        private async void ReadAllFrames()
        {
            actualFrame = 0;
            
            while (isRendering && actualFrame < framesQuantity)
            {
                actualFrame += 1;
                videoCapture.SetCaptureProperty(Emgu.CV.CvEnum.CapProp.PosFrames, actualFrame);
                videoCapture.Read(matrix);

                if (matrix.Bitmap != null)
                {
                    switch (cbFilters.SelectedIndex)
                    {

                        case 0:
                            filter = new Image<Bgr, byte>(matrix.Bitmap);
                            break;

                        case 1:
                            filter = new Image<Bgr, byte>(Filters.grayFilter(matrix.Bitmap));
                            break;

                        case 2:
                            filter = new Image<Bgr, byte>(Filters.sepiaFilter(matrix.Bitmap));
                            break;

                        case 3:
                            filter = new Image<Bgr, byte>(Filters.negativeFilter(matrix.Bitmap));
                            break;

                        case 4:
                            filter = new Image<Bgr, byte>(Filters.blurFilter(matrix.Bitmap, 1));
                            break;

                        case 5:
                            filter = new Image<Bgr, byte>(Filters.blackAndWhiteFilter(matrix.Bitmap));
                            break;

                        case 6:
                            filter = new Image<Bgr, byte>(Filters.mirrorFilter(matrix.Bitmap));
                            break;

                        case 7:
                            filter = new Image<Bgr, byte>(Filters.noiseFilter(matrix.Bitmap));
                            break;

                    }
                    pbVideo.Image = filter.ToBitmap();
                    await Task.Delay(1000 / Convert.ToInt32(fps));
                }

            }
                
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            isRendering = true;
            ReadAllFrames();
        }

        private void loadFilters()
        {
            for (int i = 0; i < filterName.Length; i++) // Ciclo para guardar todos mis filtros en el combobox
                cbFilters.Items.Add(filterName[i]); // Agrega la lista de filtros a mi combobox

            cbFilters.SelectedIndex = 0; // selecciono el index como 0
        }



        private void cbFilters_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pbVideo_Click(object sender, EventArgs e)
        {

        }

        private void btnScreenShot_Click(object sender, EventArgs e)
        {
            //GUARDAR VIDEO

            Bitmap video = new Bitmap(pbVideo.Image);

            SaveFileDialog GuardarImg = new SaveFileDialog();
            GuardarImg.Filter = "JPG(.JPG)|.jpg";


            if (GuardarImg.ShowDialog() == DialogResult.OK)
            {
                video.Save(GuardarImg.FileName);
            }
        }

    }
}
