namespace MusicPlayerWithDB {
    partial class FormMain {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.username_pic = new System.Windows.Forms.PictureBox();
            this.Username = new System.Windows.Forms.LinkLabel();
            this.Discover_bt = new System.Windows.Forms.Label();
            this.AddPlaylist = new System.Windows.Forms.Button();
            this.Playlists = new System.Windows.Forms.ListView();
            this.name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.imageListForPlaylists = new System.Windows.Forms.ImageList(this.components);
            this.Playlists_label = new System.Windows.Forms.Label();
            this.favSongs = new System.Windows.Forms.Label();
            this.mainWindow = new System.Windows.Forms.ListView();
            this.song_title = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.song_album = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.song_artist = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.song_length = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.artistsTableAdapter1 = new MusicPlayerWithDB.DataSetMainTableAdapters.ArtistsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.username_pic)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            resources.ApplyResources(this.splitContainer1, "splitContainer1");
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer1.ForeColor = System.Drawing.Color.White;
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            resources.ApplyResources(this.splitContainer1.Panel1, "splitContainer1.Panel1");
            this.splitContainer1.Panel1.ForeColor = System.Drawing.Color.White;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            resources.ApplyResources(this.splitContainer1.Panel2, "splitContainer1.Panel2");
            this.splitContainer1.Panel2.ForeColor = System.Drawing.Color.White;
            // 
            // splitContainer2
            // 
            resources.ApplyResources(this.splitContainer2, "splitContainer2");
            this.splitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.splitContainer2.Panel1.Controls.Add(this.splitContainer3);
            resources.ApplyResources(this.splitContainer2.Panel1, "splitContainer2.Panel1");
            // 
            // splitContainer2.Panel2
            // 
            resources.ApplyResources(this.splitContainer2.Panel2, "splitContainer2.Panel2");
            this.splitContainer2.Panel2.Controls.Add(this.mainWindow);
            // 
            // splitContainer3
            // 
            resources.ApplyResources(this.splitContainer3, "splitContainer3");
            this.splitContainer3.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer3.Name = "splitContainer3";
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.username_pic);
            this.splitContainer3.Panel1.Controls.Add(this.Username);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.Discover_bt);
            this.splitContainer3.Panel2.Controls.Add(this.AddPlaylist);
            this.splitContainer3.Panel2.Controls.Add(this.Playlists);
            this.splitContainer3.Panel2.Controls.Add(this.Playlists_label);
            this.splitContainer3.Panel2.Controls.Add(this.favSongs);
            // 
            // username_pic
            // 
            resources.ApplyResources(this.username_pic, "username_pic");
            this.username_pic.Image = global::MusicPlayerWithDB.Properties.Resources.thumb__ser;
            this.username_pic.Name = "username_pic";
            this.username_pic.TabStop = false;
            // 
            // Username
            // 
            this.Username.ActiveLinkColor = System.Drawing.Color.LightGray;
            resources.ApplyResources(this.Username, "Username");
            this.Username.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Username.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.Username.LinkColor = System.Drawing.Color.White;
            this.Username.Name = "Username";
            this.Username.TabStop = true;
            this.Username.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Username_MouseClick);
            // 
            // Discover_bt
            // 
            resources.ApplyResources(this.Discover_bt, "Discover_bt");
            this.Discover_bt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Discover_bt.Name = "Discover_bt";
            this.Discover_bt.Click += new System.EventHandler(this.Discover_bt_Click);
            // 
            // AddPlaylist
            // 
            this.AddPlaylist.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.AddPlaylist, "AddPlaylist");
            this.AddPlaylist.Name = "AddPlaylist";
            this.AddPlaylist.UseVisualStyleBackColor = true;
            this.AddPlaylist.Click += new System.EventHandler(this.AddPlaylist_Click);
            // 
            // Playlists
            // 
            this.Playlists.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.Playlists.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Playlists.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.name});
            this.Playlists.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.Playlists, "Playlists");
            this.Playlists.ForeColor = System.Drawing.Color.White;
            this.Playlists.MultiSelect = false;
            this.Playlists.Name = "Playlists";
            this.Playlists.SmallImageList = this.imageListForPlaylists;
            this.Playlists.UseCompatibleStateImageBehavior = false;
            this.Playlists.View = System.Windows.Forms.View.List;
            this.Playlists.Click += new System.EventHandler(this.Playlists_Click);
            // 
            // name
            // 
            resources.ApplyResources(this.name, "name");
            // 
            // imageListForPlaylists
            // 
            this.imageListForPlaylists.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            resources.ApplyResources(this.imageListForPlaylists, "imageListForPlaylists");
            this.imageListForPlaylists.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // Playlists_label
            // 
            resources.ApplyResources(this.Playlists_label, "Playlists_label");
            this.Playlists_label.ForeColor = System.Drawing.Color.Silver;
            this.Playlists_label.Name = "Playlists_label";
            // 
            // favSongs
            // 
            resources.ApplyResources(this.favSongs, "favSongs");
            this.favSongs.Cursor = System.Windows.Forms.Cursors.Hand;
            this.favSongs.Name = "favSongs";
            this.favSongs.Click += new System.EventHandler(this.favSongs_Click);
            // 
            // mainWindow
            // 
            this.mainWindow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.mainWindow.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.song_title,
            this.song_album,
            this.song_artist,
            this.song_length});
            resources.ApplyResources(this.mainWindow, "mainWindow");
            this.mainWindow.ForeColor = System.Drawing.Color.White;
            this.mainWindow.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.mainWindow.Name = "mainWindow";
            this.mainWindow.UseCompatibleStateImageBehavior = false;
            this.mainWindow.View = System.Windows.Forms.View.Details;
            // 
            // song_title
            // 
            resources.ApplyResources(this.song_title, "song_title");
            // 
            // song_album
            // 
            resources.ApplyResources(this.song_album, "song_album");
            // 
            // song_artist
            // 
            resources.ApplyResources(this.song_artist, "song_artist");
            // 
            // song_length
            // 
            resources.ApplyResources(this.song_length, "song_length");
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logOutToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            resources.ApplyResources(this.contextMenuStrip1, "contextMenuStrip1");
            // 
            // logOutToolStripMenuItem
            // 
            resources.ApplyResources(this.logOutToolStripMenuItem, "logOutToolStripMenuItem");
            this.logOutToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.logOutToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Click += new System.EventHandler(this.logOutToolStripMenuItem_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "shell32_16824.ico");
            // 
            // artistsTableAdapter1
            // 
            this.artistsTableAdapter1.ClearBeforeFill = true;
            // 
            // FormMain
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.Controls.Add(this.splitContainer1);
            this.Name = "FormMain";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel1.PerformLayout();
            this.splitContainer3.Panel2.ResumeLayout(false);
            this.splitContainer3.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.username_pic)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.LinkLabel Username;
        private System.Windows.Forms.PictureBox username_pic;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
        private System.Windows.Forms.Label favSongs;
        private System.Windows.Forms.ListView Playlists;
        private System.Windows.Forms.Label Playlists_label;
        private System.Windows.Forms.ListView mainWindow;
        private System.Windows.Forms.ColumnHeader song_title;
        private System.Windows.Forms.ColumnHeader song_album;
        private System.Windows.Forms.ColumnHeader song_artist;
        private System.Windows.Forms.ColumnHeader song_length;
        private System.Windows.Forms.Button AddPlaylist;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label Discover_bt;
        private System.Windows.Forms.ImageList imageListForPlaylists;
        private System.Windows.Forms.ColumnHeader name;
        private DataSetMainTableAdapters.ArtistsTableAdapter artistsTableAdapter1;
    }
}

