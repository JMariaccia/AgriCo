using AgriCo.Core.Modele;
using AgriCo.Core.Modeles.Producteurs;
using System;
using System.Collections.Generic;
using System.Text;

namespace AgriCo.Core.Modeles.Consommateurs
{
    public class Consommateur : Personne
    {
        public Adresse AdresseConsommateur { get; set; } 
        public Adresse AdresseLivraison {get;set;}
        List<Producteur> listeDesProducteursAbonnes = new List<Producteur>();

    }

    // Constructeur
    public Consommateur(Adresse adresse, string email, string motDePasse, string nom, string prenom, string telephone, bool valide) : base(email, motDePasse, nom, prenom, telephone, valide); 
    {
        AdresseConsommateur = adresse;
        AdresseLivraison = adresse;
    }


    // Surcharge Constructeur si AdresseConsommateur != AdresseLivraison
    public Consommateur(Adresse adresse,Adresse adresseLivraison, string email, string motDePasse, string nom, string prenom, string telephone, bool valide) : base(email, motDePasse, nom, prenom, telephone, valide); 
    {
        AdresseConsommateur = adresse;
        AdresseLivraison = adresseLivraison;
    }
}
