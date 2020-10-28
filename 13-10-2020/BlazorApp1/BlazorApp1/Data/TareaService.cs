using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp1.Data
{
    public class TareaService
    {
       
            private DataContext context;

            public TareaService(DataContext _context)
            {
                context = _context;
            }

            public async Task<List<Tarea>> GetAll()
            {
                return await context.Tareas.ToListAsync();
            }
        }

    
}
