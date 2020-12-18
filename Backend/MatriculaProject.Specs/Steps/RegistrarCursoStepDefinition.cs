using TechTalk.SpecFlow;
using FluentAssertions;
using MatriculaWebApplicationEF.DomainServices;
using MatriculaWebApplicationEF.Models;

namespace MatriculaProject.Specs.Steps
{
    [Binding]
    public sealed class RegistrarCursoStepDefinition
    {
        private readonly ScenarioContext _scenarioContext;
        private readonly Curso _curso = new Curso();
        private readonly CursoDomainService _cursoDomainService = new CursoDomainService();
        private string _resultado;
        public RegistrarCursoStepDefinition(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }

        [Given(@"el nombre del curso es ""(.*)""")]
        public void GivenElNombreDelCursoEs(string nombre)
        {
            _curso.Nombre = nombre;
        }

        [When(@"registrando el curso")]
        public void WhenRegistrandoElCurso()
        {
            _resultado = _cursoDomainService.RegistrarCurso(_curso);
        }

        [Then(@"el registro del curso es ""(.*)""")]
        public void ThenElRegistroDelCursoEs(string resultado)
        {
            _resultado.Should().Be(resultado);
        }
    }
}