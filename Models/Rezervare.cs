using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SQLite;

namespace Hotel_Booking_Mobile.Models
{
    public class Rezervare
    {
        [PrimaryKey, AutoIncrement]
        public int IdRezervare { get; set; }

        public int IdCamera { get; set; }

        public DateTime DataCheckIn { get; set; }

        public DateTime DataCheckOut { get; set; }

        
    }
}
