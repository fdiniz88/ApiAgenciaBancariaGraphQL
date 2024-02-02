using ApiAgenciaBancariaGraphQL.Data;
using ApiAgenciaBancariaGraphQL.Entities;

namespace ApiAgenciaBancariaGraphQL.Repositories
{
    public class AgenciaBancariaRepository : IAgenciaBancariaRepository
    {
        private readonly AppDbContext _appDbContext;

        public AgenciaBancariaRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
            
        }

        public void AddAgenciaBancaria(AgenciaBancaria agenciaBancaria)
        {
            _appDbContext.Add(agenciaBancaria);
            _appDbContext.SaveChanges();
            
        }
    }
}
