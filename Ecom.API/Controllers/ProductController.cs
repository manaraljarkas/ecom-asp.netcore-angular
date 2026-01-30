using AutoMapper;
using Ecom.API.Helper;
using Ecom.Core.DTOs;
using Ecom.Core.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Ecom.API.Controllers
{
    public class ProductController : BaseController
    {
        public ProductController(IUnitOfWork work, IMapper mapper) : base(work, mapper)
        {
        }
        [HttpGet("get-all")]
        public async Task<IActionResult> get()
        {
            try
            {
                var Product =await work.ProductRepository
                    .GetAllAsync(x => x.Category, x => x.Photos);
                var result = mapper.Map<List<ProductDTO>>(Product);
                if (Product == null)
                {
                    return BadRequest(new ResponseAPI(400));
                }
                return Ok(result);
            }
            catch (Exception ex)
            {

                throw;
            }
        }
    }
}
