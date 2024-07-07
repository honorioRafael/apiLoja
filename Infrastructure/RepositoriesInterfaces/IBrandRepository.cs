using Domain.Models;
using Infrastructure.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories
{
    public interface IBrandRepository : IBaseRepository<Brand>
    {
        public Brand? GetByName(string name);
    }
}
