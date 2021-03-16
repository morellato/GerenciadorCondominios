using GerenciadorCondominios.BLL.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace GerenciadorCondominios.DAL.Mapeamentos
{
    public class MesMap : IEntityTypeConfiguration<Mes>
    {
        public void Configure(EntityTypeBuilder<Mes> builder)
        {
            builder.HasKey(m => m.MesiD);
            builder.Property(m => m.MesiD).ValueGeneratedNever();
            builder.Property(m => m.Nome).IsRequired().HasMaxLength(30);
            builder.HasIndex(m => m.Nome).IsUnique();

            builder.HasMany(m => m.Alugueis).WithOne(m => m.Mes);
            builder.HasMany(m => m.HistoricoRecursos).WithOne(m => m.Mes);

            builder.HasData(

                new Mes
                {
                    MesiD = 1,
                    Nome = "Janeiro"
                },
                new Mes
                {
                    MesiD = 2,
                    Nome = "Fevereirio"
                },
                new Mes
                {
                    MesiD = 3,
                    Nome = "Março"
                },
                new Mes
                {
                    MesiD = 4,
                    Nome = "Abril"
                },
                new Mes
                {
                    MesiD = 5,
                    Nome = "Maio"
                },
                new Mes
                {
                    MesiD = 6,
                    Nome = "Junho"
                },
                new Mes
                {
                    MesiD = 7,
                    Nome = "Julho"
                },
                new Mes
                {
                    MesiD = 8,
                    Nome = "Agosto"
                },
                new Mes
                {
                    MesiD = 9,
                    Nome = "Setembro"
                },
                new Mes
                {
                    MesiD = 10,
                    Nome = "Outubro"
                },
                new Mes
                {
                    MesiD = 11,
                    Nome = "Novembro"
                },
                new Mes
                {
                    MesiD = 12,
                    Nome = "Dezembro"
                });

            builder.ToTable("Meses");
        }
    }
}
