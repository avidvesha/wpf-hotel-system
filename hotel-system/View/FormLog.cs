using hotel_system.Controller;
using hotel_system.Model.Entity;
using hotel_system.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PerpustakaanAppMVC.View
{
    public partial class FormLog : Form
    {
        //deklarasi objek collection u/ menampung obj mhs
        private List<OrderShow> listOfOrderShow= new List<OrderShow>();
        private List<Order> listOfOrder= new List<Order>();
        //deklarasi obj controller
        private OrderController controller;


        public FormLog()
        {
            InitializeComponent();

            controller = new OrderController();

            InisialisasiListView();
            LoadDataMahasiswa();
        }

        // atur kolom listview
        private void InisialisasiListView()
        {
            lvwOrder.View = System.Windows.Forms.View.Details;
            lvwOrder.FullRowSelect = true;
            lvwOrder.GridLines = true;
            lvwOrder.Columns.Add("#", 35, HorizontalAlignment.Center);
            lvwOrder.Columns.Add("Room Num.", 80, HorizontalAlignment.Center);
            lvwOrder.Columns.Add("Name", 250, HorizontalAlignment.Left);
            lvwOrder.Columns.Add("Check-in", 80, HorizontalAlignment.Center);
            lvwOrder.Columns.Add("Check-out", 80, HorizontalAlignment.Center);
            lvwOrder.Columns.Add("Admin", 50, HorizontalAlignment.Center);
        }

        // method untuk menampilkan semua data mahasiswa
        private void LoadDataMahasiswa()
        {
            // kosongkan listview
            lvwOrder.Items.Clear();
            // panggil method ReadAll dan tampung datanya ke dalam collection
            listOfOrderShow = controller.ReadOrderLog();
            // ekstrak objek mhs dari collection
            foreach (var ords in listOfOrderShow)
            {
                var noUrut = lvwOrder.Items.Count + 1;
                var item = new ListViewItem(noUrut.ToString());
                item.SubItems.Add(ords.Type_Room);
                item.SubItems.Add(ords.Name_Customer);
                item.SubItems.Add(ords.DateIn.ToString("yyyy-MM-dd"));
                item.SubItems.Add(ords.DateOut.ToString("yyyy-MM-dd"));
                item.SubItems.Add(ords.Name_Admin);
                // tampilkan data mhs ke listview
                lvwOrder.Items.Add(item);
            }
        }

        // method untuk menampilkan semua data mahasiswa
        private void LoadDataSearch()
        {
            // kosongkan listview
            lvwOrder.Items.Clear();
            // panggil method ReadAll dan tampung datanya ke dalam collection
            listOfOrderShow = controller.ReadByLog(txtNama.Text);
            txtCount.Text = listOfOrderShow.Count().ToString();
            // ekstrak objek mhs dari collection
            foreach (var ords in listOfOrderShow)
            {
                var noUrut = lvwOrder.Items.Count + 1;
                var item = new ListViewItem(noUrut.ToString());
                item.SubItems.Add(ords.Type_Room);
                item.SubItems.Add(ords.Name_Customer);
                item.SubItems.Add(ords.DateIn.ToString("yyyy-MM-dd"));
                item.SubItems.Add(ords.DateOut.ToString("yyyy-MM-dd"));
                item.SubItems.Add(ords.Name_Admin);
                // tampilkan data mhs ke listview
                lvwOrder.Items.Add(item);
            }
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            FormOrderCust formOrderCust = new FormOrderCust();
            formOrderCust.ShowDialog();
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
