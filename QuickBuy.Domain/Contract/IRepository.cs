using System;
using System.Collections.Generic;
using System.Text;

namespace QuickBuy.Domain.Contract
{
    public interface IRepository<T> : IDisposable where T : class
    {
        void Add(T entity);

        T FindById(int id);

        IEnumerable<T> FindAll();

        void Refresh(T entity);

        void Remove(T entity);
    }
}
