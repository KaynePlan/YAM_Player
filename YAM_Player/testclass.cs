using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace YAM_Player
{
    class testclass
    {
        // Test String
        private string[,] playlist = new string [3, 4] { { "C:\\Users\\Hymera\\Music\\Dark Tranquillity\\Fiction\\04 Blind at Heart.mp3", "04 Blind at Heart", "320kb", "3" }, { "C:\\Users\\Hymera\\Music\\Dark Tranquillity\\Fiction\\08 Misery's Crown.mp3", "08 Misery's Crown", "128kb", "2" },
                                        { "C:\\Users\\Hymera\\Music\\Dark Tranquillity\\Fiction\\09 Focus Shift.mp3", "09 Focus Shift", "256kb", "1" } };
        public testclass()
        {
        }

        public String[,] getplaylisttest()
        {
            return playlist;
        }
    }
}
