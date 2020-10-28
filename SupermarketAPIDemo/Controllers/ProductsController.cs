using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SupermarketAPIDemo.Domain.Models;
using SupermarketAPIDemo.Domain.Services;
using SupermarketAPIDemo.Resources;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SupermarketAPIDemo.Controllers
{
    [Route("/api/[controller]")]
    public class ProductsController : Controller
    {
        private readonly IProductService _productService;
        private readonly IMapper _mapper;

        public ProductsController(IProductService productService, IMapper mapper)
        {
            _productService = productService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IEnumerable<ProductResource>> ListAsync()
        {
            var products = await _productService.ListAsync();
            var resources = _mapper.Map<IEnumerable<Product>, IEnumerable<ProductResource>>(products);
            return resources;
        }
    }
}
