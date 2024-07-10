using Arguments.Arguments;
using Domain.Models;
using Infrastructure.Repositories;

namespace Application.Services
{
    public class CategoryService : BaseService<Category, ICategoryRepository, CategoryInputCreate, CategoryInputUpdate, CategoryInputIdentityUpdate, CategoryInputIdentityDelete, CategoryOutput>
    {
        public CategoryService(ICategoryRepository categoryRepository) : base(categoryRepository)
        { }

        public override long Create(CategoryInputCreate inputCreateCategory)
        {
            // Se a entrada esta nula
            if (inputCreateCategory == null) throw new ArgumentNullException();

            var CategoryToCreate = _repository.Create(new Category(inputCreateCategory.Name).SetCreationDate());
            return CategoryToCreate;
        }

        public override long Update(CategoryInputIdentityUpdate inputIdentityUpdateCategory)
        {
            // Se a entrada está nula
            if (inputIdentityUpdateCategory == null) throw new ArgumentNullException();
            // Verificação de ID negativo
            if (inputIdentityUpdateCategory.Id < 0) throw new NotFoundException();
            // Aquisição e verificação de ID
            var OriginalCategory = _repository.Get(inputIdentityUpdateCategory.Id);
            if (OriginalCategory == null) throw new NotFoundException();

            return _repository.Update(new Category(inputIdentityUpdateCategory.InputUpdate.Name).LoadInternalData(OriginalCategory.Id, OriginalCategory.CreationDate, OriginalCategory.ChangeDate).SetChangeDate());
        }
    }
}
