using hotel_system.Model.Context;
using hotel_system.Model.Entity;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hotel_system.Model.Repository
{
    public class RoomRepository
    {
        private MySqlConnection _conn;

        public RoomRepository(DbContext context)
        {
            _conn = context.Conn;
        }

        public int Create(Room _room)
        {
            int result = 0;

            // deklarasi perintah SQL
            string sql = @"INSERT INTO rooms(id_room, type, capacity, price, inroom_am, outroom_am, bathroom_am) VALUES (@id, @type, @capacity, @price, @inroom_am, @outroom_am, @bathroom_am)";

            // membuat objek command menggunakan blok using
            using (MySqlCommand cmd = new MySqlCommand(sql, _conn))
            {
                // mendaftarkan parameter dan mengeset nilainya
                cmd.Parameters.AddWithValue("@id", _room.Id);
                cmd.Parameters.AddWithValue("@type", _room.Type);
                cmd.Parameters.AddWithValue("@capacity", _room.Capacity);
                cmd.Parameters.AddWithValue("@price", _room.PricePerNight);
                cmd.Parameters.AddWithValue("@inroom_am", _room.Inroom_am);
                cmd.Parameters.AddWithValue("@outroom_am", _room.Outroom_am);
                cmd.Parameters.AddWithValue("@bathroom_am", _room.Bathroom_am);
                try
                {
                    // jalankan perintah INSERT dan tampung hasilnya ke dalam variabel result
                    result = cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    System.Diagnostics.Debug.Print("Create error: {0}", ex.Message);
                }
            }
            return result;
        }

        public int Update(Room _room)
        {
            int result = 0;
            // deklarasi perintah SQL
            string sql = @"UPDATE rooms SET type=@type, capacity=@capacity, price=@price, inroom_am=@inroom_am, outroom_am=@outroom_am, bathroom_am=@bathroom_am WHERE id_room=@id";
            // membuat objek command menggunakan blok using
            using (MySqlCommand cmd = new MySqlCommand(sql, _conn))
            {
                // mendaftarkan parameter dan mengeset nilainya
                cmd.Parameters.AddWithValue("@id", _room.Id);
                cmd.Parameters.AddWithValue("@type", _room.Type);
                cmd.Parameters.AddWithValue("@capacity", _room.Capacity);
                cmd.Parameters.AddWithValue("@price", _room.PricePerNight);
                cmd.Parameters.AddWithValue("@inroom_am", _room.Inroom_am);
                cmd.Parameters.AddWithValue("@outroom_am", _room.Outroom_am);
                cmd.Parameters.AddWithValue("@bathroom_am", _room.Bathroom_am);
                try
                {
                    // jalankan perintah UPDATE dan tampung hasilnya ke dalam variabel result
                    result = cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    System.Diagnostics.Debug.Print("Update error: {0}", ex.Message);
                }
            }
            return result;
        }

        public int Delete(Room _room)
        {
            int result = 0;
            // deklarasi perintah SQL
            string sql = @"DELETE FROM rooms WHERE id_room=@id";
            // membuat objek command menggunakan blok using
            using (MySqlCommand cmd = new MySqlCommand(sql, _conn))
            {
                // mendaftarkan parameter dan mengeset nilainya
                cmd.Parameters.AddWithValue("@id", _room.Id);
                try
                {
                    // jalankan perintah DELETE dan tampung hasilnya ke dalam variabel result
                    result = cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    System.Diagnostics.Debug.Print("Delete error: {0}", ex.Message);
                }
            }
            return result;
        }

        public List<Room> ReadAll()
        {
            // membuat objek collection untuk menampung objek mahasiswa
            List<Room> list = new List<Room>();
            try
            {
                // deklarasi perintah SQL
                string sql = @"SELECT id_room, type, capacity, price, inroom_am, outroom_am, bathroom_am FROM rooms ORDER BY id_room";

                // membuat objek command menggunakan blok using
                using (MySqlCommand cmd = new MySqlCommand(sql, _conn))
                {
                    // membuat objek dtr (data reader) untuk menampung result set (hasil perintah SELECT)
                    using (MySqlDataReader dtr = cmd.ExecuteReader())
                    {
                        // panggil method Read untuk mendapatkan baris dari result set
                        while (dtr.Read())
                        {
                            // proses konversi dari row result set ke object
                            Room _room = new Room
                            {
                                Id = dtr["id_room"].ToString(),
                                Type = dtr["type"].ToString(),
                                Capacity = dtr["capacity"].ToString(),
                                PricePerNight = dtr["price"].ToString(),
                                Inroom_am = dtr["inroom_am"].ToString(),
                                Outroom_am = dtr["outroom_am"].ToString(),
                                Bathroom_am = dtr["bathroom_am"].ToString()
                            };

                            // tambahkan objek mahasiswa ke dalam collection
                            list.Add(_room);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.Print("ReadAll error: {0}", ex.Message);
            }
            return list;
        }

        public List<Room> ReadOnOrder(DateTime masuk, DateTime keluar, string type)
        {
            // membuat objek collection untuk menampung objek mahasiswa
            List<Room> list = new List<Room>();
            try
            {
                // deklarasi perintah SQL
                string sql = @"SELECT * FROM rooms WHERE id_room NOT IN ( SELECT id_room FROM orders WHERE isPaid=@status AND ((date_in<=@tgl_in AND date_out>=@tgl_out) OR (date_in BETWEEN @tgl_in AND @tgl_out) OR (date_out BETWEEN @tgl_in AND @tgl_out)) )";

                // membuat objek command menggunakan blok using
                using (MySqlCommand cmd = new MySqlCommand(sql, _conn))
                {
                    cmd.Parameters.AddWithValue("@tgl_in", masuk);
                    cmd.Parameters.AddWithValue("@tgl_out", keluar);
                    //cmd.Parameters.AddWithValue("@tgl_in", string.Format("'{0}'", masuk.ToString()));
                    //cmd.Parameters.AddWithValue("@tgl_out", string.Format("'{0}'", keluar.ToString()));
                    cmd.Parameters.AddWithValue("@type", type);
                    cmd.Parameters.AddWithValue("@status", 0);
                    // membuat objek dtr (data reader) untuk menampung result set (hasil perintah SELECT)
                    using (MySqlDataReader dtr = cmd.ExecuteReader())
                    {
                        // panggil method Read untuk mendapatkan baris dari result set
                        while (dtr.Read())
                        {
                            // proses konversi dari row result set ke object
                            Room _room = new Room
                            {
                                Id = dtr["id_room"].ToString(),
                                Type = dtr["type"].ToString(),
                                Capacity = dtr["capacity"].ToString(),
                                PricePerNight = dtr["price"].ToString(),
                                Inroom_am = dtr["inroom_am"].ToString(),
                                Outroom_am = dtr["outroom_am"].ToString(),
                                Bathroom_am = dtr["bathroom_am"].ToString()
                            };

                            // tambahkan objek mahasiswa ke dalam collection
                            list.Add(_room);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.Print("ReadAll error: {0}", ex.Message);
            }
            return list;
        }

        public List<Room> SearchBy(string nama)
        {
            // membuat objek collection untuk menampung objek mahasiswa
            List<Room> list = new List<Room>();
            try
            {
                // deklarasi perintah SQL
                string sql = @"SELECT id_room, type, capacity, price, inroom_am, outroom_am, bathroom_am FROM rooms WHERE id_room LIKE @param OR type LIKE @param OR capacity LIKE @param OR price LIKE @param ORDER BY id_room";
                // membuat objek command menggunakan blok using
                using (MySqlCommand cmd = new MySqlCommand(sql, _conn))
                {
                    // mendaftarkan parameter dan mengeset nilainya
                    cmd.Parameters.AddWithValue("@param", string.Format("%{0}%", nama));
                    // membuat objek dtr (data reader) untuk menampung result set (hasil perintah SELECT)
                    using (MySqlDataReader dtr = cmd.ExecuteReader())
                    {
                        // panggil method Read untuk mendapatkan baris dari result set
                        while (dtr.Read())
                        {
                            // proses konversi dari row result set ke object
                            Room _room = new Room
                            {
                                Id = dtr["id_room"].ToString(),
                                Type = dtr["type"].ToString(),
                                Capacity = dtr["capacity"].ToString(),
                                PricePerNight = dtr["price"].ToString(),
                                Inroom_am = dtr["inroom_am"].ToString(),
                                Outroom_am = dtr["outroom_am"].ToString(),
                                Bathroom_am = dtr["bathroom_am"].ToString()
                            };
                            // tambahkan objek mahasiswa ke dalam collection
                            list.Add(_room);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.Print("ReadByNama error: {0}", ex.Message);
            }
            return list;
        }
    }
}
