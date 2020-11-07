using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaFacturación.Models.FacturacionModels
{
    public class Articulo
    {
        public Articulo()
        {
            this.DetalleFactura = new HashSet<DetalleFactura>();
        }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "Código del articulo")]
        public int IdArticulo { get; set; }

        [Required]
        [Column(TypeName = "varchar(50)")]
        [StringLength(50, MinimumLength = 5)]
        [RegularExpression(@"^[a-zA-Z\s\.]*$")]
        [Display(Name = "Descripcion del articulo")]
        public string Descripcion { get; set; }

        [Required]
        [Display(Name = "Precio unitario")]
        [DataType(DataType.Currency)]
        public float PrecioUnitario { get; set; }

        public bool Estado { get; set; }

        public virtual ICollection<DetalleFactura> DetalleFactura { get; set; }
    }
}
