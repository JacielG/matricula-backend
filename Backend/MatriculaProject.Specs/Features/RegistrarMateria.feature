Feature: RegistrarMateria

@Materias
Scenario: Registrar una Materia
	Given el nombre de la materia es "Filosofia"
	Given el CursoId de la materia es 1
	When registrando la materia
	Then el registro de materia es "Successful"