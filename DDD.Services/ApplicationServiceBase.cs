using AutoMapper;
using DDD.Application.Interfaces;
using DDD.Domain.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD.Application
{
    public class ApplicationServiceBase<TEntity> : IApplicationServiceBase<TEntity> where TEntity : class
    {
        private readonly IServiceBase<TEntity> _serviceBase;
        private readonly IMapper _mapper;

        public ApplicationServiceBase(IServiceBase<TEntity> serviceBase, IMapper mapper)
        {
            _serviceBase = serviceBase;
            _mapper = mapper;
        }

        void IApplicationServiceBase<TEntity>.Add(TEntity obj)
        {
            var obj = this.mapper.Map<TEntity>(obj);
            this.serviceProduto.Add(produto);
        }

        TEntity IApplicationServiceBase<TEntity>.FindById(int id)
        {
            throw new NotImplementedException();
        }

        IEnumerable<TEntity> IApplicationServiceBase<TEntity>.GetAll()
        {
            throw new NotImplementedException();
        }

        void IApplicationServiceBase<TEntity>.Remove(TEntity obj)
        {
            throw new NotImplementedException();
        }

        void IApplicationServiceBase<TEntity>.Update(TEntity obj)
        {
            throw new NotImplementedException();
        }
    }
}
