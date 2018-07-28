using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity.ModelConfiguration;
using Quadridge.Models;

namespace Quadridge.EntityConfigurations
{
    public class InteractionConfiguration : EntityTypeConfiguration<Interaction>
    {
        public InteractionConfiguration()
        {
            Property(e => e.InteractionType)
            .IsUnicode(false);
        }
    }
}