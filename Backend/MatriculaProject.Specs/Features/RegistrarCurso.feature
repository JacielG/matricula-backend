Feature: RegistrarCurso

@Cursos
Scenario: Registrar un Curso
	Given el nombre del curso es "Ingenieria Civil"
	When registrando el curso
	Then el registro del curso es "Successful"