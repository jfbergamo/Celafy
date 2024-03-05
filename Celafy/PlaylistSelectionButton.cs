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

        #region ATTRIBUTI

        private const int LABEL_MAX_WIDTH = 87;

        private const string DEFAULT_NOME   = "Nome";
        private const string DEFAULT_AUTORE = "Autore";

        private string nome, autore;

        #endregion

        #region COSTRUTTORE/METODI

        public PlaylistSelectionButton()
        {
            InitializeComponent();
        }

        private void PlaylistSelectionButton_Load(object sender, EventArgs e)
        {
        }

        public void Test()
        {
            Nome = "bimba carboncino";
            Autore = "cinquecellularinellatutagoldbabynonrichiamerò";
            UpdateInfo();
        }

        private void UpdateInfo()
        {
            lblNome.Text   = String.IsNullOrEmpty(nome)   ? DEFAULT_NOME   : nome;
            lblAutore.Text = String.IsNullOrEmpty(autore) ? DEFAULT_AUTORE : autore;
        }

        #endregion

        #region EVENTI

        private void UpdateText(object sender, EventArgs e)
        {
            tmrScorrimento.Start();
        }

        private void DontUpdateText(object sender, EventArgs e)
        {
            tmrScorrimento.Stop();
            UpdateInfo();
        }

        private void tmrScorrimento_Tick(object sender, EventArgs e)
        {
            if (TextRenderer.MeasureText(lblNome.Text, lblNome.Font).Width > LABEL_MAX_WIDTH)
            {
                lblNome.Text = lblNome.Text.Substring(1);
            }
            if (TextRenderer.MeasureText(lblAutore.Text, lblAutore.Font).Width > LABEL_MAX_WIDTH)
            {
                lblAutore.Text = lblAutore.Text.Substring(1);
            }
        }

        #endregion

        #region PROPRIETA'

        public string Nome { get => nome; set => nome = value; }
        public string Autore { get => autore; set => autore = value; }

        #endregion
    }
}
