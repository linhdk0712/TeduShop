using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeduShop.Services.Interfaces
{
    public interface BaseService<T> where T : class
    {
        void Add(T post);
        void Update(T post);
        void Delete(int id);
        IEnumerable<T> GetAll();
        IEnumerable<T> GetAllPaging(int page, int pageSize, out int totalRows);
        T GetById(int id);        
        void SaveChanges();
    }
}
