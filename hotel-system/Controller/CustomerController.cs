using hotel_system.Model.Context;
using hotel_system.Model.Entity;
using hotel_system.Model.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hotel_system.Controller
{
    public class CustomerController
    {
        private CustomerRepository _repository;

        public int checkForm(Customer _cust)
        {
            if (string.IsNullOrEmpty(_cust.Name))
            {
                MessageBox.Show("Name!!!", "Warning",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }
            // cek nama yang diinputkan tidak boleh kosong
            /*if (string.IsNullOrEmpty(_cust.Date_Birth))
            {
                MessageBox.Show("Date of birth must be filled!!!", "Warning",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }*/
            // cek angkatan yang diinputkan tidak boleh kosong
            if (string.IsNullOrEmpty(_cust.Gender))
            {
                MessageBox.Show("Gender must be filled!!!", "Warning",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }
            if (string.IsNullOrEmpty(_cust.Address))
            {
                MessageBox.Show("Address must be filled!!!", "Warning",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }
            if (string.IsNullOrEmpty(_cust.Phone))
            {
                MessageBox.Show("Phone number must be filled!!!", "Warning",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }
            return 1;
        }

        public int Create(Customer _cust)
        {
            int result = 0;

            // cek Id yang diinputkan tidak boleh kosong

            if (checkForm(_cust) == 1)
            {
                // membuat objek context menggunakan blok using
                using (DbContext context = new DbContext())
                {
                    // membuat objek class repository
                    _repository = new CustomerRepository(context);
                    // panggil method Create class repository untuk menambahkan data
                    result = _repository.Create(_cust);
                }
                if (result > 0)
                {
                    MessageBox.Show("Data Customer berhasil disimpan !", "Informasi",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show("Data Customer gagal disimpan !!!", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            return result;
        }

        public int Update(Customer _cust)
        {
            int result = 0;

            // cek Id yang diinputkan tidak boleh kosong
            if (checkForm(_cust) == 1)
            {
                // membuat objek context menggunakan blok using
                using (DbContext context = new DbContext())
                {
                    // membuat objek class repository
                    _repository = new CustomerRepository(context);
                    // panggil method Create class repository untuk menambahkan data
                    result = _repository.Update(_cust);
                }
                if (result > 0)
                {
                    MessageBox.Show("Data Customer berhasil diubah !", "Informasi",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show("Data Customer gagal diubah !!!", "Peringatan",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            return result;
        }

        public int Delete(Customer _cust)
        {
            int result = 0;

            // cek Id yang diinputkan tidak boleh kosong
            if (checkForm(_cust) == 1)
            {
                // membuat objek context menggunakan blok using
                using (DbContext context = new DbContext())
                {
                    // membuat objek class repository
                    _repository = new CustomerRepository(context);
                    // panggil method Create class repository untuk menambahkan data
                    result = _repository.Delete(_cust);
                }
                if (result > 0)
                {
                    MessageBox.Show("Data Customer berhasil dihapus !", "Informasi",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show("Data Customer gagal dihapus !!!", "Peringatan",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            return result;
        }

        public List<Customer> ReadByNama(string Nama)
        {
            // membuat objek collection
            List<Customer> list = new List<Customer>();
            // membuat objek context menggunakan blok using
            using (DbContext context = new DbContext())
            {
                // membuat objek dari class repository
                _repository = new CustomerRepository(context);
                // panggil method GetByType yang ada di dalam class repository
                list = _repository.ReadByNama(Nama);
            }
            return list;
        }
        public List<Customer> ReadAll()
        {
            // membuat objek collection
            List<Customer> list = new List<Customer>();
            // membuat objek context menggunakan blok using
            using (DbContext context = new DbContext())
            {
                // membuat objek dari class repository
                _repository = new CustomerRepository(context);
                // panggil method GetAll yang ada di dalam class repository
                list = _repository.ReadAll();
            }
            return list;
        }
    }
}
