using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicPlayerWithDB
{
    class Playlist
    {
        private string title;
        private List<Song> songs;

        public Playlist()
        {
            songs = null;
            title = String.Empty;
        }

        public Playlist(string ttl, List<Song> newSongs)
        {
            title = ttl;
            songs = newSongs;
        }




        public string GetTitle()
        {
            return title;
        }
        public List<Song> GetSongs()
        {
            return songs;
        }
    }
}
