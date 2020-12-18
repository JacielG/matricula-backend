using TechTalk.SpecFlow;
using FluentAssertions;
using MatriculaWebApplicationEF.DomainServices;
using MatriculaWebApplicationEF.Models;

namespace MatriculaProject.Specs.Steps
{
    [Binding]
    public sealed class RegistrarEstudianteStepDefinitions
    {
        private readonly ScenarioContext _scenarioContext;
        private readonly Estudiante _estudiante = new Estudiante();
        private readonly EstudianteDomainService _estudianteDomainService = new EstudianteDomainService();
        private string _resultado;
        public RegistrarEstudianteStepDefinitions(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }

        [Given(@"el nombre del estudiante es ""(.*)""")]
        public void GivenElNombreDelEstudianteEs(string nombre)
        {
            _estudiante.Nombre = nombre;
        }

        [Given(@"la edad del estudiante is (.*)")]
        public void GivenLaEdadIs(int edad)
        {
            _estudiante.Edad = edad;
        }

        [Given(@"el sexo del estudiante es ""(.*)""")]
        public void GivenElSexoEs(string sexo)
        {
            _estudiante.Sexo = sexo;
        }

        [Given(@"el telefono del estudiante es ""(.*)""")]
        public void GivenElTelefonoDelEstudianteEs(string telefono)
        {
            _estudiante.Telefono = telefono;
        }

        [Given(@"la direccion del estudiante es ""(.*)""")]
        public void GivenLaDireccionDelEstudianteEs(string direccion)
        {
            _estudiante.Direccion = direccion;
        }

        [Given(@"el correo del estudiante es ""(.*)""")]
        public void GivenElCorreoEs(string correo)
        {
            _estudiante.Correo = correo;
        }

        [Given(@"la contrasena del estudiante es ""(.*)""")]
        public void GivenLaContrasenaEs(string contrasena)
        {
            _estudiante.Contrasena = contrasena;
        }

        [Given(@"el estado del estudiante EstaActivo es ""(.*)""")]
        public void GivenElEstadoDelEstudianteEstaActivoEs(string estado)
        {
            _estudiante.EstaActivo = estado;
        }

        [Given(@"el PaisId del estudiante es (.*)")]
        public void GivenElPaisIdDelEstudianteEs(int paisId)
        {
            _estudiante.PaisId = paisId;
        }

        [Given(@"el CursoId del estudiante es (.*)")]
        public void GivenElCursoIdDelEstudianteEs(int cursoId)
        {
            _estudiante.CursoId = cursoId;
        }

        [When(@"registrando el estudiante")]
        public void WhenRegistrandoElEstudiante()
        {
            _resultado = _estudianteDomainService.RegistrarEstudiante(_estudiante);
        }

        [Then(@"el registro del estudiante es ""(.*)""")]
        public void ThenElRegistroDelEstudianteEs(string resultado)
        {
            _resultado.Should().Be(resultado);
        }
    }
}
