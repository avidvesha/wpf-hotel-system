using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hotel_system.Model.Entity
{
    public class OrderShow
    {
        public string Id { get; set; }
        public string Type_Room { get; set; }
        public string Name_Customer { get; set; }
        public DateTime DateIn { get; set; }
        public DateTime DateOut { get; set; }
        public string Name_Admin { get; set; }
    }
}
