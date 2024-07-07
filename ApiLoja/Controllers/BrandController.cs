using Application.Arguments;
using Application.Services;
using Microsoft.AspNetCore.Mvc;

namespace ApiLoja.Controllers
{
    [ApiController]
    [Route("api/v1/Brand")]
    public class BrandController : BaseController<IBrandService, BrandInputCreate, BrandInputUpdate, BrandInputIdentityUpdate, BrandInputIdentityDelete, BrandOutput>
    {
        public BrandController(IBrandService service) : base(service)
        { }

        public override IActionResult Create(BrandInputCreate inputCreate)
        {
            try
            {
                var CreatedBrandId = _service.Create(inputCreate);
                return Ok(CreatedBrandId);
            }
            catch (ArgumentNullException ex)
            {
                return NotFound();
            }
            catch (Exception ex) 
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
