using DDD.Application.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD.Application.Interfaces
{
    public interface IApplicationServiceProduto
    {
        void Add(ProdutoDto produtoDto);
        void Update(ProdutoDto produtoDto);
        void Remove(ProdutoDto produtoDto);
        IEnumerable<ProdutoDto> GetAll();
        ProdutoDto FindById(int id);
    }
}
