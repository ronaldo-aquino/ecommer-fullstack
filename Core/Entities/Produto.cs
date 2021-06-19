using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace Core.Entities
{
  public class Produto : ClasseBase
  {

    public string Nome { get; set; }

    public string Descricao { get; set; }

    public int Estoque { get; set; }

    public int MarcaId { get; set; }

    public Marca Marca { get; set; }

    public int CategoriaId { get; set; }

    public Categoria Categoria { get; set; }

    public decimal Preco { get; set; }

    public string Imagem { get; set; }


  }
}