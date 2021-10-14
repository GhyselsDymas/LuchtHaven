using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuchtHaven.Entities
{
    internal class Baan
    {

        public bool Vrij { get; set; } = true;

        public string GeefOmschrijving() {

            string Omschrijving = "De baan is op dit moment vrij!";

            if (Vrij == false) {
                Omschrijving = "De baan is op dit moment niet vrij!";
            }

            return Omschrijving;
        }

    }
}
