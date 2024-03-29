﻿namespace Celafy
{
    partial class frmPlayer
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

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlPlaying = new System.Windows.Forms.Panel();
            this.pnlCenter = new System.Windows.Forms.Panel();
            this.pnlTrackSelector = new System.Windows.Forms.Panel();
            this.pnlSearch = new System.Windows.Forms.Panel();
            this.pnlPlaylistSelector = new System.Windows.Forms.Panel();
            this.menu = new System.Windows.Forms.MenuStrip();
            this.shoahToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlCenter.SuspendLayout();
            this.menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlPlaying
            // 
            this.pnlPlaying.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlPlaying.Location = new System.Drawing.Point(0, 390);
            this.pnlPlaying.Name = "pnlPlaying";
            this.pnlPlaying.Size = new System.Drawing.Size(800, 60);
            this.pnlPlaying.TabIndex = 1;
            // 
            // pnlCenter
            // 
            this.pnlCenter.Controls.Add(this.pnlTrackSelector);
            this.pnlCenter.Controls.Add(this.pnlSearch);
            this.pnlCenter.Controls.Add(this.pnlPlaylistSelector);
            this.pnlCenter.Controls.Add(this.menu);
            this.pnlCenter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCenter.Location = new System.Drawing.Point(0, 0);
            this.pnlCenter.Name = "pnlCenter";
            this.pnlCenter.Size = new System.Drawing.Size(800, 390);
            this.pnlCenter.TabIndex = 2;
            // 
            // pnlTrackSelector
            // 
            this.pnlTrackSelector.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTrackSelector.Location = new System.Drawing.Point(193, 68);
            this.pnlTrackSelector.Name = "pnlTrackSelector";
            this.pnlTrackSelector.Size = new System.Drawing.Size(607, 322);
            this.pnlTrackSelector.TabIndex = 3;
            // 
            // pnlSearch
            // 
            this.pnlSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSearch.Location = new System.Drawing.Point(193, 24);
            this.pnlSearch.Name = "pnlSearch";
            this.pnlSearch.Size = new System.Drawing.Size(607, 44);
            this.pnlSearch.TabIndex = 2;
            // 
            // pnlPlaylistSelector
            // 
            this.pnlPlaylistSelector.AutoScroll = true;
            this.pnlPlaylistSelector.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pnlPlaylistSelector.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlPlaylistSelector.Location = new System.Drawing.Point(0, 24);
            this.pnlPlaylistSelector.Name = "pnlPlaylistSelector";
            this.pnlPlaylistSelector.Size = new System.Drawing.Size(193, 366);
            this.pnlPlaylistSelector.TabIndex = 0;
            // 
            // menu
            // 
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.shoahToolStripMenuItem});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(800, 24);
            this.menu.TabIndex = 1;
            this.menu.Text = "menuStrip1";
            // 
            // shoahToolStripMenuItem
            // 
            this.shoahToolStripMenuItem.Name = "shoahToolStripMenuItem";
            this.shoahToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.shoahToolStripMenuItem.Text = "Shoah";
            // 
            // frmPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlCenter);
            this.Controls.Add(this.pnlPlaying);
            this.MainMenuStrip = this.menu;
            this.Name = "frmPlayer";
            this.Text = "Celafy Music Player";
            this.Load += new System.EventHandler(this.FormLoad);
            this.pnlCenter.ResumeLayout(false);
            this.pnlCenter.PerformLayout();
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlPlaying;
        private System.Windows.Forms.Panel pnlCenter;
        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem shoahToolStripMenuItem;
        private System.Windows.Forms.Panel pnlSearch;
        private System.Windows.Forms.Panel pnlTrackSelector;
        private System.Windows.Forms.Panel pnlPlaylistSelector;
    }
}

