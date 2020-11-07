using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaFacturación.Models.FacturacionModels
{
    public class Vendedor
    {
        public Vendedor()
        {
            this.Facturacion = new HashSet<Facturacion>();
        }

        [Key]
        [Display(Name = "Codigo del vendedor")]
        public int IdVendedor { get; set; }

        [Required]
        [Column(TypeName = "varchar(50)")]
        [StringLength(50, MinimumLength = 5)]
        [RegularExpression(@"^[a-zA-Z\s\.]*$")]
        [Display(Name = "Nombre del vendedor")]
        public string Nombre { get; set; }

        [Required]
        [Display(Name = "Por ciento de comision")]
        public float PorcientoComision { get; set; }

        public bool Estado { get; set; }

        public virtual ICollection<Facturacion> Facturacion { get; set; }
    }
}
