using desafio_core.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace desafio_core.Mapping
{
    public class DividaMapping : IEntityTypeConfiguration<Divida>
    {
        public void Configure(EntityTypeBuilder<Divida> builder)
        {
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Id).ValueGeneratedOnAdd();
            builder.Property(p => p.Valor).HasColumnType("decimal(10,2)").IsRequired();
            builder.Property(p => p.ValorComissaoPaschoalotto).HasColumnType("decimal(10,2)").IsRequired();
            builder.Property(p => p.ValorJuros).HasColumnType("decimal(10,2)").IsRequired();
            builder.Property(p => p.ValorFinalComJuros).HasColumnType("decimal(10,2)").IsRequired();

            // Relacionamentos
            builder.HasMany(f => f.Parcelas).WithOne(p => p.Divida).HasForeignKey(p => p.DividaId);
        }
    }
}
