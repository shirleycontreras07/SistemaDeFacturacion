using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaFacturación.Models.FacturacionModels
{
    public class Cliente
    {
        public Cliente()
        {
            this.Facturacion = new HashSet<Facturacion>();
            this.AsientoContable = new HashSet<AsientoContable>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "Código del cliente")]
        public int IdCliente { get; set; }

        [Required]
        [Column(TypeName = "varchar(50)")]
        [StringLength(50, MinimumLength = 5)]
        [RegularExpression(@"^[a-zA-Z\s\.]*$")]
        [Display(Name = "Nombre del cliente")]
        public string Nombre { get; set; }

        [Required]
        [Column(TypeName = "varchar(15)")]
        [Display(Name = "Identificacion del cliente")]
        [MinLength(11)]
        public string Identificación { get; set; }

        [Required]
        [Column(TypeName = "varchar(15)")]
        [Display(Name = "Cuenta contable")]
        [MinLength(8)]
        public string CuentaContable { get; set; }

        public bool Estado { get; set; }

        public virtual ICollection<Facturacion> Facturacion { get; set; }
        public virtual ICollection<AsientoContable> AsientoContable { get; set; }
    }
}
