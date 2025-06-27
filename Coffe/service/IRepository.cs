using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coffe.service
{
    internal interface IRepository<T> where T : class
    {
        void Add(T entity);
        T? GetById(int id);
        void DeleteById(int id);
        List<T> GetAll();
    }
}
