namespace Quadridge
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Expense")]
    public partial class Expense
    {
        public int ExpenseId { get; set; }

        public int RevenueId { get; set; }

        public int ExpenseTypeId { get; set; }

        public double Amount { get; set; }

        public virtual ExpenseType ExpenseType { get; set; }

        public virtual Revenue Revenue { get; set; }
    }
}
