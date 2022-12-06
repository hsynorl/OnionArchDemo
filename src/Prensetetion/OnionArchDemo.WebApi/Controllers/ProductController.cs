using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OnionArchDemo.Application.Dto;
using OnionArchDemo.Application.Features.Commands.CreateProduct;
using OnionArchDemo.Application.Features.Queries.GetAllPRoduct;
using OnionArchDemo.Application.Features.Queries.GetProductById;
using OnionArchDemo.Application.Interfaces.Repository;

namespace OnionArchDemo.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IMediator mediator;

        public ProductController(IMediator mediator)
        {
       
            this.mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var query = new GetAllProductsQuery();
            return Ok(await mediator.Send(query));
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(Guid id)
        {
            var query = new GetProductByIdQuery() { Id=id};
            return Ok(await mediator.Send(query));
        }


        [HttpPost]

        public async Task<IActionResult> Add(CreateProductCommand command)
        {
            return Ok(await mediator.Send(command));
        }

    }
}
