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
    }
}
