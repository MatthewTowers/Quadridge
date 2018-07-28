namespace Quadridge.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Deal")]
    public partial class Deal
    {
        public int DealId { get; set; }

        public int DealTypeId { get; set; }

        public int? RevenueId { get; set; }

        public DateTime Date { get; set; }

        public int? BankId { get; set; }

        public int StatusId { get; set; }

        public int? LawyerId { get; set; }

        public virtual DealType DealType { get; set; }

        public virtual Status Status { get; set; }
    }
}
