namespace eCommerce.Office.Models;

public class Colaborador
{
    public int Id { get; set; }
    public string Nome { get; set; } = null!;

    public ICollection<ColaboradorSetor>? ColaboradorSetor { get; set; }

    /* Posso acessar diereto os veículos */
    public ICollection<Veiculo>? Veiculos { get; set; }

    /* Também possuo acesso a tabela de vínculo */
    public ICollection<ColaboradorVeiculo>? ColaboradoresVeiculos { get; set; }

    public ICollection<Turma>? Turmas { get; set; }
}