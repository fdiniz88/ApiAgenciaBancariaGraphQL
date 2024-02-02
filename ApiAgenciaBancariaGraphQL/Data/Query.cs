using ApiAgenciaBancariaGraphQL.Entities;

namespace ApiAgenciaBancariaGraphQL.Data;

public class Query
{
    [UseProjection]
    [UseFiltering]
    [UseSorting]
    public IQueryable<ContaBancaria> GetAgenciaBancaria([Service] AppDbContext context) =>
        context.ContasBancaria;
}
