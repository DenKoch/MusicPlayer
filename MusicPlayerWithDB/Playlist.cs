using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicPlayerWithDB {
    class Playlist {
        public string title;
        public int playlist_id;

        public List<Song> songs;

        public Playlist() {
            songs = new List<Song>();
        }
    }
}
