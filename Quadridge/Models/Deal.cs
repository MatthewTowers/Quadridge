using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Quadridge.Models
{
    public class Deal
    {
        public int DealId { get; set; }
        public string Name { get; set; }
        public DealType Type { get; set;  }
        public double Revenue { get; set; }
        public DateTime Date { get; set; }
        public Bank Bank { get; set; }
        public Lawyer Lawyer { get; set;  }
        public Status Status { get; set; }
        public Deal()
        {
        }
    }
}
