using AgriCo.Core.Modeles.Consommateurs;

namespace AgriCo.Core.Modeles.DataAccess
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
