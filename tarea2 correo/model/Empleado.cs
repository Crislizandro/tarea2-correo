using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace tarea2_correo.model
{
    public class Empleado
    {
        [PrimaryKey, AutoIncrement]
        public int id { get; set; }
        public string nombre { get; set; }
        [MaxLength(100)]
        public string apellidos { get; set;}
        [MaxLength(100)]
        public string edad { get;set; }
        public string correo { get; set; }
        

    }
}
