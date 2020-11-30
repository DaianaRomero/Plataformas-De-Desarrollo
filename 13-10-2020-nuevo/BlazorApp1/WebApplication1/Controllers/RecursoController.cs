using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
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
            return _context.Recursos.ToList();
        }

        [HttpGet("{id}")]
        public Recurso Get(int id)
        {
            return _context.Recursos.Where(i => i.Id == id).Single();
        }

        [HttpPost]
        public Recurso Post(Recurso valor)
        {
            if (valor.Id == 0)
            {
                _context.Recursos.Add(valor);
            }
            else
            {
                _context.Recursos.Attach(valor);
                _context.Recursos.Update(valor);
            }
            _context.SaveChanges();
            return valor;
        }
    }
}
