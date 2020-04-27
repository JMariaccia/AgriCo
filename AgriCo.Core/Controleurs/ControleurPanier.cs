using AgriCo.Core.Controleurs.Validateurs;
using AgriCo.Core.Modeles;
using AgriCo.Core.Modeles.Consommateurs;
using AgriCo.Core.Modeles.DataAccess;
using System;
using System.Linq;

namespace AgriCo.Core.Controleurs
{
    class ControleurPanier : IPanierDataAccess, IValidationPanier
    {
        #region Fields

        #endregion

        #region Properties

        #endregion

        #region Methods

        public void ReglementPanier(Personne p)
        {
            // ListePanier.Where(p => p.Utilisateur == p && p.MontantAPayer == 0).Select(p => p.EtatPaiement = true);
        }

        public void SuccesPaiement(int numeroCommande)
        {
            Console.WriteLine("Le paiement pour la commande {0} a été réalisé avec succés", numeroCommande);
        }

        public void ErreurPaiement(int numeroCommande)
        {
            Console.WriteLine("Une erruer est survenu lors du paiement pour la commande {0}", numeroCommande);
        }

        public Panier RecuperationPanierUtilisateur(Personne p)
        {
            //ListePanier.Select(Panier.Id).Where(p => p.Utilisateur == p);
            return new Panier();
        }

        public void SauvegarderPanier(Panier c)
        {
            c.ListePanier.Add(c);
        }

        public void ValidationPanier(Panier c)
        {
            c.ListePanier.Where(p => p == c).Select(p => p.EtatValidation = true);
        }

        #endregion
    }
}
