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
using Emgu.CV;
using Emgu.CV.Structure;

namespace Procesamiento
{
    public partial class DetectionForm : Form
    {
        private VideoCaptureDevice webcam = null;
        private FilterInfoCollection myWebcams;

        static readonly CascadeClassifier cascadeClassifier = new CascadeClassifier("haarcascade_frontalface_alt_tree.xml"); // Para reconocer el rostro
        public DetectionForm()
        {
            InitializeComponent();
            loadWebcams();
        }


        private void loadWebcams()
        {
            myWebcams = new FilterInfoCollection(FilterCategory.VideoInputDevice); // Cargo todos los dispositivos de video conectados a mi computadora

            if (myWebcams.Count > 0)
            {
                foreach (FilterInfo filterInfo in myWebcams)
                    cbWebcams.Items.Add(filterInfo.Name); // Agrega la lista de webcams a mi combobox
                cbWebcams.SelectedIndex = 0; // selecciono el index como 0
            }
            else
            {
                MessageBox.Show("No se encontró ninguna WebCam.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //this.Close(); // si no hay webcam, mando mensaje de error
                this.Dispose();
            }

        }

        private void btnWebCam_Click(object sender, EventArgs e)
        {
            if (webcam == null) // Condicional que funciona para encender y apagar la cámara
            {
                webcam = new VideoCaptureDevice(myWebcams[cbWebcams.SelectedIndex].MonikerString); // Utilizo la webcam que seleccioné en el combobox
                webcam.NewFrame += recording; // Operación rara que funciona para que vaya funcionando en tiempo real
                webcam.Start(); // Inicio la cámara 
                pbWebcam.SizeMode = PictureBoxSizeMode.StretchImage; // Acoplar la webcam a mi Picture Box
                btnWebCam.Image = new Bitmap(Procesamiento.Properties.Resources.stop_circle_regular_24); // Cambio el ícono del botón para activar la cámara al ícono de desactivar 
            }
            else
            {
                webcam.SignalToStop();
                //webcam.Stop(); // Detengo la cámara
                webcam = null;
                pbWebcam.Image = new Bitmap(Procesamiento.Properties.Resources.video_off_regular_240); //cambio la imagen del picture box
                btnWebCam.Image = new Bitmap(Procesamiento.Properties.Resources.webcam_solid_24); // cambio la imagen del botón
                pbWebcam.SizeMode = PictureBoxSizeMode.CenterImage;
            }
        }

        private void recording(object sender, NewFrameEventArgs eventArgs)
        {
            Bitmap bmp = (Bitmap)eventArgs.Frame.Clone(); // No recuerdo qué hace pero aquí entra muchas veces mientras la cámara está encendida
            Image<Bgr, byte> grayImage = new Image<Bgr, byte>(bmp);  // Dibujamos el rectángulo sobre el Bitmap y desplegamos el bitman en el Picture Box
            Rectangle[] rectangles = cascadeClassifier.DetectMultiScale(grayImage, 1.2, 1); // Mi array de rectángulos
            int people = 0;
            Color rectangleColour;
            foreach (Rectangle rectangle in rectangles) // Se repetirá por cada rectángulo que haya, es decir, por cada cara
            {
                people++;

                switch (people)
                {
                    case 1:
                        rectangleColour = Color.Red;
                        break;

                    case 2:
                        rectangleColour = Color.Blue;
                        break;

                    case 3:
                        rectangleColour = Color.Yellow;
                        break;

                    case 4:
                        rectangleColour = Color.Green;
                        break;

                    default:
                        rectangleColour = Color.White;
                        break;
                }

                using (Graphics graphics = Graphics.FromImage(bmp)) // Me sirve para poder dibujar sobre mi imagen
                {

                    using (Pen pen = new Pen(rectangleColour, 1)) // Dibujaré el rectángulo con una pluma color rojo de ancho 1
                    {
                        graphics.DrawRectangle(pen, rectangle); // Aquí lo dibujo
                    }
                }
            }

            pbWebcam.Image = bmp; // Asignamos el bmp al Picture Box

            labelPeople.Invoke(new Action(() => // si no hago esto me sale error D: 
            {
                labelPeople.Text = people.ToString(); // Imprimo la cantidad de personas en pantalla aquí mero
            }));
        }

        private void cbWebcams_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void DetectionForm_Load(object sender, EventArgs e)
        {

        }

        private void pbWebcam_Click(object sender, EventArgs e)
        {

        }

        private void lblText_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
