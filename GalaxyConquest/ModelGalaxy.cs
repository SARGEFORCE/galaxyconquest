﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GalaxyConquest
{
    [Serializable]
    public class ModelGalaxy
    {
        public string name; //название галактики
        public List<StarSystem> stars; //звездные системы
        public List<StarWarp> lanes;   //гиперпереходы

        public ModelGalaxy()
        {
            stars = new List<StarSystem>();
            lanes = new List<StarWarp>();
        }
    }
}
