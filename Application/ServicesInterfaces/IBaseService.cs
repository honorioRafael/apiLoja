using Application.Arguments;
using Domain.Models;
using Infrastructure.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services
{
    public interface IBaseService<TInputCreate, TInputUpdate, TInputIdentityUpdate, TInputIdentityDelete, TOutput>
        //where TEntry : BaseEntry<TEntry>
        //where TRepository : IBaseRepository<TEntry>
        where TInputCreate : BaseInputCreate<TInputCreate>
        where TInputUpdate : BaseInputUpdate<TInputUpdate>
        where TInputIdentityUpdate : BaseInputIdentityUpdate<TInputUpdate>
        where TInputIdentityDelete : BaseInputIdentityDelete<TInputIdentityDelete>
    {
        public long Create(TInputCreate inputCreate);
        public long Update(TInputIdentityUpdate inputIdentityUpdate);
        public void Delete(TInputIdentityDelete inputIdentityDelete);
        public List<TOutput>? GetAll();
        public TOutput? Get(long id);
    }
}
