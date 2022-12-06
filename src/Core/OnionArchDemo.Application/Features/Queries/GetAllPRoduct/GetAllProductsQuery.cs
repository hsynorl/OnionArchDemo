using MediatR;
using OnionArchDemo.Application.Dto;
using OnionArchDemo.Application.Wrappers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionArchDemo.Application.Features.Queries.GetAllPRoduct
{
    public partial class GetAllProductsQuery : IRequest<ServiceResponse<List<ProductViewDto>>>
    {
    }
}
