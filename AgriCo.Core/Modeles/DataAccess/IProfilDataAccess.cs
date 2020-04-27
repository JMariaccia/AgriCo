namespace AgriCo.Core.Modeles.DataAccess
{
    public interface IProfilDataAccess
    {


        bool RecuperationProfilAttribue(string email);


        bool SauvegarderProfil(Personne p);
      

    }
}
