using Arguments.Arguments;

namespace Application.Services
{
    public interface ICategoryService : IBaseService<CategoryInputCreate, CategoryInputUpdate, CategoryInputIdentityUpdate, CategoryInputIdentityDelete, CategoryOutput>
    {
    }
}
