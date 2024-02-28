namespace Celafy
{
    partial class PlaylistSelectionButton
    {
        /// <summary> 
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione componenti

        /// <summary> 
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare 
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlImage = new System.Windows.Forms.Panel();
            this.picThumbnail = new System.Windows.Forms.PictureBox();
            this.pnlImageLeft = new System.Windows.Forms.Panel();
            this.pnlImageCenter = new System.Windows.Forms.Panel();
            this.pnlImage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picThumbnail)).BeginInit();
            this.pnlImageCenter.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlImage
            // 
            this.pnlImage.Controls.Add(this.pnlImageCenter);
            this.pnlImage.Controls.Add(this.pnlImageLeft);
            this.pnlImage.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlImage.Location = new System.Drawing.Point(0, 0);
            this.pnlImage.Name = "pnlImage";
            this.pnlImage.Size = new System.Drawing.Size(43, 50);
            this.pnlImage.TabIndex = 0;
            // 
            // picThumbnail
            // 
            this.picThumbnail.BackgroundImage = global::Celafy.Properties.Resources.PlaylistDefault;
            this.picThumbnail.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picThumbnail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picThumbnail.Location = new System.Drawing.Point(0, 0);
            this.picThumbnail.Name = "picThumbnail";
            this.picThumbnail.Size = new System.Drawing.Size(33, 50);
            this.picThumbnail.TabIndex = 3;
            this.picThumbnail.TabStop = false;
            // 
            // pnlImageLeft
            // 
            this.pnlImageLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlImageLeft.Location = new System.Drawing.Point(0, 0);
            this.pnlImageLeft.Name = "pnlImageLeft";
            this.pnlImageLeft.Size = new System.Drawing.Size(10, 50);
            this.pnlImageLeft.TabIndex = 4;
            // 
            // pnlImageCenter
            // 
            this.pnlImageCenter.Controls.Add(this.picThumbnail);
            this.pnlImageCenter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlImageCenter.Location = new System.Drawing.Point(10, 0);
            this.pnlImageCenter.Name = "pnlImageCenter";
            this.pnlImageCenter.Size = new System.Drawing.Size(33, 50);
            this.pnlImageCenter.TabIndex = 4;
            // 
            // PlaylistSelectionButton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BackgroundImage = global::Celafy.Properties.Resources.button;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.pnlImage);
            this.DoubleBuffered = true;
            this.Name = "PlaylistSelectionButton";
            this.Size = new System.Drawing.Size(150, 50);
            this.Load += new System.EventHandler(this.PlaylistSelectionButton_Load);
            this.pnlImage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picThumbnail)).EndInit();
            this.pnlImageCenter.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlImage;
        private System.Windows.Forms.PictureBox picThumbnail;
        private System.Windows.Forms.Panel pnlImageLeft;
        private System.Windows.Forms.Panel pnlImageCenter;
    }
}
