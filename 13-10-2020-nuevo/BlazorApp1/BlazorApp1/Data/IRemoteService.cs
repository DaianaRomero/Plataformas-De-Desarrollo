using Refit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp1.Data
{
    public interface IRemoteService
    {
        [Get("/Usuario")]
        Task<List<Usuario>> GetAllUsuario();

        [Get("/Usuario/{id}")]//
        Task<Usuario> GetUsuario(int id);

        [Post("/Usuario")]
        Task<Usuario> GuardarUsuario(Usuario valor);

        [Post("/Usuario")]
        Task<Usuario> CrearUsuario(Usuario valor);

        //-----------------------------

        [Get("/Recurso")]
        Task<List<Recurso>> GetAllRecurso();

        [Get("/Recurso/{id}")]//
        Task<Recurso> GetRecurso(int id);

        [Post("/Recurso")]
        Task<Recurso> GuardarRecurso(Recurso valor);

        [Post("/Recurso")]
        Task<Recurso> CrearRecurso(Recurso valor);

        //------------------------------

        [Get("/Tarea")]
        Task<List<Tarea>> GetAllTarea();

        [Get("/Tarea/{id}")]//
        Task<Tarea> GetTarea(int id);

        [Post("/Tarea")]
        Task<Tarea> GuardarTarea(Tarea valor);

        [Post("/Tarea")]
        Task<Tarea> CrearTarea(Tarea valor);

        //------------------------------

        [Get("/Detalle")]
        Task<List<Detalle>> GetAllDetalle();

        [Get("/Detalle/{id}")]//
        Task<Detalle> GetDetalle(int id);

        [Post("/Detalle")]
        Task<Detalle> GuardarDetalle(Detalle valor);

        [Post("/Detalle")]
        Task<Detalle> CrearDetalle(Detalle valor);

    }
}
