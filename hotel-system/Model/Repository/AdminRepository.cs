using hotel_system.Model.Context;
using hotel_system.Model.Entity;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Common;
using PerpustakaanAppMVC.View;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hotel_system.Model.Repository
{
    public class AdminRepository
    {
        private MySqlConnection _conn;

        public AdminRepository(DbContext context)
        {
            _conn = context.Conn;
        }

        /*public int Create(Admin _admin)
        {
            int result = 0;

            // deklarasi perintah SQL
            string sql = @"INSERT INTO admins(id, type, capacity, price) VALUES (@id, @type, @capacity, @price)";

            // membuat objek command menggunakan blok using
            using (MySqlCommand cmd = new MySqlCommand(sql, _conn))
            {
                // mendaftarkan parameter dan mengeset nilainya
                cmd.Parameters.AddWithValue("@id", _admin.Id);
                cmd.Parameters.AddWithValue("@type", _admin.Type);
                cmd.Parameters.AddWithValue("@capacity", _admin.Capacity);
                cmd.Parameters.AddWithValue("@price", _admin.PricePerNight);
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
        }*/

        /*public int Update(Admin_admin)
        {
            int result = 0;
            // deklarasi perintah SQL
            string sql = @"UPDATE admins SET type=@type, capacity=@capacity, price=@price WHERE id=@id";
            // membuat objek command menggunakan blok using
            using (MySqlCommand cmd = new MySqlCommand(sql, _conn))
            {
                // mendaftarkan parameter dan mengeset nilainya
                cmd.Parameters.AddWithValue("@id", _admin.Id);
                cmd.Parameters.AddWithValue("@type", _admin.Type);
                cmd.Parameters.AddWithValue("@capacity", _admin.Capacity);
                cmd.Parameters.AddWithValue("@price", _admin.PricePerNight);
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
        }*/

        /*public int Delete(Admin_admin)
        {
            int result = 0;
            // deklarasi perintah SQL
            string sql = @"DELETE FROM admins WHERE id=@id";
            // membuat objek command menggunakan blok using
            using (MySqlCommand cmd = new MySqlCommand(sql, _conn))
            {
                // mendaftarkan parameter dan mengeset nilainya
                cmd.Parameters.AddWithValue("@id", _admin.Id);
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
        }*/

        public List<Admin> ReadAll()
        {
            // membuat objek collection untuk menampung objek mahasiswa
            List<Admin> list = new List<Admin>();
            try
            {
                // deklarasi perintah SQL
                string sql = @"SELECT id, name, date_birth, gender, address, phone, uname, pwd FROM admins ORDER BY id";
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
                            Admin _admin = new Admin
                            {
                                Id = dtr["id"].ToString(),
                                Name = dtr["name"].ToString(),
                                Date_Birth = dtr["date_birth"].ToString(),
                                Gender = dtr["gender"].ToString(),
                                Address = dtr["address"].ToString(),
                                Phone = dtr["phone"].ToString(),
                                Uname = dtr["uname"].ToString(),
                                Pwd = dtr["pwd"].ToString()
                            };
                                // tambahkan objek mahasiswa ke dalam collection
                                list.Add(_admin);
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

        public List<Admin> ReadByNama(string nama)
        {
            // membuat objek collection untuk menampung objek mahasiswa
            List<Admin> list = new List<Admin>();
            try
            {
                // deklarasi perintah SQL
                string sql = @"SELECT id, name, date_birth, gender, address, phone, uname, pwd FROM admins WHERE name LIKE @name ORDER BY id";
                // membuat objek command menggunakan blok using
                using (MySqlCommand cmd = new MySqlCommand(sql, _conn))
                {
                    // mendaftarkan parameter dan mengeset nilainya
                    cmd.Parameters.AddWithValue("@nama", string.Format("%{0}%", nama));
                    // membuat objek dtr (data reader) untuk menampung result set (hasil perintah SELECT)
                    using (MySqlDataReader dtr = cmd.ExecuteReader())
                    {
                        // panggil method Read untuk mendapatkan baris dari result set
                        while (dtr.Read())
                        {
                            // proses konversi dari row result set ke object
                            Admin _admin= new Admin
                            {
                                Id = dtr["id"].ToString(),
                                Name = dtr["name"].ToString(),
                                Date_Birth = dtr["date_birth"].ToString(),
                                Gender = dtr["gender"].ToString(),
                                Address = dtr["address"].ToString(),
                                Phone = dtr["phone"].ToString(),
                                Uname = dtr["uname"].ToString(),
                                Pwd = dtr["pwd"].ToString()
                            };
                            // tambahkan objek mahasiswa ke dalam collection
                            list.Add(_admin);
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

        public int ReadOnLogin(string uname, string pwd)
        {
            int result = 0;
            try
            {
                // deklarasi perintah SQL
                string sql = "SELECT `id`, `name`, `date_birth`, `gender`, `address`, `phone`, `uname`, `pwd` FROM `admins` WHERE `uname`=" + uname + " AND `pwd`=" + pwd;
                // membuat objek command menggunakan blok using
                using (MySqlDataAdapter adp = new MySqlDataAdapter(sql, _conn))
                {
                    DataTable dtable = new DataTable();
                    adp.Fill(dtable);

                    if (dtable.Rows.Count > 0)
                    {
                        result = 1;
                    }
                }
                return result;
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.Print("ReadByNama error: {0}", ex.Message);
            }
            return result;
        }
    }
}
