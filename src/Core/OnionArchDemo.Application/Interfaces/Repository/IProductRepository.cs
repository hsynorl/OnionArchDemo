using OnionArchDemo.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionArchDemo.Application.Interfaces.Repository
{
    public interface IProductRepository:IGenericRepositoryAsync<Product>
    {
        //application nun domanine erişmesinde sıkıntı yok
    
    }
}
