using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public interface ICRUD<T>
    {
        T FindByID(int id);
        IEnumerable<T> FindAll();
        T Create(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
