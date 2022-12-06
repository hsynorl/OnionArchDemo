using AutoMapper;
using MediatR;
using OnionArchDemo.Application.Dto;
using OnionArchDemo.Application.Interfaces.Repository;
using OnionArchDemo.Application.Wrappers;

namespace OnionArchDemo.Application.Features.Queries.GetProductById
{
    public class GetProductByIdQueryHandler : IRequestHandler<GetProductByIdQuery, ServiceResponse<GetProductByIdViewModel>>
    {
        private readonly IProductRepository productRepository;
        private readonly IMapper mapper;

        public GetProductByIdQueryHandler(IProductRepository productRepository,IMapper mapper)
        {
            this.productRepository = productRepository;
            this.mapper = mapper;
        }
        public async Task<ServiceResponse<GetProductByIdViewModel>> Handle(GetProductByIdQuery request, CancellationToken cancellationToken)
        {
            var product=await productRepository.GetByIdAsync(request.Id);
            var dto = mapper.Map<GetProductByIdViewModel>(product);
            return new ServiceResponse<GetProductByIdViewModel>(dto); 
        }
    }
}
