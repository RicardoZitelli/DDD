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
    public class ServiceTipoProduto : ServiceBase<TipoProduto>, IServiceTipoProduto
    {
        private readonly IRepositoryTipoProduto repositoryTipoProduto;
        public ServiceTipoProduto(IRepositoryTipoProduto repositoryTipoProduto) : base(repositoryTipoProduto)
        {
            this.repositoryTipoProduto = repositoryTipoProduto;
        }
    }
}
