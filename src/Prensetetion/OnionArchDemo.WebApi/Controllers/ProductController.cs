﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OnionArchDemo.Application.Dto;
using OnionArchDemo.Application.Interfaces.Repository;

namespace OnionArchDemo.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductRepository productRepository;
        public ProductController(IProductRepository productRepository)
        {
            this.productRepository = productRepository;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var allList = await productRepository.GetAllAsync();
            var result = allList.Select(i => new ProductViewDto() { Id = i.Id, Name = i.Name }).ToList();
            return Ok(result);
        }



    }
}
