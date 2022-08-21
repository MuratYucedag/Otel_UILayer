using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class CustomerProcess
    {
        [Key]
        public int CustomerProcessID { get; set; }
        public DateTime EntryDate { get; set; }
        public DateTime LeaveDate { get; set; }
        public int CountDay { get; set; }
        public decimal Price { get; set; }
        public string RoomNumber { get; set; }
    }
}
