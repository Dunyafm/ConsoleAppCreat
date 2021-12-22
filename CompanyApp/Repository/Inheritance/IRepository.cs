﻿using Domain.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Inheritance
{
    public interface IRepository <T> where T : BaseEntity 
    {
        bool Create(T entity);
        bool Update(T entity);
        bool Deelete(T entity);

        T Get(Predicate<T> filter);
        List<T> GetAll(Predicate<T> filter);
;

    }
}
