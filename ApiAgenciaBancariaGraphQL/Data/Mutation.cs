using ApiAgenciaBancariaGraphQL.Entities;
using ApiAgenciaBancariaGraphQL.Repositories;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Metadata.Ecma335;

namespace ApiAgenciaBancariaGraphQL.Data;

public class Mutation
{
    private readonly IAgenciaBancariaRepository _agenciaBancariaRepository;
    public Mutation(IAgenciaBancariaRepository agenciaBancariaRepository) 
    {
        _agenciaBancariaRepository = agenciaBancariaRepository;
    }
    public AgenciaBancaria CriarAgenciaBancaria(AgenciaBancariaViewModel agenciaBancaria)
    {
        var novaAgencia = new AgenciaBancaria
        {
            AgenciaBancariaId = Guid.NewGuid(),
            Nome = agenciaBancaria.Nome,
            Endereco = agenciaBancaria.Endereco
        };

        _agenciaBancariaRepository.AddAgenciaBancaria(novaAgencia);

        return novaAgencia;
    }
}
