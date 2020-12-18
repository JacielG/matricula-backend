using MatriculaWebApplicationEF.Models;

namespace MatriculaWebApplicationEF.DomainServices
{
    public class MateriaDomainService
    {
        public string RegistrarMateria(Materia materiaRequest)
        {
            var esNombreValido = materiaRequest.Nombre == "";
            if (esNombreValido)
            {
                return "El nombre es inválido.";
            }

            return "Successful";
        }
    }
}
