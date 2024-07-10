using Domain.Models;
using Infrastructure.Mappings;

namespace Infrastructure.Repositories
{
    public class CategoryRepository : BaseRepository<Category>, ICategoryRepository
    {
        public CategoryRepository(ConnectionContext context) : base(context)
        { }
    }
}
