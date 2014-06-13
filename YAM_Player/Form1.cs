using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WMPLib;

namespace YAM_Player
{
    public partial class UserControl1 : Form
    {
        private int inow = 0, imax = 0;
        Random rand = new Random();
        private string[,] playlist;
        
        public UserControl1()
        {
            InitializeComponent();
            
            wmp.Visible = false;
            wmp.settings.autoStart = false;
            // Nur zum Testen
            /*testclass ts = new testclass();
            playlist = ts.getplaylisttest();
            setPlaylist(playlist);*/
        }

        public void setPlaylist(String[,] playlist)
        {
            int i = 0;
            int y = playlist.GetLength(0);
            wmp.Ctlcontrols.stop();

            do
            {
                foreach (DataGridViewRow row in dgvsongs.Rows)
                {
                    try
                    {
                        dgvsongs.Rows.Remove(row);  // löscht die alten Einträge in der Liste
                    }
                    catch (Exception)
                    {
                    }
                }
            } while (dgvsongs.Rows.Count > 0);

            for (i=0; i<y; i++)
            {
                dgvsongs.Rows.Add(1);
                dgvsongs.Rows[i].Cells[0].Value = i.ToString();
                dgvsongs.Rows[i].Cells[1].Value = playlist[i, 1];
                dgvsongs.Rows[i].Cells[2].Value = playlist[i, 2];
                dgvsongs.Rows[i].Cells[3].Value = playlist[i, 3];
            }
        }

        private void dgvsongs_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvsongs.SelectedCells.Count > 0)
            {
                int selectedrowindex = dgvsongs.SelectedCells[1].RowIndex;

                wmp.URL = playlist[selectedrowindex, 0];
                tmruntime.Enabled = true;
            }
        }

        private void dgvsongs_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            wmp.Ctlcontrols.play();
            tmruntime.Enabled = true;
        }

        private void tbvolume_Scroll(object sender, EventArgs e)
        {
            wmp.settings.volume = tbvolume.Value;
        }

        private void btstop_Click(object sender, EventArgs e)
        {
            tmruntime.Enabled = false;
            tbruntime.Value = 0;
            lbruntimenow.Text = "Now: -";
            lbruntimemax.Text = "Max: -";
            wmp.Ctlcontrols.stop();
        }

        private void btprevious_Click(object sender, EventArgs e)
        {
            if (dgvsongs.SelectedCells[1].RowIndex >= 1)
                dgvsongs.Rows[dgvsongs.SelectedCells[1].RowIndex - 1].Selected = true;

            wmp.Ctlcontrols.play();

            tmruntime.Enabled = true;
        }

        private void btnext_Click(object sender, EventArgs e)
        {
            int count = dgvsongs.Rows.Count - 2;

            if (dgvsongs.SelectedCells[1].RowIndex <= count)
                dgvsongs.Rows[dgvsongs.SelectedCells[1].RowIndex + 1].Selected = true;

            wmp.Ctlcontrols.play();

            tmruntime.Enabled = true;
        }

        private void btmute_Click(object sender, EventArgs e)
        {
            if (wmp.settings.mute == false)
            {
                wmp.settings.mute = true;
                btmute.BackgroundImage = Properties.Resources.speaker_bt_off;
            }
            else
            {
                wmp.settings.mute = false;
                btmute.BackgroundImage = Properties.Resources.speaker_bt_on;
            }
        }

        private void btpause_Click(object sender, EventArgs e)
        {
            tmruntime.Enabled = false;
            wmp.Ctlcontrols.pause();
        }

        private void btplay_Click_(object sender, EventArgs e)
        {
            wmp.Ctlcontrols.play();
            tmruntime.Enabled = true;
        }

        private void tbruntime_Scroll(object sender, EventArgs e)
        {
            wmp.Ctlcontrols.currentPosition = tbruntime.Value;
        }

        private void tmruntime_Tick(object sender, EventArgs e)
        {
            if (wmp.playState == WMPPlayState.wmppsPlaying)
            {
                // Laufzeit Anzeigen
                inow = Convert.ToInt32(wmp.Ctlcontrols.currentPosition);
                tbruntime.Value = inow; // Scrollbar setzen aktuell
                TimeSpan resultn = TimeSpan.FromSeconds(inow);
                string fromTimeStringn = resultn.ToString("mm':'ss");
                lbruntimenow.Text = "Now: " + fromTimeStringn;  // in min. : sec. anzeigen

                imax = Convert.ToInt32(wmp.currentMedia.duration);
                tbruntime.Maximum = imax; // Scrollbar setzen maximum
                TimeSpan resultm = TimeSpan.FromSeconds(imax);
                string fromTimeStringm = resultm.ToString("mm':'ss");
                lbruntimemax.Text = "Max: " + fromTimeStringm;  // in min. : sec. anzeigen
            }

            // Nächstes Lied spielen
            if ((inow == imax - 1) && (inow != 0) && (imax != 0)) // kleiner puffer
            {
                if (cbrand.Checked == false)
                {
                    int count = dgvsongs.Rows.Count - 2;

                    if (dgvsongs.SelectedCells[1].RowIndex <= count)
                        dgvsongs.Rows[dgvsongs.SelectedCells[1].RowIndex + 1].Selected = true;

                    wmp.Ctlcontrols.play();
                }
                else
                {
                    int irand = rand.Next(1, dgvsongs.Rows.Count);

                    dgvsongs.Rows[irand].Selected = true;

                    wmp.Ctlcontrols.play();
                }
            }
        }
    }
}
