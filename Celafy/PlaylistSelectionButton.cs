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

        private class ProprietaTesto
        {
            private string Default;
            private string testo;
            private int i;
            private int v;
            private bool b;

            public ProprietaTesto(string DEFAULT)
            {
                Default = DEFAULT;
                Testo = DEFAULT;
            }

            public void Reset()
            {
                i = 0;
                v = 1;
                b = false;
            }

            public string DEFAULT { get => Default; }
            public string Testo { get => testo; set => testo = value; }

            public int index { get => i; set => i = value; }
            public int vel { get => v; set => v = value; }
            public bool stato { get => b; set => b = value; }
        }

        private ProprietaTesto nome, autore;

        #endregion

        #region COSTRUTTORE/METODI

        public PlaylistSelectionButton()
        {
            nome = new ProprietaTesto("Nome");
            autore = new ProprietaTesto("Autore");

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
            lblNome.Text   = String.IsNullOrEmpty(nome.Testo)   ?   nome.DEFAULT : nome.Testo;
            lblAutore.Text = String.IsNullOrEmpty(autore.Testo) ? autore.DEFAULT : autore.Testo;
        }

        #endregion

        #region EVENTI

        private void UpdateText(object sender, EventArgs e)
        {
            nome.Reset();
            autore.Reset();
            tmrScorrimento.Start();
        }

        private void DontUpdateText(object sender, EventArgs e)
        {
            tmrScorrimento.Stop();
            UpdateInfo();
        }

        private void tmrScorrimento_Tick(object sender, EventArgs e)
        {
            if (TextRenderer.MeasureText(lblNome.Text, lblNome.Font).Width > LABEL_MAX_WIDTH || nome.stato)
            {
                lblNome.Text = nome.Testo.Substring(nome.index);
            }
            else
            {
                nome.vel = -nome.vel;
                nome.stato = true;
            }
            if (lblNome.Text == nome.Testo && nome.stato)
            {
                nome.stato = false;
                nome.vel -= nome.vel;
            }

            if (TextRenderer.MeasureText(lblAutore.Text, lblAutore.Font).Width > LABEL_MAX_WIDTH || autore.stato)
            {
                lblAutore.Text = autore.Testo.Substring(autore.index);
            }
            else
            {
                autore.vel = -autore.vel;
                autore.stato = true;
            }
            if (lblAutore.Text == autore.Testo && autore.stato)
            {
                autore.stato = false;
                autore.vel -= autore.vel;
            }

            nome.index += nome.vel;
            autore.index += autore.vel;
        }

        #endregion

        #region PROPRIETA'

        public string Nome   { get => nome.Testo;   set => nome.Testo = value; }
        public string Autore { get => autore.Testo; set => autore.Testo = value; }

        #endregion
    }
}
