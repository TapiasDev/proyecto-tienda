using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using LaQuiebraBack.Data;
using LaQuiebraModelo.Entidades;

namespace LaQuiebraBack.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EstadoCarteraController : ControllerBase
    {
        private readonly DataContext _context;

        public EstadoCarteraController(DataContext context)
        {
            _context = context;
        }

        // GET: api/EstadoCartera
        // Consulta la vista Vw_EstadoCartera de la B de D
        [HttpGet]
        public async Task<ActionResult<IEnumerable<EstadoCartera>>> GetEstadoCartera()
        {
            return await _context.EstadoCartera.ToListAsync();
        }
    }
}
