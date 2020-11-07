using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaFacturación.Models.FacturacionModels
{
    public class TipoMovimiento
    {
        public TipoMovimiento()
        {
            this.AsientoContable = new HashSet<AsientoContable>();
        }
        [Key]
        public int IdTipoMovimiento { get; set; }
        public string Descripcion { get; set; }

        public virtual ICollection<AsientoContable> AsientoContable { get; set; }
    }
}
