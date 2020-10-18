using CORE.CoreEntity.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace CORE.CoreEntity
{
    public class EntityRepository : IEntity<Guid>
    {
        public EntityRepository()
        {
            Status = Status.Active;
            CreatedDate = DateTime.Now;
            CreatedComputerName = Environment.MachineName;
            CreatedAdUserName = WindowsIdentity.GetCurrent().Name;
            //todo: appuser oluşturulduktan sonra kullanıcı adı buraya tanımlanacak.
            CreatedBy = "admin";
            //todo: Ip tanımlama metodundan sonra gerçek ip burada gösterilecek.
            CreatedIP = "192.168.1.1";
           
        }

        public Guid ID { get ; set ; }

        public int? MasterId { get; set; }
        public Status Status { get; set; }


        public DateTime? CreatedDate { get; set; }
        public string CreatedComputerName { get; set; }
        public string CreatedIP { get; set; }
        public string CreatedAdUserName { get; set; }
        public string CreatedBy { get; set; }

        public DateTime? UpdatedDate { get; set; }
        public string UpdatedComputerName { get; set; }
        public string UpdatedIP { get; set; }
        public string UpdatedAdUserName { get; set; }
        public string UpdatedBy { get; set; }

    }
}
