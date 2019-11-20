using Upsert.Entities;
using Upsert.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace Upsert.Services
{
    public class ProductService : IProductService
    {
        private readonly UpsertContext _dbcontext;
        public ProductService(UpsertContext dbcontext)
        {
            _dbcontext = dbcontext;
        }
        
        public Product GetProduct(int productId)
        {
           return _dbcontext.Product.Include(prod => prod.ProductReviews)
             .ThenInclude(review => review.User)
             .SingleOrDefault(s => s.ProductId == productId);
          
        }

        public Product SaveProduct(Product product)
        {
            _dbcontext.Update(product);
            _dbcontext.SaveChanges();

            return product;
        }
    }
}