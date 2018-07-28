using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity.ModelConfiguration;

namespace Quadridge.EntityConfigurations
{
    public class RevenueConfiguration : EntityTypeConfiguration<Revenue>
    {
        public RevenueConfiguration()
        {
            HasMany(e => e.Expenses)
            .WithRequired(e => e.Revenue)
            .WillCascadeOnDelete(false);
        }
    }
}