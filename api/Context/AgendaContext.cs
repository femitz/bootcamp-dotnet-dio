using api.Entities;
using Microsoft.EntityFrameworkCore;

namespace api.Context;

public class AgendaContext : DbContext
{
    public AgendaContext(DbContextOptions<AgendaContext> options) : base(options) { }

    // Minhas Tabelas
    public DbSet<Contato> Contatos { get; set; }
}
