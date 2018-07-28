using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity.ModelConfiguration;

namespace Quadridge.EntityConfigurations
{
    public class ExpenseTypeConfiguration : EntityTypeConfiguration<ExpenseType>
    {
        public ExpenseTypeConfiguration()
        {
            Property(e => e.ExpenseType1)
            .IsUnicode(false);

            HasMany(e => e.Expenses)
            .WithRequired(e => e.ExpenseType)
            .WillCascadeOnDelete(false);
        }
    }
}