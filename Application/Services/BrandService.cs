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
    public class BrandService : BaseService<Brand, IBrandRepository, BrandInputCreate, BrandInputUpdate, BrandInputIdentityUpdate, BrandInputIdentityDelete, BrandOutput>, IBrandService
    {
        public BrandService(IBrandRepository repository) : base(repository)
        { }

        public override long Create(BrandInputCreate inputCreate)
        {
            var ExistingBrand = _repository.GetByName(inputCreate.Name);
            if (ExistingBrand != null) throw new NameInUseException("Esse nome ja está em uso");

            var ItemToCreate = _repository.Create(new Brand(inputCreate.Name));
            return ItemToCreate;
        }

        public class NameInUseException : Exception
        {
            public NameInUseException(string message) : base(message)
            { }
        }
    }
}
