using Dominio.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configuration;
    public class PaisConfiguration : IEntityTypeConfiguration<Pais>
    {
    public void Configure(EntityTypeBuilder<Pais> builder)
    {
        builder.ToTable("Paises");

            builder.Property(p => p.IdPais)
                .HasAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
                .HasColumnName("IdPais")
                .HasColumnType("int")
                .IsRequired();

            builder.Property(p => p.NombrePais)
                .HasColumnName("NombrePais")
                .HasColumnType("varchar")
                .HasMaxLength(200)
                .IsRequired();
    }
}
