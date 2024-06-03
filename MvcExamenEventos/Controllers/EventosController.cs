using Microsoft.AspNetCore.Mvc;
using MvcExamenEventos.Models;
using MvcExamenEventos.Services;

namespace MvcExamenEventos.Controllers
{
    public class EventosController : Controller
    {
        private ServiceApiEventos service;
        

        public EventosController(ServiceApiEventos service)
        {
            this.service = service;
        }
        public async Task<IActionResult> Index()
        {
            List<EventoExamen> eventos = await this.service.GetEventosAsync();
            return View(eventos);
        }
        public async Task<IActionResult> Categorias()
        {
            List<CategoriaEvento> categorias = await this.service.GetCategoriasAsync();
            return View(categorias);
        }
        public async Task<IActionResult> EventosCategoria(int id)
        {
            List<EventoExamen> eventos = await this.service.GetEventosCategoriaAsync(id);
            return View(eventos);
        }
    }
}
