using AgriCo.Core.Modeles.Consommateurs;

namespace AgriCo.Core.Controleurs.Transformateurs
{
    /// <summary>
    /// Transforme l'objet panier en paramettre en un object commande
    /// </summary>
    public interface ITansformationPanierEnCommande
    {
        void Transform(Panier p);
    }
}
