using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hotel_system.Model.Entity
{
    public class Order
    {
        public string Id { get; set; }
        public string Id_Room { get; set; }
        public string Id_Customer { get; set; }
        public DateTime DateIn { get; set; }
        public DateTime DateOut { get; set; }
        public string Id_Admin { get; set; }
        public string IsPaid { get; set; }

    }


}