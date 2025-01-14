using hotel_system.Model.Context;
using hotel_system.Model.Entity;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hotel_system.Model.Repository
{
    public class CustomerRepository
    {
        private MySqlConnection _conn;

        public CustomerRepository(DbContext context)
        {
            _conn = context.Conn;
        }
         
        public int Create(Customer _cust)
        {
            int result = 0;

            // deklarasi perintah SQL
            string sql = @"INSERT INTO customers(name, date_birth, gender, address, phone) VALUES (@name, @date_birth, @gender, @address, @phone)";

            // membuat objek command menggunakan blok using
            using (MySqlCommand cmd = new MySqlCommand(sql, _conn))
            {
                // mendaftarkan parameter dan mengeset nilainya
                cmd.Parameters.AddWithValue("@name", _cust.Name);
                cmd.Parameters.AddWithValue("@date_birth", _cust.Date_Birth);
                cmd.Parameters.AddWithValue("@gender", _cust.Gender);
                cmd.Parameters.AddWithValue("@address", _cust.Address);
                cmd.Parameters.AddWithValue("@phone", _cust.Phone);
                try
                {
                    // jalankan perintah INSERT dan tampung hasilnya ke dalam variabel result
                    result = cmd.ExecuteNonQuery();
                    if (result > 0)
                    {
                        MessageBox.Show("Data Customer berhasil disimpan ke db!", "Informasi",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                        MessageBox.Show("Data Customer gagal disimpan ke db!!!", "Warning",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                catch (Exception ex)
                {
                    System.Diagnostics.Debug.Print("Create error: {0}", ex.Message);
                }
            }
            return result;
        }

        public int Update(Customer _cust)
        {
            int result = 0;
            // deklarasi perintah SQL
            string sql = @"UPDATE customers SET name=@name, date_birth=@date_birth, gender=@gender, address=@address, phone=@phone WHERE id=@id";
            // membuat objek command menggunakan blok using
            using (MySqlCommand cmd = new MySqlCommand(sql, _conn))
            {
                // mendaftarkan parameter dan mengeset nilainya
                cmd.Parameters.AddWithValue("@id", _cust.Id);
                cmd.Parameters.AddWithValue("@name", _cust.Name);
                cmd.Parameters.AddWithValue("@date_birth", _cust.Date_Birth);
                cmd.Parameters.AddWithValue("@gender", _cust.Gender);
                cmd.Parameters.AddWithValue("@address", _cust.Address);
                cmd.Parameters.AddWithValue("@phone", _cust.Phone);
                try
                {
                    // jalankan perintah UPDATE dan tampung hasilnya ke dalam variabel result
                    result = cmd.ExecuteNonQuery();
                    if (result > 0)
                    {
                        MessageBox.Show("Data Customer berhasil diubah ke db!", "Informasi",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                        MessageBox.Show("Data Customer gagal diubah ke db!!!", "Warning",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                catch (Exception ex)
                {
                    System.Diagnostics.Debug.Print("Update error: {0}", ex.Message);
                }
            }
            return result;
        }

        public int Delete(Customer _cust)
        {
            int result = 0;
            // deklarasi perintah SQL
            string sql = @"DELETE FROM customers WHERE id=@id";
            // membuat objek command menggunakan blok using
            using (MySqlCommand cmd = new MySqlCommand(sql, _conn))
            {
                // mendaftarkan parameter dan mengeset nilainya
                cmd.Parameters.AddWithValue("@id", _cust.Id);
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

        public List<Customer> ReadAll()
        {
            // membuat objek collection untuk menampung objek mahasiswa
            List<Customer> list = new List<Customer>();
            try
            {
                // deklarasi perintah SQL
                string sql = @"SELECT id, name, date_birth, gender, address, phone FROM customers ORDER BY id";

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
                            Customer _cust = new Customer
                            {
                                Id = dtr["id"].ToString(),
                                Name = dtr["name"].ToString(),
                                Date_Birth = DateTime.Parse(dtr["date_birth"].ToString()),
                                Gender = dtr["gender"].ToString(),
                                Address = dtr["address"].ToString(),
                                Phone = dtr["phone"].ToString()
                            };

                            // tambahkan objek mahasiswa ke dalam collection
                            list.Add(_cust);
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

        public List<Customer> ReadByNama(string nama)
        {
            // membuat objek collection untuk menampung objek mahasiswa
            List<Customer> list = new List<Customer>();
            try
            {
                // deklarasi perintah SQL
                string sql = @"SELECT * FROM customers WHERE name LIKE @name ORDER BY id";
                // membuat objek command menggunakan blok using
                using (MySqlCommand cmd = new MySqlCommand(sql, _conn))
                {
                    // mendaftarkan parameter dan mengeset nilainya
                    cmd.Parameters.AddWithValue("@name", string.Format("%{0}%", nama));
                    // membuat objek dtr (data reader) untuk menampung result set (hasil perintah SELECT)
                    using (MySqlDataReader dtr = cmd.ExecuteReader())
                    {
                        // panggil method Read untuk mendapatkan baris dari result set
                        while (dtr.Read())
                        {
                            // proses konversi dari row result set ke object
                            Customer _cust = new Customer
                            {
                                Id = dtr["id"].ToString(),
                                Name = dtr["name"].ToString(),
                                Date_Birth = DateTime.Parse(dtr["date_birth"].ToString()),
                                Gender = dtr["gender"].ToString(),
                                Address = dtr["address"].ToString(),
                                Phone = dtr["phone"].ToString()
                            };
                            // tambahkan objek mahasiswa ke dalam collection
                            list.Add(_cust);
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
