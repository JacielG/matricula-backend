using MatriculaWebApplicationEF.DomainServices;
using MatriculaWebApplicationEF.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MatriculaUnitTest
{
    [TestClass]
    public class CursoUnitTest
    {
        [TestMethod]
        public void ValidarNombreCurso()
        {
            CursoDomainService estudianteDomainService = new CursoDomainService();
            Curso curso = new Curso();
            curso.Nombre = "";

            var respuesta = estudianteDomainService.RegistrarCurso(curso);

            Assert.AreEqual("El nombre es inválido.", respuesta);
        }
    }
}
