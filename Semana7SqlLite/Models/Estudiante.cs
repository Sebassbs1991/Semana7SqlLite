using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace Semana7SqlLite.Models
{
    public class Estudiante
    {
        [PrimaryKey, AutoIncrement]
        
        public int Id { get; set; }

        [MaxLength(255)]
        public string Nombre { get; set; }

        [MaxLength(255)]
        public string Usuario { get; set; }

        [MaxLength(255)]
        public string Contrasena { get; set; }
    }
}
