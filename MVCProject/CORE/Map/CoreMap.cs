using CORE.CoreEntity;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CORE.Map
{
    public class CoreMap<T>:EntityTypeConfiguration<T> where T:EntityRepository
    {
        public CoreMap()
        {
            //Property(x => x.ID).HasColumnName("ID").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);

            Property(x => x.CreatedAdUserName).HasColumnName("CreatedAdUserName").IsOptional();

            Property(x => x.CreatedComputerName).HasColumnName("CreatedComputerName").IsOptional();

            Property(x => x.UpdatedDate).HasColumnName("UpdatedDate").IsOptional();

            Property(x => x.UpdatedIP).HasColumnName("UpdatedIP").IsOptional();
            Property(x => x.MasterId).IsOptional();

        }
    }
}
