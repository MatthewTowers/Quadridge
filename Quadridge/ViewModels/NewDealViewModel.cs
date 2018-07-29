using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Quadridge.Models;

namespace Quadridge.ViewModels
{
    public class NewDealViewModel
    {
        public IEnumerable<Client> clients { get; set; }
        public Deal deal { get; set; }
    }
}