using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaFacturación.Models.FacturacionModels
{
    public class DetalleFactura
    {
        

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "Código del detalle")]
        public int IdDetalleFactura { get; set; }

        [Required]
        [Display(Name = "Código del articulo")]
        public int IdArticulo { get; set; }

        [Required]
        [Display(Name = "Cantidad del articulo")]
        public int Cantidad { get; set; }

        [Required]
        [Display(Name = "Codigo de la factura asociada")]
        public int IdFactura { get; set; }

        [Required]
        [Display(Name = "Precio del articulo")]
        [DataType(DataType.Currency)]
        public decimal Precio { get; set; }

        public bool Estado { get; set; }


        public virtual Articulo Articulo { get; set; }
        public virtual Facturacion Facturacion { get; set; }

    }
}
