using Auditoria.Dados.Entidades;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace auditoria_api.Controllers
{
    /// <summary>
    /// Controller de auditoria de pedidos
    /// </summary>
    [Route("v1/[controller]")]
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
        [HttpPost("pagamentos")]
        public ActionResult RegistrarPagamento([FromBody]Pagamento pagamento)
        {
            string log = pagamento.RegistrarPagamento();
            _logger.LogInformation(log);
            return Ok(log);
        }   
    }
}
