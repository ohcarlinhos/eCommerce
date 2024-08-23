using eCommerce.Office;
using eCommerce.Office.Models;
using Microsoft.EntityFrameworkCore;

var db = new eCommerceOfficeContext();

#region ManyToMany > 2x One-To-Many = EF Core < 3.1

var result = db.Setores!
    .Include(s => s.ColaboradorSetor)!
    .ThenInclude(cs => cs.Colaborador);

foreach (var setor in result)
{
    Console.WriteLine(setor.Nome);

    if (setor.ColaboradorSetor == null) continue;

    foreach (var cs in setor.ColaboradorSetor)
    {
        Console.WriteLine($"-- {cs.Colaborador?.Nome}");
    }

    if (setor.ColaboradorSetor.Count == 0)
        Console.WriteLine("-- Vazio --");

    Console.WriteLine("");
}

#endregion

#region EF Core 5+

Console.WriteLine("----------------------------\n");

var colaboradores =
    db.Colaboradores!.Include(c => c.Turmas);

foreach (var c in colaboradores)
{
    Console.WriteLine(c.Nome);

    foreach (var turma in c.Turmas!)
    {
        Console.WriteLine($"- {turma.Nome}");
    }
}

#endregion

#region Many-to-Many + Payload

Console.WriteLine("----------------------------\n");

var colabVeiculos = db.Colaboradores!
    .Include(a => a.ColaboradoresVeiculos)!
    .ThenInclude(a => a.Veiculo);

foreach (var colab in colabVeiculos)
{
    Console.WriteLine(colab.Nome);

    foreach (var cv in colab.ColaboradoresVeiculos!)
    {
        Console.WriteLine($"- {cv.Veiculo!.Nome} ({cv.Veiculo.Placa}) - {cv.DataInicioVinculo}");
    }
}

#endregion

// Obtendo "tabela" em tempo de código que não foi adicionada ao DbSet, mas existe.
var coVeiculo = db.Set<ColaboradorVeiculo>()
    .SingleOrDefault(a => a.ColaboradorId == 1 && a.VeiculoId == 1);

Console.WriteLine();
Console.WriteLine("--- " + coVeiculo.DataInicioVinculo);