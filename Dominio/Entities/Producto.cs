using System.ComponentModel.DataAnnotations;

namespace Dominio.Entities;

    public class Producto{
        [Key]
        public int IdProducto { get; set; }
        public string ? RefProducto { get; set; }
        public string ? DescripcionProducto { get; set; }
        public double PrecioProducto { get; set; }
        public double DctoProducto { get; set; }
        public int IdMarca { get; set; }
        public Marca ? Marcas { get; set; }
        public ICollection<PersonaProducto> ? PersonaProductos { get; set; }
        
    }
