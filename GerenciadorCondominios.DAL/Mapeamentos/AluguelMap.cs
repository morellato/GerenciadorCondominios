using GerenciadorCondominios.BLL.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace GerenciadorCondominios.DAL.Mapeamentos
{
    public class AluguelMap : IEntityTypeConfiguration<Aluguel>
    {
        public void Configure(EntityTypeBuilder<Aluguel> builder)
        {
            builder.HasKey(a => a.AluguelId);
            builder.Property(a => a.Valor).IsRequired();
            builder.Property(a => a.MesID).IsRequired();
            builder.Property(a => a.Ano).IsRequired();

            builder.HasOne(a => a.Mes).WithMany(a => a.Alugueis).HasForeignKey(a => a.MesID);
            builder.HasMany(a => a.Pagamentos).WithOne(a => a.Aluguel);

            builder.ToTable("Alugueis");

        }
    }
}
