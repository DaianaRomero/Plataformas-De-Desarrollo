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
            return _context.Tareas.ToList();
        }



    }
}