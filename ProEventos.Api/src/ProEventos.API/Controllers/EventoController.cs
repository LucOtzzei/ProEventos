using Microsoft.AspNetCore.Mvc;
using ProEventos.API.Data;
using ProEventos.API.models;

namespace ProEventos.API.Controllers;

[ApiController]
[Route("[controller]")]
public class EventoController : ControllerBase
{
    private readonly DataContext _context;
    public EventoController(DataContext dataContext)
    {     
        _context = dataContext;
    }

    [HttpGet]
    public List<Evento> Get()
    {
        return _context.Eventos.ToList();
    }
    [HttpGet("{id}")]
    public Evento Get(int id)
    {
        return _context.Eventos.FirstOrDefault(x => x.EventoId == id);
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
