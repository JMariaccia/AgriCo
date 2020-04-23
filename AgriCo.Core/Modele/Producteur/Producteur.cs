using System;
using System.Collections.Generic;
using System.Text;

namespace AgriCo.Core.Modele.Producteur
{
    public class Producteur : Personne
    {
        public string Siret { get; set; }
        public string NomEntreprise { get; set; }
        public string TelEntreprise { get; set; }

        public Producteur()
        {

        }

        public Producteur(string siret, string nomEntreprise, string telEntreprise)
        {
            Siret = siret;
            NomEntreprise = nomEntreprise;
            TelEntreprise = telEntreprise;
        }
    }
}
