using System;
using System.Collections.Generic;
using System.Text;

namespace AgriCo.Core.Modeles.Producteurs
{
    public class Producteur : Personne
    {
        public string Siret { get; set; }
        public string NomEntreprise { get; set; }
        public string TelEntreprise { get; set; }
        public Adresse Adresse { get; set; }


        public Producteur()
        {

        }

        public Producteur(string siret, string nomEntreprise, string telEntreprise,string libelle, string lattitude, string longitude)
        {
            Siret = siret;
            NomEntreprise = nomEntreprise;
            TelEntreprise = telEntreprise;
            Adresse = new Adresse(libelle, lattitude, longitude);
        }

        
    }
}
