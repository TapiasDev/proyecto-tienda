using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using LaQuiebraBack.Data;
using LaQuiebraModelo.Entidades;

namespace LaQuiebraBack.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CreditosController : ControllerBase
    {
        private readonly DataContext _context;

        public CreditosController(DataContext context)
        {
            _context = context;
        }

        // GET: api/Creditos
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Credito>>> GetCreditos()
        {
            return await _context.Creditos.ToListAsync();
        }

        // GET: api/Creditos/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Credito>> GetCredito(int id)
        {
            var credito = await _context.Creditos.FindAsync(id);

            if (credito == null)
            {
                return NotFound();
            }

            return credito;
        }

        // GET: api/Creditos/cliente/1
        // Detalle de un cliente: sus créditos (para el Maestro-Detalle)
        [HttpGet("cliente/{codigoCliente}")]
        public async Task<ActionResult<IEnumerable<Credito>>> GetCreditosPorCliente(int codigoCliente)
        {
            return await _context.Creditos.Where(c => c.CodigoCliente == codigoCliente).ToListAsync();
        }

        // PUT: api/Creditos/5
        // Cambiar los datos de un crédito
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCredito(int id, Credito credito)
        {
            if (id != credito.Id)
            {
                return BadRequest();
            }

            _context.Entry(credito).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CreditoExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Creditos
        // Ingresar un crédito: el saldo inicia igual al monto
        [HttpPost]
        public async Task<ActionResult<Credito>> PostCredito(Credito credito)
        {
            if (!await _context.Clientes.AnyAsync(c => c.Codigo == credito.CodigoCliente))
            {
                return BadRequest("El cliente no existe");
            }

            credito.SaldoActual = credito.MontoInicial;
            credito.Estado = "Activo";
            _context.Creditos.Add(credito);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCredito", new { id = credito.Id }, credito);
        }

        // DELETE: api/Creditos/5
        // Retirar un crédito cumplido (se eliminan también sus pagos)
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCredito(int id)
        {
            var credito = await _context.Creditos.FindAsync(id);
            if (credito == null)
            {
                return NotFound();
            }

            if (credito.Estado != "Cumplido")
            {
                return BadRequest("Solo se pueden retirar créditos en estado Cumplido");
            }

            _context.Pagos.RemoveRange(_context.Pagos.Where(p => p.IdCredito == id));
            _context.Creditos.Remove(credito);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool CreditoExists(int id)
        {
            return _context.Creditos.Any(e => e.Id == id);
        }
    }
}
