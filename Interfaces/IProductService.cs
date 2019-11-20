using Upsert.Entities;

namespace Upsert.Interfaces
{
    public interface IProductService
    {
        Product GetProduct(int productId);
        Product SaveProduct(Product product);
    }
}