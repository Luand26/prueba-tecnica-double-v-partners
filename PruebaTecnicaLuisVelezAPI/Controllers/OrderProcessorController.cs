using Microsoft.AspNetCore.Mvc;
using PruebaTecnicaLuisVelezAPI.Services;

namespace PruebaTecnicaLuisVelezAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class OrderProcessorController : ControllerBase
    {
        // Instancia manual de OrderProcessor sin inyección de dependencias.
        // OrderProcessor orderProcessor = new OrderProcessor();

        // Inyección de dependencias a través de la interfaz IOrderProcessor.
        private readonly IOrderProcessor _orderProcessorService;
        public OrderProcessorController(IOrderProcessor orderProcessorService)
        {
            _orderProcessorService = orderProcessorService;
        }

        [HttpGet]
        public async Task<IActionResult> OrderProcess()
        {
            // Si el proceso es exitoso, retorna una respuesta HTTP 200 (Ok) con el resultado.
            try
            {
                return Ok(await _orderProcessorService.OrderProcess());
            }
            // Si ocurre un error en el procesamiento, captura la excepción y devuelve
            // una respuesta HTTP 500 (Internal Server Error) con el mensaje detallado de la excepción.
            catch (Exception ex)
            {
                return StatusCode(500, $"Error en el servidor: {ex.Message}");
            }
        }
    }
}