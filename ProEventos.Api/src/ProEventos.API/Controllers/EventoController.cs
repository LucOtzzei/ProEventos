using Microsoft.AspNetCore.Mvc;
using ProEventos.API.models;

namespace ProEventos.API.Controllers;

[ApiController]
[Route("[controller]")]
public class EventoController : ControllerBase
{
    
    public EventoController()
    {     
    }

    [HttpGet]
    public Evento Get()
    {
        return new Evento(){
            EventoId = 1,
            Tema = ".NET",
            Local = "BH",
            QtdPessoas = 200,
            Lote = "1",
            ImagemUrl = "aaa.com",
            DataEvento = DateTime.Now.AddDays(2).ToString()
        };
    }
    [HttpPost]
    public string Post()
    {
        return "Value";
    }
    [HttpDelete]
    public string Delete()
    {
        return "Value";
    }
    [HttpPut]
    public string Put()
    {
        return "Value";
    }
}
