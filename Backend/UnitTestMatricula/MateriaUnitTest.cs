using MatriculaWebApplicationEF.DomainServices;
using MatriculaWebApplicationEF.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MatriculaUnitTest
{
    [TestClass]
    public class MateriaUnitTest
    {
        [TestMethod]
        public void ValidarNombreMateria()
        {
            MateriaDomainService materiaDomainService = new MateriaDomainService();
            Materia materia = new Materia();
            materia.Nombre = "";

            var respuesta = materiaDomainService.RegistrarMateria(materia);

            Assert.AreEqual("El nombre es inválido.", respuesta);
        }
    }
}
