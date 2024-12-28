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
    internal class AdminController
    {
        private AdminRepository _repository;

        /*private int checkForm(Admin _admin)
        {
            if (string.IsNullOrEmpty(_admin.Id))
            {
                MessageBox.Show("Id harus diisi !!!", "Peringatan",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }
            // cek Type yang diinputkan tidak boleh kosong
            if (string.IsNullOrEmpty(_admin.Type))
            {
                MessageBox.Show("Type harus diisi !!!", "Peringatan",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }
            // cek Capacity yang diinputkan tidak boleh kosong
            if (string.IsNullOrEmpty(_admin.Capacity))
            {
                MessageBox.Show("Capacity harus diisi !!!", "Peringatan",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }
            return 1;
        }*/

        /*public int Create(Admin _admin)
        {
            int result = 0;

            // cek Id yang diinputkan tidak boleh kosong
            checkForm(_admin);

            // membuat objek context menggunakan blok using
            using (DbContext context = new DbContext())
            {
                // membuat objek class repository
                _repository = new AdminRepository(context);
                // panggil method Create class repository untuk menambahkan data
                result = _repository.Create(_admin);
            }
            if (result > 0)
            {
                MessageBox.Show("Data Admin berhasil disimpan !", "Informasi",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Data Admin gagal disimpan !!!", "Peringatan",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            return result;
        }*/

        /*public int Update(Admin _admin)
        {
            int result = 0;

            // cek Id yang diinputkan tidak boleh kosong
            checkForm(_admin);

            // membuat objek context menggunakan blok using
            using (DbContext context = new DbContext())
            {
                // membuat objek class repository
                _repository = new AdminRepository(context);
                // panggil method Create class repository untuk menambahkan data
                result = _repository.Update(_admin);
            }
            if (result > 0)
            {
                MessageBox.Show("Data Admin berhasil diubah !", "Informasi",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Data Admin gagal diubah !!!", "Peringatan",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            return result;
        }*/

        /*public int Delete(Admin _admin)
        {
            int result = 0;

            // cek Id yang diinputkan tidak boleh kosong
            checkForm(_admin);

            // membuat objek context menggunakan blok using
            using (DbContext context = new DbContext())
            {
                // membuat objek class repository
                _repository = new AdminRepository(context);
                // panggil method Create class repository untuk menambahkan data
                result = _repository.Delete(_admin);
            }
            if (result > 0)
            {
                MessageBox.Show("Data Admin berhasil dihapus !", "Informasi",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Data Admin gagal dihapus !!!", "Peringatan",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            return result;
        }*/


        public List<Admin> ReadByNama(string Nama)
        {
            // membuat objek collection
            List<Admin> list = new List<Admin>();
            // membuat objek context menggunakan blok using
            using (DbContext context = new DbContext())
            {
                // membuat objek dari class repository
                _repository = new AdminRepository(context);
                // panggil method GetByType yang ada di dalam class repository
                list = _repository.ReadByNama(Nama);
            }
            return list;
        }
        /*public List<Admin> ReadOnLogin(string uname, string pwd)
        {
            // membuat objek collection
            List<Admin> list = new List<Admin>();
            // membuat objek context menggunakan blok using
            using (DbContext context = new DbContext())
            {
                // membuat objek dari class repository
                _repository = new AdminRepository(context);
                // panggil method GetByType yang ada di dalam class repository
                list = _repository?.ReadOnLogin(uname, pwd);
            }
            return list;
        }*/
        public int ReadOnLogin(string uname, string pwd)
        {
            int result = 0;

            // membuat objek context menggunakan blok using
            using (DbContext context = new DbContext())
            {
                // membuat objek class repository
                _repository = new AdminRepository(context);
                // panggil method Create class repository untuk menambahkan data
                result = _repository.ReadOnLogin(uname, pwd);
            }
            if (result > 0)
            {
                result = 1;
                MessageBox.Show("You are logged in !", "Informasi",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("You are not authorized !!!", "Peringatan",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            return result;
        }
        public List<Admin> ReadAll()
        {
            // membuat objek collection
            List<Admin> list = new List<Admin>();
            // membuat objek context menggunakan blok using
            using (DbContext context = new DbContext())
            {
                // membuat objek dari class repository
                _repository = new AdminRepository(context);
                // panggil method GetAll yang ada di dalam class repository
                list = _repository.ReadAll();
            }
            return list;
        }
    }
}
