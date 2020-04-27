
﻿namespace AgriCo.Core.Modeles.Produits
{
    public class Produit
    {
		public string IDProduit { get; set; }

		public string Nom { get; set; }

		public string Variete { get; set; }

		public decimal Prix { get; set; }

		public string Description { get; set; }

		public TypeProduit Type { get; set; }

		public Producteur.Producteur ProducteurProduit { get; set; }

	}

}
