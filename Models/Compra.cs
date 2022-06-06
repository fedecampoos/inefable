using System;
using System.Collections.Generic;

#nullable disable

namespace proyectoinefrable.Models
{
    public partial class Compra
    {
        public int IdCo { get; set; }
        public DateTime Fechacomppra { get; set; }
        public int? IdC { get; set; }
        public int? IdP { get; set; }

        public virtual Cliente IdCNavigation { get; set; }
    }
}
