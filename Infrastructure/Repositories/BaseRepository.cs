using Domain.Models;
using Infrastructure.Mappings;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories
{
    public abstract class BaseRepository<TEntry> : IBaseRepository<TEntry>
        where TEntry : BaseEntry<TEntry>
    {
        public readonly ConnectionContext _context;
        public readonly DbSet<TEntry> _dbset;

        public BaseRepository(ConnectionContext context)
        {
            _context = context;
            _dbset = _context.Set<TEntry>();
        }

        public long Create(TEntry entry)
        {
            return CreateRange([entry]);
        }

        public long CreateRange(List<TEntry> entry)
        {
            _context.AddRange(entry);
            _context.SaveChanges();
            return (from item in entry select item.Id).FirstOrDefault();
        }

        public void Delete(TEntry entry)
        {
            DeleteRange([entry]);
        }


        public void DeleteRange(List<TEntry> entry)
        {
            _context.RemoveRange(entry);
            _context.SaveChanges();
        }

        public long Update(TEntry entry)
        {
            return UpdateRange([entry]);
        }

        public long UpdateRange(List<TEntry> entry)
        {
            _context.UpdateRange(entry);
            _context.SaveChanges();
            return entry[0].Id;
        }

        public TEntry? Get(long id)
        {
            return _dbset.Where(x => x.Id == id).AsNoTracking().FirstOrDefault();
        }

        public List<TEntry>? GetAll()
        {
            return _dbset.AsNoTracking().ToList();
        }

    }
}
