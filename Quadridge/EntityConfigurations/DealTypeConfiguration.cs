using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity.ModelConfiguration;
using Quadridge.Models;

namespace Quadridge.EntityConfigurations
{
    public class DealTypeConfiguration : EntityTypeConfiguration<DealType>
    {
        public DealTypeConfiguration()
        {

            Property(e => e.Type)
            .IsUnicode(false);


            HasMany(e => e.Deals)
            .WithRequired(e => e.DealType)
            .WillCascadeOnDelete(false);
        }
    }
}