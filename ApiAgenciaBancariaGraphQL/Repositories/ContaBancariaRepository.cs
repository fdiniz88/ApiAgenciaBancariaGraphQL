using ApiAgenciaBancariaGraphQL.Data;

namespace ApiAgenciaBancariaGraphQL.Repositories;

public class ContaBancariaRepository : IContaBancariaRepository
{
    private readonly AppDbContext _appDbContext;

    public ContaBancariaRepository(AppDbContext appDbContext)
    {
        _appDbContext = appDbContext;
    }
}
