using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LuchtHaven.Entities;

namespace LuchtHaven.Entities
{
    internal class Vliegtuig
    {
        public string Vluchtnummer { get; set; }
        public Baan BaanVoorVliegtuig { get; set; }

    }
}
