using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicPlayerWithDB
{
    class Song
    {
        private string title;
        private string album_name;
        private string artist_name;
        private int length;

        public Song(string ttl, string album, string artist, int lngth)
        {
            title = ttl;
            album_name = album;
            artist_name = artist;
            length = lngth;
        }

        public Song()
        {
            this.title = String.Empty;
            album_name = String.Empty;
            artist_name = String.Empty;
            length = 0;
        }

        public (string, string, string, int) GetTitleArtistAlbumLength()
        {
            return (title, album_name, artist_name, length);
        }
    }
}
