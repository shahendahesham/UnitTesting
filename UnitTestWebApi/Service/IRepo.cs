using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    interface IRepo<A>
    {
        List<A> GetAll();
        A GetById(int id);
        void Add(A data);
        A Edit(A data);

        bool Delete(A data);
    }
}
