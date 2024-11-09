using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaTecnicaLuisVelez.Exceptions
{
    // Excepción personalizada para errores al procesar pagos.
    public class ProcessPaymentException : Exception
    {
        public ProcessPaymentException(string message, Exception ex) : base(message, ex)
        {
        }
    }
}
