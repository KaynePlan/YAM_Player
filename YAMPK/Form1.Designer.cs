namespace YAM
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.btopen = new System.Windows.Forms.Button();
            this.btplay = new System.Windows.Forms.Button();
            this.btstop = new System.Windows.Forms.Button();
            this.btprevious = new System.Windows.Forms.Button();
            this.btnext = new System.Windows.Forms.Button();
            this.tbvolume = new System.Windows.Forms.TrackBar();
            this.lbvolume = new System.Windows.Forms.Label();
            this.btmute = new System.Windows.Forms.Button();
            this.btpause = new System.Windows.Forms.Button();
            this.tbruntime = new System.Windows.Forms.TrackBar();
            this.lbruntime = new System.Windows.Forms.Label();
            this.tmruntime = new System.Windows.Forms.Timer(this.components);
            this.lbruntimenow = new System.Windows.Forms.Label();
            this.lbruntimemax = new System.Windows.Forms.Label();
            this.wmp = new AxWMPLib.AxWindowsMediaPlayer();
            this.dgvsongs = new System.Windows.Forms.DataGridView();
            this.ColId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColTitlename = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColBitrate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColDuration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbrand = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.tbvolume)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbruntime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wmp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvsongs)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            this.openFileDialog.Multiselect = true;
            // 
            // btopen
            // 
            this.btopen.Location = new System.Drawing.Point(539, 105);
            this.btopen.Name = "btopen";
            this.btopen.Size = new System.Drawing.Size(75, 95);
            this.btopen.TabIndex = 2;
            this.btopen.Text = "Open";
            this.btopen.UseVisualStyleBackColor = true;
            this.btopen.Click += new System.EventHandler(this.btopen_Click);
            // 
            // btplay
            // 
            this.btplay.Location = new System.Drawing.Point(93, 12);
            this.btplay.Name = "btplay";
            this.btplay.Size = new System.Drawing.Size(75, 23);
            this.btplay.TabIndex = 3;
            this.btplay.Text = "Play";
            this.btplay.UseVisualStyleBackColor = true;
            this.btplay.Click += new System.EventHandler(this.btplay_Click_);
            // 
            // btstop
            // 
            this.btstop.Location = new System.Drawing.Point(12, 12);
            this.btstop.Name = "btstop";
            this.btstop.Size = new System.Drawing.Size(75, 23);
            this.btstop.TabIndex = 4;
            this.btstop.Text = "Stop";
            this.btstop.UseVisualStyleBackColor = true;
            this.btstop.Click += new System.EventHandler(this.btstop_Click);
            // 
            // btprevious
            // 
            this.btprevious.Location = new System.Drawing.Point(255, 12);
            this.btprevious.Name = "btprevious";
            this.btprevious.Size = new System.Drawing.Size(75, 23);
            this.btprevious.TabIndex = 5;
            this.btprevious.Text = "Previous";
            this.btprevious.UseVisualStyleBackColor = true;
            this.btprevious.Click += new System.EventHandler(this.btprevious_Click);
            // 
            // btnext
            // 
            this.btnext.Location = new System.Drawing.Point(336, 12);
            this.btnext.Name = "btnext";
            this.btnext.Size = new System.Drawing.Size(75, 23);
            this.btnext.TabIndex = 6;
            this.btnext.Text = "Next";
            this.btnext.UseVisualStyleBackColor = true;
            this.btnext.Click += new System.EventHandler(this.btnext_Click);
            // 
            // tbvolume
            // 
            this.tbvolume.Location = new System.Drawing.Point(397, 54);
            this.tbvolume.Maximum = 100;
            this.tbvolume.Name = "tbvolume";
            this.tbvolume.Size = new System.Drawing.Size(136, 45);
            this.tbvolume.TabIndex = 9;
            this.tbvolume.Value = 50;
            this.tbvolume.Scroll += new System.EventHandler(this.tbvolume_Scroll);
            // 
            // lbvolume
            // 
            this.lbvolume.AutoSize = true;
            this.lbvolume.Location = new System.Drawing.Point(346, 54);
            this.lbvolume.Name = "lbvolume";
            this.lbvolume.Size = new System.Drawing.Size(45, 13);
            this.lbvolume.TabIndex = 8;
            this.lbvolume.Text = "Volume:";
            // 
            // btmute
            // 
            this.btmute.Location = new System.Drawing.Point(12, 54);
            this.btmute.Name = "btmute";
            this.btmute.Size = new System.Drawing.Size(75, 23);
            this.btmute.TabIndex = 10;
            this.btmute.Text = "Mute";
            this.btmute.UseVisualStyleBackColor = true;
            this.btmute.Click += new System.EventHandler(this.btmute_Click);
            // 
            // btpause
            // 
            this.btpause.Location = new System.Drawing.Point(174, 12);
            this.btpause.Name = "btpause";
            this.btpause.Size = new System.Drawing.Size(75, 23);
            this.btpause.TabIndex = 11;
            this.btpause.Text = "Pause";
            this.btpause.UseVisualStyleBackColor = true;
            this.btpause.Click += new System.EventHandler(this.btpause_Click);
            // 
            // tbruntime
            // 
            this.tbruntime.Location = new System.Drawing.Point(148, 53);
            this.tbruntime.Maximum = 100;
            this.tbruntime.Name = "tbruntime";
            this.tbruntime.Size = new System.Drawing.Size(136, 45);
            this.tbruntime.TabIndex = 12;
            this.tbruntime.Scroll += new System.EventHandler(this.tbruntime_Scroll);
            // 
            // lbruntime
            // 
            this.lbruntime.AutoSize = true;
            this.lbruntime.Location = new System.Drawing.Point(93, 54);
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
            this.lbruntimenow.Location = new System.Drawing.Point(290, 53);
            this.lbruntimenow.Name = "lbruntimenow";
            this.lbruntimenow.Size = new System.Drawing.Size(36, 13);
            this.lbruntimenow.TabIndex = 14;
            this.lbruntimenow.Text = "now: -";
            // 
            // lbruntimemax
            // 
            this.lbruntimemax.AutoSize = true;
            this.lbruntimemax.Location = new System.Drawing.Point(290, 75);
            this.lbruntimemax.Name = "lbruntimemax";
            this.lbruntimemax.Size = new System.Drawing.Size(35, 13);
            this.lbruntimemax.TabIndex = 15;
            this.lbruntimemax.Text = "max: -";
            // 
            // wmp
            // 
            this.wmp.Enabled = true;
            this.wmp.Location = new System.Drawing.Point(539, 12);
            this.wmp.Name = "wmp";
            this.wmp.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("wmp.OcxState")));
            this.wmp.Size = new System.Drawing.Size(75, 76);
            this.wmp.TabIndex = 16;
            // 
            // dgvsongs
            // 
            this.dgvsongs.AllowUserToAddRows = false;
            this.dgvsongs.AllowUserToDeleteRows = false;
            this.dgvsongs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvsongs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColId,
            this.ColTitlename,
            this.ColBitrate,
            this.ColDuration});
            this.dgvsongs.Location = new System.Drawing.Point(13, 91);
            this.dgvsongs.MultiSelect = false;
            this.dgvsongs.Name = "dgvsongs";
            this.dgvsongs.ReadOnly = true;
            this.dgvsongs.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dgvsongs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvsongs.Size = new System.Drawing.Size(443, 104);
            this.dgvsongs.TabIndex = 17;
            this.dgvsongs.SelectionChanged += new System.EventHandler(this.dgvsongs_SelectionChanged);
            // 
            // ColId
            // 
            this.ColId.HeaderText = "Id";
            this.ColId.Name = "ColId";
            this.ColId.ReadOnly = true;
            // 
            // ColTitlename
            // 
            this.ColTitlename.HeaderText = "Titlename";
            this.ColTitlename.Name = "ColTitlename";
            this.ColTitlename.ReadOnly = true;
            // 
            // ColBitrate
            // 
            this.ColBitrate.HeaderText = "Bitrate";
            this.ColBitrate.Name = "ColBitrate";
            this.ColBitrate.ReadOnly = true;
            // 
            // ColDuration
            // 
            this.ColDuration.HeaderText = "Duration";
            this.ColDuration.Name = "ColDuration";
            this.ColDuration.ReadOnly = true;
            // 
            // cbrand
            // 
            this.cbrand.AutoSize = true;
            this.cbrand.Location = new System.Drawing.Point(427, 18);
            this.cbrand.Name = "cbrand";
            this.cbrand.Size = new System.Drawing.Size(66, 17);
            this.cbrand.TabIndex = 18;
            this.cbrand.Text = "Random";
            this.cbrand.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 207);
            this.Controls.Add(this.cbrand);
            this.Controls.Add(this.dgvsongs);
            this.Controls.Add(this.wmp);
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
            this.Controls.Add(this.btopen);
            this.Name = "Form1";
            this.Text = "YAM";
            ((System.ComponentModel.ISupportInitialize)(this.tbvolume)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbruntime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wmp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvsongs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Button btopen;
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
        private AxWMPLib.AxWindowsMediaPlayer wmp;
        private System.Windows.Forms.DataGridView dgvsongs;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTitlename;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColBitrate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColDuration;
        private System.Windows.Forms.CheckBox cbrand;
    }
}

