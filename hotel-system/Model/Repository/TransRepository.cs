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
    public class TransRepository
    {
        private MySqlConnection _conn;

        public TransRepository(DbContext context)
        {
            _conn = context.Conn;
        }

        public string getPrice(string idtrans)
        {
            // membuat objek collection untuk menampung objek mahasiswa
            string result="";
            string id_room="";
            try
            {
                // deklarasi perintah SQL
                string sql = @"SELECT rooms.id_room FROM rooms INNER JOIN orders ON orders.id_room=rooms.id_room WHERE orders.id=@idtrans;";
                // membuat objek command menggunakan blok using
                using (MySqlCommand cmd = new MySqlCommand(sql, _conn))
                {
                    cmd.Parameters.AddWithValue("@idtrans", idtrans);

                    // membuat objek dtr (data reader) untuk menampung result set (hasil perintah SELECT)
                    using (MySqlDataReader dtr = cmd.ExecuteReader())
                    {
                        // panggil method Read untuk mendapatkan baris dari result set
                        while (dtr.Read())
                        {
                            id_room = dtr["id_room"].ToString();
                        }
                    }
                }

                sql = @"SELECT price FROM rooms WHERE id_room=@param;";
                // membuat objek command menggunakan blok using
                using (MySqlCommand cmd = new MySqlCommand(sql, _conn))
                {
                    cmd.Parameters.AddWithValue("@param", id_room);

                    // membuat objek dtr (data reader) untuk menampung result set (hasil perintah SELECT)
                    using (MySqlDataReader dtr = cmd.ExecuteReader())
                    {
                        // panggil method Read untuk mendapatkan baris dari result set
                        while (dtr.Read())
                        {
                            result = dtr["price"].ToString();
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.Print("ReadAll error: {0}", ex.Message);
            }
            return result;
        }

        public int Create(Transaction trans)
        {
            int result = 0;

            // deklarasi perintah SQL
            string sql = @"INSERT INTO transactions(id, id_order, other_charge, total_bill, id_admin) VALUES (NULL, @id_order, @other_charge, @total_bill, @id_admin)";

            // membuat objek command menggunakan blok using
            using (MySqlCommand cmd = new MySqlCommand(sql, _conn))
            {
                // mendaftarkan parameter dan mengeset nilainya
                //cmd.Parameters.AddWithValue("@id", trans.Id);
                cmd.Parameters.AddWithValue("@id_order", trans.Id_Order);
                cmd.Parameters.AddWithValue("@other_charge", trans.Other_charge);
                cmd.Parameters.AddWithValue("@total_bill", trans.Total_bill);
                cmd.Parameters.AddWithValue("@id_admin", trans.Id_Admin);
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
    }
}
