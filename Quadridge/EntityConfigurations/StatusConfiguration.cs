using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity.ModelConfiguration;
using Quadridge.Models;

namespace Quadridge.EntityConfigurations
{
    public class StatusConfiguration : EntityTypeConfiguration<Status>
    {
        public StatusConfiguration()
        {
            Property(e => e.StatusType)
            .IsUnicode(false);

            HasMany(e => e.Deals)
            .WithRequired(e => e.Status)
            .WillCascadeOnDelete(false);
        }
    }
}