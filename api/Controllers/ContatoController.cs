using api.Context;
using api.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace api.Controllers;

[ApiController]
[Route("[controller]")]
public class ContatoController : ControllerBase
{

    private readonly AgendaContext _context;
    public ContatoController(AgendaContext context)
    {
        _context = context;
    }

    [HttpPost]
    public IActionResult Create(Contato contato)
    {
        _context.Add(contato);
        _context.SaveChanges();
        return CreatedAtAction(nameof(ObterPorId), new { id = contato.Id }, contato); 
    }

    [HttpGet("{id}")]
    public IActionResult ObterPorId(int id)
    {
        // DbSet
        var contato = _context.Contatos.Find(id);

        if (contato == null)
        {
            return NotFound();
        }

        return Ok(contato);
    }

    [HttpGet("ObterPorNome")]
    public IActionResult ObterPorNome(string nome)
    {
        var contatos = _context.Contatos.Where(x => x.Nome.Contains(nome));

        return Ok(contatos);
    }

    [HttpPut("{id}")]
    public IActionResult Update(int id, Contato contato)
    {
        var contatoBancoDeDados = _context.Contatos.Find(id);

        if (contatoBancoDeDados == null)
        {
            return NotFound();
        }

        contatoBancoDeDados.Nome = contato.Nome;
        contatoBancoDeDados.Telefone = contato.Telefone;
        contatoBancoDeDados.Ativo = contato.Ativo;

        _context.Contatos.Update(contatoBancoDeDados);
        _context.SaveChanges();

        return Ok(contatoBancoDeDados);
    }

    [HttpDelete("{id}")]
    public IActionResult Delete(int id)
    {
        var contatoBancoDeDados = _context.Contatos.Find(id);

        if (contatoBancoDeDados == null)
        {
            return NotFound();
        }

        _context.Contatos.Remove(contatoBancoDeDados);
        _context.SaveChanges();

        return Ok(NoContent());
    }


}
