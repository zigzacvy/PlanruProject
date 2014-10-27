using Planru.Plugins.Main.Domain;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Planru.Plugins.Main.Persistence.Mappings
{
    public class UserMapping : EntityTypeConfiguration<User>
    {
        public UserMapping() 
        { 
            // Key an properties
            this.HasKey(u => u.Id);
            this.Property(u => u.FirstName).HasMaxLength(35);
            this.Property(u => u.LastName).HasMaxLength(35);

            // Associations
        }
    }
}
