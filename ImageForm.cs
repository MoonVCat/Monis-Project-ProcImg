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


namespace Procesamiento
{
    public partial class ImageForm : Form
    {
        //Global Variables
        private Bitmap bmp = null;
        private Bitmap bmpOriginal = null;
        private String[] filterName = { "Normal", "Grayscale", "Sepia", "Negative", "Blur", "Black and White", "Mirror", "Noise" };
        private int[] histograma = new int[256];
        private int[] Rhistograma = new int[256];
        private int[] Ghistograma = new int[256];
        private int[] Bhistograma = new int[256];

        public ImageForm()
        {
            InitializeComponent();
            loadFilters();
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog(); 
            openFile.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop); // El path default lo defino como el escritorio

            openFile.Title = "Selecciona una imagen"; 
            openFile.Filter = "Image Files (*.jpg; *.jpeg; *.bmp; *.png)|*.jpg|All files (*.*)|*.*"; 

            if (openFile.ShowDialog() == DialogResult.OK) 
            {
                string imagePath = openFile.FileName;
                
                pbFilterImage.Image = Image.FromFile(imagePath); 
                pbFilterImage.SizeMode = PictureBoxSizeMode.StretchImage; 
                bmp = new Bitmap(imagePath); 
                bmpOriginal = new Bitmap(imagePath); 
                cbFilters.SelectedIndex = 0; 
            }

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (bmp != null) // Si ya hay una imagen seleccionada
            {
                SaveFileDialog SaveFileDialog = new SaveFileDialog(); 
                SaveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures); 

                SaveFileDialog.Title = "Guardar imagen como"; 
                SaveFileDialog.Filter = "Image Files (*.jpg)|*.jpg|All files (*.*)|*.*"; 

