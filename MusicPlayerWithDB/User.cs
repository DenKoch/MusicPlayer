using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace MusicPlayerWithDB {
    class User {
        public string username;
        public int user_id;

        public List<Song> fav_songs;
        public List<Playlist> playlists;

        public User(string username, int id) {
            this.username = username;
            this.user_id = id;
            fav_songs = new List<Song>();
            playlists = new List<Playlist>();
        }

        private string connString = @"Data Source=DESKTOP-31T7P0B\SQLEXPRESS;Initial Catalog=MusicPlayerDB;Integrated Security=True";

        public void UpdateFavSongs() {
            fav_songs.Clear();

            int playlist_id, artist_id;
            string name;

            DataTable[] res = getDataTablesFromDB(new string[] { "playlists", "playlists-songs", "songs", "albums", "artists" });
            DataTable dtbl_playlists = res[0];
            DataTable dtbl_playlists_songs = res[1];
            DataTable dtbl_songs = res[2];
            DataTable dtbl_albums = res[3];
            DataTable dtbl_artists = res[4];

            using (SqlConnection conn = new SqlConnection(connString)) {
                playlist_id = (int)dtbl_playlists.Select("user_id = '" + user_id + "' and title = 'fav_songs'")[0]["playlist_id"];

                DataRow[] songs_in_playlist = dtbl_playlists_songs.Select("playlist_id = '" + playlist_id + "'");

                foreach (DataRow row in songs_in_playlist) {
                    int id = (int)row["song_id"];
                    DataRow song_with_id = dtbl_songs.Select("song_id = '" + id + "'")[0];
                    var new_song = new Song {
                        title = (string)song_with_id["title"],
                        length = (int)song_with_id["length"],
                        album_name = (string)song_with_id["album_name"]
                    };

                    artist_id = (int)dtbl_albums.Select("album_name = '" + (string)song_with_id["album_name"] + "'")[0]["artist_id"];
                    name = (string)dtbl_artists.Select("artist_id = '" + artist_id + "'")[0]["name"];
                    new_song.artist_name = name;
                    fav_songs.Add(new_song);
                }
            }
        }

        public void UpdatePlaylists() {
            playlists.Clear();

            int artist_id;
            string name;

            DataTable[] res = getDataTablesFromDB(new string[] { "playlists", "playlists-songs", "songs", "albums", "artists" });
            DataTable dtbl_playlists = res[0];
            DataTable dtbl_playlists_songs = res[1];
            DataTable dtbl_songs = res[2];
            DataTable dtbl_albums = res[3];
            DataTable dtbl_artists = res[4];



            using (SqlConnection conn = new SqlConnection(connString)) {
                DataRow[] playlistsForThisUser = dtbl_playlists.Select("user_id = '" + user_id + "' and title <> 'fav_songs'");
                foreach (DataRow row in playlistsForThisUser) {
                    Playlist newPlaylist = new Playlist() {
                        title = (string)row["title"],
                        playlist_id = (int)row["playlist_id"],
                        songs = new List<Song>()
                    };
                    DataRow[] songsInThisPlaylistID = dtbl_playlists_songs.Select("playlist_id = '" + (int)row["playlist_id"] + "'");

                    foreach (DataRow song in songsInThisPlaylistID) {

                        int id = (int)song["song_id"];
                        DataRow song_with_id = dtbl_songs.Select("song_id = '" + id + "'")[0];

                        Song new_song = new Song() {
                            title = (string)song_with_id["title"],
                            length = (int)song_with_id["length"],
                            album_name = (string)song_with_id["album_name"]
                        };

                        artist_id = (int)dtbl_albums.Select("album_name = '" + (string)song_with_id["album_name"] + "'")[0]["artist_id"];
                        name = (string)dtbl_artists.Select("artist_id = '" + artist_id + "'")[0]["name"];
                        new_song.artist_name = name;

                        newPlaylist.songs.Add(new_song);
                    }
                    playlists.Add(newPlaylist);
                }
            }
        }

        public DataTable[] getDataTablesFromDB(string[] dbNames) {
            DataTable[] res = new DataTable[dbNames.Length];
            for (int i = 0; i < dbNames.Length; i++) {
                res[i] = new DataTable();
                using (SqlConnection conn = new SqlConnection(connString)) {
                    string query;

                    if (dbNames[i].Contains("-"))
                        query = "select * from \"" + dbNames[i] + "\"";
                    else
                        query = "select * from " + dbNames[i];

                    using (SqlCommand comm = new SqlCommand(query, conn)) {
                        conn.Open();
                        SqlDataAdapter da = new SqlDataAdapter(comm);
                        da.Fill(res[i]);
                        conn.Close();
                        da.Dispose();
                    }
                }
            }

            return res;
        }

        public void addPlaylist(string new_title) {
            playlists.Add(new Playlist() {
                title = new_title,
            });
            DataTable[] res = getDataTablesFromDB(new string[] { "playlists" });

            DataTable dtbl_playlists = res[0];

            using (SqlConnection conn = new SqlConnection(connString)) {
                using (SqlCommand comm = new SqlCommand()) {

                    comm.Connection = conn;
                    comm.CommandText = "insert into playlists (title, user_id) values (@val1, @val2)";

                    comm.Parameters.AddWithValue("@val1", new_title);
                    comm.Parameters.AddWithValue("@val2", user_id);

                    try {
                        conn.Open();
                        comm.ExecuteNonQuery();
                        conn.Close();
                    } catch {
                        return;
                    }
                }
            }
        }
    }
}
