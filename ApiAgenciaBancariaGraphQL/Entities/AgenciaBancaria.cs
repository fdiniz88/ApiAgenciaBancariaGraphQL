using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ApiAgenciaBancariaGraphQL.Entities;

public class AgenciaBancaria
{
    [Key]
    public Guid AgenciaBancariaId { get; set; }

    [Required(ErrorMessage = "O nome da agência é obrigatório")]
    public string? Nome { get; set; }
    public string? Endereco { get; set; }

    [UseSorting]
    public ICollection<ContaBancaria>? ContasBancarias { get; set; }
}