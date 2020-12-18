using MatriculaWebApplicationEF.Models;

namespace MatriculaWebApplicationEF.DomainServices
{
    public class EstudianteDomainService
    {
        public string RegistrarEstudiante(Estudiante estudianteRequest)
        {
            var esEdadValida = estudianteRequest.Edad < 18;
            if (esEdadValida)
            {
                return "Edad es inválida, debe ser mayor a 18";
            }

            var esSexoValido = estudianteRequest.Sexo != "M" && estudianteRequest.Sexo != "F";
            if (esSexoValido)
            {
                return "El sexo es inválido";
            }

            var esTelefonoValido = estudianteRequest.Telefono == "";
            if (esTelefonoValido)
            {
                return "El telefono es inválido";
            }

            var esDireccionValida = estudianteRequest.Direccion == "";
            if (esDireccionValida)
            {
                return "La direccion es inválida";
            }

            var esCorreoValido = estudianteRequest.Correo == "";
            if (esCorreoValido)
            {
                return "El correo es inválido";
            }

            var esContrasenaValida = estudianteRequest.Contrasena == "";
            if (esContrasenaValida)
            {
                return "La contrasena es inválida";
            }

            return "Successful";
        }
    }
}