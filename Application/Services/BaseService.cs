using Arguments.Arguments;
using Domain.Models;
using Infrastructure.Repositories;

namespace Application.Services
{
    public abstract class BaseService<TEntry, TRepository, TInputCreate, TInputUpdate, TInputIdentityUpdate, TInputIdentityDelete, TOutput> : IBaseService<TInputCreate, TInputUpdate, TInputIdentityUpdate, TInputIdentityDelete, TOutput>
        where TEntry : BaseEntry<TEntry>
        where TRepository : IBaseRepository<TEntry>
        where TInputCreate : BaseInputCreate<TInputCreate>
        where TInputUpdate : BaseInputUpdate<TInputUpdate>
        where TInputIdentityUpdate : BaseInputIdentityUpdate<TInputUpdate>
        where TInputIdentityDelete : BaseInputIdentityDelete<TInputIdentityDelete>
        where TOutput : BaseOutput<TOutput>        
    {
        protected readonly TRepository _repository;

        public BaseService(TRepository repository)
        {
            _repository = repository;
        }

        public virtual long Create(TInputCreate inputCreate)
        {
            throw new NotImplementedException();
        }

        public virtual long Update(TInputIdentityUpdate inputIdentityUpdate)
        {
            throw new NotImplementedException();
        }

        public virtual void Delete(TInputIdentityDelete inputIdentityDelete)
        {
            var ToBeDeleted = _repository.Get(inputIdentityDelete.Id);
            if (ToBeDeleted == null) throw new ItemNotFoundException();
            
            _repository.Delete(ToBeDeleted);
        }

        public virtual TOutput? Get(long id)
        {
            return EntryToOutput(_repository.Get(id));
        }

        public virtual List<TOutput>? GetAll()
        {
            return EntryToOutput(_repository.GetAll());
        }

        internal TOutput? EntryToOutput(TEntry? entrada)
        {
            return (TOutput)(dynamic)entrada;
        }

        internal List<TOutput?> EntryToOutput(List<TEntry?> entrada)
        {
            return (from item in entrada select (TOutput)(dynamic)entrada).ToList();
        }

    }
}
