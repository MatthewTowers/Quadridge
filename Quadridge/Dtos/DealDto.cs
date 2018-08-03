using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Quadridge.Dtos
{
    public class DealDto
    {
        public int DealId { get; set; }

        [Required]
        [MaxLength(255)]
        public string Name { get; set; }

        public int DealTypeId { get; set; }

        public int? RevenueId { get; set; }

        public DateTime Date { get; set; }

        public int? BankId { get; set; }

        public int StatusId { get; set; }

        public int? LawyerId { get; set; }

        public static readonly byte InProgress = 1;
    }
}