﻿namespace eCommerce.Office.Models;

public class Setor
{
    public int Id { get; set; }
    public string Nome { get; set; } = null!;

    public ICollection<ColaboradorSetor>? ColaboradorSetor { get; set; }
}