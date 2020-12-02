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
    public class RecursoController : ControllerBase
    {

        private readonly DataContext _context;
        public RecursoController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public List<Recurso> Get()
        {
            return _context.Recursos.Include(i => i.Usuario).ToList();
        }

        [HttpGet("{id}")]
        public Recurso Get(int id)
        {
            return _context.Recursos.Where(i => i.Id == id).Single();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var borrar = await _context.Recursos.FindAsync(id);
            if (borrar == null)
            {
                return NotFound();
            }

            _context.Recursos.Remove(borrar);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        [HttpPost]
        public IActionResult Post(Recurso valor)
        {
            var local = _context.Recursos.Local.FirstOrDefault(e => e.Id.Equals(valor.Id));

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
