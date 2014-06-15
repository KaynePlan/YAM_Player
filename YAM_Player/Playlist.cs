using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace YAM_Player
{
    public class Playlist
    {
        public Playlist(string filepath, string titlename, int bitrate, long playtime)
        {
            this.Filepath = filepath;
            this.Titlename = titlename;
            this.Bitrate = bitrate;
            this.Playtime = playtime;
        }

        public int Id { get; set; }
        public string Titlename { get; set; }
        public Nullable<int> Genre { get; set; }
        public Nullable<int> Bitrate { get; set; }
        public Nullable<int> Releaseyear { get; set; }
        public long Playtime { get; set; }
        public Nullable<int> Lang { get; set; }
        public string Filepath { get; set; }
        public Nullable<System.DateTime> Lastplayed { get; set; }
        public Nullable<int> Playcounter { get; set; }
    }   
}
