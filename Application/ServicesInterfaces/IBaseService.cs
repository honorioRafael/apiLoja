using Application.Arguments;

namespace Application.Services
{
    public interface IBaseService<TInputCreate, TInputUpdate, TInputIdentityUpdate, TInputIdentityDelete, TOutput>
        where TInputCreate : BaseInputCreate<TInputCreate>
        where TInputUpdate : BaseInputUpdate<TInputUpdate>
        where TInputIdentityUpdate : BaseInputIdentityUpdate<TInputUpdate>
        where TInputIdentityDelete : BaseInputIdentityDelete<TInputIdentityDelete>
        where TOutput : BaseOutput<TOutput>
    {
        public long Create(TInputCreate inputCreate);
        public long Update(TInputIdentityUpdate inputIdentityUpdate);
        public void Delete(TInputIdentityDelete inputIdentityDelete);
        public List<TOutput>? GetAll();
        public TOutput? Get(long id);
    }
}
