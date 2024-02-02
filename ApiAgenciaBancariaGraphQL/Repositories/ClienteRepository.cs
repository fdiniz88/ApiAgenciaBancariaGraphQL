using ApiAgenciaBancariaGraphQL.Data;

namespace ApiAgenciaBancariaGraphQL.Repositories;

public class ClienteRepository : IClienteRepository
{
    private readonly AppDbContext _appDbContext;

    public ClienteRepository(AppDbContext appDbContext)
    {
        _appDbContext = appDbContext;
    }
}
