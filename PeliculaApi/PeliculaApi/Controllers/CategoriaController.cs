using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PeliculaApi.Data;
using System.Linq;
using System.Threading.Tasks;

namespace PeliculaApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriaController : ControllerBase
    {
        private readonly ApplicationDbContext _db;

        public CategoriaController(ApplicationDbContext db)
        {
            _db = db;
        }

        [HttpGet]
        public async Task<IActionResult> GetCategorias()
        {
            var lista = await _db.Categorias.OrderBy(c => c.Nombre).ToListAsync();

            return Ok(lista);

        }
    }
}
