using Application.Arguments;
using Application.Services;
using Microsoft.AspNetCore.Mvc;

namespace ApiLoja.Controllers
{
    public abstract class BaseController<TService, TInputCreate, TInputUpdate, TInputIdentityUpdate, TInputIdentityDelete, TOutput> : ControllerBase
        where TService : IBaseService<TInputCreate, TInputUpdate, TInputIdentityUpdate, TInputIdentityDelete, TOutput>
        where TInputCreate : BaseInputCreate<TInputCreate>
        where TInputUpdate : BaseInputUpdate<TInputUpdate>
        where TInputIdentityUpdate : BaseInputIdentityUpdate<TInputUpdate>
        where TInputIdentityDelete : BaseInputIdentityDelete<TInputIdentityDelete>, new()
        where TOutput : BaseOutput<TOutput>
    {
        protected readonly TService _service;

        public BaseController(TService service)
        {
            _service = service;
        }

        [HttpPost]
        public virtual IActionResult Create(TInputCreate inputCreate)
        {
            throw new NotImplementedException();
        }

        [HttpPut]
        public virtual IActionResult Update(TInputIdentityUpdate inputIdentityUpdate) 
        {
            throw new NotImplementedException(); 
        }

        [HttpDelete]
        public virtual IActionResult Delete(long id) 
        {
            try
            {
                _service.Delete(new TInputIdentityDelete() { Id = id });
                return Ok();
            }
            catch (ItemNotFoundException ex)
            {
                return NotFound(ex.Message);
            }
            catch (Exception ex)
            { 
                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        public virtual IActionResult GetAll()
        {
            return Ok(_service.GetAll());
        }


        [HttpGet("{id}")]
        public virtual IActionResult GetAll(long id)
        {
            return Ok(_service.Get(id));
        }
    }
}

/*
 try
            {
                var QueryResult = _service.Get(id);
                return Ok(QueryResult);
            }
            catch (ArgumentNullException ex)
            {
                return NotFound();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
 */
