using System;
using System.Collections.Generic;

namespace HomeWorkTask.BusinessLayer
{
    public interface IRepository<T> 
    {
        T Add(T entity);
        T GetById(int id);
        IEnumerable<T> List();

    }
  
}
