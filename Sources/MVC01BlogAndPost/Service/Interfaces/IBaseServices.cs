using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC01BlogAndPost.Service.Interfaces
{
    public interface IBaseServices<T>
    {
        List<T> GetLists();

        bool AddNew(T data);
    }
}
