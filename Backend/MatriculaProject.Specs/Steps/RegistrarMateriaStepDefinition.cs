using TechTalk.SpecFlow;
using FluentAssertions;
using MatriculaWebApplicationEF.DomainServices;
using MatriculaWebApplicationEF.Models;

namespace MatriculaProject.Specs.Steps
{
    [Binding]
    public sealed class RegistrarMateriaStepDefinition
    {
        private readonly ScenarioContext _scenarioContext;
        private readonly Materia _materia = new Materia();
        private readonly MateriaDomainService _materiaDomainService = new MateriaDomainService();
        private string _resultado;
        public RegistrarMateriaStepDefinition(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }

        [Given(@"el nombre de la materia es ""(.*)""")]
        public void GivenElNombreDeLaMateriaEs(string nombre)
        {
            _materia.Nombre = nombre;
        }

        [Given(@"el CursoId de la materia es (.*)")]
        public void GivenElCursoIdDeLaMateriaEs(int cursoId)
        {
            _materia.CursoId = cursoId;
        }

        [When(@"registrando la materia")]
        public void WhenRegistrandoLaMateria()
        {
            _resultado = _materiaDomainService.RegistrarMateria(_materia);
        }

        [Then(@"el registro de materia es ""(.*)""")]
        public void ThenElRegistroDeMateriaEs(string resultado)
        {
            _resultado.Should().Be(resultado);
        }
    }
}
