using AutoMapper;
using CoreProject.Dto;
using CoreProject.Entities;
using CoreProject.IService;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : CostomBaseController
    {
        private readonly IMapper _mapper;
        private readonly IService<Product> _service;
        public ProductController(IService<Product> service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }
        //www.mysite.com/api/products
        [HttpGet]
        public async Task<IActionResult> All()
        {
            var products = await _service.GetAllAsync();

            var productsDto = _mapper.Map<List<ProductDto>>(products.ToList());
            //return Ok(CustomResponseDto<List<ProductDto>>.Success(200, productsDto));
            return CreateActionResult(CustomResponseDto<List<ProductDto>>.Success(200, productsDto));

        }
        //www.mysite.com/api/products/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var products = await _service.GetAllAsync();

            var productsDto = _mapper.Map<ProductDto>(products);
            //return Ok(CustomResponseDto<List<ProductDto>>.Success(200, productsDto));
            return CreateActionResult(CustomResponseDto<ProductDto>.Success(200, productsDto));

        }
        [HttpPost]
        public async Task<IActionResult> Save(ProductDto productDto)
        {
            var product = await _service.AddAsync(_mapper.Map<Product>(productDto));

            var productsDto = _mapper.Map<ProductDto>(product);
            //return Ok(CustomResponseDto<List<ProductDto>>.Success(200, productsDto));
            return CreateActionResult(CustomResponseDto<ProductDto>.Success(201, productsDto));

        }

        [HttpPut]
        public async Task<IActionResult> Update(ProductDto productDto)
        {
            await _service.UpdateAsync(_mapper.Map<Product>(productDto));

            
            //return Ok(CustomResponseDto<List<ProductDto>>.Success(200, productsDto));
            return CreateActionResult(CustomResponseDto<NoContentDto>.Success(204));

        }
        //Dele api/Products/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Remove(int id)
        {
            var product=await _service.GetByIdAsync(id);
            await _service.RemoveAsync(product);

            
            //return Ok(CustomResponseDto<List<ProductDto>>.Success(200, productsDto));
            return CreateActionResult(CustomResponseDto<NoContentDto>.Success(204));

        }

    }
}
