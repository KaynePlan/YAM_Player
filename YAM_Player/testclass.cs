using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace YAM_Player
{
    class testclass
    {
        // Test List
        private List<Playlist> playlist = new List<Playlist>();
        
        public testclass()
        {
        }

        public List<Playlist> getplaylisttest()
        {
            playlist.Add(new Playlist("C:\\Users\\Hymera\\Music\\Dark Tranquillity\\Fiction\\04 Blind at Heart.mp3", "04 Blind at Heart", 320, 3));

            playlist.Add(new Playlist("C:\\Users\\Hymera\\Music\\Dark Tranquillity\\Fiction\\08 Misery's Crown.mp3", "08 Misery's Crown", 128, 2));

            playlist.Add(new Playlist("C:\\Users\\Hymera\\Music\\Dark Tranquillity\\Fiction\\09 Focus Shift.mp3", "09 Focus Shift", 256, 1));
            
            return playlist;
        }
    }
}
