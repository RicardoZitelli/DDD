using DDD.Domain.Entities;
using DDD.Domain.Repositories.Interfaces;
using DDD.Domain.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD.Domain.Services
{
    public class ServiceProductType : ServiceBase<ProductType>, IServiceProductType
    {        
        public ServiceProductType(IRepositoryProductType repositoryTipoProduto) : base(repositoryTipoProduto)
        {            
        }
    }
}
