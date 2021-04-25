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
    public class EventosController : ControllerBase
    {
    
    public IEnumerable<Evento> eventos =
        new Evento[]{
               new Evento(){
               EventoId= 1,
               Tema= "Angular 11 e .Net 5.0",
               Local = " Belo Horizonte",
               Lote = " 1º Lote",
               QtdPessoas = 250,
               DataEvento = DateTime.Now.AddDays(15).ToString("dd/mm/yyyy"),
               ImagemUrl = "foto.png"
               },
               new Evento(){
               EventoId= 2,
               Tema= "Angular e suas novidades",
               Local = " São Paulo",
               Lote = " 2 Lote",
               QtdPessoas = 350,
               DataEvento = DateTime.Now.AddDays(3).ToString("dd/mm/yyyy"),
               ImagemUrl = "foto1.png"
               }

          };

 
        public EventosController()
        {
            
        }

        [HttpGet]
        public IEnumerable<Evento> Get()
        {
          return eventos;
        }

        
        [HttpGet("{id}")]
        public IEnumerable<Evento> Get(int id)
        {
          return eventos.Where(e=> e.EventoId == id);
        }


    }
}
