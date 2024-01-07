using System;
using Hotel_Booking_Mobile.Data;
using System.IO;
using Microsoft.Maui;
using Microsoft.Maui.Controls.Hosting;


namespace Hotel_Booking_Mobile
{
    public partial class App : Application
    {
        static HotelBookingDatabase database;

        public static HotelBookingDatabase Database
        {
            get
            {
                if (database == null)
                {
                    database = new HotelBookingDatabase(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "HotelBooking.db3"));
                }
                return database;
            }
        }

        public App()
        {
            InitializeComponent();
            MainPage = new MainPage();
        }
    }
}