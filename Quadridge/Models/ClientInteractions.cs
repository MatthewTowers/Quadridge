using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Quadridge.Models
{
    public class ClientInteractions
    {
        public int InteractionId { get; set; }
        public int ClientId { get; set; }
        public string comment { get; set; }
        public Interaction interaction { get; set; }
        public ClientInteractions()
        {
        }
    }
}
