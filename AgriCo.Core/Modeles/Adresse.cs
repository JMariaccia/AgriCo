using System;
using System.Collections.Generic;
using System.Text;

namespace AgriCo.Core.Modeles
{
    public class Adresse
    {
        public string Libelle { get; set; }
        public string Lattitude { get; set; }
        public string Longitude { get; set; }

        public Adresse()
        {

        }

        public Adresse(string libelle, string lattitude, string longitude)
        {
            Libelle = libelle;
            Lattitude = lattitude;
            Longitude = longitude;
        }
    }
}
