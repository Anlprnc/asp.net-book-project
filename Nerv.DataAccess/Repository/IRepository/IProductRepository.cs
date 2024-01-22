using Nerv.Models;

namespace Nerv.DataAccess.Repository.IRepository;

public interface IProductRepository : IRepository<Product>
{
    void Update(Product obj);
}