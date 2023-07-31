using Dominio.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configuration;

    public class ProductoConfiguration : IEntityTypeConfiguration<Producto>
    {
    public void Configure(EntityTypeBuilder<Producto> builder)
    {
        builder.ToTable("Productos");

            builder.Property(p => p.IdProducto)
                .HasAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
                .HasColumnName("IdProducto")
                .HasColumnType("int")
                .IsRequired();

            builder.Property(p => p.RefProducto)
                .HasColumnName("RefProducto")
                .HasColumnType("varchar")
                .HasMaxLength(70)
                .IsRequired();

             builder.Property(p => p.DescripcionProducto)
                .HasColumnName("DescripcionProducto")
                .HasColumnType("varchar")
                .HasMaxLength(200)
                .IsRequired();

            builder.Property(p => p.PrecioProducto)
                .HasColumnName("PrecioProducto")
                .HasColumnType("double")
                .IsRequired();

            builder.Property(p => p.DctoProducto)
                .HasColumnName("DctoProducto")
                .HasColumnType("double")
                .IsRequired();

            builder.Property(p => p.IdMarca)
                .HasColumnName("Marca_Id")
                .HasColumnType("int")
                .IsRequired();
            
            builder.HasOne(p => p.Marcas)
                .WithMany(p => p.Productos)
                .HasForeignKey(p => p.IdMarca);
    }
}
