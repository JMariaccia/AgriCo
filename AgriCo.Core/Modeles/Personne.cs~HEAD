using System;
using System.Collections.Generic;
using System.Text;

namespace AgriCo.Core.Modeles
{
     public abstract class Personne
    {
        public string Email { get; set; }
        public string MotDePasse { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string Telephone { get; set; }

        public bool Valide { get; set; } = false;


        public Personne()
        {

        }

        public Personne(string email, string motDePasse, string nom, string prenom, string telephone, bool valide)
        {
            Email = email;
            MotDePasse = motDePasse;
            Nom = nom;
            Prenom = prenom;
            Telephone = telephone;
            Valide = valide;
        }
    }
}
