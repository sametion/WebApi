using Business.Abstract;
using Business.Abstract.Dtos.Requests;
using Business.Abstract.Dtos.Responses;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Reflection.Metadata.Ecma335;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BrandsController : ControllerBase
    {
        private readonly IBrandService _brandService;

        public BrandsController(IBrandService brandService)
        {
            _brandService = brandService;
        }

        [HttpPost]
        public IActionResult Add(CreateBrandRequest createdBrandRequest)
        {
            CreatedBrandResponse createdBrandResponse = _brandService.Add(createdBrandRequest);
            return Ok(createdBrandResponse);
        }
        [HttpGet]

        public IActionResult Get()
        {
            return Ok(_brandService.GetAll());

        }
    }
}

