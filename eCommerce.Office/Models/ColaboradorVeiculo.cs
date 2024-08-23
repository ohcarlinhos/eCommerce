namespace eCommerce.Office.Models;

public class ColaboradorVeiculo
{
    /* MER */
    public int ColaboradorId { get; set; }
    public int VeiculoId { get; set; }

    public DateTimeOffset DataInicioVinculo { get; set; }

    /* POO */
    public Colaborador? Colaborador { get; set; }
    public Veiculo? Veiculo { get; set; }
}