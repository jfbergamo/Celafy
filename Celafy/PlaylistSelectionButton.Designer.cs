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
            this.components = new System.ComponentModel.Container();
            this.pnlImage = new System.Windows.Forms.Panel();
            this.pnlImageCenter = new System.Windows.Forms.Panel();
            this.picThumbnail = new System.Windows.Forms.PictureBox();
            this.pnlImageLeft = new System.Windows.Forms.Panel();
            this.pnlButtonFill = new System.Windows.Forms.Panel();
            this.lblAutore = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.pnlButtonRight = new System.Windows.Forms.Panel();
            this.tmrNome = new System.Windows.Forms.Timer(this.components);
            this.tmrAutore = new System.Windows.Forms.Timer(this.components);
            this.pnlImage.SuspendLayout();
            this.pnlImageCenter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picThumbnail)).BeginInit();
            this.pnlButtonFill.SuspendLayout();
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
            // pnlImageCenter
            // 
            this.pnlImageCenter.Controls.Add(this.picThumbnail);
            this.pnlImageCenter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlImageCenter.Location = new System.Drawing.Point(10, 0);
            this.pnlImageCenter.Name = "pnlImageCenter";
            this.pnlImageCenter.Size = new System.Drawing.Size(33, 50);
            this.pnlImageCenter.TabIndex = 4;
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
            // pnlButtonFill
            // 
            this.pnlButtonFill.Controls.Add(this.lblAutore);
            this.pnlButtonFill.Controls.Add(this.lblNome);
            this.pnlButtonFill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlButtonFill.Location = new System.Drawing.Point(43, 0);
            this.pnlButtonFill.Name = "pnlButtonFill";
            this.pnlButtonFill.Size = new System.Drawing.Size(93, 50);
            this.pnlButtonFill.TabIndex = 3;
            // 
            // lblAutore
            // 
            this.lblAutore.AutoSize = true;
            this.lblAutore.Font = new System.Drawing.Font("Cascadia Code", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAutore.ForeColor = System.Drawing.SystemColors.Control;
            this.lblAutore.Location = new System.Drawing.Point(6, 30);
            this.lblAutore.Name = "lblAutore";
            this.lblAutore.Size = new System.Drawing.Size(13, 13);
            this.lblAutore.TabIndex = 4;
            this.lblAutore.Text = DEFAULT_AUTORE;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Cascadia Code SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.ForeColor = System.Drawing.SystemColors.Control;
            this.lblNome.Location = new System.Drawing.Point(6, 9);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(119, 16);
            this.lblNome.TabIndex = 3;
            this.lblNome.Text = DEFAULT_NOME;
            // 
            // pnlButtonRight
            // 
            this.pnlButtonRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlButtonRight.Location = new System.Drawing.Point(136, 0);
            this.pnlButtonRight.Name = "pnlButtonRight";
            this.pnlButtonRight.Size = new System.Drawing.Size(14, 50);
            this.pnlButtonRight.TabIndex = 5;
            // 
            // tmrNome
            // 
            this.tmrNome.Interval = 1000;
            this.tmrNome.Tick += new System.EventHandler(this.tmrNome_Tick);
            // 
            // tmrAutore
            // 
            this.tmrAutore.Interval = 1000;
            // 
            // PlaylistSelectionButton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BackgroundImage = global::Celafy.Properties.Resources.button;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.pnlButtonFill);
            this.Controls.Add(this.pnlImage);
            this.Controls.Add(this.pnlButtonRight);
            this.DoubleBuffered = true;
            this.Name = "PlaylistSelectionButton";
            this.Size = new System.Drawing.Size(150, 50);
            this.Load += new System.EventHandler(this.PlaylistSelectionButton_Load);
            this.pnlImage.ResumeLayout(false);
            this.pnlImageCenter.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picThumbnail)).EndInit();
            this.pnlButtonFill.ResumeLayout(false);
            this.pnlButtonFill.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlImage;
        private System.Windows.Forms.PictureBox picThumbnail;
        private System.Windows.Forms.Panel pnlImageLeft;
        private System.Windows.Forms.Panel pnlImageCenter;
        private System.Windows.Forms.Panel pnlButtonFill;
        private System.Windows.Forms.Panel pnlButtonRight;
        private System.Windows.Forms.Label lblAutore;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Timer tmrNome;
        private System.Windows.Forms.Timer tmrAutore;
    }
}
