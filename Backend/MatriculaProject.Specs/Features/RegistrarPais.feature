Feature: RegistrarPais

@Paises
Scenario: Registrar un Pais
	Given el nombre del pais es "Mexico"
	When registrando el pais
	Then el registro del pais es "Successful"