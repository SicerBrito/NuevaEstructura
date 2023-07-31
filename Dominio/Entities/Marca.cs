using System.ComponentModel.DataAnnotations;

namespace Dominio.Entities;

    public class Marca{
        [Key]
        public int IdMarca { get; set; }
        public string ? DescripcionMarca { get; set; }
        public ICollection<Producto> ? Productos { get; set; }
    }
