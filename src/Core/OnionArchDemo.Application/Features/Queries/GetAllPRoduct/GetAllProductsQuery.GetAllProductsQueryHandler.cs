using AutoMapper;
using MediatR;
using OnionArchDemo.Application.Dto;
using OnionArchDemo.Application.Interfaces.Repository;
using OnionArchDemo.Application.Wrappers;

namespace OnionArchDemo.Application.Features.Queries.GetAllPRoduct
{
    public partial class GetAllProductsQuery
    {
        public class GetAllProductsQueryHandler : IRequestHandler<GetAllProductsQuery, ServiceResponse<List<ProductViewDto>>>
        {
            private readonly IProductRepository productRepository;
            private readonly IMapper mapper;

            public GetAllProductsQueryHandler(IProductRepository productRepository, IMapper mapper)
            {
                this.productRepository = productRepository;
                this.mapper = mapper;
            }

            async Task<ServiceResponse<List<ProductViewDto>>> IRequestHandler<GetAllProductsQuery, ServiceResponse<List<ProductViewDto>>>.Handle(GetAllProductsQuery request, CancellationToken cancellationToken)
            {
                var products = await productRepository.GetAllAsync();
                var viewModel = mapper.Map<List<ProductViewDto>>(products);
              
                return new ServiceResponse<List<ProductViewDto>>(viewModel);
            }
        }
    }
}
