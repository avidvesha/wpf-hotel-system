using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hotel_system.Model.Entity
{
    public class Room
    {
        public string Id { get; set; }
        public string Type { get; set; }
        public string Capacity { get; set; }
        public string PricePerNight { get; set; }
        public string Inroom_am {  get; set; }
        public string Outroom_am {  get; set; }
        public string Bathroom_am {  get; set; }
        //public bool IsAvailable { get; set; }
    }
}
