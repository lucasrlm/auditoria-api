using AuditoriaApi.Dados;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace auditoria_api.Controllers
{
    /// <summary>
    /// Controller de auditoria de pedidos
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class PedidosController : ControllerBase
    {

        ILogger _logger;
        public PedidosController(ILogger<PedidosController> logger)
        {
            _logger = logger;
        }

        /// <summary>
        /// Registra os dados de um pagamento que foi realizado
        /// </summary>
        /// <param name="pagamento"></param>
        /// <returns></returns>
        [HttpPost("pagamento")]
        public ActionResult RegistrarPagamento([FromBody]Pagamento pagamento)
        {
            string log = pagamento.RegistrarPagamento();
            _logger.LogInformation(log);
            return Ok(log);
        }   
    }
}
