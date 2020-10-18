using MODEL.Entities;
using SERVICE.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SERVICE.Repository
{
    public class AppUserService:BaseService<AppUser>
    {
        public string AppUserRevenue()
        {
            return "Toplam Kullanıcı Sayısı 100";
        }
    }
}
