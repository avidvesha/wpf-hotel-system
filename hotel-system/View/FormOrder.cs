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
    public partial class FormOrder : Form
    {

        private List<Room> listOfRoom = new List<Room>();
        private RoomController roomController;

        public FormOrder()
        {
            roomController = new RoomController();
            InitializeComponent();
            InisialisasiListView();
            LoadDataRoom();
        }

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

        private void LoadDataRoom()
        {
            // kosongkan listview
            lvwRoom.Items.Clear();
            // panggil method ReadAll dan tampung datanya ke dalam collection
            listOfRoom = roomController.ReadAll();
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

        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }

        private void btnFindRoom_Click(object sender, EventArgs e)
        {

        }
    }
}
