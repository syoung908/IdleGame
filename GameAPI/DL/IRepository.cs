using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DL {
    public interface IRepository<T> where T: class {
        Task<T> Insert(T model);
        Task<T> Delete(T model);
        Task Save();
        Task<IList<T>> Query(QueryOptions<T> options);
        Task<T> QuerySingle(QueryOptions<T> options);
    }
}
