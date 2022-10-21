
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
            this.label1 = new System.Windows.Forms.Label();
            this.btn_HistogramaBN = new System.Windows.Forms.Button();
            this.btn_HistogramaVerde = new System.Windows.Forms.Button();
            this.btn_HistogramaRojo = new System.Windows.Forms.Button();
            this.btn_HistogramaAzul = new System.Windows.Forms.Button();
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
            this.btnSave.BackColor = System.Drawing.Color.CadetBlue;
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
            this.btnUpload.BackColor = System.Drawing.Color.MediumSlateBlue;
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
            this.pbFilterImage.Location = new System.Drawing.Point(163, 81);
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
            this.cbFilters.Location = new System.Drawing.Point(630, 50);
            this.cbFilters.Name = "cbFilters";
            this.cbFilters.Size = new System.Drawing.Size(260, 21);
            this.cbFilters.TabIndex = 4;
            this.cbFilters.SelectedIndexChanged += new System.EventHandler(this.cbFilters_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.label1.Location = new System.Drawing.Point(666, 154);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 39);
            this.label1.TabIndex = 5;
            this.label1.Text = "Histograma";
            // 
            // btn_HistogramaBN
            // 
            this.btn_HistogramaBN.BackColor = System.Drawing.Color.LightCoral;
            this.btn_HistogramaBN.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.btn_HistogramaBN.ForeColor = System.Drawing.Color.LavenderBlush;
            this.btn_HistogramaBN.Location = new System.Drawing.Point(657, 243);
            this.btn_HistogramaBN.Name = "btn_HistogramaBN";
            this.btn_HistogramaBN.Size = new System.Drawing.Size(92, 56);
            this.btn_HistogramaBN.TabIndex = 12;
            this.btn_HistogramaBN.Text = " B/N";
            this.btn_HistogramaBN.UseVisualStyleBackColor = false;
            this.btn_HistogramaBN.Click += new System.EventHandler(this.btn_HistogramaBN_Click);
            // 
            // btn_HistogramaVerde
            // 
            this.btn_HistogramaVerde.BackColor = System.Drawing.Color.LightCoral;
            this.btn_HistogramaVerde.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.btn_HistogramaVerde.ForeColor = System.Drawing.Color.LavenderBlush;
            this.btn_HistogramaVerde.Location = new System.Drawing.Point(789, 243);
            this.btn_HistogramaVerde.Name = "btn_HistogramaVerde";
            this.btn_HistogramaVerde.Size = new System.Drawing.Size(92, 56);
            this.btn_HistogramaVerde.TabIndex = 13;
            this.btn_HistogramaVerde.Text = "Verde";
            this.btn_HistogramaVerde.UseVisualStyleBackColor = false;
            this.btn_HistogramaVerde.Click += new System.EventHandler(this.btn_HistogramaVerde_Click);
            // 
            // btn_HistogramaRojo
            // 
            this.btn_HistogramaRojo.BackColor = System.Drawing.Color.LightCoral;
            this.btn_HistogramaRojo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.btn_HistogramaRojo.ForeColor = System.Drawing.Color.LavenderBlush;
            this.btn_HistogramaRojo.Location = new System.Drawing.Point(657, 352);
            this.btn_HistogramaRojo.Name = "btn_HistogramaRojo";
            this.btn_HistogramaRojo.Size = new System.Drawing.Size(92, 56);
            this.btn_HistogramaRojo.TabIndex = 14;
            this.btn_HistogramaRojo.Text = "Rojo";
            this.btn_HistogramaRojo.UseVisualStyleBackColor = false;
            this.btn_HistogramaRojo.Click += new System.EventHandler(this.btn_HistogramaRojo_Click);
            // 
            // btn_HistogramaAzul
            // 
            this.btn_HistogramaAzul.BackColor = System.Drawing.Color.LightCoral;
            this.btn_HistogramaAzul.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.btn_HistogramaAzul.ForeColor = System.Drawing.Color.LavenderBlush;
            this.btn_HistogramaAzul.Location = new System.Drawing.Point(789, 352);
            this.btn_HistogramaAzul.Name = "btn_HistogramaAzul";
            this.btn_HistogramaAzul.Size = new System.Drawing.Size(92, 56);
            this.btn_HistogramaAzul.TabIndex = 15;
            this.btn_HistogramaAzul.Text = "Azul";
            this.btn_HistogramaAzul.UseVisualStyleBackColor = false;
            this.btn_HistogramaAzul.Click += new System.EventHandler(this.btn_HistogramaAzul_Click);
            // 
            // ImageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.BackgroundImage = global::Procesamiento.Properties.Resources.gatitos;
            this.ClientSize = new System.Drawing.Size(938, 528);
            this.Controls.Add(this.btn_HistogramaAzul);
            this.Controls.Add(this.btn_HistogramaRojo);
            this.Controls.Add(this.btn_HistogramaVerde);
            this.Controls.Add(this.btn_HistogramaBN);
            this.Controls.Add(this.label1);
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
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pbFilterImage;
        private System.Windows.Forms.Panel panelImageButtons;
        private System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ComboBox cbFilters;
        private System.Windows.Forms.PictureBox pbLogos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_HistogramaBN;
        private System.Windows.Forms.Button btn_HistogramaVerde;
        private System.Windows.Forms.Button btn_HistogramaRojo;
        private System.Windows.Forms.Button btn_HistogramaAzul;
    }
}