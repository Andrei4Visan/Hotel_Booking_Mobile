using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SQLite;

namespace Hotel_Booking_Mobile.Models
{
    public class Camera
    {
        [PrimaryKey, AutoIncrement]
        public int IdCamera { get; set; }

        [MaxLength(50), Unique]
        public string TipCamera { get; set; }

        public decimal PretPeNoapte { get; set; }

        
    }
}

