using MatriculaWebApplicationEF.DomainServices;
using MatriculaWebApplicationEF.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MatriculaUnitTest
{
    [TestClass]
    public class EstudianteUnitTest
    {
        [TestMethod]
        public void ValidarEdadEstudianteMenorA18()
        {
            EstudianteDomainService estudianteDomainService = new EstudianteDomainService();
            Estudiante estudiante = new Estudiante();
            estudiante.Nombre = "Test Vanguardia";
            estudiante.Edad = 14;
            estudiante.Sexo = "M";

            var respuesta =  estudianteDomainService.RegistrarEstudiante(estudiante);

            Assert.AreEqual("Edad es inválida, debe ser mayor a 18", respuesta);
        }

        [TestMethod]
        public void ValidarEdadEstudianteMayorA18()
        {
            EstudianteDomainService estudianteDomainService = new EstudianteDomainService();
            Estudiante estudiante = new Estudiante();
            estudiante.Nombre = "Test Vanguardia";
            estudiante.Edad = 20;
            estudiante.Sexo = "M";

            var respuesta = estudianteDomainService.RegistrarEstudiante(estudiante);

            Assert.AreEqual("Successful", respuesta);
        }

        [TestMethod]
        public void ValidarTelefono()
        {
            EstudianteDomainService estudianteDomainService = new EstudianteDomainService();
            Estudiante estudiante = new Estudiante();
            estudiante.Nombre = "Test Vanguardia";
            estudiante.Edad = 19;
            estudiante.Sexo = "M";
            estudiante.Telefono = "";

            var respuesta = estudianteDomainService.RegistrarEstudiante(estudiante);

            Assert.AreEqual("El telefono es inválido", respuesta);
        }

        [TestMethod]
        public void ValidarDireccion()
        {
            EstudianteDomainService estudianteDomainService = new EstudianteDomainService();
            Estudiante estudiante = new Estudiante();
            estudiante.Nombre = "Test Vanguardia";
            estudiante.Edad = 19;
            estudiante.Sexo = "M";
            estudiante.Direccion = "";

            var respuesta = estudianteDomainService.RegistrarEstudiante(estudiante);

            Assert.AreEqual("La direccion es inválida", respuesta);
        }

        [TestMethod]
        public void ValidarCorreo()
        {
            EstudianteDomainService estudianteDomainService = new EstudianteDomainService();
            Estudiante estudiante = new Estudiante();
            estudiante.Nombre = "Test Vanguardia";
            estudiante.Edad = 19;
            estudiante.Sexo = "M";
            estudiante.Correo = "";

            var respuesta = estudianteDomainService.RegistrarEstudiante(estudiante);

            Assert.AreEqual("El correo es inválido", respuesta);
        }

        [TestMethod]
        public void ValidarContrasena()
        {
            EstudianteDomainService estudianteDomainService = new EstudianteDomainService();
            Estudiante estudiante = new Estudiante();
            estudiante.Nombre = "Test Vanguardia";
            estudiante.Edad = 19;
            estudiante.Sexo = "M";
            estudiante.Contrasena = "";

            var respuesta = estudianteDomainService.RegistrarEstudiante(estudiante);

            Assert.AreEqual("La contrasena es inválida", respuesta);
        }
    }
}
