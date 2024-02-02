using ApiAgenciaBancariaGraphQL.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace ApiAgenciaBancariaGraphQL.Data.ContextConfigurations;

public class ContaBancariaContextConfiguration : IEntityTypeConfiguration<ContaBancaria>
{
    private Guid[] _ids;

    public ContaBancariaContextConfiguration(Guid[] ids)
    {
        _ids = ids;
    }

    public void Configure(EntityTypeBuilder<ContaBancaria> builder)
    {
            builder
        .HasData(
        new ContaBancaria
        {
            ContaBancariaId = Guid.Parse("7f5e1c23d7744922b8f9ff8667fb42bf"),
            NumeroConta = "123456789",
            Saldo = 100,
            AgenciaBancariaId = Guid.Parse("29d94a898d9649d49e9c335eab2b650a")
        },
        new ContaBancaria
        {
            ContaBancariaId = Guid.Parse("33c5b0bb73954ebaa9222c3322e267bc"),
            NumeroConta = "987654321",
            Saldo = 500,
            AgenciaBancariaId = Guid.Parse("3a21dbcef7f64b9abaef504511263cee")
        },
        new ContaBancaria
        {
            ContaBancariaId = Guid.Parse("6d08a9dd4907452d8ea1a46e75d171cd"),
            NumeroConta = "111222333",
            Saldo = 150,
            AgenciaBancariaId = Guid.Parse("a87c8e0e63f14cc7b83a1a6b60959d36")
        });

    }
}