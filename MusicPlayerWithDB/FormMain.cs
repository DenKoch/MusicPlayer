using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace MusicPlayerWithDB
{
    public partial class FormMain : Form
    {
        private FormInit objFormInit;
        private User user;
        private DataSetMain ds;

        public FormMain()
        {
            InitializeComponent();
            ds = new DataSetMain();
        }

        public FormMain(string username, int id, FormInit form)
        {
            InitializeComponent();
            user = new User(username, id);
            objFormInit = form;
            ds = new DataSetMain();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            mainWindow.View = View.LargeIcon;
            Username.Text = user.GetUsername() + " ▼";

            user.UpdatePlaylists();
            var userPlaylists = user.GetPlaylists();
            foreach (Playlist p in userPlaylists)
            {
                var lvi = new ListViewItem(p.GetTitle());
                Playlists.Items.Add(lvi);
            }

            DataTable artists = artistsTableAdapter1.GetData();
            foreach (DataRow row in artists.Rows)
            {
                var artist = new ListViewItem((string)row["name"]);
                mainWindow.Items.Add(artist);
            }
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            objFormInit.Close();
        }

        private void Username_MouseClick(object sender, MouseEventArgs e)
        {
            contextMenuStrip1.Show(new Point(this.PointToScreen(e.Location).X + 100, this.PointToScreen(e.Location).Y + 50));
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            var objFormInit = new FormInit(this);
            objFormInit.Show();
        }

        private void favSongs_Click(object sender, EventArgs e)
        {
            mainWindow.Items.Clear();
            mainWindow.View = View.Details;

            user.UpdateFavSongs();
            var userFavSongs = user.GetFavSongs();
            foreach (Song new_song in userFavSongs)
            {
                (string title, string album, string artist, int length) = new_song.GetTitleArtistAlbumLength();
                var new_song_lvi = new ListViewItem(title);
                new_song_lvi.SubItems.Add(album);
                new_song_lvi.SubItems.Add(artist);
                new_song_lvi.SubItems.Add(length.ToString());
                mainWindow.Items.Add(new_song_lvi);
            }
        }

        private void Playlists_Click(object sender, EventArgs e)
        {
            if (Playlists.SelectedItems.Count != 1)
                return;

            mainWindow.Items.Clear();
            mainWindow.View = View.Details;

            var songs = new List<Song>();

            string playlistSelected = Playlists.SelectedItems[0].Text;
            var userPlaylists = user.GetPlaylists();

            foreach (Playlist playlist in userPlaylists)
            {
                if (playlist.GetTitle() == playlistSelected)
                    songs = playlist.GetSongs();
            }

            foreach (Song song in songs)
            {
                (string title, string album, string artist, int length) = song.GetTitleArtistAlbumLength();
                ListViewItem song_lvi = new ListViewItem(title);
                song_lvi.SubItems.Add(album);
                song_lvi.SubItems.Add(artist);
                song_lvi.SubItems.Add(length.ToString());
                mainWindow.Items.Add(song_lvi);
            }
        }

        private void AddPlaylist_Click(object sender, EventArgs e)
        {
            var npd = new NewPlaylistDialog();
            npd.ShowDialog();
            try
            {
                if (npd.SendText != "")
                {
                    user.addPlaylist(npd.SendText);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            Playlists.Items.Clear();

            var userPlaylists = user.GetPlaylists();
            foreach (Playlist p in userPlaylists)
            {
                var lvi = new ListViewItem(p.GetTitle());
                Playlists.Items.Add(lvi);
            }
        }

        private DataTable GetArtists()
        {
            return artistsTableAdapter1.GetData();
        }

        private void Discover_bt_Click(object sender, EventArgs e)
        {
            mainWindow.Items.Clear();
            mainWindow.View = View.LargeIcon;

            DataTable artists = artistsTableAdapter1.GetData();
            foreach (DataRow row in artists.Rows)
            {
                var artist = new ListViewItem((string)row["name"]);
                mainWindow.Items.Add(artist);
            }
        }
    }
}
