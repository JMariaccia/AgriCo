using AgriCo.Core.Modeles.Consommateurs;

namespace AgriCo.Core.Controleur.Validateur
{
    interface IValidationPanier
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="c"></param>
        void ValidationPanier(Panier c);
        /*{
            //ListePanier.FirstOrDefault.Where(p => p == c).Select(p => p.EtatValidation = true);
        }*/

    }
}
