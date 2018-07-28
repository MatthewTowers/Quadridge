using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity.ModelConfiguration;
using Quadridge.Models;

namespace Quadridge.EntityConfigurations
{
    public class UserConfiguration : EntityTypeConfiguration<User>
    {
        public UserConfiguration()
        {
            Property(e => e.Name)
            .IsUnicode(false);

            Property(e => e.Password)
            .IsUnicode(false);
        }
    }
}