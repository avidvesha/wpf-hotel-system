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
    public partial class FormCustomer : Form
    {
        //deklarasi objek collection u/ menampung obj mhs
        private List<Customer> listOfCustomer = new List<Customer>();
        //deklarasi obj controller
        private CustomerController controller;


        public FormCustomer()
        {
            InitializeComponent();

            controller = new CustomerController();

            InisialisasiListView();
            LoadDataMahasiswa();
        }

        // atur kolom listview
        private void InisialisasiListView()
        {
            lvwCustomer.View = System.Windows.Forms.View.Details;
            lvwCustomer.FullRowSelect = true;
            lvwCustomer.GridLines = true;
            lvwCustomer.Columns.Add("#", 35, HorizontalAlignment.Center);
            lvwCustomer.Columns.Add("ID", 50, HorizontalAlignment.Center);
            lvwCustomer.Columns.Add("Nama", 250, HorizontalAlignment.Left);
            lvwCustomer.Columns.Add("Date of Birth", 80, HorizontalAlignment.Center);
            lvwCustomer.Columns.Add("Gender", 50, HorizontalAlignment.Center);
            lvwCustomer.Columns.Add("Address", 200, HorizontalAlignment.Center);
            lvwCustomer.Columns.Add("Phone", 100, HorizontalAlignment.Center);
        }

        // method untuk menampilkan semua data mahasiswa
        private void LoadDataMahasiswa()
        {
            // kosongkan listview
            lvwCustomer.Items.Clear();
            // panggil method ReadAll dan tampung datanya ke dalam collection
            listOfCustomer = controller.ReadAll();
            // ekstrak objek mhs dari collection
            foreach (var cust in listOfCustomer)
            {
                var noUrut = lvwCustomer.Items.Count + 1;
                var item = new ListViewItem(noUrut.ToString());
                item.SubItems.Add(cust.Id);
                item.SubItems.Add(cust.Name);
                item.SubItems.Add(cust.Date_Birth.ToString("yyyy-MM-dd"));
                item.SubItems.Add(cust.Gender);
                item.SubItems.Add(cust.Address);
                item.SubItems.Add(cust.Phone);
                // tampilkan data mhs ke listview
                lvwCustomer.Items.Add(item);
            }
        }

        // method untuk menampilkan semua data mahasiswa
        private void LoadDataSearch()
        {
            // kosongkan listview
            lvwCustomer.Items.Clear();
            // panggil method ReadAll dan tampung datanya ke dalam collection
            listOfCustomer = controller.ReadByNama(txtNama.Text);
            txtCount.Text = listOfCustomer.Count().ToString();
            // ekstrak objek mhs dari collection
            foreach (var cust in listOfCustomer)
            {
                var noUrut = lvwCustomer.Items.Count + 1;
                var item = new ListViewItem(noUrut.ToString());
                item.SubItems.Add(cust.Id);
                item.SubItems.Add(cust.Name);
                item.SubItems.Add(cust.Date_Birth.ToString("yyyy-MM-dd"));
                item.SubItems.Add(cust.Gender);
                item.SubItems.Add(cust.Address);
                item.SubItems.Add(cust.Phone);
                // tampilkan data mhs ke listview
                lvwCustomer.Items.Add(item);
            }
        }

        // method event handler untuk merespon event OnCreate,
        private void OnCreateEventHandler(Customer cust)
        {
            // tambahkan objek mhs yang baru ke dalam collection
            listOfCustomer.Add(cust);
            int noUrut = lvwCustomer.Items.Count + 1;
            // tampilkan data mhs yg baru ke list view
            ListViewItem item = new ListViewItem(noUrut.ToString());
            item.SubItems.Add(cust.Id);
            item.SubItems.Add(cust.Name);
            item.SubItems.Add(cust.Date_Birth.ToString("yyyy-MM-dd"));
            item.SubItems.Add(cust.Gender);
            item.SubItems.Add(cust.Address);
            item.SubItems.Add(cust.Phone);
            lvwCustomer.Items.Add(item);
        }
        // method event handler untuk merespon event OnUpdate,
        private void OnUpdateEventHandler(Customer cust)
        {
            // ambil index data mhs yang edit
            int index = lvwCustomer.SelectedIndices[0];
            // update informasi mhs di listview
            ListViewItem itemRow = lvwCustomer.Items[index];
            itemRow.SubItems[1].Text = cust.Id;
            itemRow.SubItems[2].Text = cust.Name;
            itemRow.SubItems[3].Text = cust.Date_Birth.ToString("yyyy-MM-dd");
            itemRow.SubItems[3].Text = cust.Gender;
            itemRow.SubItems[3].Text = cust.Address;
            itemRow.SubItems[3].Text = cust.Phone;
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            // buat objek form entry data mahasiswa
            FormEntryCustomer frmEntry = new FormEntryCustomer("Tambah Data Customer", controller);
            // mendaftarkan method event handler untuk merespon event OnCreate
            frmEntry.OnCreate += OnCreateEventHandler;
            // tampilkan form entry mahasiswa
            frmEntry.ShowDialog();
        }

        private void btnPerbaiki_Click(object sender, EventArgs e)
        {
            if (lvwCustomer.SelectedItems.Count > 0)
            {
                // ambil objek mhs yang mau diedit dari collection
                Customer cust= listOfCustomer[lvwCustomer.SelectedIndices[0]];
                // buat objek form entry data mahasiswa
                FormEntryCustomer frmEntry = new FormEntryCustomer("Edit Data Customer", cust, controller);
                // mendaftarkan method event handler untuk merespon event OnUpdate
                frmEntry.OnUpdate += OnUpdateEventHandler;
                // tampilkan form entry mahasiswa
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
            if (lvwCustomer.SelectedItems.Count > 0)
            {
                var konfirmasi = MessageBox.Show("Apakah data customer ingin dihapus?", "Konfirmasi",
                MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (konfirmasi == DialogResult.Yes)
                {
                    // ambil objek mhs yang mau dihapus dari collection
                    Customer cust = listOfCustomer[lvwCustomer.SelectedIndices[0]];
                    // panggil operasi CRUD
                    var result = controller.Delete(cust);
                    if (result > 0) LoadDataMahasiswa();
                }
            }
            else // data belum dipilih
            {
                MessageBox.Show("Data customer belum dipilih !!!", "Peringatan",
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
