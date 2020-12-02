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
    public class UsuarioController : ControllerBase
    {

        private readonly DataContext _context;
        public UsuarioController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public List<Usuario> Get()
        {
            return _context.Usuarios.ToList();
        }

        [HttpGet("{id}")]
        public Usuario Get(int id)
        {
            return _context.Usuarios.Where(i => i.Id == id).Single();
        }

        

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var borrar = await _context.Usuarios.FindAsync(id);
            if (borrar == null)
            {
                return NotFound();
            }

            _context.Usuarios.Remove(borrar);
            await _context.SaveChangesAsync();

            return NoContent();
        }
        //[HttpPost]
        //public Usuario Post(Usuario valor)
        //{
        //    if (valor.Id == 0)
        //    {
        //        _context.Usuarios.Add(valor);
        //    }
        //    else
        //    {
        //        _context.Usuarios.Attach(valor);
        //        _context.Usuarios.Update(valor);
        //    }
        //    _context.SaveChanges();
        //    return valor;
        //}
        [HttpPost]
        public IActionResult Post(Usuario valor)
        {
            var local = _context.Usuarios.Local.FirstOrDefault(e => e.Id.Equals(valor.Id));

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
