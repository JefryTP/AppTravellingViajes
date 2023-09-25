using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace TravellingViajes.Modelos
{
    internal class Usuario
    {
            [PrimaryKey, AutoIncrement]
            public int Id { get; set; }
        [MaxLength(50)]
        public string Nombre { get; set; }
        [MaxLength(50)]
        public string ApellidoPaterno { get; set; }
        [MaxLength(50)]
        public string ApellidoMaterno { get; set; }
        public int Edad { get; set; }
        [MaxLength(50)]
        public string Correo { get; set; }
        [MaxLength(50)]
        public string Contraseña { get; set; }

    }
}
