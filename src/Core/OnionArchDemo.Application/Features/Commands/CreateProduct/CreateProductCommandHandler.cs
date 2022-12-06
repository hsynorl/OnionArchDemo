using AutoMapper;
using MediatR;
using OnionArchDemo.Application.Interfaces.Repository;
using OnionArchDemo.Application.Wrappers;

namespace OnionArchDemo.Application.Features.Commands.CreateProduct
{
    public class CreateProductCommandHandler : IRequestHandler<CreateProductCommand,ServiceResponse<Guid>>
    {
        IProductRepository productRepository;
        private readonly IMapper mapper;

        public CreateProductCommandHandler(IProductRepository productRepository,IMapper mapper)
        {
            this.productRepository = productRepository ?? throw new ArgumentNullException(nameof(productRepository));
            this.mapper = mapper;
        }
        async Task<ServiceResponse<Guid>> IRequestHandler<CreateProductCommand, ServiceResponse<Guid>>.Handle(CreateProductCommand request, CancellationToken cancellationToken)
        {
            var product = mapper.Map<Domain.Entities.Product>(request);
            await productRepository.AddAsync(product);
            return new ServiceResponse<Guid>(product.Id);
        }
    }
}
