using hotel_system.Model.Context;
using hotel_system.Model.Entity;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace hotel_system.Model.Repository
{
    public class OrderRepository
    {
        private MySqlConnection _conn;

        public OrderRepository(DbContext context)
        {
            _conn = context.Conn;
        }

        public int Create(Order _order)
        {
            int result = 0;

            // deklarasi perintah SQL
            string sql = @"INSERT INTO orders (id, id_room, id_customer, date_in, date_out, id_admin, isPaid) VALUES (NULL, @id_room, @id_customer, @date_in, @date_out, @id_admin, @ispaid);";

            // membuat objek command menggunakan blok using
            using (MySqlCommand cmd = new MySqlCommand(sql, _conn))
            {
                // mendaftarkan parameter dan mengeset nilainya
                //cmd.Parameters.AddWithValue("@id", _order.Id);
                cmd.Parameters.AddWithValue("@id_room", _order.Id_Room);
                cmd.Parameters.AddWithValue("@id_customer", _order.Id_Customer);
                cmd.Parameters.AddWithValue("@date_in", _order.DateIn);
                cmd.Parameters.AddWithValue("@date_out", _order.DateOut);
                cmd.Parameters.AddWithValue("@id_admin", _order.Id_Admin);
                cmd.Parameters.AddWithValue("@ispaid", _order.IsPaid);
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

        public int Update(Order _order)
        {
            int result = 0;
            // deklarasi perintah SQL
            string sql = @"UPDATE orders SET id_room=@id_room, id_customer=@id_customer, date_in=@date_in, date_out=@date_out, id_admin=@id_admin WHERE id=@id";
            // membuat objek command menggunakan blok using
            using (MySqlCommand cmd = new MySqlCommand(sql, _conn))
            {
                // mendaftarkan parameter dan mengeset nilainya
                cmd.Parameters.AddWithValue("@id", _order.Id);
                cmd.Parameters.AddWithValue("@id_room", _order.Id_Room);
                cmd.Parameters.AddWithValue("@id_customer", _order.Id_Customer);
                cmd.Parameters.AddWithValue("@date_in", _order.DateIn);
                cmd.Parameters.AddWithValue("@date_out", _order.DateOut);
                cmd.Parameters.AddWithValue("@id_admin", _order.Id_Admin);
                try
                {
                    // jalankan perintah UPDATE dan tampung hasilnya ke dalam variabel result
                    result = cmd.ExecuteNonQuery();
                    // jalankan perintah INSERT dan tampung hasilnya ke dalam variabel result
                    result = cmd.ExecuteNonQuery();
                    if (result > 0)
                    {
                        MessageBox.Show("Data Order berhasil disimpan ke db!", "Informasi",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                        MessageBox.Show("Data Order gagal disimpan ke db!!!", "Warning",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                catch (Exception ex)
                {
                    System.Diagnostics.Debug.Print("Update error: {0}", ex.Message);
                }
            }
            return result;
        }
        
        public int Bayar(string id_order)
        {
            int result = 0;
            // deklarasi perintah SQL
            string sql = @"UPDATE orders SET isPaid=1 WHERE id=@id_order";
            // membuat objek command menggunakan blok using
            using (MySqlCommand cmd = new MySqlCommand(sql, _conn))
            {
                // mendaftarkan parameter dan mengeset nilainya
                cmd.Parameters.AddWithValue("@id_order", id_order);
                try
                {
                    // jalankan perintah INSERT dan tampung hasilnya ke dalam variabel result
                    result = cmd.ExecuteNonQuery();
                    if (result > 0)
                    {
                        MessageBox.Show("Data Order berhasil dibayar ke db!", "Informasi",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                        MessageBox.Show("Data Order gagal dibayar ke db!!!", "Warning",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                catch (Exception ex)
                {
                    System.Diagnostics.Debug.Print("Update error: {0}", ex.Message);
                }
            }
            return result;
        }

        public int Delete(Order _order)
        {
            int result = 0;
            // deklarasi perintah SQL
            string sql = @"DELETE FROM orders WHERE id=@id";
            // membuat objek command menggunakan blok using
            using (MySqlCommand cmd = new MySqlCommand(sql, _conn))
            {
                // mendaftarkan parameter dan mengeset nilainya
                cmd.Parameters.AddWithValue("@id", _order.Id);
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

        public List<Order> ReadAll()
        {
            // membuat objek collection untuk menampung objek mahasiswa
            List<Order> list = new List<Order>();
            try
            {
                // deklarasi perintah SQL
                string sql = @"SELECT `id`, `id_room`, `id_customer`, `date_in`, `date_out`, `id_admin` FROM orders ORDER BY id";
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
                            Order _order = new Order
                            {
                                Id          = dtr["id"].ToString(),
                                Id_Room     = dtr["id_room"].ToString(),
                                Id_Customer = dtr["id_customer"].ToString(),
                                DateIn      = DateTime.Parse(dtr["date_in"].ToString()),
                                DateOut     = DateTime.Parse(dtr["date_out"].ToString()),
                                Id_Admin    = dtr["id_admin"].ToString()
                            };

                            // tambahkan objek mahasiswa ke dalam collection
                            list.Add(_order);
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
        
        public List<OrderShow> ReadOrderList()
        {
            // membuat objek collection untuk menampung objek mahasiswa
            List<OrderShow> list = new List<OrderShow>();
            try
            {
                // deklarasi perintah SQL
                string sql = @"SELECT o.id, r.id_room, c.name, o.date_in, o.date_out, o.id_admin FROM orders o INNER JOIN customers c ON o.id_customer=c.id INNER JOIN rooms r ON o.id_room=r.id_room WHERE isPaid=0 ORDER BY id;";
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
                            OrderShow _order = new OrderShow
                            {
                                Id              = dtr["id"].ToString(),
                                Type_Room       = dtr["id_room"].ToString(),
                                Name_Customer   = dtr["name"].ToString(),
                                DateIn          = DateTime.Parse(dtr["date_in"].ToString()),
                                DateOut         = DateTime.Parse(dtr["date_out"].ToString()),
                                Name_Admin      = dtr["id_admin"].ToString()
                            };

                            // tambahkan objek mahasiswa ke dalam collection
                            list.Add(_order);
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
        
        public List<OrderShow> ReadByName(String Name)
        {
            // membuat objek collection untuk menampung objek mahasiswa
            List<OrderShow> list = new List<OrderShow>();
            try
            {
                // deklarasi perintah SQL
                string sql = @"SELECT o.id, r.id_room, c.name, o.date_in, o.date_out, o.id_admin FROM orders o INNER JOIN customers c ON o.id_customer=c.id INNER JOIN rooms r ON o.id_room=r.id_room WHERE isPaid=0 AND c.name LIKE @param ORDER BY r.id";
                // membuat objek command menggunakan blok using
                using (MySqlCommand cmd = new MySqlCommand(sql, _conn))
                {
                    // membuat objek dtr (data reader) untuk menampung result set (hasil perintah SELECT)
                    cmd.Parameters.AddWithValue("@param", string.Format("%{0}%", Name));
                    using (MySqlDataReader dtr = cmd.ExecuteReader())
                    {
                        // panggil method Read untuk mendapatkan baris dari result set
                        while (dtr.Read())
                        {
                            // proses konversi dari row result set ke object
                            OrderShow _order = new OrderShow
                            {
                                Id              = dtr["id"].ToString(),
                                Type_Room       = dtr["id_room"].ToString(),
                                Name_Customer   = dtr["name"].ToString(),
                                DateIn          = DateTime.Parse(dtr["date_in"].ToString()),
                                DateOut         = DateTime.Parse(dtr["date_out"].ToString()),
                                Name_Admin      = dtr["id_admin"].ToString()
                            };

                            // tambahkan objek mahasiswa ke dalam collection
                            list.Add(_order);
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

        public List<Order> ReadByNama(string nama)
        {
            // membuat objek collection untuk menampung objek mahasiswa
            List<Order> list = new List<Order>();
            try
            {
                // deklarasi perintah SQL
                string sql = @"SELECT id, type, capacity, price FROM orders WHERE id LIKE @id OR type LIKE @type OR capacity LIKE @capacity ORDER BY id";
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
                            Order _order = new Order
                            {
                                Id          = dtr["id"].ToString(),
                                Id_Room     = dtr["id_room"].ToString(),
                                Id_Customer = dtr["id_customer"].ToString(),
                                DateIn      = DateTime.Parse(dtr["date_in"].ToString()),
                                DateOut     = DateTime.Parse(dtr["date_out"].ToString()),
                                Id_Admin    = dtr["id_admin"].ToString()
                            };
                            // tambahkan objek mahasiswa ke dalam collection
                            list.Add(_order);
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
