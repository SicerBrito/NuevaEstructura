using System.Reflection;
using Dominio.Entities;
using Microsoft.EntityFrameworkCore;

namespace Persistencia;

    public class TablaContext : DbContext
    {
        public TablaContext(DbContextOptions<TablaContext> options) : base(options){

        }
        public DbSet<Marca> Marcas { get; set; } = null!;
        public DbSet<Pais> Paises { get; set; } = null!;
        public DbSet<Persona> Personas { get; set; } = null!;
        public DbSet<PersonaProducto> PersonaProductos { get; set; } = null!;
        public DbSet<Producto> Productos { get; set; } = null!;
        public DbSet<Provincia> Provincias { get; set; } = null!;
        public DbSet<Region> Regiones { get; set; } = null!;
        public DbSet<TipoPersona> TipoPersonas { get; set; } = null!;



        protected override void OnModelCreating(ModelBuilder modelBuilder){
        base.OnModelCreating(modelBuilder);
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
