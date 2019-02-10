using Icatu.ListaLeitura.Modelos;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Icatu.ListaLeitura.Persistencia
{
    internal class FuncConfiguration : IEntityTypeConfiguration<Funcionario>
    {
        public void Configure(EntityTypeBuilder<Funcionario> builder)
        {
            builder
             .Property(l => l.Nome)
             .HasColumnType("nvarchar(50)")
             .IsRequired();

            builder
                .Property(l => l.Email)
                .HasColumnType("nvarchar(50)")
                .IsRequired();

            builder
                .Property(l => l.Departamento)
                .HasColumnType("nvarchar(50)")
                .IsRequired();

            builder
                .Property(l => l.Funcao)
                .HasColumnType("nvarchar(50)")
                .IsRequired();

            builder
                .Property(l => l.ImagemCapa);

            builder
                .Property(l => l.Lista)
                .HasColumnType("nvarchar(10)")
                .IsRequired()
                .HasConversion<string>(
                    tipo => tipo.ParaString(),
                    texto => texto.ParaTipo()
                );
        }
    }
}