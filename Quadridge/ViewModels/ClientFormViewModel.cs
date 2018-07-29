using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Quadridge.Models;

namespace Quadridge.ViewModels
{
    public class ClientFormViewModel
    {
        public IEnumerable<Province> Provinces { get; set; }
        public IEnumerable<Company> Companies { get; set; }
        public Client Client { get; set; }
    }
}