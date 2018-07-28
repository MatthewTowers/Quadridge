using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity.ModelConfiguration;
using Quadridge.Models;

namespace Quadridge.EntityConfigurations
{
    public class LawyerConfiguration : EntityTypeConfiguration<Lawyer>
    {
        public LawyerConfiguration()
        {
            Property(e => e.Name)
            .IsUnicode(false);

            Property(e => e.Surname)
            .IsUnicode(false);

            Property(e => e.Firm)
            .IsUnicode(false);

            Property(e => e.Email)
            .IsUnicode(false);

            Property(e => e.ContactNo)
            .IsUnicode(false);
        }

    }
}