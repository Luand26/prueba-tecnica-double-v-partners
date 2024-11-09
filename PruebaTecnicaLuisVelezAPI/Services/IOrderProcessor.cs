namespace PruebaTecnicaLuisVelezAPI.Services
{
    // Definición de la interfaz.
    public interface IOrderProcessor
    {
        // Método asincrónico que inicia el procesamiento del pedido.
        Task<string> OrderProcess();
    }
}
