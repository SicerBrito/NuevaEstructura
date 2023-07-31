using Dominio.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configuration;

    public class PersonaConfiguration : IEntityTypeConfiguration<Persona>
    {
    public void Configure(EntityTypeBuilder<Persona> builder)
    {
        builder.ToTable("Personas");

            builder.Property(p => p.IdPersona)
                .HasAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
                .HasColumnName("IdMarcas")
                .HasColumnType("int")
                .IsRequired();

            builder.Property(p => p.NombrePersona)
                .HasColumnName("NombrePersona")
                .HasColumnType("varchar")
                .HasMaxLength(70)
                .IsRequired();

            builder.Property(p => p.ApellidoPersona)
                .HasColumnName("ApellidoPersona")
                .HasColumnType("varchar")
                .HasMaxLength(70)
                .IsRequired();

            builder.Property(p => p.EdadPersona)
                .HasColumnName("EdadPersona")
                .HasColumnType("int")
                .IsRequired();

            builder.Property(p => p.IdProvincia)
                .HasColumnName("Provincia_Id")
                .HasColumnType("int")
                .IsRequired();
            
            builder.HasOne(p => p.Provincias)
                .WithMany(p => p.Personas)
                .HasForeignKey(p => p.IdProvincia);

            builder.Property(p => p.IdTipoPersona)
                .HasColumnName("TipoPersona_Id")
                .HasColumnType("int")
                .IsRequired();
            
            builder.HasOne(p => p.TipoPersonas)
                .WithMany(p => p.Personas)
                .HasForeignKey(p => p.IdTipoPersona);
    }
}
