using ApiAgenciaBancariaGraphQL.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace ApiAgenciaBancariaGraphQL.Data.ContextConfigurations;

public class AgenciaBancariaContextConfiguration :
             IEntityTypeConfiguration<AgenciaBancaria>
{
    private Guid[] _ids;

    public AgenciaBancariaContextConfiguration(Guid[] ids)
    {
        _ids = ids;
    }

    public void Configure(EntityTypeBuilder<AgenciaBancaria> builder)
    {
            builder
        .HasData(
        new AgenciaBancaria
        {
            AgenciaBancariaId = Guid.Parse("29d94a898d9649d49e9c335eab2b650a"),
            Nome = "AgenciaA",
            Endereco = "Rua A, 123"
        },
        new AgenciaBancaria
        {
            AgenciaBancariaId = Guid.Parse("3a21dbcef7f64b9abaef504511263cee"),
            Nome = "AgenciaB",
            Endereco = "Avenida B, 456"
        },
        new AgenciaBancaria
        {
            AgenciaBancariaId = Guid.Parse("a87c8e0e63f14cc7b83a1a6b60959d36"),
            Nome = "AgenciaC",
            Endereco = "Praça C, 789"
        });

    }
}