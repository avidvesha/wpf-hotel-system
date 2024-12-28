using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hotel_system.Model.Entity
{
    public class Transaction
    {
        public string Id { get; set; }
        public string Id_Order { get; set; }
        public string Other_charge { get; set; }
        public string Total_bill{ get; set; }
        public string Id_Admin { get; set; }
    }
}
