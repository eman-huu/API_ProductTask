using API_ProductTask.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_ProductTask.Repository
{
    public class ProductRepository : IRepository<ProductViewModel>
    {
        private readonly _Context _context;
        public ProductRepository(_Context context)
        {
            _context = context;
        }
        public void Add(ProductViewModel Item)
        {
            Product product = new Product();
            product.ProductID = Item.ProductID;
            product.Product_Name = Item.Product_Name;
            product.CategoryID = Item.CategoryID;
            //product.Category_MetaID = Item.Category_MetaID;
            product.Product_Date = Item.Product_Date;
            _context.Add(product);
        }

        public ProductViewModel FindByName(string Name)
        {
            //var model = _context.Products.Where(x => x.Product_Name == Name).FirstOrDefault();
            //return null;
            var model = (from a in _context.Products
                         join b in _context.Categories
                         on a.CategoryID equals b.CategoryID
                         select new ProductViewModel
                         {
                             ProductID = a.ProductID,
                             Product_Name = a.Product_Name,
                             Product_Date = a.Product_Date,
                             Categoy = b.Category_Name,
                             Archieve_Status = a.Archieve_Status
                         }).Where(x => x.Product_Name == Name).FirstOrDefault();
            return model;

        }

        public ProductViewModel FindByDate(string Date)
        {
            DateTime date = Convert.ToDateTime(Date);
            //var model = _context.Products.Where(x => x.Product_Date == date).FirstOrDefault();
            //return null;
            var model = (from a in _context.Products
                         join b in _context.Categories
                         on a.CategoryID equals b.CategoryID
                         select new ProductViewModel
                         {
                             ProductID = a.ProductID,
                             Product_Name = a.Product_Name,
                             Product_Date = a.Product_Date,
                             Categoy = b.Category_Name,
                             Archieve_Status = a.Archieve_Status
                         }).Where(x => x.Product_Date == date).FirstOrDefault();
            return model;

        } 
        public void Delete(int id)
        {
            var model = _context.Products.Where(x => x.ProductID == id).FirstOrDefault();
            model.Archieve_Status = 1;
            _context.Update(model);
        }

        public void Edit(int id, ProductViewModel item)
        {
            var model= _context.Products.Where(x => x.ProductID == id).FirstOrDefault();
            model.Product_Name = item.Product_Name;
           // model.Category_MetaID = item.Category_MetaID;
            model.Archieve_Status = item.Archieve_Status;
            model.Product_Date = item.Product_Date;
            model.CategoryID = item.CategoryID;
            _context.Update(model);
        }

        public IEnumerable<ProductViewModel>GetAll()
        
            {
                var model = (from a in _context.Products
                             join b in _context.Categories on a.CategoryID equals b.CategoryID
                             //join c in _context.category_Metas  equals c.MetaID

                             select new ProductViewModel
                             {
                                 ProductID = a.ProductID,
                                 Product_Name = a.Product_Name,
                                 Product_Date = a.Product_Date,
                                 Categoy = b.Category_Name,
                                 Archieve_Status = a.Archieve_Status
                             }).ToList();
            //var model= _context.Products.ToList();
            return model;

        }

        public ProductViewModel GetById(int Id)
        {
            //var model = (from a in _context.Products
            //             join b in _context.Categories on a.CategoryID equals b.CategoryID
            //             //join c in _context.category_Metas  equals c.MetaID

            //             select new ProductViewModel
            //             {
            //                 ProductID = a.ProductID,
            //                 Product_Name = a.Product_Name,
            //                 Product_Date = a.Product_Date,
            //                 Categoy = b.Category_Name,
            //                 Archieve_Status = a.Archieve_Status
            //             }).Where(x => x.ProductID == Id).FirstOrDefault();
            var model = _context.Products.Where(x => x.ProductID == Id).FirstOrDefault();
            if (model != null) { 
                ProductViewModel mdl = new ProductViewModel { ProductID = model.ProductID, Product_Name = model.Product_Name, Product_Date = model.Product_Date, Categoy = "kljlkj", Categoy_Meta = "jkljl", Category_MetaID = 1, Archieve_Status = 1 };
            return mdl;
        }
            else return  null;
        }
        public bool SaveChanges()
        {
            return (_context.SaveChanges() >= 0);
        }
    }
}
