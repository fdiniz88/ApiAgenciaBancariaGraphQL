using ApiAgenciaBancariaGraphQL.Entities;
using System.ComponentModel.DataAnnotations;

namespace ApiAgenciaBancariaGraphQL.Data
{
    public class AgenciaBancariaViewModel
    {
        [Required(ErrorMessage = "O nome da agência é obrigatório")]
        public string? Nome { get; set; }
        public string? Endereco { get; set; }

        [UseSorting]
        public ICollection<ContaBancaria>? ContasBancarias { get; set; }
    }
}
