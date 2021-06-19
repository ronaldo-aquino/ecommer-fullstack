using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLogic.Data.Conriguration
{
  public class ProdutoConfiguration : IEntityTypeConfiguration<Produto>
  {
    public void Configure(EntityTypeBuilder<Produto> builder)
    {
      builder.Property(p => p.Nome).IsRequired().HasMaxLength(250);
      builder.Property(p => p.Descricao).IsRequired().HasMaxLength(500);
      builder.Property(p => p.Imagem).HasMaxLength(1000);
      builder.Property(p => p.Preco).HasColumnType("decimal(18, 2)");
      builder.HasOne(m => m.Marca).WithMany().HasForeignKey(p => p.MarcaId);
      builder.HasOne(c => c.Categoria).WithMany().HasForeignKey(p => p.CategoriaId);
    }
  }
}