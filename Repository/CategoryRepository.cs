using API_ProductTask.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_ProductTask.Repository
{
    public class CategoryRepository:IRepository<Category>
    {
        private readonly _Context _context;
        public CategoryRepository(_Context context)
        {
            _context = context;
        }

        public void Add(Category Item)
        {
            _context.Add(Item);
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public void Edit(int id, Category item)
        {
            var model = _context.Categories.Where(x => x.CategoryID == id).FirstOrDefault();
            model.Category_Name = item.Category_Name;
            model.CategoryID = item.CategoryID;
            _context.Update(model);
        }

        public Category FindByDate(string Date)
        {
            throw new NotImplementedException();
        }

        public Category FindByName(string Name)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Category> GetAll()
        {
            throw new NotImplementedException();
        }

        public Category GetById(int Id)
        {
            throw new NotImplementedException();
        }

        public bool SaveChanges()
        {
            throw new NotImplementedException();
        }
    }
}
