using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GalaxyConquest
{
    [Serializable]
    public class StarWarp
    {
        public string name;
        public int type;

        public StarSystem system1;
        public StarSystem system2;
    }
}
