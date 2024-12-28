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
    public class OrderController
    {
        private OrderRepository _repository;

        private int checkForm(Order _order)
        {
            if (string.IsNullOrEmpty(_order.Id))
            {
                MessageBox.Show("Id harus diisi !!!", "Peringatan",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }
            if (string.IsNullOrEmpty(_order.Id_Room))
            {
                MessageBox.Show("Id Room harus diisi !!!", "Peringatan",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }
            if (string.IsNullOrEmpty(_order.Id_Customer))
            {
                MessageBox.Show("Id Customer harus diisi !!!", "Peringatan",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }
            /*if (string.IsNullOrEmpty(_order.DateIn))
            {
                MessageBox.Show("Date-In harus diisi !!!", "Peringatan",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }
            if (string.IsNullOrEmpty(_order.DateOut))
            {
                MessageBox.Show("Date-out harus diisi !!!", "Peringatan",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }*/
            /*if (string.IsNullOrEmpty(_order.Id_Admin))
            {
                MessageBox.Show("Id Admin harus diisi !!!", "Peringatan",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }*/
            return 1;
        }

        public int Create(Order _order)
        {
            int result = 0;

            // cek form yang diinputkan tidak boleh kosong
            
                // membuat objek context menggunakan blok using
            using (DbContext context = new DbContext())
            {
                // membuat objek class repository
                _repository = new OrderRepository(context);
                // panggil method Create class repository untuk menambahkan data
                result = _repository.Create(_order);
                if (result > 0)
                {
                    MessageBox.Show("Data Order berhasil disimpan !", "Informasi",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                } else if (result == null)
                {
                    MessageBox.Show("Return null di controller !!!", "Peringatan",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                    MessageBox.Show("Data Order gagal disimpan !!!", "Peringatan",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            return result;
        }

        public int Update(Order _order)
        {
            int result = 0;

            // cek form yang diinputkan tidak boleh kosong
            checkForm(_order);

            // membuat objek context menggunakan blok using
            using (DbContext context = new DbContext())
            {
                // membuat objek class repository
                _repository = new OrderRepository(context);
                // panggil method Create class repository untuk menambahkan data
                result = _repository.Update(_order);
            }
            if (result > 0)
            {
                MessageBox.Show("Data Order berhasil diubah !", "Informasi",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Data Order gagal diubah !!!", "Peringatan",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            return result;
        }
        public int Bayar(string id_order)
        {
            int result = 0;


            // membuat objek context menggunakan blok using
            using (DbContext context = new DbContext())
            {
                // membuat objek class repository
                _repository = new OrderRepository(context);
                // panggil method Create class repository untuk menambahkan data
                result = _repository.Bayar(id_order);
            }
            if (result > 0)
            {
                MessageBox.Show("Data Order berhasil diubah !", "Informasi",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Data Order gagal diubah !!!", "Peringatan",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            return result;
        }

        public int Delete(Order _order)
        {
            int result = 0;

            // cek form yang diinputkan tidak boleh kosong
            checkForm(_order);

            // membuat objek context menggunakan blok using
            using (DbContext context = new DbContext())
            {
                // membuat objek class repository
                _repository = new OrderRepository(context);
                // panggil method Create class repository untuk menambahkan data
                result = _repository.Delete(_order);
            }
            if (result > 0)
            {
                MessageBox.Show("Data Order berhasil dihapus !", "Informasi",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Data Order gagal dihapus !!!", "Peringatan",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            return result;
        }


        public List<Order> ReadByType(string Type)
        {
            // membuat objek collection
            List<Order> list = new List<Order>();
            // membuat objek context menggunakan blok using
            using (DbContext context = new DbContext())
            {
                // membuat objek dari class repository
                _repository = new OrderRepository(context);
                // panggil method GetByType yang ada di dalam class repository
                list = _repository.ReadByNama(Type);
            }
            return list;
        }
        
        public List<OrderShow> ReadByName(string Name)
        {
            // membuat objek collection
            List<OrderShow> list = new List<OrderShow>();
            // membuat objek context menggunakan blok using
            using (DbContext context = new DbContext())
            {
                // membuat objek dari class repository
                _repository = new OrderRepository(context);
                // panggil method GetByType yang ada di dalam class repository
                list = _repository.ReadByName(Name);
            }
            return list;
        }
        
        public List<Order> ReadAll()
        {
            // membuat objek collection
            List<Order> list = new List<Order>();
            // membuat objek context menggunakan blok using
            using (DbContext context = new DbContext())
            {
                // membuat objek dari class repository
                _repository = new OrderRepository(context);
                // panggil method GetAll yang ada di dalam class repository
                list = _repository.ReadAll();
            }
            return list;
        }
        public List<OrderShow> ReadOrderList()
        {
            // membuat objek collection
            List<OrderShow> list = new List<OrderShow>();
            // membuat objek context menggunakan blok using
            using (DbContext context = new DbContext())
            {
                // membuat objek dari class repository
                _repository = new OrderRepository(context);
                // panggil method GetAll yang ada di dalam class repository
                list = _repository.ReadOrderList();
            }
            return list;
        }
    }
}
