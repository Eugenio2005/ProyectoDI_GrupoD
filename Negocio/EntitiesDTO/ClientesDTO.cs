using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.EntitiesDTO
{
    public class ClientesDTO: UsuariosDTO
    {
        private string cuentaCorriente;
        public string CuentaCorriente { get; set; }
    }
}
