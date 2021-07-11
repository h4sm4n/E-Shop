using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer.Abstract;
using DataAccessLayer.Context;
using EntityLayer.Entity;

namespace BusinessLayer.Concrete
{
    public class ProductRepository:GenericRepository<Product>
    {
        private DataContext db = new DataContext();

        public List<Product> GetPopularProduct()
        {
            return db.Products.Where(x => x.IsPopular == true).Take(3).ToList();
        }
    }
}
