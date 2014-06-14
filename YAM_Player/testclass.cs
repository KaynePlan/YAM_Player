using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace YAM_Player
{
    class testclass
    {
        // Test List
        private List<List<string>> playlist = new List<List<string>>();
        
        public testclass()
        {
        }

        public List<List<string>> getplaylisttest()
        {
            playlist.Add(new List<String>()); //sub list
            playlist[0].Add("C:\\Users\\Hymera\\Music\\Dark Tranquillity\\Fiction\\04 Blind at Heart.mp3");
            playlist[0].Add("04 Blind at Heart");
            playlist[0].Add("320kb");
            playlist[0].Add("3");

            playlist.Add(new List<String>()); //sub list
            playlist[1].Add("C:\\Users\\Hymera\\Music\\Dark Tranquillity\\Fiction\\08 Misery's Crown.mp3");
            playlist[1].Add("08 Misery's Crown");
            playlist[1].Add("128kb");
            playlist[1].Add("2");

            playlist.Add(new List<String>()); //sub list
            playlist[2].Add("C:\\Users\\Hymera\\Music\\Dark Tranquillity\\Fiction\\09 Focus Shift.mp3");
            playlist[2].Add("09 Focus Shift");
            playlist[2].Add("256kb");
            playlist[2].Add("1");

            return playlist;
        }
    }
}
