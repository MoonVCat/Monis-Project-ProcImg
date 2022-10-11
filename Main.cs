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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            customizePanel();
        }

        #region Form Design
        private void customizePanel()
        {
            panelSubMenuFilters.Visible = false;
        }

        private void hideSubMenu() // Función para esconder el submenú.
        {
            refreshColors();
            if (panelSubMenuFilters.Visible)
            {
                panelSubMenuFilters.Visible = false;
            }
            else
            {
                panelSubMenuFilters.Visible = true;
                btnFilters.BackColor = Design.CHOSEN_BUTTON;
            }
        }

        private void refreshColors() // Función para devolver los botones a su color original.
        {
            btnFilters.BackColor = Design.PANEL_BUTTON;
            btnFilterImage.BackColor = Design.PANEL_SUB_BUTTON;
            btnFilterVideo.BackColor = Design.PANEL_SUB_BUTTON;

            btnMovementDetection.BackColor = Design.PANEL_BUTTON;
        }

        #endregion

        #region Events
        private void btnFilters_Click(object sender, EventArgs e)
        {
            hideSubMenu();

        }
        
        private void btnFilterImage_Click(object sender, EventArgs e)
        {
            btnFilterImage.BackColor = Design.CHOSEN_SUB_BUTTON;
            btnFilterVideo.BackColor = Design.PANEL_SUB_BUTTON;

            openChildForm(new ImageForm());
        }

        private void btnFilterVideo_Click(object sender, EventArgs e)
        {
            btnFilterVideo.BackColor = Design.CHOSEN_SUB_BUTTON;
            btnFilterImage.BackColor = Design.PANEL_SUB_BUTTON;
            openChildForm(new VideoForm());
        }

        private void btnMovementDetection_Click(object sender, EventArgs e)
        {
            refreshColors();
            panelSubMenuFilters.Visible = false; // Escondo el submenú de filtros.

            if (btnMovementDetection.BackColor == Design.PANEL_BUTTON)
            {
                btnMovementDetection.BackColor = Design.CHOSEN_BUTTON;
            }

            openChildForm(new DetectionForm());
        }

        #endregion

        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close(); // Si existe un formulario abierto, lo cerramos.

            activeForm = childForm; // Guardamos el formulario que se abre.
            childForm.TopLevel = false; 
            childForm.FormBorderStyle = FormBorderStyle.None; 
            childForm.Dock = DockStyle.Fill; 
            panelChildForm.Controls.Add(childForm); // Agregamos el formulario a la lista de controles del panel contenedor.
            panelChildForm.Tag = childForm; 
            childForm.BringToFront(); 
            childForm.Show(); 
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void pbLogos_Click(object sender, EventArgs e)
        {

        }

        private void pbBigLogos_Click(object sender, EventArgs e)
        {

        }

        private void panelSideMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
