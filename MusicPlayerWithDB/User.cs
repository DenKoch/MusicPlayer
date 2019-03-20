using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace MusicPlayerWithDB
{
    class User
    {
        private string username;
        private int user_id;
        private List<Song> fav_songs;
        private List<Playlist> playlists;

        private DataSetMainTableAdapters.UsersTableAdapter userTA;
        private DataSetMainTableAdapters.PlaylistsTableAdapter playlistTA;
        private DataSetMainTableAdapters.Playlists_SongsTableAdapter playlistsSongsTA;
        private DataSetMainTableAdapters.TableAdapterManager TableAdapter;
        private DataSetMain ds;


        public User(string username, int id)
        {
            this.username = username;
            this.user_id = id;
            fav_songs = new List<Song>();
            playlists = new List<Playlist>();
            ds = new DataSetMain();
            userTA = new DataSetMainTableAdapters.UsersTableAdapter();
            playlistTA = new DataSetMainTableAdapters.PlaylistsTableAdapter();
            playlistsSongsTA = new DataSetMainTableAdapters.Playlists_SongsTableAdapter();
            TableAdapter = new DataSetMainTableAdapters.TableAdapterManager();
        }

        public List<Song> GetFavSongs()
        {
            return fav_songs;
        }
        public List<Playlist> GetPlaylists()
        {
            return playlists;
        }
        public string GetUsername()
        {
            return username;
        }

        public void UpdateFavSongs()
        {
            fav_songs.Clear();

            var favSongsDT = playlistTA.GetFavSongsByUserId(user_id);
            fav_songs = (from DataRow dr in favSongsDT.Rows
                         select new Song(dr["song_title"].ToString(),
                                          dr["album_title"].ToString(),
                                          dr["artist_title"].ToString(),
                                          Convert.ToInt32(dr["song_length"]))
                          ).ToList();
        }

        public void UpdatePlaylists()
        {
            playlists.Clear();

            var thisUserPlaylists = playlistTA.GetPlaylistIdByUserId(user_id);
            foreach (DataRow dr in thisUserPlaylists)
            {
                var playlistTitle = dr["playlist_title"].ToString();
                var playlistId = Convert.ToInt32(dr["playlist_id"]);

                var songsInNewPlaylistDT = playlistsSongsTA.GetSongsByPlaylistId(playlistId);
                var songsInNewPlaylist = (from DataRow datarow in songsInNewPlaylistDT.Rows
                                          select new Song(datarow["song_title"].ToString(),
                                                           datarow["album_title"].ToString(),
                                                           datarow["artist_title"].ToString(),
                                                           Convert.ToInt32(datarow["song_length"]))
                          ).ToList();

                var newPlaylist = new Playlist(playlistTitle, songsInNewPlaylist);
                playlists.Add(newPlaylist);
            }
            /*
            int artist_id;
            string name;

            DataTable[] res = getDataTablesFromDB(new string[] { "playlists", "playlists-songs", "songs", "albums", "artists" });
            DataTable dtbl_playlists = res[0];
            DataTable dtbl_playlists_songs = res[1];
            DataTable dtbl_songs = res[2];
            DataTable dtbl_albums = res[3];
            DataTable dtbl_artists = res[4];



            using (SqlConnection conn = new SqlConnection(connString))
            {
                DataRow[] playlistsForThisUser = dtbl_playlists.Select("user_id = '" + user_id + "' and title <> 'fav_songs'");
                foreach (DataRow row in playlistsForThisUser)
                {
                    Playlist newPlaylist = new Playlist()
                    {
                        title = (string)row["title"],
                        playlist_id = (int)row["playlist_id"],
                        songs = new List<Song>()
                    };
                    DataRow[] songsInThisPlaylistID = dtbl_playlists_songs.Select("playlist_id = '" + (int)row["playlist_id"] + "'");

                    foreach (DataRow song in songsInThisPlaylistID)
                    {

                        int id = (int)song["song_id"];
                        DataRow song_with_id = dtbl_songs.Select("song_id = '" + id + "'")[0];

                        Song new_song = new Song()
                        {
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
            */

        }

        public void addPlaylist(string new_title)
        {
            playlists.Add(new Playlist(new_title, null));
            playlistTA.Insert(new_title, user_id);
        }
    }
}
