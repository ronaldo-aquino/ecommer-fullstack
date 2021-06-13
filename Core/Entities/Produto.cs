using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace Core.Entities
{
  public class Produto
  {
    public int Id { get; set; }

    public string Nome { get; set; }

    public string Descricao { get; set; }

    public int Estoque { get; set; }

    public int Marca { get; set; }

    [Column(TypeName = "decimal(18,4")]
    public decimal Preco { get; set; }

    public string Imagem { get; set; }


  }
}