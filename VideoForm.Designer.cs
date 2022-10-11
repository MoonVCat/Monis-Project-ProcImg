
namespace Procesamiento
{
    partial class VideoForm
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
            this.cbFilters = new System.Windows.Forms.ComboBox();
            this.btnPlay = new System.Windows.Forms.Button();
            this.btnAddVideo = new System.Windows.Forms.Button();
            this.pbVideo = new System.Windows.Forms.PictureBox();
            this.panelImageButtons = new System.Windows.Forms.Panel();
            this.pbLogos = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbVideo)).BeginInit();
            this.panelImageButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogos)).BeginInit();
            this.SuspendLayout();
            // 
            // cbFilters
            // 
            this.cbFilters.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFilters.FormattingEnabled = true;
            this.cbFilters.Location = new System.Drawing.Point(665, 89);
            this.cbFilters.Name = "cbFilters";
            this.cbFilters.Size = new System.Drawing.Size(261, 21);
            this.cbFilters.TabIndex = 5;
            this.cbFilters.SelectedIndexChanged += new System.EventHandler(this.cbFilters_SelectedIndexChanged);
            // 
            // btnPlay
            // 
            this.btnPlay.BackColor = System.Drawing.Color.CadetBlue;
            this.btnPlay.Image = global::Procesamiento.Properties.Resources.play_regular_24;
            this.btnPlay.Location = new System.Drawing.Point(11, 446);
            this.btnPlay.Margin = new System.Windows.Forms.Padding(2);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(82, 46);
            this.btnPlay.TabIndex = 6;
            this.btnPlay.UseVisualStyleBackColor = false;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // btnAddVideo
            // 
            this.btnAddVideo.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnAddVideo.Image = global::Procesamiento.Properties.Resources.video_plus_regular_24;
            this.btnAddVideo.Location = new System.Drawing.Point(11, 204);
            this.btnAddVideo.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddVideo.Name = "btnAddVideo";
            this.btnAddVideo.Size = new System.Drawing.Size(82, 46);
            this.btnAddVideo.TabIndex = 3;
            this.btnAddVideo.UseVisualStyleBackColor = false;
            this.btnAddVideo.Click += new System.EventHandler(this.btnAddVideo_Click);
            // 
            // pbVideo
            // 
            this.pbVideo.BackColor = System.Drawing.Color.Transparent;
            this.pbVideo.Image = global::Procesamiento.Properties.Resources.video_off_regular_240;
            this.pbVideo.Location = new System.Drawing.Point(130, 89);
            this.pbVideo.Margin = new System.Windows.Forms.Padding(2);
            this.pbVideo.Name = "pbVideo";
            this.pbVideo.Size = new System.Drawing.Size(530, 379);
            this.pbVideo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbVideo.TabIndex = 0;
            this.pbVideo.TabStop = false;
            this.pbVideo.Click += new System.EventHandler(this.pbVideo_Click);
            // 
            // panelImageButtons
            // 
            this.panelImageButtons.AutoScroll = true;
            this.panelImageButtons.BackColor = System.Drawing.Color.LightCoral;
            this.panelImageButtons.Controls.Add(this.pbLogos);
            this.panelImageButtons.Controls.Add(this.btnPlay);
            this.panelImageButtons.Controls.Add(this.btnAddVideo);
            this.panelImageButtons.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelImageButtons.Location = new System.Drawing.Point(0, 0);
            this.panelImageButtons.Margin = new System.Windows.Forms.Padding(2);
            this.panelImageButtons.Name = "panelImageButtons";
            this.panelImageButtons.Size = new System.Drawing.Size(114, 528);
            this.panelImageButtons.TabIndex = 7;
            // 
            // pbLogos
            // 
            this.pbLogos.Dock = System.Windows.Forms.DockStyle.Top;
            this.pbLogos.Image = global::Procesamiento.Properties.Resources.logos_cut1;
            this.pbLogos.Location = new System.Drawing.Point(0, 0);
            this.pbLogos.Name = "pbLogos";
            this.pbLogos.Size = new System.Drawing.Size(114, 120);
            this.pbLogos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLogos.TabIndex = 4;
            this.pbLogos.TabStop = false;
            // 
            // VideoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.BackgroundImage = global::Procesamiento.Properties.Resources.gatitos;
            this.ClientSize = new System.Drawing.Size(938, 528);
            this.Controls.Add(this.panelImageButtons);
            this.Controls.Add(this.cbFilters);
            this.Controls.Add(this.pbVideo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "VideoForm";
            this.Text = "Video";
            ((System.ComponentModel.ISupportInitialize)(this.pbVideo)).EndInit();
            this.panelImageButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbVideo;
        private System.Windows.Forms.Button btnAddVideo;
        private System.Windows.Forms.ComboBox cbFilters;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Panel panelImageButtons;
        private System.Windows.Forms.PictureBox pbLogos;
    }
}