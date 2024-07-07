using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories
{
    public interface IBaseRepository<TEntry>
        where TEntry : BaseEntry<TEntry>
    {
        public long Create(TEntry entry);
        public long Update(TEntry entry);
        public void Delete(TEntry entry);
        public long CreateRange(List<TEntry> entry);
        public long UpdateRange(List<TEntry> entry);
        public void DeleteRange(List<TEntry> entry);
        public List<TEntry>? GetAll();
        public TEntry? Get(long id);
    }
}
