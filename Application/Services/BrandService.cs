using Application.Arguments;
using Domain.Models;
using Infrastructure.Repositories;

namespace Application.Services
{
    public class BrandService : BaseService<Brand, IBrandRepository, BrandInputCreate, BrandInputUpdate, BrandInputIdentityUpdate, BrandInputIdentityDelete, BrandOutput, BrandOutputHandler>, IBrandService
    {
        public BrandService(IBrandRepository repository) : base(repository)
        { }

        public override long Create(BrandInputCreate inputCreate)
        {
            var ExistingBrand = _repository.GetByName(inputCreate.Name);
            if (ExistingBrand != null) throw new NameInUseException("Esse nome ja está em uso");

            var ItemToCreate = _repository.Create(new Brand(inputCreate.Name).SetCreationDate());
            return ItemToCreate;
        }

        public override long Update(BrandInputIdentityUpdate inputIdentityUpdate)
        {
            var OriginalItem = _repository.Get(inputIdentityUpdate.Id);
            if (OriginalItem == null) throw new NotFoundException();

            var ItemToCreate = _repository.Update(new Brand(inputIdentityUpdate.InputUpdate.Name).LoadInternalData(OriginalItem.Id, OriginalItem.CreationDate, OriginalItem.ChangeDate).SetChangeDate());
            return ItemToCreate;
        }
    }
}
