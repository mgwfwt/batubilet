using batubilet.entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace batubilet.data.Abstract
{
    public interface ISehirRepository:IRepository<Sehir>
    {
        string sehirad();
    }
}
