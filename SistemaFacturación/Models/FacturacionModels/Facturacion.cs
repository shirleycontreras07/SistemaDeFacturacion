using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaFacturación.Models.FacturacionModels
{
    public class Facturacion
    {
        public Facturacion()
        {

            this.DetalleFactura = new HashSet<DetalleFactura>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "Código de la factura")]
        public int IdFactura { get; set; }

        [Required]
        [Display(Name = "Codigo del vendedor")]
        public int IdVendedor { get; set; }

        [Required]
        [Display(Name = "Codigo del cliente")]
        public int IdCliente { get; set; }

      

        [Required]
        [Display(Name = "Fecha")]
        public DateTime Fecha { get; set; }

        [Required]
        [Column(TypeName = "varchar(50)")]
        [StringLength(50, MinimumLength = 5)]
        [RegularExpression(@"^[a-zA-Z\s\.]*$")]
        public string Comentario { get; set; }

        public bool Estado { get; set; }


        public virtual Vendedor Vendedor { get; set; }
        public virtual Cliente Cliente { get; set; }
        public virtual ICollection <DetalleFactura> DetalleFactura { get; set; }
    }
}
