
namespace Procesamiento
{
    partial class Main
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelSideMenu = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnMovementDetection = new System.Windows.Forms.Button();
            this.panelSubMenuFilters = new System.Windows.Forms.Panel();
            this.btnFilterVideo = new System.Windows.Forms.Button();
            this.btnFilterImage = new System.Windows.Forms.Button();
            this.btnFilters = new System.Windows.Forms.Button();
            this.panelAppName = new System.Windows.Forms.Panel();
            this.panelChildForm = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pbBigLogos = new System.Windows.Forms.PictureBox();
            this.pbLogos = new System.Windows.Forms.PictureBox();
            this.panelSideMenu.SuspendLayout();
            this.panelSubMenuFilters.SuspendLayout();
            this.panelAppName.SuspendLayout();
            this.panelChildForm.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbBigLogos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogos)).BeginInit();
            this.SuspendLayout();
            // 
            // panelSideMenu
            // 
            this.panelSideMenu.AutoScroll = true;
            this.panelSideMenu.BackColor = System.Drawing.Color.LightCoral;
            this.panelSideMenu.Controls.Add(this.btnExit);
            this.panelSideMenu.Controls.Add(this.btnMovementDetection);
            this.panelSideMenu.Controls.Add(this.panelSubMenuFilters);
            this.panelSideMenu.Controls.Add(this.btnFilters);
            this.panelSideMenu.Controls.Add(this.panelAppName);
            this.panelSideMenu.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelSideMenu.Location = new System.Drawing.Point(937, 0);
            this.panelSideMenu.Margin = new System.Windows.Forms.Padding(2);
            this.panelSideMenu.Name = "panelSideMenu";
            this.panelSideMenu.Size = new System.Drawing.Size(188, 528);
            this.panelSideMenu.TabIndex = 0;
            this.panelSideMenu.Paint += new System.Windows.Forms.PaintEventHandler(this.panelSideMenu_Paint);
            // 
            // btnExit
            // 
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.AliceBlue;
            this.btnExit.Location = new System.Drawing.Point(0, 491);
            this.btnExit.Margin = new System.Windows.Forms.Padding(2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.btnExit.Size = new System.Drawing.Size(188, 37);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnMovementDetection
            // 
            this.btnMovementDetection.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMovementDetection.FlatAppearance.BorderSize = 0;
            this.btnMovementDetection.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMovementDetection.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMovementDetection.ForeColor = System.Drawing.Color.AliceBlue;
            this.btnMovementDetection.Location = new System.Drawing.Point(0, 232);
            this.btnMovementDetection.Margin = new System.Windows.Forms.Padding(2);
            this.btnMovementDetection.Name = "btnMovementDetection";
            this.btnMovementDetection.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.btnMovementDetection.Size = new System.Drawing.Size(188, 37);
            this.btnMovementDetection.TabIndex = 3;
            this.btnMovementDetection.Text = "Detección de movimiento";
            this.btnMovementDetection.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMovementDetection.UseVisualStyleBackColor = true;
            this.btnMovementDetection.Click += new System.EventHandler(this.btnMovementDetection_Click);
            // 
            // panelSubMenuFilters
            // 
            this.panelSubMenuFilters.BackColor = System.Drawing.Color.White;
            this.panelSubMenuFilters.Controls.Add(this.btnFilterVideo);
            this.panelSubMenuFilters.Controls.Add(this.btnFilterImage);
            this.panelSubMenuFilters.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSubMenuFilters.Location = new System.Drawing.Point(0, 157);
            this.panelSubMenuFilters.Margin = new System.Windows.Forms.Padding(2);
            this.panelSubMenuFilters.Name = "panelSubMenuFilters";
            this.panelSubMenuFilters.Size = new System.Drawing.Size(188, 75);
            this.panelSubMenuFilters.TabIndex = 2;
            // 
            // btnFilterVideo
            // 
            this.btnFilterVideo.BackColor = System.Drawing.Color.CadetBlue;
            this.btnFilterVideo.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnFilterVideo.FlatAppearance.BorderSize = 0;
            this.btnFilterVideo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFilterVideo.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFilterVideo.ForeColor = System.Drawing.Color.AliceBlue;
            this.btnFilterVideo.Location = new System.Drawing.Point(0, 37);
            this.btnFilterVideo.Margin = new System.Windows.Forms.Padding(2);
            this.btnFilterVideo.Name = "btnFilterVideo";
            this.btnFilterVideo.Padding = new System.Windows.Forms.Padding(26, 0, 0, 0);
            this.btnFilterVideo.Size = new System.Drawing.Size(188, 38);
            this.btnFilterVideo.TabIndex = 1;
            this.btnFilterVideo.Text = "Videos";
            this.btnFilterVideo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFilterVideo.UseVisualStyleBackColor = false;
            this.btnFilterVideo.Click += new System.EventHandler(this.btnFilterVideo_Click);
            // 
            // btnFilterImage
            // 
            this.btnFilterImage.BackColor = System.Drawing.Color.CadetBlue;
            this.btnFilterImage.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnFilterImage.FlatAppearance.BorderSize = 0;
            this.btnFilterImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFilterImage.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFilterImage.ForeColor = System.Drawing.Color.AliceBlue;
            this.btnFilterImage.Location = new System.Drawing.Point(0, 0);
            this.btnFilterImage.Margin = new System.Windows.Forms.Padding(2);
            this.btnFilterImage.Name = "btnFilterImage";
            this.btnFilterImage.Padding = new System.Windows.Forms.Padding(26, 0, 0, 0);
            this.btnFilterImage.Size = new System.Drawing.Size(188, 37);
            this.btnFilterImage.TabIndex = 0;
            this.btnFilterImage.Text = "Imágenes";
            this.btnFilterImage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFilterImage.UseVisualStyleBackColor = false;
            this.btnFilterImage.Click += new System.EventHandler(this.btnFilterImage_Click);
            // 
            // btnFilters
            // 
            this.btnFilters.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnFilters.FlatAppearance.BorderSize = 0;
            this.btnFilters.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFilters.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFilters.ForeColor = System.Drawing.Color.AliceBlue;
            this.btnFilters.Location = new System.Drawing.Point(0, 120);
            this.btnFilters.Margin = new System.Windows.Forms.Padding(2);
            this.btnFilters.Name = "btnFilters";
            this.btnFilters.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.btnFilters.Size = new System.Drawing.Size(188, 37);
            this.btnFilters.TabIndex = 1;
            this.btnFilters.Text = "Filtros";
            this.btnFilters.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFilters.UseVisualStyleBackColor = true;
            this.btnFilters.Click += new System.EventHandler(this.btnFilters_Click);
            // 
            // panelAppName
            // 
            this.panelAppName.Controls.Add(this.pbLogos);
            this.panelAppName.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelAppName.Location = new System.Drawing.Point(0, 0);
            this.panelAppName.Margin = new System.Windows.Forms.Padding(2);
            this.panelAppName.Name = "panelAppName";
            this.panelAppName.Size = new System.Drawing.Size(188, 120);
            this.panelAppName.TabIndex = 0;
            // 
            // panelChildForm
            // 
            this.panelChildForm.Controls.Add(this.panel1);
            this.panelChildForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChildForm.Location = new System.Drawing.Point(0, 0);
            this.panelChildForm.Margin = new System.Windows.Forms.Padding(2);
            this.panelChildForm.Name = "panelChildForm";
            this.panelChildForm.Size = new System.Drawing.Size(937, 528);
            this.panelChildForm.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::Procesamiento.Properties.Resources.gatitos;
            this.panel1.Controls.Add(this.pbBigLogos);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(150);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(35);
            this.panel1.Size = new System.Drawing.Size(937, 528);
            this.panel1.TabIndex = 1;
            // 
            // pbBigLogos
            // 
            this.pbBigLogos.BackColor = System.Drawing.Color.Transparent;
            this.pbBigLogos.BackgroundImage = global::Procesamiento.Properties.Resources.welcome;
            this.pbBigLogos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pbBigLogos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbBigLogos.Location = new System.Drawing.Point(35, 35);
            this.pbBigLogos.Name = "pbBigLogos";
            this.pbBigLogos.Padding = new System.Windows.Forms.Padding(50);
            this.pbBigLogos.Size = new System.Drawing.Size(867, 458);
            this.pbBigLogos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbBigLogos.TabIndex = 1;
            this.pbBigLogos.TabStop = false;
            this.pbBigLogos.Click += new System.EventHandler(this.pbBigLogos_Click);
            // 
            // pbLogos
            // 
            this.pbLogos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbLogos.Image = global::Procesamiento.Properties.Resources.logos_cut1;
            this.pbLogos.Location = new System.Drawing.Point(0, 0);
            this.pbLogos.Name = "pbLogos";
            this.pbLogos.Size = new System.Drawing.Size(188, 120);
            this.pbLogos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLogos.TabIndex = 0;
            this.pbLogos.TabStop = false;
            this.pbLogos.Click += new System.EventHandler(this.pbLogos_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.ClientSize = new System.Drawing.Size(1125, 528);
            this.Controls.Add(this.panelChildForm);
            this.Controls.Add(this.panelSideMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Procesamiento de imágenes";
            this.panelSideMenu.ResumeLayout(false);
            this.panelSubMenuFilters.ResumeLayout(false);
            this.panelAppName.ResumeLayout(false);
            this.panelChildForm.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbBigLogos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSideMenu;
        private System.Windows.Forms.Button btnFilters;
        private System.Windows.Forms.Panel panelAppName;
        private System.Windows.Forms.Button btnMovementDetection;
        private System.Windows.Forms.Panel panelSubMenuFilters;
        private System.Windows.Forms.Button btnFilterVideo;
        private System.Windows.Forms.Button btnFilterImage;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Panel panelChildForm;
        private System.Windows.Forms.PictureBox pbLogos;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pbBigLogos;
    }
}

