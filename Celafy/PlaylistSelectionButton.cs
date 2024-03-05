using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Celafy
{
    public partial class PlaylistSelectionButton : UserControl
    {
        private const int LABEL_MAX_WIDTH = 87;

        private const string DEFAULT_NOME   = "Nome playlist";
        private const string DEFAULT_AUTORE = "Autore playlist";

        public PlaylistSelectionButton()
        {
            InitializeComponent();
        }

        private void PlaylistSelectionButton_Load(object sender, EventArgs e)
        {
        }

        public void Test()
        {
            UpdateInfo("bimba carboncino", "J");
        }

        private void UpdateInfo(string nome, string autore)
        {
            tmrNome.Stop();
            tmrAutore.Stop();

            lblNome.Text   = String.IsNullOrEmpty(nome)   ? DEFAULT_NOME   : nome;
            lblAutore.Text = String.IsNullOrEmpty(autore) ? DEFAULT_AUTORE : autore;
        
            if (TextRenderer.MeasureText(lblNome.Text, lblNome.Font).Width > LABEL_MAX_WIDTH)
            {
                tmrNome.Start();
            }
            if (TextRenderer.MeasureText(lblAutore.Text, lblAutore.Font).Width > LABEL_MAX_WIDTH)
            {
                tmrAutore.Start();
            }
        }

        private void tmrNome_Tick(object sender, EventArgs e)
        {
            if (lblNome.Text[lblNome.Text.Length - 1] != '\t')
                lblNome.Text += "\t";
            else
            {
                if (lblNome.Text[0] == '\t')
                    lblNome.Text = lblNome.Text.Substring(1);
                else
                    lblNome.Text = lblNome.Text.Substring(1) + lblNome.Text[0];
            }
        }
    }
}
