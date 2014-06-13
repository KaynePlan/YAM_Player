namespace YAM_Player
{
    partial class UserControl1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControl1));
            this.tbvolume = new System.Windows.Forms.TrackBar();
            this.lbvolume = new System.Windows.Forms.Label();
            this.tbruntime = new System.Windows.Forms.TrackBar();
            this.lbruntime = new System.Windows.Forms.Label();
            this.tmruntime = new System.Windows.Forms.Timer(this.components);
            this.lbruntimenow = new System.Windows.Forms.Label();
            this.lbruntimemax = new System.Windows.Forms.Label();
            this.dgvsongs = new System.Windows.Forms.DataGridView();
            this.ColId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColTitlename = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColBitrate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColDuration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbrand = new System.Windows.Forms.CheckBox();
            this.wmp = new AxWMPLib.AxWindowsMediaPlayer();
            this.btpause = new System.Windows.Forms.Button();
            this.btmute = new System.Windows.Forms.Button();
            this.btnext = new System.Windows.Forms.Button();
            this.btprevious = new System.Windows.Forms.Button();
            this.btstop = new System.Windows.Forms.Button();
            this.btplay = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tbvolume)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbruntime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvsongs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wmp)).BeginInit();
            this.SuspendLayout();
            // 
            // tbvolume
            // 
            this.tbvolume.Location = new System.Drawing.Point(528, 6);
            this.tbvolume.Maximum = 100;
            this.tbvolume.Name = "tbvolume";
            this.tbvolume.Size = new System.Drawing.Size(108, 45);
            this.tbvolume.TabIndex = 9;
            this.tbvolume.Value = 50;
            this.tbvolume.Scroll += new System.EventHandler(this.tbvolume_Scroll);
            // 
            // lbvolume
            // 
            this.lbvolume.AutoSize = true;
            this.lbvolume.Location = new System.Drawing.Point(477, 15);
            this.lbvolume.Name = "lbvolume";
            this.lbvolume.Size = new System.Drawing.Size(45, 13);
            this.lbvolume.TabIndex = 8;
            this.lbvolume.Text = "Volume:";
            // 
            // tbruntime
            // 
            this.tbruntime.Location = new System.Drawing.Point(296, 6);
            this.tbruntime.Maximum = 100;
            this.tbruntime.Name = "tbruntime";
            this.tbruntime.Size = new System.Drawing.Size(108, 45);
            this.tbruntime.TabIndex = 12;
            this.tbruntime.Scroll += new System.EventHandler(this.tbruntime_Scroll);
            // 
            // lbruntime
            // 
            this.lbruntime.AutoSize = true;
            this.lbruntime.Location = new System.Drawing.Point(241, 15);
            this.lbruntime.Name = "lbruntime";
            this.lbruntime.Size = new System.Drawing.Size(49, 13);
            this.lbruntime.TabIndex = 13;
            this.lbruntime.Text = "Runtime:";
            // 
            // tmruntime
            // 
            this.tmruntime.Interval = 1000;
            this.tmruntime.Tick += new System.EventHandler(this.tmruntime_Tick);
            // 
            // lbruntimenow
            // 
            this.lbruntimenow.AutoSize = true;
            this.lbruntimenow.Location = new System.Drawing.Point(410, 9);
            this.lbruntimenow.Name = "lbruntimenow";
            this.lbruntimenow.Size = new System.Drawing.Size(36, 13);
            this.lbruntimenow.TabIndex = 14;
            this.lbruntimenow.Text = "now: -";
            // 
            // lbruntimemax
            // 
            this.lbruntimemax.AutoSize = true;
            this.lbruntimemax.Location = new System.Drawing.Point(410, 22);
            this.lbruntimemax.Name = "lbruntimemax";
            this.lbruntimemax.Size = new System.Drawing.Size(35, 13);
            this.lbruntimemax.TabIndex = 15;
            this.lbruntimemax.Text = "max: -";
            // 
            // dgvsongs
            // 
            this.dgvsongs.AllowUserToAddRows = false;
            this.dgvsongs.AllowUserToDeleteRows = false;
            this.dgvsongs.BackgroundColor = System.Drawing.Color.White;
            this.dgvsongs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvsongs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColId,
            this.ColTitlename,
            this.ColBitrate,
            this.ColDuration});
            this.dgvsongs.GridColor = System.Drawing.Color.Black;
            this.dgvsongs.Location = new System.Drawing.Point(12, 48);
            this.dgvsongs.MultiSelect = false;
            this.dgvsongs.Name = "dgvsongs";
            this.dgvsongs.ReadOnly = true;
            this.dgvsongs.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dgvsongs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvsongs.Size = new System.Drawing.Size(624, 104);
            this.dgvsongs.TabIndex = 17;
            this.dgvsongs.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvsongs_CellDoubleClick);
            this.dgvsongs.SelectionChanged += new System.EventHandler(this.dgvsongs_SelectionChanged);
            // 
            // ColId
            // 
            this.ColId.FillWeight = 20F;
            this.ColId.HeaderText = "#";
            this.ColId.Name = "ColId";
            this.ColId.ReadOnly = true;
            this.ColId.Width = 20;
            // 
            // ColTitlename
            // 
            this.ColTitlename.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColTitlename.HeaderText = "Titlename";
            this.ColTitlename.Name = "ColTitlename";
            this.ColTitlename.ReadOnly = true;
            // 
            // ColBitrate
            // 
            this.ColBitrate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColBitrate.FillWeight = 50F;
            this.ColBitrate.HeaderText = "Bitrate";
            this.ColBitrate.Name = "ColBitrate";
            this.ColBitrate.ReadOnly = true;
            // 
            // ColDuration
            // 
            this.ColDuration.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColDuration.FillWeight = 50F;
            this.ColDuration.HeaderText = "Duration";
            this.ColDuration.Name = "ColDuration";
            this.ColDuration.ReadOnly = true;
            // 
            // cbrand
            // 
            this.cbrand.AutoSize = true;
            this.cbrand.Location = new System.Drawing.Point(169, 14);
            this.cbrand.Name = "cbrand";
            this.cbrand.Size = new System.Drawing.Size(66, 17);
            this.cbrand.TabIndex = 18;
            this.cbrand.Text = "Random";
            this.cbrand.UseVisualStyleBackColor = true;
            // 
            // wmp
            // 
            this.wmp.Enabled = true;
            this.wmp.Location = new System.Drawing.Point(543, 129);
            this.wmp.Name = "wmp";
            this.wmp.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("wmp.OcxState")));
            this.wmp.Size = new System.Drawing.Size(75, 23);
            this.wmp.TabIndex = 20;
            // 
            // btpause
            // 
            this.btpause.BackColor = System.Drawing.Color.Transparent;
            this.btpause.BackgroundImage = global::YAM_Player.Properties.Resources.pause_bt;
            this.btpause.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btpause.FlatAppearance.BorderSize = 0;
            this.btpause.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btpause.Location = new System.Drawing.Point(65, 12);
            this.btpause.Name = "btpause";
            this.btpause.Size = new System.Drawing.Size(20, 19);
            this.btpause.TabIndex = 11;
            this.btpause.UseVisualStyleBackColor = false;
            this.btpause.Click += new System.EventHandler(this.btpause_Click);
            // 
            // btmute
            // 
            this.btmute.BackColor = System.Drawing.Color.Transparent;
            this.btmute.BackgroundImage = global::YAM_Player.Properties.Resources.speaker_bt_on;
            this.btmute.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btmute.FlatAppearance.BorderSize = 0;
            this.btmute.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btmute.Location = new System.Drawing.Point(143, 12);
            this.btmute.Name = "btmute";
            this.btmute.Size = new System.Drawing.Size(20, 19);
            this.btmute.TabIndex = 10;
            this.btmute.UseVisualStyleBackColor = false;
            this.btmute.Click += new System.EventHandler(this.btmute_Click);
            // 
            // btnext
            // 
            this.btnext.BackColor = System.Drawing.Color.Transparent;
            this.btnext.BackgroundImage = global::YAM_Player.Properties.Resources.next_bt;
            this.btnext.FlatAppearance.BorderSize = 0;
            this.btnext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnext.Location = new System.Drawing.Point(117, 12);
            this.btnext.Name = "btnext";
            this.btnext.Size = new System.Drawing.Size(20, 19);
            this.btnext.TabIndex = 6;
            this.btnext.UseVisualStyleBackColor = false;
            this.btnext.Click += new System.EventHandler(this.btnext_Click);
            // 
            // btprevious
            // 
            this.btprevious.BackColor = System.Drawing.Color.Transparent;
            this.btprevious.BackgroundImage = global::YAM_Player.Properties.Resources.previous_bt;
            this.btprevious.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btprevious.FlatAppearance.BorderSize = 0;
            this.btprevious.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btprevious.Location = new System.Drawing.Point(91, 12);
            this.btprevious.Name = "btprevious";
            this.btprevious.Size = new System.Drawing.Size(20, 19);
            this.btprevious.TabIndex = 5;
            this.btprevious.UseVisualStyleBackColor = false;
            this.btprevious.Click += new System.EventHandler(this.btprevious_Click);
            // 
            // btstop
            // 
            this.btstop.BackColor = System.Drawing.Color.Transparent;
            this.btstop.BackgroundImage = global::YAM_Player.Properties.Resources.stop_bt;
            this.btstop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btstop.FlatAppearance.BorderSize = 0;
            this.btstop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btstop.Location = new System.Drawing.Point(13, 12);
            this.btstop.Name = "btstop";
            this.btstop.Size = new System.Drawing.Size(20, 19);
            this.btstop.TabIndex = 4;
            this.btstop.UseVisualStyleBackColor = false;
            this.btstop.Click += new System.EventHandler(this.btstop_Click);
            // 
            // btplay
            // 
            this.btplay.BackColor = System.Drawing.Color.Transparent;
            this.btplay.BackgroundImage = global::YAM_Player.Properties.Resources.play_bt;
            this.btplay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btplay.FlatAppearance.BorderSize = 0;
            this.btplay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btplay.Location = new System.Drawing.Point(39, 12);
            this.btplay.Name = "btplay";
            this.btplay.Size = new System.Drawing.Size(20, 19);
            this.btplay.TabIndex = 3;
            this.btplay.UseVisualStyleBackColor = false;
            this.btplay.Click += new System.EventHandler(this.btplay_Click_);
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(648, 159);
            this.Controls.Add(this.wmp);
            this.Controls.Add(this.cbrand);
            this.Controls.Add(this.dgvsongs);
            this.Controls.Add(this.lbruntimemax);
            this.Controls.Add(this.lbruntimenow);
            this.Controls.Add(this.lbruntime);
            this.Controls.Add(this.tbruntime);
            this.Controls.Add(this.btpause);
            this.Controls.Add(this.btmute);
            this.Controls.Add(this.lbvolume);
            this.Controls.Add(this.tbvolume);
            this.Controls.Add(this.btnext);
            this.Controls.Add(this.btprevious);
            this.Controls.Add(this.btstop);
            this.Controls.Add(this.btplay);
            this.Name = "UserControl1";
            this.Text = "YAM";
            ((System.ComponentModel.ISupportInitialize)(this.tbvolume)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbruntime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvsongs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wmp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btplay;
        private System.Windows.Forms.Button btstop;
        private System.Windows.Forms.Button btprevious;
        private System.Windows.Forms.Button btnext;
        private System.Windows.Forms.TrackBar tbvolume;
        private System.Windows.Forms.Label lbvolume;
        private System.Windows.Forms.Button btmute;
        private System.Windows.Forms.Button btpause;
        private System.Windows.Forms.TrackBar tbruntime;
        private System.Windows.Forms.Label lbruntime;
        private System.Windows.Forms.Timer tmruntime;
        private System.Windows.Forms.Label lbruntimenow;
        private System.Windows.Forms.Label lbruntimemax;
        private System.Windows.Forms.DataGridView dgvsongs;
        private System.Windows.Forms.CheckBox cbrand;
        private AxWMPLib.AxWindowsMediaPlayer wmp;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTitlename;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColBitrate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColDuration;
    }
}

