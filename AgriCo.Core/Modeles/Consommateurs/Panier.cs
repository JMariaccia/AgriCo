using AgriCo.Core.Modeles.Producteurs;
using AgriCo.Core.Modeles.Produits;
using System.Collections.Generic;

namespace AgriCo.Core.Modeles.Consommateurs
{
    public class Panier
    {
        #region Fields

        bool etatPaiement = false;
        bool etatValidation = false;

        Dictionary<Producteur, ISet<Produit>> listeProduitAchete = new Dictionary<Producteur, ISet<Produit>>();

        #endregion

        #region Properties
        public bool EtatPaiement { get; set; } = false;

        public bool EtatValidation { get; set; } = false;

        public List<Panier> ListePanier { get; set; } = new List<Panier>();

        public Consommateur Utilisateur { get; set; }

        #endregion

        #region Methods
        public Panier()
        {

        }

        public Panier(Dictionary<Producteur, ISet<Produit>> listeProduitAchete, Consommateur utilisateur)
        {
            this.listeProduitAchete = listeProduitAchete;
            Utilisateur = utilisateur;
        }

        public decimal CalculTotalPanier(Dictionary<Producteur, Produit> mesProduits)
        {
            return 0;//mesProduits.Select(p => p.Value.Prix);
        }

        public void AjouterProduit(Produit monProduit)
        {
            // listeProduitAchete.Add(monProduit.Producteur, monProduit);
        }

        #endregion
    }
}
