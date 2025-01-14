using hotel_system.Controller;
using hotel_system.Model.Entity;
using hotel_system.View;
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

namespace hotel_system
{
    public partial class FormLogin : Form
    {
        private List<Admin> listOfAdmin = new List<Admin>();
        private AdminController controller;
        private bool isNewData = true;
        private Admin _admin;



        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            string uname, pwd;
            uname = txtUser.Text;
            pwd = txtPass.Text;


            //int result = controller.ReadOnLogin(uname, pwd);

            if (uname=="kenthir" && pwd=="panorama")
            {
                FormMainMenu formEntryRoom = new FormMainMenu();
                formEntryRoom.Show();
                this.Hide();

            } else
            {
                MessageBox.Show("Data not found !!!", "Warning",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtUser.Clear();
                txtPass.Clear();
                txtUser.Focus();
            }


        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
