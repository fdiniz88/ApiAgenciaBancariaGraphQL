using ApiAgenciaBancariaGraphQL.Entities;

namespace ApiAgenciaBancariaGraphQL.Data;

public class Query
{
    [UseProjection]  
    [UseFiltering]
    [UseSorting]
    public IQueryable<AgenciaBancaria> GetAgenciaBancaria([Service] AppDbContext context) =>
        context.AgenciasBancaria;
}
