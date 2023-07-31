using System.ComponentModel.DataAnnotations;

namespace Dominio.Entities;

    public class Provincia{
        [Key]
        public int IdProvincia { get; set; }
        public string ? NombreProvincia { get; set; }
        public int IdRegion { get; set; }
        public Region ? Regions { get; set; }
        public ICollection<Persona> ? Personas { get; set; }
    }
