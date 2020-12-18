using MatriculaWebApplicationEF.DomainServices;
using MatriculaWebApplicationEF.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MatriculaUnitTest
{
    [TestClass]
    public class PaisUnitTest
    {
        [TestMethod]
        public void ValidarNombrePais()
        {
            PaisDomainService paisDomainService = new PaisDomainService();
            Pais pais = new Pais();
            pais.Nombre = "";

            var respuesta = paisDomainService.RegistrarPais(pais);

            Assert.AreEqual("El nombre es inválido.", respuesta);
        }
    }
}