                if (SaveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    bmp.Save(SaveFileDialog.FileName); 
                }
                else
                {
                    MessageBox.Show("Ha ocurrido un error al guardar la imagen", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Selecciona una imagen", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void loadFilters()
        {
            for (int i = 0; i < filterName.Length; i++) 
                cbFilters.Items.Add(filterName[i]); 

            cbFilters.SelectedIndex = 0; // selecciono el index como 0
        }

        private void cbFilters_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (bmp != null) {
  
                switch (cbFilters.SelectedIndex)
                {
                    case 0:
                        {
                            pbFilterImage.Image = bmpOriginal;
                            break;
                        }

                    case 1:
                        {
                            pbFilterImage.Image = Filters.grayFilter(bmp);
                            break;
                        }

                    case 2:
                        {
                            pbFilterImage.Image = Filters.sepiaFilter(bmp);
                            break;
                        }

                    case 3:
                        {
                            pbFilterImage.Image = Filters.negativeFilter(bmp);
                            break;
                        }
                    case 4:
                        {
                            pbFilterImage.Image = Filters.blurFilter(bmp, 1);
                            break;
                        }

                    case 5:
                        {
                            pbFilterImage.Image = Filters.blackAndWhiteFilter(bmp);
                            break;
                        }

                    case 6:
                        {
                            pbFilterImage.Image = Filters.mirrorFilter(bmp);
                            break;
                        }

                    case 7:
                        {
                            pbFilterImage.Image = Filters.noiseFilter(bmp);
                            break;
                        }



                }
            }
        }


        private void pbFilterImage_Click(object sender, EventArgs e)
        {

        }

        private void btn_HistogramaBN_Click(object sender, EventArgs e)
        {

            //Histograma BLANCO Y NEGRO
            int x = 0;
            int y = 0;
            Bitmap foto = new Bitmap(bmpOriginal.Width, bmpOriginal.Height);
            Color rColor = new Color();
            Color ocolor = new Color();
            float g;
            for (x = 0; x < bmpOriginal.Width; x++)
            {
                for (y = 0; y < bmpOriginal.Height; y++)
                {
                    ocolor = bmpOriginal.GetPixel(x, y);
                    g = ocolor.R * 0.299f + ocolor.G * 0.587f + ocolor.B * 0.114f;
                    rColor = Color.FromArgb((int)g, (int)g, (int)g);
                    foto.SetPixel(x, y, rColor);
                }
            }
            pbFilterImage.Image = foto;

            for (x = 0; x < bmpOriginal.Width; x++)
            {
                for (y = 0; y < bmpOriginal.Height; y++)
                {
                    //obtenemos el color del pixel

                    rColor = bmpOriginal.GetPixel(x, y);
                    histograma[rColor.R]++;
                }

            }

            Histograma hform = new Histograma(histograma);
            hform.Show();

        }

        private void btn_HistogramaVerde_Click(object sender, EventArgs e)
        {

            //Histograma VERDE
            int x = 0;
            int y = 0;
            Bitmap foto = new Bitmap(bmpOriginal.Width, bmpOriginal.Height);
            Color rColor = new Color();
            Color ocolor = new Color();

            for (x = 0; x < bmpOriginal.Width; x++)
            {
                for (y = 0; y < bmpOriginal.Height; y++)
                {
                    //obtenemos el color del pixel
                    ocolor = bmpOriginal.GetPixel(x, y);

                    //procesamos el nuevo color
                    rColor = Color.FromArgb(0, ocolor.G, 0);

                    //colocamos el color resultante
                    foto.SetPixel(x, y, rColor);
                }
            }
            pbFilterImage.Image = foto;

            for (x = 0; x < bmpOriginal.Width; x++)
            {
                for (y = 0; y < bmpOriginal.Height; y++)
                {
                    //obtenemos el color del pixel

                    rColor = bmpOriginal.GetPixel(x, y);
                    Ghistograma[rColor.B]++;
                }
            }

            Histograma hform = new Histograma(Ghistograma);
            hform.Show();

        }

        private void btn_HistogramaRojo_Click(object sender, EventArgs e)
        {

            //Histograma ROJO
            int x = 0;
            int y = 0;
            Bitmap foto = new Bitmap(bmpOriginal.Width, bmpOriginal.Height);
            Color rColor = new Color();
            Color ocolor = new Color();


            for (x = 0; x < bmpOriginal.Width; x++)
            {
                for (y = 0; y < bmpOriginal.Height; y++)
                {
                    //obtenemos el color del pixel
                    ocolor = bmpOriginal.GetPixel(x, y);

                    //procesamos el nuevo color
                    rColor = Color.FromArgb(ocolor.R, 0, 0);

                    //colocamos el color resultante
                    foto.SetPixel(x, y, rColor);
                }
            }
            pbFilterImage.Image = foto;

            for (x = 0; x < bmpOriginal.Width; x++)
            {
                for (y = 0; y < bmpOriginal.Height; y++)
                {
                    //obtenemos el color del pixel

                    rColor = bmpOriginal.GetPixel(x, y);
                    Rhistograma[rColor.G]++;
                }
            }

            Histograma hform = new Histograma(Rhistograma);
            hform.Show();

        }

        private void btn_HistogramaAzul_Click(object sender, EventArgs e)
        {
            //Histograma AZUL
            int x = 0;
            int y = 0;
            Bitmap foto = new Bitmap(bmpOriginal.Width, bmpOriginal.Height);
            Color rColor = new Color();
            Color ocolor = new Color();

            for (x = 0; x < bmpOriginal.Width; x++)
            {
                for (y = 0; y < bmpOriginal.Height; y++)
                {
                    //obtenemos el color del pixel
                    ocolor = bmpOriginal.GetPixel(x, y);

                    //procesamos el nuevo color
                    rColor = Color.FromArgb(0, 0, ocolor.B);

                    //colocamos el color resultante
                    foto.SetPixel(x, y, rColor);
                }
            }
            pbFilterImage.Image = foto;

            for (x = 0; x < bmpOriginal.Width; x++)
            {
                for (y = 0; y < bmpOriginal.Height; y++)
                {
                    //obtenemos el color del pixel

                    rColor = bmpOriginal.GetPixel(x, y);
                    Bhistograma[rColor.R]++;
                }
            }

            Histograma hform = new Histograma(Bhistograma);
            hform.Show();

        }
    }
}
