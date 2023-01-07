using batubilet.data.Abstract;
using batubilet.entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace batubilet.data.Concrete
{
    public class EfCoreSehirRepository : EfCoreGenericRepository<Sehir, BiletContext>, ISehirRepository
    {
        public string sehirad()
        {
            throw new NotImplementedException();
        }
    }
}
