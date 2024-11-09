using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaTecnicaLuisVelez.Exceptions
{
    // Excepción personalizada para errores al validar pedidos.
    public class ValidateOrderException : Exception
    {
        public ValidateOrderException(string message, Exception ex) : base(message, ex)
        {
        }
    }
}
