using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity.ModelConfiguration;
using Quadridge.Models;

namespace Quadridge.EntityConfigurations
{
    public class ClientConfiguration : EntityTypeConfiguration<Client>
    {
        public ClientConfiguration()
        {

            HasOptional(e => e.Company)
            .WithMany(e => e.Clients)
            .HasForeignKey(e => e.CompanyId);

            Property(e => e.Firstname)
            .IsUnicode(false);

            Property(e => e.Surname)
            .IsUnicode(false);


            Property(e => e.Email)
            .IsUnicode(false);


            Property(e => e.CellNo)
            .IsUnicode(false);


            Property(e => e.BusinessNo)
            .IsUnicode(false);


            Property(e => e.FirstAddressLine)
            .IsUnicode(false);


            Property(e => e.SecondAddressLine)
            .IsUnicode(false);


            Property(e => e.City)
            .IsUnicode(false);


            Property(e => e.Zip)
            .IsUnicode(false);


            Property(e => e.Province)
            .IsUnicode(false);


            Property(e => e.Country)
            .IsUnicode(false);


            HasMany(e => e.ClientInteractions)
            .WithRequired(e => e.Client)
            .WillCascadeOnDelete(true);
        }
    }
}