using Arguments.Arguments;
using Domain.Models;
using Infrastructure.Repositories;

namespace Application.Services
{
    public class BrandService : BaseService<Brand, IBrandRepository, BrandInputCreate, BrandInputUpdate, BrandInputIdentityUpdate, BrandInputIdentityDelete, BrandOutput>, IBrandService
    {
        public BrandService(IBrandRepository brandRepository) : base(brandRepository)
        { }

        public override long Create(BrandInputCreate inputCreateBrand)
        {
            // Se a entrada esta nula
            if (inputCreateBrand == null) throw new ArgumentNullException();
            var ExistingBrand = _repository.GetByName(inputCreateBrand.Name);
            if (ExistingBrand != null) throw new NameInUseException("Esse nome ja está em uso");

            var BrandToCreate = _repository.Create(new Brand(inputCreateBrand.Name).SetCreationDate());
            return BrandToCreate;
        }

        public override long Update(BrandInputIdentityUpdate inputIdentityUpdateBrand)
        {
            // Nenhum valor informado
            if (inputIdentityUpdateBrand == null) throw new ArgumentNullException();
            // Id negativo
            if (inputIdentityUpdateBrand.Id < 0) throw new NotFoundException();
            // Aquisição e verificação de ID
            var OriginalBrand = _repository.Get(inputIdentityUpdateBrand.Id);
            if (OriginalBrand == null) throw new NotFoundException();

            return _repository.Update(new Brand(inputIdentityUpdateBrand.InputUpdate.Name).LoadInternalData(OriginalBrand.Id, OriginalBrand.CreationDate, OriginalBrand.ChangeDate).SetChangeDate());
        }
    }
}
