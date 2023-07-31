using System.ComponentModel.DataAnnotations;

namespace Dominio.Entities;

    public class PersonaProducto{
        [Key]
        public int IdPersonaProducto { get; set; }
        public int IdPersona { get; set; }
        public Persona ? Personas { get; set; }
        public int IdProducto { get; set; }
        public Producto ? Productos { get; set; }

    }
