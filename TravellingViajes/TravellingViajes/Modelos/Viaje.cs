using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace TravellingViajes.Modelos
{
    internal class Viaje
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        [MaxLength(50)]
        public string PuntoPartida { get; set; }
        [MaxLength(50)]
        public string PuntoDestino { get; set; }
        [MaxLength(50)]
        public string Agencia { get; set; }
        public double Precio { get; set; }
        [MaxLength(5)]
        public string HoraSalida { get; set; }
        [MaxLength(5)]
        public string HoraLlegada { get; set; }
        public int Duracion { get; set; }
        public DateTime FechaSalida { get; set; }
    }
}
