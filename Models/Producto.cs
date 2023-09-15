using System;
using System.Collections.Generic;
using System.ComponentModel;

#nullable disable

namespace proyectoinefrable.Models
{
    public partial class Producto
    {
        public int IdP { get; set; }
        [DisplayName("Producto")]
        public string Nombreproducto { get; set; }
        public int? Precio { get; set; }
        public string Imagen { get; set; }
        public int? Stock { get; set; }
    }
}
