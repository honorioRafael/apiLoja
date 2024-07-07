using Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Models;
using Microsoft.EntityFrameworkCore;
using Infrastructure.Mappings;

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
            return CreateRange([entry.SetCreationDate()]);
        }

        public long CreateRange(List<TEntry> entry)
        {
            _context.AddRange(entry);
            _context.SaveChanges();
            return (from item in entry select item.Id).FirstOrDefault();
        }

        public void Delete(TEntry entry)
        {
            throw new NotImplementedException();
        }


        public void DeleteRange(List<TEntry> entry)
        {
            throw new NotImplementedException();
        }

        public long Update(TEntry entry)
        {
            throw new NotImplementedException();
        }

        public long UpdateRange(List<TEntry> entry)
        {
            throw new NotImplementedException();
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
