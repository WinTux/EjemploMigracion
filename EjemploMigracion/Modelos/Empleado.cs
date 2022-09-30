using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EjemploMigracion.Modelos
{
    public class Empleado
    {
        public int id { get; set; }
        [Required]
        public string nombre { get; set; }
        public string apellido { get; set; }
    }
}
