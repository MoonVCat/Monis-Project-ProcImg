using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Procesamiento
{
    public partial class Histograma : Form
    {
        private int[] histogram;
        private int mayor;
        public Histograma(int[] pHistograma)
        {
            InitializeComponent();
            histogram = pHistograma;
            int n = 0;

            // encontramos al mayor
            mayor = 0;
            for (n = 0; n < 256; n++)
            {
                if (histogram[n] > mayor)
                    mayor = histogram[n];
            }

            for (n = 0; n < 256; n++)
                histogram[n] = (int)((float)histogram[n] / (float)mayor * 256.0f);
        }

        private void Histograma_Load(object sender, EventArgs e)

        {


        }

        private void Histograma_Paint(object sender, PaintEventArgs e)
        {
            int n = 0;
            int altura = 0;
            Graphics g = e.Graphics;
            Pen plumaH = new Pen(Color.Black);
            Pen plumaEjes = new Pen(Color.Black);


            g.DrawLine(plumaEjes, 19, 271, 277, 271);
            g.DrawLine(plumaEjes, 19, 270, 19, 14);

            for (n = 0; n < 256; n++)
            {
                g.DrawLine(plumaH, n + 20, 270, n + 20, 270 - histogram[n]);
            }
        }
    }
}
