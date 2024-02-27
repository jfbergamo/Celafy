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
            this.pnlImageDown = new System.Windows.Forms.Panel();
            this.pnlImageUp = new System.Windows.Forms.Panel();
            this.pnlImage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picThumbnail)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlImage
            // 
            this.pnlImage.Controls.Add(this.picThumbnail);
            this.pnlImage.Controls.Add(this.pnlImageDown);
            this.pnlImage.Controls.Add(this.pnlImageUp);
            this.pnlImage.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlImage.Location = new System.Drawing.Point(0, 0);
            this.pnlImage.Name = "pnlImage";
            this.pnlImage.Size = new System.Drawing.Size(85, 150);
            this.pnlImage.TabIndex = 0;
            // 
            // picThumbnail
            // 
            this.picThumbnail.BackgroundImage = global::Celafy.Properties.Resources.PlaylistDefault;
            this.picThumbnail.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picThumbnail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picThumbnail.Location = new System.Drawing.Point(0, 42);
            this.picThumbnail.Name = "picThumbnail";
            this.picThumbnail.Size = new System.Drawing.Size(85, 63);
            this.picThumbnail.TabIndex = 3;
            this.picThumbnail.TabStop = false;
            // 
            // pnlImageDown
            // 
            this.pnlImageDown.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlImageDown.Location = new System.Drawing.Point(0, 105);
            this.pnlImageDown.Name = "pnlImageDown";
            this.pnlImageDown.Size = new System.Drawing.Size(85, 45);
            this.pnlImageDown.TabIndex = 2;
            // 
            // pnlImageUp
            // 
            this.pnlImageUp.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlImageUp.Location = new System.Drawing.Point(0, 0);
            this.pnlImageUp.Name = "pnlImageUp";
            this.pnlImageUp.Size = new System.Drawing.Size(85, 42);
            this.pnlImageUp.TabIndex = 0;
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
            this.Size = new System.Drawing.Size(300, 150);
            this.Load += new System.EventHandler(this.PlaylistSelectionButton_Load);
            this.pnlImage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picThumbnail)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlImage;
        private System.Windows.Forms.PictureBox picThumbnail;
        private System.Windows.Forms.Panel pnlImageDown;
        private System.Windows.Forms.Panel pnlImageUp;
    }
}
