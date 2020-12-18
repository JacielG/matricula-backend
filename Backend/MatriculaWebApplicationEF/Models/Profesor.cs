using System.Collections.Generic;

namespace MatriculaWebApplicationEF.Models
{
    public class Profesor
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public string Sexo { get; set; }
        public string Telefono { get; set; }
        public string Direccion { get; set; }
        public string Correo { get; set; }
        public string Contrasena { get; set; }
        public string EstaActivo { get; set; }
        public int PaisId { get; set; }
        public int MateriaId { get; set; }
        public Pais Pais { get; set; }
        public Materia Materia { get; set; }
    }
}