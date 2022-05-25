using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace SEMANA7VK.Models
{
    public class Estudiante
    {
        [AutoIncrement, PrimaryKey]
        public int Id { get; set; }
        [MaxLength(50)]
        public string Nombre { get; set; }
        [MaxLength(50)]
        public string Usuario { get; set; }
        [MaxLength(50)]
        public string Contrasenia { get; set; }


    }
}
