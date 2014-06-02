using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WMPLib;

namespace YAM
{
    public partial class Form1 : Form
    {
        private string[] path;
        private int now = 0, max = 0;
        Random rand = new Random();

        public Form1()
        {
            InitializeComponent();
            wmp.Visible = false;
            wmp.settings.autoStart = false;
        }

        public void LoadPlaylist(String[] playlist)
        {
            wmp.Ctlcontrols.stop();
        }

        private void btopen_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                int i = 0;
                var files = openFileDialog.SafeFileNames;
                path = openFileDialog.FileNames;
                
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

                foreach (var item in files)
                {
                    dgvsongs.Rows.Add(1);
                    dgvsongs.Rows[i].Cells[1].Value = item.ToString();
                    i++;
                }
            }
        }

        private void dgvsongs_SelectionChanged(object sender, EventArgs e)
        {    
            if (dgvsongs.SelectedCells.Count > 0)
            {
                int selectedrowindex = dgvsongs.SelectedCells[1].RowIndex;
                
                wmp.URL = path[selectedrowindex];
                tmruntime.Enabled = true;
            }
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
                dgvsongs.Rows[dgvsongs.SelectedCells[1].RowIndex -1].Selected = true;

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
            }
            else
            {
                wmp.settings.mute = false;
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
                now = Convert.ToInt32(wmp.Ctlcontrols.currentPosition);
                tbruntime.Value = now;
                lbruntimenow.Text = "Now: " + Convert.ToString(now);

                max = Convert.ToInt32(wmp.currentMedia.duration);
                tbruntime.Maximum = max;
                lbruntimemax.Text = "Max: " + Convert.ToString(max);    //in sec. abspeichern und in min. anzeigen
            }

            // Nächstes Lied spielen
            if ((now == max-1) && (now != 0) && (max != 0)) // kleiner puffer
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
