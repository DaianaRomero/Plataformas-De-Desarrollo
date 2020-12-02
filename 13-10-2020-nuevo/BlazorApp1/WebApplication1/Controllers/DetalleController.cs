using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Model.Entidades;
using WebApplication1.Data;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DetalleController : ControllerBase
    {

        private readonly DataContext _context;
        public DetalleController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public List<Detalle> Get()
        {
            return _context.Detalles.Include(i => i.Recurso).Include(i => i.Tarea).ToList();
        }

        [HttpGet("{id}")]
        public Detalle Get(int id)
        {
            return _context.Detalles.Where(i => i.Id == id).Single();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var borrar = await _context.Detalles.FindAsync(id);
            if (borrar == null)
            {
                return NotFound();
            }

            _context.Detalles.Remove(borrar);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        [HttpPost]
        public IActionResult Post(Detalle valor)
        {
            var local = _context.Detalles.Local.FirstOrDefault(e => e.Id.Equals(valor.Id));

            if (local != null)
                _context.Entry(local).State = EntityState.Detached;

            if (valor.Id == 0)
            {
                _context.Entry(valor).State = EntityState.Added;
            }
            else
            {
                _context.Entry(valor).State = EntityState.Modified;
            }
            _context.SaveChanges();
            return Ok(valor);
        }
    }
}
