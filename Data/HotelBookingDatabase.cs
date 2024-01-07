using Hotel_Booking_Mobile.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Booking_Mobile.Data
{
    public class HotelBookingDatabase
    {
        readonly SQLiteAsyncConnection _database;

        public HotelBookingDatabase(string dbPath)
        {
            _database = new SQLiteAsyncConnection(dbPath);
            _database.CreateTableAsync<Camera>().Wait();
            _database.CreateTableAsync<Rezervare>().Wait();
            _database.CreateTableAsync<Recenzie>().Wait();
        }

        public Task<List<Camera>> GetCamereAsync()
        {
            return _database.Table<Camera>().ToListAsync();
        }

        public Task<Camera> GetCameraAsync(int id)
        {
            return _database.Table<Camera>()
                            .Where(i => i.IdCamera == id)
                            .FirstOrDefaultAsync();
        }

        public Task<int> SaveCameraAsync(Camera camera)
        {
            if (camera.IdCamera != 0)
            {
                return _database.UpdateAsync(camera);
            }
            else
            {
                return _database.InsertAsync(camera);
            }
        }

        public Task<int> DeleteCameraAsync(Camera camera)
        {
            return _database.DeleteAsync(camera);
        }
        public Task<List<Rezervare>> GetRezervariAsync()
        {
            return _database.Table<Rezervare>().ToListAsync();
        }

        public Task<Rezervare> GetRezervareAsync(int id)
        {
            return _database.Table<Rezervare>()
                            .Where(i => i.IdRezervare == id)
                            .FirstOrDefaultAsync();
        }

        public Task<int> SaveRezervareAsync(Rezervare rezervare)
        {
            if (rezervare.IdRezervare != 0)
            {
                return _database.UpdateAsync(rezervare);
            }
            else
            {
                return _database.InsertAsync(rezervare);
            }
        }

        public Task<int> DeleteRezervareAsync(Rezervare rezervare)
        {
            return _database.DeleteAsync(rezervare);
        }

        public Task<List<Recenzie>> GetRecenziiAsync()
        {
            return _database.Table<Recenzie>().ToListAsync();
        }

        public Task<Recenzie> GetRecenzieAsync(int id)
        {
            return _database.Table<Recenzie>()
                            .Where(i => i.IdRecenzie == id)
                            .FirstOrDefaultAsync();
        }

        public Task<int> SaveRecenzieAsync(Recenzie recenzie)
        {
            if (recenzie.IdRecenzie != 0)
            {
                return _database.UpdateAsync(recenzie);
            }
            else
            {
                return _database.InsertAsync(recenzie);
            }
        }

        public Task<int> DeleteRecenzieAsync(Recenzie recenzie)
        {
            return _database.DeleteAsync(recenzie);
        }
    }
}
