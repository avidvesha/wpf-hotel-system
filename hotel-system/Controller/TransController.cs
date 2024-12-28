using hotel_system.Model.Context;
using hotel_system.Model.Entity;
using hotel_system.Model.Repository;
using MySqlX.XDevAPI.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hotel_system.Controller
{
    public class TransController
    {
        private TransRepository _repository;

        public string getPrice(string id_order)
        {
            string result;
            using (DbContext context = new DbContext())
            {
                // membuat objek class repository
                _repository = new TransRepository(context);
                // panggil method Create class repository untuk menambahkan data
                result = _repository.getPrice(id_order);
            }
            if (result.Length > 0)
            {
                MessageBox.Show("Data price berhasil diambil !", "Informasi",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Data price gagal diambil !!!", "Peringatan",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            return result;
        }

        public int Create(Model.Entity.Transaction trans)
        {
            int result = 0;

            // cek form yang diinputkan tidak boleh kosong

            // membuat objek context menggunakan blok using
            using (DbContext context = new DbContext())
            {
                // membuat objek class repository
                _repository = new TransRepository(context);
                // panggil method Create class repository untuk menambahkan data
                result = _repository.Create(trans);
                if (result > 0)
                {
                    MessageBox.Show("Data Transaksi berhasil disimpan !", "Informasi",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show("Data Transaksi gagal disimpan !!!", "Peringatan",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            return result;
        }
    }
}
