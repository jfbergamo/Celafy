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
    public partial class frmPlayer : Form
    {
        public frmPlayer()
        {
            //byte[] data = Images.ImageToBytes(Image.FromFile("..\\..\\src\\buttonClick.png"));

            //string dataStr = "";
            //foreach (byte b in data)
            //{
            //    dataStr += (char)b;
            //}

            //Application.Exit();
            InitializeComponent();
        }

        private void FormLoad(object sender, EventArgs e)
        {
            // 12, 17
            const int SETTE = 7;

            string[] nomiPL = {
                "Mic Trvp",
                "Aspettando SportWeek 2024",
                "bimba carboncino",
                "s°tt°f°nd°",
                "Mic SportWeek",
                "SportWeeeeeeeeeeekkkkkkkkkkkk",
                "SportWeek 2023",
                "Mic €DM",
                "KESTECCA"
            };

            string[] autoriPL =
            {
                "J",
                "TwoSportWeek",
                "J",
                "J",
                "J",
                "J",
                "TwoSportWeek",
                "TwoSportWeek",
                "J",
                "J"
            };

            for (int i = 0; i < SETTE + 2; ++i)
            {
                PlaylistSelectionButton psb = new PlaylistSelectionButton();
                psb.Location = new Point(12, 17 + (i * (psb.Size.Height + 17)));
                psb.Nome = nomiPL[i];
                psb.Autore = autoriPL[i];
                pnlPlaylistSelector.Controls.Add(psb);
            }
        }
    }
}
