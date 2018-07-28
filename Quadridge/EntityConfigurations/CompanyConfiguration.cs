using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity.ModelConfiguration;

namespace Quadridge.EntityConfigurations
{
    public class CompanyConfiguration : EntityTypeConfiguration<Company>
    {
        public CompanyConfiguration()
        {

            Property(e => e.Name)
            .IsUnicode(false);


            Property(e => e.AddressLine1)
            .IsUnicode(false);


            Property(e => e.AddressLine2)
            .IsUnicode(false);


            Property(e => e.City)
            .IsUnicode(false);


            Property(e => e.Zip)
            .IsUnicode(false);


            Property(e => e.Province)
            .IsUnicode(false);


            Property(e => e.Country)
            .IsUnicode(false);
        }
    }
}