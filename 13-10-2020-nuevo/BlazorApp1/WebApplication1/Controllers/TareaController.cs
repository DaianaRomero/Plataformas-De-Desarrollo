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
    public class TareaController : ControllerBase
    {

        private readonly DataContext _context;
        public TareaController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public List<Tarea> Get()
        {
            return _context.Tareas.Include(i =>i.Recurso).ToList();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var borrar = await _context.Tareas.FindAsync(id);
            if (borrar == null)
            {
                return NotFound();
            }

            _context.Tareas.Remove(borrar);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        [HttpGet("{id}")]
        public Tarea Get(int id)
        {
            return _context.Tareas.Where(i => i.Id == id).Single();
        }


        [HttpPost]
        public IActionResult Post(Tarea valor)
        {
            var local = _context.Tareas.Local.FirstOrDefault(e => e.Id.Equals(valor.Id));

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