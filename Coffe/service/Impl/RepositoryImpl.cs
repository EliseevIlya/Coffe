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
            
        }

        public void DeleteById(int id)
        {
            throw new NotImplementedException();
        }

        public List<T> GetAll()
        {
            throw new NotImplementedException();
        }

        public T? GetById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
