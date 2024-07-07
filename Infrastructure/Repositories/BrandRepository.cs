using Domain.Models;
using Infrastructure.Mappings;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Formats.Tar;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories
{
    public class BrandRepository : BaseRepository<Brand>, IBrandRepository
    {
        public BrandRepository(ConnectionContext context) : base(context)
        { }

        public Brand? GetByName(string name)
        {
            return _dbset.Where(x => x.Name == name).AsNoTracking().FirstOrDefault();
        }
    }
}
