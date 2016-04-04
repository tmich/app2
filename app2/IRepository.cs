using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app2
{
    interface IRepository<T>
    {
        T GetById(int id);
        void Add(ref T model);
        void Delete(int id);
    }
}
