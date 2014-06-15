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
    public partial class UserControl1 : UserControl
    {
        private int inow = 0, imax = 0;
        Random rand = new Random();
        private List<Playlist> playlist = new List<Playlist>();

        // Notwendiges Event um der WPF Anwendung eine Änderung mitzuteilen
        public Action<Playlist> TriggerUpdateTitleEntry;   //Mod by Christian

        // Notwendig um auf die Methoden zugreifen zu können
        public UserControl1 GetUserControl() { return this; }   //Mod by Christian

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

        public void setPlaylist(List<Playlist> playlist)
        {
            int y = playlist.Count;
            wmp.Ctlcontrols.stop();

            dgvsongs.Rows.Clear();  // löscht die alten Einträge in der Liste

            for (int i = 0; i < y; i++)
            {
                dgvsongs.Rows.Add(1);
                dgvsongs.Rows[i].Cells[0].Value = (i + 1).ToString();   //Mod by Christian
                dgvsongs.Rows[i].Cells[1].Value = playlist[i].Titlename;
                dgvsongs.Rows[i].Cells[2].Value = playlist[i].Bitrate;
                dgvsongs.Rows[i].Cells[3].Value = new TimeSpan((long)playlist[i].Playtime).ToString(@"mm\:ss");   //Mod by Christian
            }

            // Interne Liste wurde nicht befüllt
            this.playlist = playlist;   //Mod by Christian
        }

        private void dgvsongs_SelectionChanged(object sender, EventArgs e)
        {
            //if (dgvsongs.SelectedCells.Count > 0)
            if (dgvsongs.SelectedRows.Count > 0)   //Mod by Christian
            {
                int selectedrowindex = dgvsongs.SelectedCells[1].RowIndex;

                // Fehler beim Einfügen von Zeilen beim verwenden der setPlaylist Methode
                if (playlist.Count > 0)   //Mod by Christian
                {
                    wmp.URL = playlist[selectedrowindex].Filepath;
                    TriggerUpdateTitleEntry(playlist[selectedrowindex]);
                    tmruntime.Enabled = true;
                }
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
            if (dgvsongs.SelectedCells.Count > 0)
            {
                if (dgvsongs.SelectedCells[1].RowIndex >= 1)
                    dgvsongs.Rows[dgvsongs.SelectedCells[1].RowIndex - 1].Selected = true;

                wmp.Ctlcontrols.play();

                tmruntime.Enabled = true;
            }
        }

        private void btnext_Click(object sender, EventArgs e)
        {
            if (dgvsongs.SelectedCells.Count > 0)
            {
                int count = dgvsongs.Rows.Count - 2;

                if (dgvsongs.SelectedCells[1].RowIndex <= count)
                    dgvsongs.Rows[dgvsongs.SelectedCells[1].RowIndex + 1].Selected = true;

                wmp.Ctlcontrols.play();

                tmruntime.Enabled = true;
            }
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
