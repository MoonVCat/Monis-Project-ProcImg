
namespace Procesamiento
{
    partial class DetectionForm
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
            this.cbWebcams = new System.Windows.Forms.ComboBox();
            this.labelPeople = new System.Windows.Forms.Label();
            this.btnWebCam = new System.Windows.Forms.Button();
            this.pbWebcam = new System.Windows.Forms.PictureBox();
            this.lblText = new System.Windows.Forms.Label();
            this.panelImageButtons = new System.Windows.Forms.Panel();
            this.pbLogos = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbWebcam)).BeginInit();
            this.panelImageButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cbWebcams
            // 
            this.cbWebcams.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbWebcams.FormattingEnabled = true;
            this.cbWebcams.Location = new System.Drawing.Point(698, 80);
            this.cbWebcams.Name = "cbWebcams";
            this.cbWebcams.Size = new System.Drawing.Size(214, 21);
            this.cbWebcams.TabIndex = 4;
            this.cbWebcams.SelectedIndexChanged += new System.EventHandler(this.cbWebcams_SelectedIndexChanged);
            // 
            // labelPeople
            // 
            this.labelPeople.AutoSize = true;
            this.labelPeople.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPeople.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelPeople.Location = new System.Drawing.Point(804, 393);
            this.labelPeople.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPeople.Name = "labelPeople";
            this.labelPeople.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelPeople.Size = new System.Drawing.Size(18, 20);
            this.labelPeople.TabIndex = 6;
            this.labelPeople.Text = "0";
            // 
            // btnWebCam
            // 
            this.btnWebCam.BackColor = System.Drawing.Color.CadetBlue;
            this.btnWebCam.BackgroundImage = global::Procesamiento.Properties.Resources.webcam_solid_241;
            this.btnWebCam.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnWebCam.Location = new System.Drawing.Point(18, 210);
            this.btnWebCam.Margin = new System.Windows.Forms.Padding(2);
            this.btnWebCam.Name = "btnWebCam";
            this.btnWebCam.Size = new System.Drawing.Size(82, 46);
            this.btnWebCam.TabIndex = 5;
            this.btnWebCam.UseVisualStyleBackColor = false;
            this.btnWebCam.Click += new System.EventHandler(this.btnWebCam_Click);
            // 
            // pbWebcam
            // 
            this.pbWebcam.Location = new System.Drawing.Point(0, 0);
            this.pbWebcam.Name = "pbWebcam";
            this.pbWebcam.Size = new System.Drawing.Size(100, 50);
            this.pbWebcam.TabIndex = 9;
            this.pbWebcam.TabStop = false;
            // 
            // lblText
            // 
            this.lblText.AutoSize = true;
            this.lblText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblText.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblText.Location = new System.Drawing.Point(746, 357);
            this.lblText.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(143, 17);
            this.lblText.TabIndex = 7;
            this.lblText.Text = "Personas en cámara:";
            this.lblText.Click += new System.EventHandler(this.lblText_Click);
            // 
            // panelImageButtons
            // 
            this.panelImageButtons.AutoScroll = true;
            this.panelImageButtons.BackColor = System.Drawing.Color.LightCoral;
            this.panelImageButtons.Controls.Add(this.pbLogos);
            this.panelImageButtons.Controls.Add(this.btnWebCam);
            this.panelImageButtons.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelImageButtons.Location = new System.Drawing.Point(0, 0);
            this.panelImageButtons.Margin = new System.Windows.Forms.Padding(2);
            this.panelImageButtons.Name = "panelImageButtons";
            this.panelImageButtons.Size = new System.Drawing.Size(114, 528);
            this.panelImageButtons.TabIndex = 8;
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
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Image = global::Procesamiento.Properties.Resources.camera_off_regular_240;
            this.pictureBox1.ImageLocation = "";
            this.pictureBox1.Location = new System.Drawing.Point(138, 80);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(543, 385);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // DetectionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.BackgroundImage = global::Procesamiento.Properties.Resources.gatitos;
            this.ClientSize = new System.Drawing.Size(938, 528);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panelImageButtons);
            this.Controls.Add(this.lblText);
            this.Controls.Add(this.labelPeople);
            this.Controls.Add(this.cbWebcams);
            this.Controls.Add(this.pbWebcam);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "DetectionForm";
            this.Text = "DetectionForm";
            this.Load += new System.EventHandler(this.DetectionForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbWebcam)).EndInit();
            this.panelImageButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbWebcam;
        private System.Windows.Forms.ComboBox cbWebcams;
        private System.Windows.Forms.Button btnWebCam;
        private System.Windows.Forms.Label labelPeople;
        private System.Windows.Forms.Label lblText;
        private System.Windows.Forms.Panel panelImageButtons;
        private System.Windows.Forms.PictureBox pbLogos;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}