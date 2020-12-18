Feature: RegistrarEstudiante

@Estudiantes
Scenario: Registrar un estudiante
	Given el nombre del estudiante es "Reina Alcantara"
	And la edad del estudiante is 21
	And el sexo del estudiante es "F"
	And el telefono del estudiante es "98575758"
	And la direccion del estudiante es "Campeche"
	And el correo del estudiante es "reina@gmail.com"
	And la contrasena del estudiante es "contrasenia"
	And el estado del estudiante EstaActivo es "true"
	And el PaisId del estudiante es 1
	And el CursoId del estudiante es 1
	When registrando el estudiante
	Then el registro del estudiante es "Successful"
