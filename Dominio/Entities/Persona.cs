using System.ComponentModel.DataAnnotations;

namespace Dominio.Entities;

    public class Persona{
        [Key]
        public int IdPersona { get; set; }
        public string ? NombrePersona { get; set; }
        public string ? ApellidoPersona { get; set; }
        public int EdadPersona { get; set; }
        public int IdProvincia { get; set; }
        public Provincia ? Provincias { get; set; }
        public int IdTipoPersona{ get; set; }
        public TipoPersona ? TipoPersonas { get; set; }
        public ICollection<PersonaProducto> ? PersonaProductos { get; set; }
    }
