using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GalaxyConquest
{
    [Serializable]
    public class StarSystem
    {
        public string name;

        public int type; //тип звезды

        public double x;
        public double y;
        public double z;
        public int color_A; //alfa
        public int color_R; //red
        public int color_G; //green
        public int color_B; //blue

    }
}
