using Arguments.Arguments;

namespace Application.Services
{
    public interface IBrandService : IBaseService<BrandInputCreate, BrandInputUpdate, BrandInputIdentityUpdate, BrandInputIdentityDelete, BrandOutput>
    {
    }
}
