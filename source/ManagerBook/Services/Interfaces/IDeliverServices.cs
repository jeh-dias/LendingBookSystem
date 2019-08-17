﻿using Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services.Interfaces
{
    public interface IDeliverServices
    {
        List<Deliver> GetAll();
        Deliver GetById(Guid key);
        Deliver Insert(Deliver book);
    }
}