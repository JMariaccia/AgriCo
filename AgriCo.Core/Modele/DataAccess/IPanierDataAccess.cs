using AgriCo.Core.Modele.Consommateur;

namespace AgriCo.Core.Modele.DataAccess
{
    interface IPanierDataAccess
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        Panier RecuperationPanierUtilisateur(Personne p);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="c"></param>
        void SauvegarderPanier(Panier c);
    }
}
