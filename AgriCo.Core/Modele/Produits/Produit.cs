namespace AgriCo.Core.Modele.Produits
{
    public abstract class Produit
    {
        public string IdentifiantProduit { get; set; }         
        public QualiteProduit Name { get; set; }
        public string Variete { get; set; }
        public decimal Prix { get; set; }
        public string Qualite { get; set; }
        public string Description { get; set; }

    }
}
