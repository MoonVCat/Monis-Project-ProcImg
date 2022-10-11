namespace Procesamiento
{
    partial class ManualUsuario
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelImageButtons = new System.Windows.Forms.Panel();
            this.pbLogos = new System.Windows.Forms.PictureBox();
            this.panelImageButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogos)).BeginInit();
            this.SuspendLayout();
            // 
            // panelImageButtons
            // 
            this.panelImageButtons.AutoScroll = true;
            this.panelImageButtons.BackColor = System.Drawing.Color.LightCoral;
            this.panelImageButtons.Controls.Add(this.pbLogos);
            this.panelImageButtons.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelImageButtons.Location = new System.Drawing.Point(0, 0);
            this.panelImageButtons.Margin = new System.Windows.Forms.Padding(2);
            this.panelImageButtons.Name = "panelImageButtons";
            this.panelImageButtons.Size = new System.Drawing.Size(114, 528);
            this.panelImageButtons.TabIndex = 9;
            // 
            // pbLogos
            // 
            this.pbLogos.Dock = System.Windows.Forms.DockStyle.Top;
            this.pbLogos.Image = global::Procesamiento.Properties.Resources.logos_cut1;
            this.pbLogos.Location = new System.Drawing.Point(0, 0);
            this.pbLogos.Name = "pbLogos";
            this.pbLogos.Size = new System.Drawing.Size(114, 120);
            this.pbLogos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLogos.TabIndex = 6;
            this.pbLogos.TabStop = false;
            // 
            // ManualUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.BackgroundImage = global::Procesamiento.Properties.Resources.gatitos;
            this.ClientSize = new System.Drawing.Size(938, 528);
            this.Controls.Add(this.panelImageButtons);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ManualUsuario";
            this.Text = "ManualUsuario";
            this.Load += new System.EventHandler(this.ManualUsuario_Load);
            this.panelImageButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelImageButtons;
        private System.Windows.Forms.PictureBox pbLogos;
    }
}