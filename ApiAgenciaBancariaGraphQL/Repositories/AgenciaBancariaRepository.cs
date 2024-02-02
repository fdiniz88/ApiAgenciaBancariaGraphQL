using ApiAgenciaBancariaGraphQL.Data;

namespace ApiAgenciaBancariaGraphQL.Repositories
{
    public class AgenciaBancariaRepository : IAgenciaBancariaRepository
    {
        private readonly AppDbContext _appDbContext;

        public AgenciaBancariaRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
    }
}
