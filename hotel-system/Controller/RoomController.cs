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
    public class RoomController
    {
        private RoomRepository _repository;

        private int checkForm(Room _room)
        {
            if (string.IsNullOrEmpty(_room.Id))
            {
                MessageBox.Show("Id harus diisi !!!", "Peringatan",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }
            // cek Type yang diinputkan tidak boleh kosong
            if (string.IsNullOrEmpty(_room.Type))
            {
                MessageBox.Show("Type harus diisi !!!", "Peringatan",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }
            // cek Capacity yang diinputkan tidak boleh kosong
            if (string.IsNullOrEmpty(_room.Capacity))
            {
                MessageBox.Show("Capacity harus diisi !!!", "Peringatan",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }
            if (string.IsNullOrEmpty(_room.PricePerNight))
            {
                MessageBox.Show("Price harus diisi !!!", "Peringatan",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }
            if (string.IsNullOrEmpty(_room.Inroom_am))
            {
                MessageBox.Show("In-room amenities harus diisi !!!", "Peringatan",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }
            if (string.IsNullOrEmpty(_room.Outroom_am))
            {
                MessageBox.Show("Out-room amenities harus diisi !!!", "Peringatan",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }
            if (string.IsNullOrEmpty(_room.Bathroom_am))
            {
                MessageBox.Show("Bathroom amenities harus diisi !!!", "Peringatan",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }
            return 1;
        }

        public int Create(Room _room)
        {
            int result = 0;

            // cek Id yang diinputkan tidak boleh kosong
            if (checkForm(_room) == 1)
            {
                // membuat objek context menggunakan blok using
                using (DbContext context = new DbContext())
                {
                    // membuat objek class repository
                    _repository = new RoomRepository(context);
                    // panggil method Create class repository untuk menambahkan data
                    result = _repository.Create(_room);
                }
                if (result > 0)
                {
                    MessageBox.Show("Data Room berhasil disimpan !", "Informasi",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show("Data Room gagal disimpan !!!", "Peringatan",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            return result;
        }

        public int Update(Room _room)
        {
            int result = 0;

            // cek Id yang diinputkan tidak boleh kosong
            if (checkForm(_room) == 1)
            {
                // membuat objek context menggunakan blok using
                using (DbContext context = new DbContext())
                {
                    // membuat objek class repository
                    _repository = new RoomRepository(context);
                    // panggil method Create class repository untuk menambahkan data
                    result = _repository.Update(_room);
                }
                if (result > 0)
                {
                    MessageBox.Show("Data Room berhasil diubah !", "Informasi",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show("Data Room gagal diubah !!!", "Peringatan",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            return result;
        }

        public int Delete(Room _room)
        {
            int result = 0;

            // cek Id yang diinputkan tidak boleh kosong
            if (checkForm(_room) == 1)
            {
                // membuat objek context menggunakan blok using
                using (DbContext context = new DbContext())
                {
                    // membuat objek class repository
                    _repository = new RoomRepository(context);
                    // panggil method Create class repository untuk menambahkan data
                    result = _repository.Delete(_room);
                }
                if (result > 0)
                {
                    MessageBox.Show("Data Room berhasil dihapus !", "Informasi",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show("Data Room gagal dihapus !!!", "Peringatan",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            return result;
        }


        public List<Room> SearchBy(string nama)
        {
            // membuat objek collection
            List<Room> list = new List<Room>();
            // membuat objek context menggunakan blok using
            using (DbContext context = new DbContext())
            {
                // membuat objek dari class repository
                _repository = new RoomRepository(context);
                // panggil method GetByType yang ada di dalam class repository
                list = _repository.SearchBy(nama);
            }
            return list;
        }

        public List<Room> ReadOnOrder(DateTime tgl_in, DateTime tgl_out, string type)
        {

            List<Room> list = new List<Room>();
            
            //if (tgl_in >= tgl_out)
            //{
            //    MessageBox.Show("Check out date must be after Check in date !!!", "Warning",
            //    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //    return list;
            //} else
            //{
                using (DbContext context = new DbContext())
                {
                    // membuat objek dari class repository
                    _repository = new RoomRepository(context);
                    // panggil method GetAll yang ada di dalam class repository
                    list = _repository.ReadOnOrder(tgl_in, tgl_out, type);
                }
            //}
            
            return list;
        }

        public List<Room> ReadAll()
        {
            // membuat objek collection
            List<Room> list = new List<Room>();
            // membuat objek context menggunakan blok using
            using (DbContext context = new DbContext())
            {
                // membuat objek dari class repository
                _repository = new RoomRepository(context);
                // panggil method GetAll yang ada di dalam class repository
                list = _repository.ReadAll();
            }
            return list;
        }
    }
}
