using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DenemeDiyetDAL.Repository
{
    public interface IRepository <T>
    {

        void Add(T item);
        void Update(T item);
        void Delete(T item);
        List<T> GetAll();
        T GetID(int id);
    }
}
