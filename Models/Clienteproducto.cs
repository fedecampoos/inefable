using System;
using System.Collections.Generic;

#nullable disable

namespace proyectoinefrable.Models
{
    public partial class Clienteproducto
    {
        public int? Cantidad { get; set; }
        public int? Preciototal { get; set; }
        public int? IdC { get; set; }
        public int? IdP { get; set; }

        public virtual Cliente IdCNavigation { get; set; }
        public virtual Producto IdPNavigation { get; set; }
    }
}
