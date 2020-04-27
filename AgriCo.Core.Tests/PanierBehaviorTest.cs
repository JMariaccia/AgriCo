using AgriCo.Core.Modeles.Consommateurs;
using AgriCo.Core.Modeles.Produits;
using System.Collections.Generic;
using Xunit;

namespace AgriCo.Core.Tests
{
    public class PanierBehaviorTest
    {
        [Fact]
        public void Test_CalculTotalPanier_Behavior()
        {
            Panier p = new Panier();
            List<Produit> listeDeProduits = new List<Produit>();
            listeDeProduits.Add(new Produit());
            listeDeProduits.Add(new Produit());
            float resultat = p.CalculTotalPanier(mesProduits: listeDeProduits);
            Assert.Equal(2, resultat);
        }

        [Fact]
        public void Test_AjouterProduit_Behavior()
        {

        }
    }
}
