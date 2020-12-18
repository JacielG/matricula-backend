Feature: RegistrarProfesor

@Profesores
Scenario: Registrar un profesor
	Given el nombre del profesor es "Josue Aleman"
	And la edad del profesor is 31
	And el sexo del profesor es "M"
	And el telefono del profesor es "98451367"
	And la direccion del profesor es "Campeche"
	And el correo del profesor es "jaleman@gmail.com"
	And la contrasena del profesor es "contrasenia"
	And el estado del profesor EstaActivo es "true"
	And el PaisId del profesor es 1
	And el MateriaId del profesor es 1
	When registrando el profesor
	Then el registro del profesor es "Successful"