using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace Games.Model
{
    [Table("Contatos")]
public class Contato
{

    [Column("id")]
    public int Id { get; set; }

    [Column("cpf")]
    public string Cpf { get; set; } = string.Empty;

    [Column("nome")]
    public string Nome { get; set; } = string.Empty;

    [Column("email")]
    public string Email { get; set; } = string.Empty;

    [Column("telefone")]
    public string Telefone { get; set; } = string.Empty;
}
}
