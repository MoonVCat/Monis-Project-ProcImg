
namespace Procesamiento
{
    partial class ImageForm
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
            this.btnSave = new System.Windows.Forms.Button();
            this.btnUpload = new System.Windows.Forms.Button();
            this.pbFilterImage = new System.Windows.Forms.PictureBox();
            this.cbFilters = new System.Windows.Forms.ComboBox();
            this.panelImageButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFilterImage)).BeginInit();
            this.SuspendLayout();
            // 
            // panelImageButtons
            // 
            this.panelImageButtons.AutoScroll = true;
            this.panelImageButtons.BackColor = System.Drawing.Color.LightCoral;
            this.panelImageButtons.Controls.Add(this.pbLogos);
            this.panelImageButtons.Controls.Add(this.btnSave);
            this.panelImageButtons.Controls.Add(this.btnUpload);
            this.panelImageButtons.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelImageButtons.Location = new System.Drawing.Point(0, 0);
            this.panelImageButtons.Margin = new System.Windows.Forms.Padding(2);
            this.panelImageButtons.Name = "panelImageButtons";
            this.panelImageButtons.Size = new System.Drawing.Size(114, 528);
            this.panelImageButtons.TabIndex = 2;
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
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnSave.Image = global::Procesamiento.Properties.Resources.save_regular_24;
            this.btnSave.Location = new System.Drawing.Point(20, 395);
            this.btnSave.Margin = new System.Windows.Forms.Padding(2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(65, 46);
            this.btnSave.TabIndex = 3;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnUpload
            // 
            this.btnUpload.BackColor = System.Drawing.Color.CadetBlue;
            this.btnUpload.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnUpload.Image = global::Procesamiento.Properties.Resources.image_add_regular_24;
            this.btnUpload.Location = new System.Drawing.Point(20, 157);
            this.btnUpload.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(65, 46);
            this.btnUpload.TabIndex = 0;
            this.btnUpload.UseVisualStyleBackColor = false;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // pbFilterImage
            // 
            this.pbFilterImage.BackColor = System.Drawing.Color.Transparent;
            this.pbFilterImage.Image = global::Procesamiento.Properties.Resources.photo_album_regular_240;
            this.pbFilterImage.Location = new System.Drawing.Point(142, 86);
            this.pbFilterImage.Margin = new System.Windows.Forms.Padding(2);
            this.pbFilterImage.Name = "pbFilterImage";
            this.pbFilterImage.Size = new System.Drawing.Size(414, 382);
            this.pbFilterImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbFilterImage.TabIndex = 1;
            this.pbFilterImage.TabStop = false;
            this.pbFilterImage.Click += new System.EventHandler(this.pbFilterImage_Click);
            // 
            // cbFilters
            // 
            this.cbFilters.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFilters.FormattingEnabled = true;
            this.cbFilters.Location = new System.Drawing.Point(604, 86);
            this.cbFilters.Name = "cbFilters";
            this.cbFilters.Size = new System.Drawing.Size(260, 21);
            this.cbFilters.TabIndex = 4;
            this.cbFilters.SelectedIndexChanged += new System.EventHandler(this.cbFilters_SelectedIndexChanged);
            // 
            // ImageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.BackgroundImage = global::Procesamiento.Properties.Resources.gatitos;
            this.ClientSize = new System.Drawing.Size(938, 528);
            this.Controls.Add(this.cbFilters);
            this.Controls.Add(this.panelImageButtons);
            this.Controls.Add(this.pbFilterImage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ImageForm";
            this.Text = "Images";
            this.panelImageButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFilterImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pbFilterImage;
        private System.Windows.Forms.Panel panelImageButtons;
        private System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ComboBox cbFilters;
        private System.Windows.Forms.PictureBox pbLogos;
    }
}