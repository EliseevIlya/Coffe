using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coffe.service.Impl
{
    internal class RepositoryImpl<T> : IRepository<T> where T : class
    {
        private readonly List<T> Items = new();
        public void Add(T entity)
        {
            Items.Add(entity);
        }

        public void DeleteById(int id)
        {
            var item = GetById(id);
            if (item != null) Items.Remove(item);
        }

        public List<T> GetAll()
        {
            return Items;
        }

        public T? GetById(int id)
        {
            return Items.FirstOrDefault(item => GetId(item).Equals(id));
        }
        private int GetId(T item)
        {
            var prop = typeof(T).GetProperty("Id");
            return prop != null ? (int)(prop.GetValue(item) ?? 0) : 0;
        }
    }
}
