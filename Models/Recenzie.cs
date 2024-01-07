using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SQLite;

namespace Hotel_Booking_Mobile.Models
{
    public class Recenzie
    {
        [PrimaryKey, AutoIncrement]
        public int IdRecenzie { get; set; }

        public int IdCamera { get; set; }

        [MaxLength(250), Unique]
        public string Comentariu { get; set; }

        public int Evaluare { get; set; }

        
    }
}

