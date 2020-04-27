using AgriCo.Core.Modele.Produits;
using System.Collections.Generic;

namespace AgriCo.Core.Modeles.Consommateurs
{
    public class Panier
    {
        #region Fields

        bool etatPaiement = false;
        bool etatValidation = false;
        //List<Producteur,Produit> listeProduitAchete = new List<Producteur,Produit>();
        List<Produit> listeProduitAchete = new List<Produit>();

        #endregion

        #region Properties
        bool EtatPaiement { get; set; }

        bool EtatValidation { get; set; }

        public List<Panier> ListePanier { get; set; }

        #endregion

        #region Methods
        public Panier()
        {

        }

        public float CalculTotalPanier(List<Produit> mesProduits)
        {
            return mesProduits.Count;
        }

        public void AjouterProduit(Produit monProduit)
        {
            listeProduitAchete.Add(monProduit);
        }

        #endregion
    }
}
