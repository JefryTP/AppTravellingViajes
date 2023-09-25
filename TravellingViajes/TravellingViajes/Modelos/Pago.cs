using SQLite;
using SQLiteNetExtensions.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace TravellingViajes.Modelos
{
    internal class Pago
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        [MaxLength(12)]
        public int NumeroTarjeta { get; set; }

        [MaxLength(5)]
        public string FechaExpiracion { get; set; }
        [MaxLength(3)]
        public int CodigoCCV { get; set; }
        [MaxLength(5)]
        public string tarjeta { get; set; }

        // Clave externa que se relaciona con TipoTarjeta
        //public int TipoTarjetaId { get; set; }

        // Propiedad de navegación para acceder al tipo de tarjeta
        /*[ManyToOne]
        public TipoTarjeta TipoTarjeta { get; set; }*/
    }
}

