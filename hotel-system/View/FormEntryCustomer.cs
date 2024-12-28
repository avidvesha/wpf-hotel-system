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
    public partial class FormEntryCustomer : Form
    {

        // deklarasi tipe data untuk event OnCreate dan OnUpdate
        public delegate void CreateUpdateEventHandler(Customer cust);
        // deklarasi event ketika terjadi proses input data baru
        public event CreateUpdateEventHandler OnCreate;
        // deklarasi event ketika terjadi proses update data
        public event CreateUpdateEventHandler OnUpdate;
        // deklarasi objek controller
        private CustomerController controller;
        // deklarasi field untuk menyimpan status entry data (input baru atau update)
        private bool isNewData = true;
        // deklarasi field untuk meyimpan objek Customer
        private Customer cust;


        public FormEntryCustomer()
        {
            InitializeComponent();
        }

        // constructor untuk inisialisasi data ketika entri data baru
        public FormEntryCustomer(string title, CustomerController controller)
        : this()
        {
            // ganti text/judul form
            this.Text = title;
            this.controller = controller;
        }
        // constructor untuk inisialisasi data ketika mengedit data
        public FormEntryCustomer(string title, Customer obj, CustomerController controller)
        : this()
        {
            // ganti text/judul form
            this.Text = title;
            this.controller = controller;
            isNewData = false; // set status edit data
            cust = obj; // set objek cust yang akan diedit
                        // untuk edit data, tampilkan data lama
            txtName.Text = cust.Name;
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "yyyy-MM-dd";
            dateTimePicker1.Text = cust.Date_Birth.ToString();
            cbxGender.Text = cust.Gender;
            txtAddress.Text = cust.Address;
            txtPhone.Text = cust.Phone;
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            // jika data baru, inisialisasi objek Customer
            if (isNewData) cust = new Customer();
            // set nilai property objek Customer yg diambil dari TextBox
            cust.Name = txtName.Text;
            cust.Date_Birth = DateTime.Parse(dateTimePicker1.Text);
            cust.Gender = cbxGender.Text;
            cust.Address = txtAddress.Text;
            cust.Phone = txtPhone.Text;
            int result = 0;
            if (isNewData) // tambah data baru, panggil method Create
            {
                // panggil operasi CRUD
                result = controller.Create(cust);
                if (result > 0) // tambah data berhasil
                {
                    OnCreate(cust); // panggil event OnCreate
                                    // reset form input, utk persiapan input data berikutnya
                    txtName.Clear();
                    dateTimePicker1.ResetText();
                    cbxGender.Refresh();
                    txtAddress.Clear();
                    txtPhone.Clear();
                    txtName.Focus();
                }
            }
            else // edit data, panggil method Update
            {
                // panggil operasi CRUD
                result = controller.Update(cust);
                if (result > 0)
                {
                    OnUpdate(cust); // panggil event OnUpdate
                    this.Close();
                }
            }
        }

        private void btnSelesai_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormEntryCustomer_Load(object sender, EventArgs e)
        {

        }

    }
}
