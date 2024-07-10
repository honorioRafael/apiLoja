using Application.Services;
using Arguments.Arguments;
using Microsoft.AspNetCore.Mvc;

namespace ApiLoja.Controllers
{
    [ApiController]
    [Route("api/v1/Brand")]
    public class BrandController : BaseController<IBrandService, BrandInputCreate, BrandInputUpdate, BrandInputIdentityUpdate, BrandInputIdentityDelete, BrandOutput>
    {
        public BrandController(IBrandService brandService) : base(brandService)
        { }
    }
}
