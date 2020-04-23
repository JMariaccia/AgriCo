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
        bool EtatPaiement { get; set; } = false;

        bool EtatValidation { get; set; } = false;

        public List<Panier> ListePanier { get; set; }

        Consommateur Utilisateur { get; set; }

        #endregion

        #region Methods
        public Panier()
        {

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
