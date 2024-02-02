using ApiAgenciaBancariaGraphQL.Data.ContextConfigurations;
using ApiAgenciaBancariaGraphQL.Entities;
using Microsoft.EntityFrameworkCore;

namespace ApiAgenciaBancariaGraphQL.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions options) : base(options)
    { }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        // Gera 3 GUIDS e os coloca em um array
        var ids = new Guid[] { Guid.NewGuid(), Guid.NewGuid(), Guid.NewGuid() };

        // Aplica a configuração para 3 contextos
        // Isso vai criar os dados usados no endpoint do GraphQL
        builder.ApplyConfiguration(new ClienteContextConfiguration(ids));
        builder.ApplyConfiguration(new ContaBancariaContextConfiguration(ids));
        builder.ApplyConfiguration(new AgenciaBancariaContextConfiguration(ids));
    }

    // Adiciona os DbSets para cada modelo
    public DbSet<Cliente> Clientes { get; set; }
    public DbSet<ContaBancaria> ContasBancaria { get; set; }
    public DbSet<AgenciaBancaria> AgenciasBancaria { get; set; }
}
