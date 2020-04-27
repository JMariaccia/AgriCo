using AgriCo.Core.Modeles.Consommateurs;

namespace AgriCo.Core.Controleurs.Validateurs
{
    interface IValidationPanier
    {
        /// <summary>
        /// Permet de valider le contenu du panier passé en paramètre
        /// </summary>
        /// <param name="c">Le panier devant être validé</param>
        void ValidationPanier(Panier c);
        //ListePanier.FirstOrDefault.Where(p => p == c).Select(p => p.EtatValidation = true);


    }
}