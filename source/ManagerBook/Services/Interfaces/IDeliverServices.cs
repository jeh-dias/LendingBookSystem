using Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services.Interfaces
{
    public interface IDeliverServices
    {
        IEnumerable<Deliver> GetAll();
        Deliver GetByKey(Guid key);
        Deliver Insert(Deliver book);

        Deliver Update(Deliver book);
    }
}
