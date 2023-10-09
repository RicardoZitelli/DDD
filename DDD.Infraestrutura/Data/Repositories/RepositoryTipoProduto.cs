using DDD.Domain.Entities;
using DDD.Domain.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD.Infrastructure.Data.Repositories
{
    public class RepositoryTipoProduto : RepositoryBase<TipoProduto>, IRepositoryTipoProduto
    {
        private readonly SqlContext sqlContext;
        public RepositoryTipoProduto(SqlContext sqlContext) : base(sqlContext)
        {
            this.sqlContext = sqlContext;
        }
    }
}
