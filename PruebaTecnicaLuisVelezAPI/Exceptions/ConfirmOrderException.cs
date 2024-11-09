using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaTecnicaLuisVelezAPI.Exceptions
{
    // Excepción personalizada para errores al confirmar pedidos.
    public class ConfirmOrderException : Exception
    {
        public ConfirmOrderException(string message, Exception ex) : base(message, ex)
        {
        }
    }
}
