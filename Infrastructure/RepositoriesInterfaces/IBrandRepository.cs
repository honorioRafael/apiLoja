using Domain.Models;

namespace Infrastructure.Repositories
{
    public interface IBrandRepository : IBaseRepository<Brand>
    {
        public Brand? GetByName(string name);
    }
}
