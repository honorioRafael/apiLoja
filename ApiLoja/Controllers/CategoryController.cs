using ApiLoja.Controllers;
using Application.Services;
using Arguments.Arguments;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [ApiController]
    [Route("api/v1/Category")]
    public class CategoryController : BaseController<ICategoryService, CategoryInputCreate, CategoryInputUpdate, CategoryInputIdentityUpdate, CategoryInputIdentityDelete, CategoryOutput>
    {
        public CategoryController(ICategoryService categoryService) : base(categoryService)
        { }
    }
}
