using hotel_system.Controller;
using hotel_system.Model.Entity;
using hotel_system.View;
using Mysqlx.Crud;
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
    public partial class FormTransaction : Form
    {
        //deklarasi objek collection u/ menampung obj mhs
        private List<OrderShow> listOfOrderShow = new List<OrderShow>();
        //deklarasi obj controller
        private OrderController orderController;
        private TransController transController;


        public FormTransaction()
        {
            InitializeComponent();

            orderController = new OrderController();
            transController = new TransController();

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
            listOfOrderShow = orderController.ReadOrderList();
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
            listOfOrderShow = orderController.ReadByName(txtNama.Text);
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
            int total_bill, night;
            int result = 0;

            if (lvwOrder.SelectedItems.Count > 0)
            {

                // ambil objek mhs yang mau diedit dari collection
                OrderShow ords = listOfOrderShow[lvwOrder.SelectedIndices[0]];
                txtIdOrder.Text = ords.Id;

                night = (ords.DateOut.Subtract(ords.DateIn)).Days;
                txtNight.Text = night.ToString();

                string getPrice = transController.getPrice(ords.Id);
                int price = Int32.Parse(getPrice);
                string chg = "";
                if (txtCharge.Text.Length == 0)
                {
                    chg = "0";
                }
                else
                {
                    chg = txtCharge.Text;
                }
                int charge = Int32.Parse(chg);
                total_bill = price * night + charge;
                txtBill.Text = total_bill.ToString();

                Transaction trans = new Transaction();
                trans.Id_Order = ords.Id;
                trans.Other_charge = chg;
                trans.Total_bill = total_bill.ToString();
                trans.Id_Admin = "1";

                result = transController.Create(trans);
                if (result > 0)
                {
                    result = 0;
                    result = orderController.Bayar(trans.Id_Order);
                    if (result > 0)
                    {
                        txtIdOrder.Clear();
                        txtNama.Clear();
                        txtNight.Clear();
                        txtCharge.Clear();
                        txtBill.Clear();
                    }
                }

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

        private void lvwOrder_SelectedIndexChanged(object sender, EventArgs e)
        {
            int total_bill, room_price, night;

            if (lvwOrder.SelectedItems.Count > 0)
            {

                // ambil objek mhs yang mau diedit dari collection
                OrderShow ords = listOfOrderShow[lvwOrder.SelectedIndices[0]];
                txtIdOrder.Text = ords.Id;

                night = (ords.DateOut.Subtract(ords.DateIn)).Days;
                txtNight.Text = night.ToString(); 
                
                string getPrice = transController.getPrice(ords.Id);
                int price = Int32.Parse(getPrice);
                total_bill = price * night;
                txtBill.Text = total_bill.ToString();
            }

        }

        private void btnCek_Click(object sender, EventArgs e)
        {
            int total_bill, night;

            if (lvwOrder.SelectedItems.Count > 0)
            {

                // ambil objek mhs yang mau diedit dari collection
                OrderShow ords = listOfOrderShow[lvwOrder.SelectedIndices[0]];
                txtIdOrder.Text = ords.Id;

                night = (ords.DateOut.Subtract(ords.DateIn)).Days;
                txtNight.Text = night.ToString();

                string getPrice = transController.getPrice(ords.Id);
                int price = Int32.Parse(getPrice);
                string chg="";
                if (txtCharge.Text.Length == 0)
                {
                    chg = "0";
                }
                else
                {
                    chg = txtCharge.Text;
                }
                int charge = Int32.Parse(chg);
                total_bill = price * night + charge;
                txtBill.Text = total_bill.ToString();
            }
        }
    }
}
