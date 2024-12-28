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
    public partial class FormOrderRoom : Form
    {
        //deklarasi objek collection u/ menampung obj room
        private List<Room> listOfRoom = new List<Room>();
        private RoomController controller;
        //deklarasi obj controller
        private OrderController orderController;
        private string ygOrder;

        public FormOrderRoom(string idCust)
        {
            InitializeComponent();

            controller = new RoomController();
            orderController = new OrderController();
            dtIn.Format = DateTimePickerFormat.Custom;
            dtIn.CustomFormat = "yyyy-MM-dd";
            dtOut.Format = DateTimePickerFormat.Custom;
            dtOut.CustomFormat = "yyyy-MM-dd";

            ygOrder = idCust;

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
            dtIn.Format = DateTimePickerFormat.Custom;
            dtIn.CustomFormat = "yyyy-MM-dd";
            dtOut.Format = DateTimePickerFormat.Custom;
            dtOut.CustomFormat = "yyyy-MM-dd";
            DateTime co_date = dtOut.Value.AddDays(-1);
            // kosongkan listview
            lvwRoom.Items.Clear();
            // panggil method ReadAll dan tampung datanya ke dalam collection
            listOfRoom = controller.ReadOnOrder(dtIn.Value, co_date, txtNama.Text);
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

        private void btnSelesai_Click(object sender, EventArgs e)
        {

            if (lvwRoom.SelectedItems.Count > 0)
            {
                
                // ambil objek mhs yang mau diedit dari collection
                Room room = listOfRoom[lvwRoom.SelectedIndices[0]];
                Order _order = new Order();
                dtIn.Format = DateTimePickerFormat.Custom;
                dtIn.CustomFormat = "yyyy-MM-dd";
                dtOut.Format = DateTimePickerFormat.Custom;
                dtOut.CustomFormat = "yyyy-MM-dd";
                _order.Id = "1";
                _order.Id_Customer = ygOrder;
                _order.Id_Room = room.Id;
                _order.DateIn = DateTime.Parse(dtIn.Text);
                _order.DateOut = DateTime.Parse(dtOut.Text);
                _order.Id_Admin = "1";
                _order.IsPaid = "0";
                int result = orderController.Create(_order);
                if (result > 0)
                {
                    this.Close();
                }
            }
            else // data belum dipilih
            {
                MessageBox.Show("Data belum dipilih", "Peringatan", MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation);
            }
        }

        private void btnCari_Click(object sender, EventArgs e)
        {
            LoadDataSearch();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormOrderCust formOrderCust = new FormOrderCust();
            formOrderCust.ShowDialog();
            this.Close();
        }

        
    }
}
