using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaFacturación.Models.FacturacionModels
{
    public class AsientoContable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "Código del asiento contable")]
        public int IdAsiento { get; set; }

        [Required]
        [Column(TypeName = "varchar(50)")]
        [Display(Name = "Descripcion del asiento")]
        [RegularExpression(@"^[a-zA-Z\s\.]*$")]
        [MinLength(4)]
        public string Descripción { get; set; }


        [Display(Name = "Código del cliente")]
        public int IdCliente { get; set; }

        [Required]
        [Column(TypeName = "varchar(20)")]
        [StringLength(19, MinimumLength = 13)]
        [Display(Name = "Tarjeta de crédito")]
        [DataType(DataType.CreditCard)]
        public string Cuenta { get; set; }

        [Required]
        [Display(Name = "Tipo de movimiento")]
        public int IdTipoMovimiento { get; set; }

        [Required]
        [Display(Name = "Fecha")]
        [DataType(DataType.Date)]
        public string Fecha { get; set; }

        [Required]
        [Display(Name = "Monto del asiento")]
        [DataType(DataType.Currency)]
        public float MontoAsiento { get; set; }


        public bool Estado { get; set; }

        public virtual Cliente Cliente { get; set; }
        public virtual TipoMovimiento TipoMovimiento { get; set; }
    }
}
