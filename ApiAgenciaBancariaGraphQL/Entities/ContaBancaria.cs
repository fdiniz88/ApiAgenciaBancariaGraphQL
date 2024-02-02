using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApiAgenciaBancariaGraphQL.Entities;

public class ContaBancaria
{
    [Key]
    public Guid ContaBancariaId { get; set; }

    [Required(ErrorMessage = "O número da conta é obrigatório")]
    public string? NumeroConta { get; set; }
    public decimal Saldo { get; set; }

    [ForeignKey("AgenciaBancariaId")]
    public Guid AgenciaBancariaId { get; set; }

    [UseSorting]
    public AgenciaBancaria? AgenciaBancaria { get; set; }

    [UseSorting]
    public ICollection<Cliente>? Clientes { get; set; }
}
