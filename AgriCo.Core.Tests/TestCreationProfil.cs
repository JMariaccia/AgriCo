using AgriCo.Core.Controleur.Transformateurs;
    using AgriCo.Core.Modeles.DataAccess;
using Moq;
using Xunit;

namespace AgriCo.Core.Tests
{

    public class TestCreationProfil
    {



        [Fact]
        public void Test_ProfilIsNull_ReturnsError()
        {
            IProfilDataAccess dal = Mock.Of<IProfilDataAccess>();
            ITransformationFormEnProfil transformer = Mock.
        }

        [Fact]
        public void Test_PersistanceFailed_ReturnsError()
        {

        }

        [Fact]
        public void Test_RegistrationIsSuccessful()
        {

        }

        [Fact]
        public void Test_EmailValidated_ReturnSuccess()
        {

        }
    }