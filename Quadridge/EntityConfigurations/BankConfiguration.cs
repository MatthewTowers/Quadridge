using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Quadridge.Models;
using System.Data.Entity.ModelConfiguration;

namespace Quadridge.EntityConfigurations
{
    public class BankConfiguration : EntityTypeConfiguration<Bank>
    {
        public BankConfiguration()
        {
            Property(e => e.Name)
            .IsUnicode(false);
        }
    }
}