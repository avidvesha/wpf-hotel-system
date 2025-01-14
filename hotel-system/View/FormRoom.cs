using hotel_system.Controller;
using hotel_system.Model.Entity;
using PerpustakaanAppMVC.View;
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
    public partial class FormRoom : Form
    {
        //deklarasi objek collection u/ menampung obj room
        private List<Room> listOfRoom = new List<Room>();
        //deklarasi obj controller
        private RoomController controller;


        public FormRoom()
        {
            InitializeComponent();

            controller = new RoomController();

            InisialisasiListView();
            LoadDataRoom();
        }

        // atur kolom listview
        private void InisialisasiListView()
        {
            lvwRoom.View = System.Windows.Forms.View.Details;
            lvwRoom.FullRowSelect = true;
            lvwRoom.GridLines = true;
            lvwRoom.Columns.Add("#", 35, HorizontalAlignment.Center);
            lvwRoom.Columns.Add("Room Number", 80, HorizontalAlignment.Center);
            lvwRoom.Columns.Add("Type", 80, HorizontalAlignment.Center);
            lvwRoom.Columns.Add("Capacity", 80, HorizontalAlignment.Center);
            lvwRoom.Columns.Add("Price per night", 80, HorizontalAlignment.Center);
            lvwRoom.Columns.Add("In-room Amenities", 80, HorizontalAlignment.Center);
            lvwRoom.Columns.Add("Out-room Amenities", 80, HorizontalAlignment.Center);
            lvwRoom.Columns.Add("Bathroom Amenities", 80, HorizontalAlignment.Center);
        }

        // method untuk menampilkan semua data Room
        private void LoadDataRoom()
        {
            // kosongkan listview
            lvwRoom.Items.Clear();
            // panggil method ReadAll dan tampung datanya ke dalam collection
            listOfRoom = controller.ReadAll();
            // ekstrak objek room dari collection
            foreach (var room in listOfRoom)
            {
                var noUrut = lvwRoom.Items.Count + 1;
                var item = new ListViewItem(noUrut.ToString());
                item.SubItems.Add(room.Id);
                item.SubItems.Add(room.Type);
                item.SubItems.Add(room.Capacity);
                item.SubItems.Add(room.PricePerNight);
                //item.SubItems.Add(room.Inroom_am);
                //item.SubItems.Add(room.Outroom_am);
                //item.SubItems.Add(room.Bathroom_am);
                if (room.Inroom_am == "True")
                {
                    item.SubItems.Add("Yes");
                }
                else
                {
                    item.SubItems.Add("No");
                }
                if (room.Outroom_am == "True")
                {
                    item.SubItems.Add("Yes");
                }
                else
                {
                    item.SubItems.Add("No");
                }
                if (room.Bathroom_am == "True")
                {
                    item.SubItems.Add("Yes");
                }
                else
                {
                    item.SubItems.Add("No");
                }
                // tampilkan data room ke listview
                lvwRoom.Items.Add(item);
            }
        }

        // method untuk menampilkan semua data Room
        private void LoadDataSearch()
        {
            // kosongkan listview
            lvwRoom.Items.Clear();
            // panggil method ReadAll dan tampung datanya ke dalam collection
            listOfRoom = controller.SearchBy(txtNama.Text);
            txtCount.Text = listOfRoom.Count().ToString();
            // ekstrak objek room dari collection
            foreach (var room in listOfRoom)
            {
                var noUrut = lvwRoom.Items.Count + 1;
                var item = new ListViewItem(noUrut.ToString());
                item.SubItems.Add(room.Id);
                item.SubItems.Add(room.Type);
                item.SubItems.Add(room.Capacity);
                item.SubItems.Add(room.PricePerNight);
                if (room.Inroom_am == "True")
                {
                    item.SubItems.Add("Yes");
                }
                else
                {
                    item.SubItems.Add("No");
                }
                if (room.Outroom_am == "True")
                {
                    item.SubItems.Add("Yes");
                }
                else
                {
                    item.SubItems.Add("No");
                }
                if (room.Bathroom_am == "True")
                {
                    item.SubItems.Add("Yes");
                }
                else
                {
                    item.SubItems.Add("No");
                }
                // tampilkan data room ke listview
                lvwRoom.Items.Add(item);
            }
        }

        // method event handler untuk merespon event OnCreate,
        private void OnCreateEventHandler(Room room)
        {
            // tambahkan objek room yang baru ke dalam collection
            listOfRoom.Add(room);
            int noUrut = lvwRoom.Items.Count + 1;
            // tampilkan data room yg baru ke list view
            ListViewItem item = new ListViewItem(noUrut.ToString());
            item.SubItems.Add(room.Id);
            item.SubItems.Add(room.Type);
            item.SubItems.Add(room.Capacity);
            item.SubItems.Add(room.PricePerNight);
            if (room.Inroom_am == "True")
            {
                item.SubItems.Add("Yes");
            }
            else
            {
                item.SubItems.Add("No");
            }
            if (room.Outroom_am == "True")
            {
                item.SubItems.Add("Yes");
            }
            else
            {
                item.SubItems.Add("No");
            }
            if (room.Bathroom_am == "True")
            {
                item.SubItems.Add("Yes");
            }
            else
            {
                item.SubItems.Add("No");
            }
            lvwRoom.Items.Add(item);
        }
        // method event handler untuk merespon event OnUpdate,
        private void OnUpdateEventHandler(Room room)
        {
            // ambil index data room yang edit
            int index = lvwRoom.SelectedIndices[0];
            // update informasi room di listview
            ListViewItem itemRow = lvwRoom.Items[index];
            itemRow.SubItems[1].Text = room.Id;
            itemRow.SubItems[2].Text = room.Type;
            itemRow.SubItems[3].Text = room.Capacity;
            itemRow.SubItems[4].Text = room.PricePerNight;
            itemRow.SubItems[5].Text = room.Inroom_am;
            itemRow.SubItems[6].Text = room.Outroom_am;
            itemRow.SubItems[7].Text = room.Bathroom_am;
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            // buat objek form entry data Room
            FormEntryRoom frmEntry = new FormEntryRoom("Tambah Data Room", controller);
            // mendaftarkan method event handler untuk merespon event OnCreate
            frmEntry.OnCreate += OnCreateEventHandler;
            // tampilkan form entry Room
            frmEntry.ShowDialog();
        }

        private void btnPerbaiki_Click(object sender, EventArgs e)
        {
            if (lvwRoom.SelectedItems.Count > 0)
            {
                // ambil objek room yang mau diedit dari collection
                Room room = listOfRoom[lvwRoom.SelectedIndices[0]];
                // buat objek form entry data Room
                FormEntryRoom frmEntry = new FormEntryRoom("Edit Data Room", room, controller);
                // mendaftarkan method event handler untuk merespon event OnUpdate
                frmEntry.OnUpdate += OnUpdateEventHandler;
                // tampilkan form entry Room
                frmEntry.ShowDialog();
            }
            else // data belum dipilih
            {
                MessageBox.Show("Data belum dipilih", "Peringatan", MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation);
            }
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            if (lvwRoom.SelectedItems.Count > 0)
            {
                var konfirmasi = MessageBox.Show("Apakah data Room ingin dihapus?", "Konfirmasi",
                MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (konfirmasi == DialogResult.Yes)
                {
                    // ambil objek room yang mau dihapus dari collection
                    Room room = listOfRoom[lvwRoom.SelectedIndices[0]];
                    // panggil operasi CRUD
                    var result = controller.Delete(room);
                    if (result > 0) LoadDataRoom();
                }
            }
            else // data belum dipilih
            {
                MessageBox.Show("Data Room belum dipilih !!!", "Peringatan",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnSelesai_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCari_Click(object sender, EventArgs e)
        {
            LoadDataSearch();
        }

    }
}
