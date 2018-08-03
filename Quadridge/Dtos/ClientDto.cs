using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace Quadridge.Dtos
{
    public class ClientDto
    {
        public int ClientId { get; set; }

        [Required]
        [StringLength(100)]
        public string Firstname { get; set; }

        [Required]
        [StringLength(100)]
        public string Surname { get; set; }

        public int? CompanyId { get; set; }

        [Required]
        [StringLength(255)]
        public string Email { get; set; }

        [Required]
        [StringLength(10)]
        public string CellNo { get; set; }

        [StringLength(10)]
        public string BusinessNo { get; set; }

        [Required]
        [StringLength(255)]
        public string FirstAddressLine { get; set; }

        [StringLength(255)]
        public string SecondAddressLine { get; set; }

        [Required]
        [StringLength(255)]
        public string Suburb { get; set; }

        [Required]
        [StringLength(100)]
        public string City { get; set; }

        [StringLength(8)]
        public string Zip { get; set; }

        [StringLength(100)]
        public string Province { get; set; }

        [Required]
        [StringLength(100)]
        public string Country { get; set; }
    }
}