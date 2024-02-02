using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using ApiAgenciaBancariaGraphQL.Entities;

namespace ApiAgenciaBancariaGraphQL.Data.ContextConfigurations;

public class ClienteContextConfiguration : IEntityTypeConfiguration<Cliente>
{
    private Guid[] _ids;

    public ClienteContextConfiguration(Guid[] ids)
    {
        _ids = ids;
    }

    public void Configure(EntityTypeBuilder<Cliente> builder)
    {
            builder
           .HasData(
           new Cliente
           {
               ClienteId = Guid.Parse("c5a66b10862d4d5da98d3a14e4e3da92"),
               Nome = "João",
               Sobrenome = "Silva",
               Email = "joao.silva@email.com",
               ContaBancariaId = Guid.Parse("7f5e1c23d7744922b8f9ff8667fb42bf")
           },
           new Cliente
           {
               ClienteId = Guid.Parse("3cbf93e503a04c39a126f7a1e150ca9d"),
               Nome = "Maria",
               Sobrenome = "Santos",
               Email = "maria.santos@email.com",
               ContaBancariaId = Guid.Parse("33c5b0bb73954ebaa9222c3322e267bc")
           },
           new Cliente
           {
               ClienteId = Guid.Parse("edb236972d0a458d8a1d87481a361515"),
               Nome = "Carlos",
               Sobrenome = "Ferreira",
               Email = "carlos.ferreira@email.com",
               ContaBancariaId = Guid.Parse("6d08a9dd4907452d8ea1a46e75d171cd")
           });

    }
}