using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Quadridge.Models
{
    public class Client
    {
        public int ClientId { get; set; }
        public string FirstName { get; set; }
        public string Surname { get; set; }
        public int CompanyId { get; set; }
        public string Email { get; set; }
        public string BusinessTel { get; set; }
        public string Cellphone { get; set; }
        public string addressLine1 { get; set; }
        public string addressLine2 { get; set; }
        public string City { get; set; }
        public string Province { get; set; }
        public string Zip { get; set; }
        public string Country { get; set; }

        public Client(){
            
        }
    }
}
