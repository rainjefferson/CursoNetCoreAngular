using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProEventos.API.Models;

namespace ProEventos.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]

    public class EventoController : ControllerBase
    {

        public IEnumerable<Evento> _evento = new Evento[]
            {
               new Evento() {
                EventoId = 1,
                Tema = "Angular 11 e .NET 5",
                Local = "Curitiba",
                Lote = "1",
                QtdePessoas = 250,
                DataEvento = DateTime.Now.AddDays(2).ToString(),
                ImageURL = "foto.com.br/123/1.png"
               },

               new Evento() {
                EventoId = 2,
                Tema = "Angular e sua evolução",
                Local = "Curitiba",
                Lote = "2",
                QtdePessoas = 450,
                DataEvento = DateTime.Now.AddDays(2).ToString(),
                ImageURL = "foto.com.br/123/2.png"
               }
            };

        public EventoController()
        {

        }

        [HttpGet]
        public IEnumerable<Evento> Get()
        {
            return _evento;
        }

        [HttpGet("{id}")]
        public IEnumerable<Evento> GetById(int id)
        {
            return _evento.Where(evento => evento.EventoId == id);
        }

        [HttpPost]
        public string Post()
        {
            return "Exemplo post";
        }

        [HttpPut("{id}")]
        public string Put(int id)
        {
            return $"Exemplo put com id {id}";
        }

        [HttpDelete("{id}")]
        public string Delete(int id)
        {
            return $"Exemplo delete com id {id}";
        }

    }
}
