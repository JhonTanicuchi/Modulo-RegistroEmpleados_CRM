using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EmpleadoRegister.Entities
{
    public class Empleado
    {
        [Key]
        public int EmpleadoId { get; set; }
        public string Identificacion { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Contacto { get; set; }
        public string Email { get; set; }
        public string Clave { get; set; }
        public static DateTime CreacionEmpleado { get; }
        public DateTime Nacimiento { get; set; }

        [NotMapped]
        public string NombreCompleato { get { return $"{Nombre} {Apellido}"; } }
        [NotMapped]
        public double Edad { get { return DateTime.Now.Subtract(Nacimiento).TotalDays / 365; } }
    }
}
