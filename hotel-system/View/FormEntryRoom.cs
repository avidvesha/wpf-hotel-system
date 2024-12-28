using hotel_system.Controller;
using hotel_system.Model.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hotel_system.View
{
    public partial class FormEntryRoom : Form
    {

        // deklarasi tipe data untuk event OnCreate dan OnUpdate
        public delegate void CreateUpdateEventHandler(Room _room);
        // deklarasi event ketika terjadi proses input data baru
        public event CreateUpdateEventHandler OnCreate;
        // deklarasi event ketika terjadi proses update data
        public event CreateUpdateEventHandler OnUpdate;
        // deklarasi objek controller
        private RoomController controller;
        // deklarasi field untuk menyimpan status entry data (input baru atau update)
        private bool isNewData = true;
        // deklarasi field untuk meyimpan objek Room
        private Room _room;


        public FormEntryRoom()
        {
            InitializeComponent();
        }

        // constructor untuk inisialisasi data ketika entri data baru
        public FormEntryRoom(string title, RoomController controller)
        : this()
        {
            // ganti text/judul form
            this.Text = title;
            this.controller = controller;
        }
        // constructor untuk inisialisasi data ketika mengedit data
        public FormEntryRoom(string title, Room obj, RoomController controller)
        : this()
        {
            // ganti text/judul form
            this.Text = title;
            this.controller = controller;
            isNewData = false; // set status edit data
            _room = obj; // set objek _room yang akan diedit
                       // untuk edit data, tampilkan data lama
            txtId.Text = _room.Id;
            cmbType.Text = _room.Type;
            txtCapacity.Text = _room.Capacity;
            txtPrice.Text = _room.PricePerNight;
            if (_room.Inroom_am == "1")
            {
                cbxInroom.Checked = true;
            } else
            {
                cbxInroom.Checked = false;
            }
            if (_room.Outroom_am == "1")
            {
                cbxOutroom.Checked = true;
            }
            else
            {
                cbxOutroom.Checked = false;
            }
            if (_room.Bathroom_am == "1")
            {
                cbxBathroom.Checked = true;
            }
            else
            {
                cbxBathroom.Checked = false;
            }
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            // jika data baru, inisialisasi objek Room
            if (isNewData) _room = new Room();
            // set nilai property objek Room yg diambil dari TextBox
            _room.Id = txtId.Text;
            _room.Type = cmbType.Text;
            _room.Capacity = txtCapacity.Text;
            _room.PricePerNight = txtPrice.Text;
            if (cbxInroom.Checked == true)
            {
                _room.Inroom_am = "1";
            } else
            {
                _room.Inroom_am = "0";
            }
            if (cbxOutroom.Checked == true)
            {
                _room.Outroom_am = "1";
            } else
            {
                _room.Outroom_am = "0";
            }
            if (cbxBathroom.Checked == true)
            {
                _room.Bathroom_am = "1";
            } else
            {
                _room.Bathroom_am = "0";
            }

            int result = 0;
            if (isNewData) // tambah data baru, panggil method Create
            {
                // panggil operasi CRUD
                result = controller.Create(_room);
                if (result > 0) // tambah data berhasil
                {
                    OnCreate(_room); // panggil event OnCreate
                                   // reset form input, utk persiapan input data berikutnya
                    txtId.Clear();
                    cmbType.Items.Clear();
                    txtCapacity.Value = 1;
                    txtPrice.Clear();
                    cbxInroom.Checked = false;
                    cbxOutroom.Checked = false;
                    cbxBathroom.Checked = false;
                    txtId.Focus();
                }
            }
            else // edit data, panggil method Update
            {
                // panggil operasi CRUD
                result = controller.Update(_room);
                if (result > 0)
                {
                    OnUpdate(_room); // panggil event OnUpdate
                    this.Close();
                }
            }
        }

        private void btnSelesai_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
