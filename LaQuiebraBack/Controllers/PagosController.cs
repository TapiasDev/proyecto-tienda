using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using LaQuiebraBack.Data;
using LaQuiebraModelo.Entidades;

namespace LaQuiebraBack.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PagosController : ControllerBase
    {
        private readonly DataContext _context;

        public PagosController(DataContext context)
        {
            _context = context;
        }

        // GET: api/Pagos
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Pago>>> GetPagos()
        {
            return await _context.Pagos.ToListAsync();
        }

        // GET: api/Pagos/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Pago>> GetPago(int id)
        {
            var pago = await _context.Pagos.FindAsync(id);

            if (pago == null)
            {
                return NotFound();
            }

            return pago;
        }

        // GET: api/Pagos/credito/1
        // Detalle de un crédito: sus pagos (para el Maestro-Detalle)
        [HttpGet("credito/{idCredito}")]
        public async Task<ActionResult<IEnumerable<Pago>>> GetPagosPorCredito(int idCredito)
        {
            return await _context.Pagos.Where(p => p.IdCredito == idCredito).ToListAsync();
        }

        // POST: api/Pagos
        // Novedad: pago de una cuota (el trigger de la B de D descuenta el saldo)
        [HttpPost]
        public async Task<ActionResult<Pago>> PostPago(Pago pago)
        {
            var credito = await _context.Creditos.FindAsync(pago.IdCredito);
            if (credito == null)
            {
                return BadRequest("El crédito no existe");
            }

            if (credito.Estado != "Activo")
            {
                return BadRequest("Solo se pueden pagar créditos activos");
            }

            if (pago.ValorCuota <= 0)
            {
                return BadRequest("El valor del pago debe ser mayor a cero");
            }

            _context.Pagos.Add(pago);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetPago", new { id = pago.Id }, pago);
        }
    }
}
