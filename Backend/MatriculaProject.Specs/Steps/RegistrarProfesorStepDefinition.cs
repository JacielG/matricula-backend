using TechTalk.SpecFlow;
using FluentAssertions;
using MatriculaWebApplicationEF.DomainServices;
using MatriculaWebApplicationEF.Models;

namespace MatriculaProject.Specs.Steps
{
    [Binding]
    public sealed class RegistrarProfesorStepDefinition
    {
        private readonly ScenarioContext _scenarioContext;
        private readonly Profesor _profesor = new Profesor();
        private readonly ProfesorDomainService _profesorDomainService = new ProfesorDomainService();
        private string _resultado;

        public RegistrarProfesorStepDefinition(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }

        [Given(@"el nombre del profesor es ""(.*)""")]
        public void GivenElNombreDelProfesorEs(string nombre)
        {
            _profesor.Nombre = nombre;
        }

        [Given(@"la edad del profesor is (.*)")]
        public void GivenLaEdadIs(int edad)
        {
            _profesor.Edad = edad;
        }

        [Given(@"el sexo del profesor es ""(.*)""")]
        public void GivenElSexoDelProfesorEs(string sexo)
        {
            _profesor.Sexo = sexo;
        }

        [Given(@"el telefono del profesor es ""(.*)""")]
        public void GivenElTelefonoDelProfesorEs(string telefono)
        {
            _profesor.Telefono = telefono;
        }

        [Given(@"la direccion del profesor es ""(.*)""")]
        public void GivenLaDireccionDelProfesorEs(string direccion)
        {
            _profesor.Direccion = direccion;
        }

        [Given(@"el correo del profesor es ""(.*)""")]
        public void GivenElCorreoDelProfesorEs(string correo)
        {
            _profesor.Correo = correo;
        }

        [Given(@"la contrasena del profesor es ""(.*)""")]
        public void GivenLaContrasenaDelProfesorEs(string contrasena)
        {
            _profesor.Contrasena = contrasena;
        }

        [Given(@"el estado del profesor EstaActivo es ""(.*)""")]
        public void GivenElEstadoDelProfesorEstaActivoEs(string estado)
        {
            _profesor.EstaActivo = estado;
        }

        [Given(@"el PaisId del profesor es (.*)")]
        public void GivenElPaisIdDelProfesorEs(int paisId)
        {
            _profesor.PaisId = paisId;
        }

        [Given(@"el MateriaId del profesor es (.*)")]
        public void GivenElMateriaIdDelProfesorEs(int materiaId)
        {
            _profesor.MateriaId = materiaId;
        }

        [When(@"registrando el profesor")]
        public void WhenRegistrandoElProfesor()
        {
            _resultado = _profesorDomainService.RegistrarProfesor(_profesor);
        }

        [Then(@"el registro del profesor es ""(.*)""")]
        public void ThenElRegistroDelProfesorEs(string resultado)
        {
            _resultado.Should().Be(resultado);
        }
    }
}