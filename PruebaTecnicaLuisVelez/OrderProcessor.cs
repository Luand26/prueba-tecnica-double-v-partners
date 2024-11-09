using PruebaTecnicaLuisVelez.Exceptions;

namespace PruebaTecnicaLuisVelez
{
    // Clase OrderProcessor
    internal class OrderProcessor
    {
        // Constante que define el tiempo de espera en milisegundos.
        private const int DelayMs = 5000;

        // Método privado y asincrónico que valida el pedido.
        private async Task ValidateOrder()
        {
            try
            {
                // Excepción controlada para probar el manejo de excepciones.
                //throw new NotImplementedException();
                Console.WriteLine("Validando orden...");
                await Task.Delay(DelayMs);
                Console.WriteLine("Orden validada");
            }
            catch (Exception ex)
            {
                throw new ValidateOrderException("**Ocurrió un error validando la orden** ", ex);
            }
        }

        // Método privado y asincrónico que procesa el pedido.
        private async Task ProcessPayment()
        {
            try
            {
                // Excepción controlada para probar el manejo de excepciones.
                //throw new NotImplementedException();
                Console.WriteLine("Procesando Pago...");
                await Task.Delay(DelayMs);
                Console.WriteLine("Pago procesado");
            }
            catch (Exception ex)
            {
                throw new ProcessPaymentException("**Ocurrió un error procesando el pago** ", ex);
            }
        }

        // Método privado y asincrónico que confirma el pedido.
        private async Task ConfirmOrder()
        {
            try
            {
                // Excepción controlada para probar el manejo de excepciones.
                //throw new NotImplementedException();
                Console.WriteLine("Confirmando Orden...");
                await Task.Delay(DelayMs);
                Console.WriteLine("Orden confirmada");
            }
            catch (Exception ex)
            {
                throw new ConfirmOrderException("**Ocurrió un error confirmando la orden** ", ex);
            }
        }

        // Método asincrónico que coordina el flujo completo del procesamiento del pedido.
        public async Task OrderProcess()
        {
            try
            {
                Console.WriteLine("----- Iniciando el procesamiento de la orden -----");

                await ValidateOrder();

                await ProcessPayment();

                await ConfirmOrder();

                Console.WriteLine("----- Procesamiento de la orden exitoso -----");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.InnerException);
            }
        }
    }
}
