using SecureFtpClient.AppCode.Models;
using SecureFtpClient.AppCode.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecureFtpClient.AppCode.Controllers
{
    class ProductoBancarioController
    {
        public static List<ProductoBancario> GetCuentasBancarias()
        {
            var cuentasBancariasRepo = new CuentasBancariaRepository();
            return cuentasBancariasRepo.GetCuentasBancarias("0801199010718");
        }

        public static List<ProductoBancario> GetTarjetasCredito()
        {
            var tarjetasCreditoRepo = new TarjetasCreditoRepository();
            return tarjetasCreditoRepo.GetTarjetasCredito("0801199010718");
        }

        public void TcpClient()
        {

        }

    }
}
