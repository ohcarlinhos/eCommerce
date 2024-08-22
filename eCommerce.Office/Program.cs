using eCommerce.Office;
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

