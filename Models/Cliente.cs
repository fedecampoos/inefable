using System;
using System.Collections.Generic;
using System.ComponentModel;

#nullable disable

namespace proyectoinefrable.Models
{
    public partial class Cliente
    {
        public Cliente()
        {
            Compras = new HashSet<Compra>();
        }

        public int IdC { get; set; }
        [DisplayName("Usuario")]
        public string Nombreusuario { get; set; }
        public string Email { get; set; }
        public int Telefono { get; set; }
        [DisplayName("Fecha de Nacimiento")]
        public DateTime Fechanac { get; set; }

        public virtual ICollection<Compra> Compras { get; set; }
    }
}
