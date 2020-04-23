using AgriCo.Core.Modeles.Consommateurs;

namespace AgriCo.Core.Modeles.DataAccess
{
    interface IPanierDataAccess
    {
        /// <summary>
        /// Permet la récuparation du panier correspondant a l'utilisateur connecté
        /// </summary>
        /// <param name="p">L'utilisateur connecté</param>
        /// <returns>Retourne le panier de l'utilisateur</returns>
        Panier RecuperationPanierUtilisateur(Personne p);

        /// <summary>
        /// Permet la sauvegarde de l'instance de panier dans la base de données
        /// </summary>
        /// <param name="c">L'instance de panier</param>
        void SauvegarderPanier(Panier c);
    }
}
