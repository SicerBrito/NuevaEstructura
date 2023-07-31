using Dominio.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configuration;
    public class PersonaProductoConfiguration : IEntityTypeConfiguration<PersonaProducto>
    {
    public void Configure(EntityTypeBuilder<PersonaProducto> builder)
    {
        builder.ToTable("PersonaProducto");

            builder.Property(p => p.IdPersona)
                .HasColumnName("Persona_Id")
                .HasColumnType("int")
                .IsRequired();

            builder.HasOne(p => p.Personas)
                .WithMany(p => p.PersonaProductos)
                .HasForeignKey(p => p.IdPersona);

            builder.Property(p => p.IdProducto)
                .HasColumnName("Producto_Id")
                .HasColumnType("int")
                .IsRequired();

            builder.HasOne(p => p.Productos)
                .WithMany(p => p.PersonaProductos)
                .HasForeignKey(p => p.IdProducto);
    }
}
