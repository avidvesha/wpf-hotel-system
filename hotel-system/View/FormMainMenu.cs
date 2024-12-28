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
    public partial class FormMainMenu : Form
    {
        public FormMainMenu()
        {
            InitializeComponent();
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            FormCustomer formCustomer = new FormCustomer();
            formCustomer.Show();
        }

        private void btnRoom_Click(object sender, EventArgs e)
        {
            FormRoom formRoom = new FormRoom();
            formRoom.Show();
        }

        private void btnOrders_Click(object sender, EventArgs e)
        {
            FormOrderMain formOrderMain = new FormOrderMain();
            formOrderMain.Show();
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            FormTransaction formTransaction = new FormTransaction();
            formTransaction.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void btnLog_Click(object sender, EventArgs e)
        {
            
        }
    }
}
