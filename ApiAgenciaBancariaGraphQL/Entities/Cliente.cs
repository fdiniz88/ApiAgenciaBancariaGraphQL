using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ApiAgenciaBancariaGraphQL.Entities;

public class Cliente
{
    [Key]
    public Guid ClienteId { get; set; }

    [Required(ErrorMessage = "O nome do cliente é obrigatório")]
    public string? Nome { get; set; }
    public string? Sobrenome { get; set; }
    public string? Email { get; set; }

    [ForeignKey("ContaBancariaId")]
    public Guid ContaBancariaId { get; set; }

    [UseSorting]
    public ContaBancaria? ContaBancaria { get; set; }
}