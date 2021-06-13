using Core.Entities;
using Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLogic.Logic
{
  public class ProdutoRepository : IProdutoRepository
  {
    public Task<Produto> GetProdutoByIdAsync(int id)
    {
      throw new NotImplementedException();
    }

    public Task<IReadOnlyList<Produto>> GetProdutosAsync()
    {
      throw new NotImplementedException();
    }
  }
}