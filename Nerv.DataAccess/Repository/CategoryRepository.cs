using System.Linq.Expressions;
using Nerv.DataAccess.Data;
using Nerv.DataAccess.Repository.IRepository;
using Nerv.Models;

namespace Nerv.DataAccess.Repository;

public class CategoryRepository : Repository<Category>, ICategoryRepository
{
    private ApplicationDbContext _db;

    public CategoryRepository(ApplicationDbContext db) : base(db)
    {
        _db = db;
    }
    
    public void Update(Category obj)
    {
        _db.Categories.Update(obj);
    }
}