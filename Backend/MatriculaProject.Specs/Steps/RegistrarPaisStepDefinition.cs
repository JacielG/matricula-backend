using TechTalk.SpecFlow;
using FluentAssertions;
using MatriculaWebApplicationEF.DomainServices;
using MatriculaWebApplicationEF.Models;

namespace MatriculaProject.Specs.Steps
{
    [Binding]
    public sealed class RegistrarPaisStepDefinition
    {
        private readonly ScenarioContext _scenarioContext;
        private readonly Pais _pais = new Pais();
        private readonly PaisDomainService _paisDomainService = new PaisDomainService();
        private string _resultado;
        public RegistrarPaisStepDefinition(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }

        [Given(@"el nombre del pais es ""(.*)""")]
        public void GivenElNombreDelPaisEs(string nombre)
        {
            _pais.Nombre = nombre;
        }

        [When(@"registrando el pais")]
        public void WhenRegistrandoElPais()
        {
            _resultado = _paisDomainService.RegistrarPais(_pais);
        }

        [Then(@"el registro del pais es ""(.*)""")]
        public void ThenElRegistroDelPaisEs(string resultado)
        {
            _resultado.Should().Be(resultado);
        }
    }
}