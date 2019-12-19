using System;
using System.Collections.Generic;

namespace OS.WpfDevExpress.Domain.Repository
{
    interface IRepository<T> : IDisposable
        where T : class
    {
        ICollection<T> GetItems();
        T GetEmployee(int id);
        void Create(T item);
        void Update(T item);
        void Delete(int id);
        void Save();
    }
}
