namespace AgriCo.Core.Controleur.Validateur
{
    public interface IValidationCompteBancaire
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="montant"></param>
        /// <param name="numeroDeCommande"></param>
        void DemandePaiement(float montant, int numeroDeCommande);
        /*{
            //Demander un payement du montant sur la commande == numeroDeCommande
        }*/
    }
}
