using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_ProductTask.Repository
{
    public interface IRepository<T>
    {
        IEnumerable<T> GetAll();
        T GetById(int Id);

        void Add(T Item);

        void Edit(int id, T item);

        void Delete(int id);
        public bool SaveChanges();
        public T FindByName(string Name);

        public T FindByDate(string Date);


    }
}
