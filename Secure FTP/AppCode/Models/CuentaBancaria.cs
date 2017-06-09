using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecureFtpClient.AppCode.Models
{
    class ProductoBancario
    {
        public int IdCuentaBancaria { get; set; }
        public string NumeroCuenta { get; set; }
        public string Descripcion { get; set; }
        public string Moneda { get; set; }
        public double Saldo { get; set; }
        public string FechaCreacion { get; set; }
    }
}
