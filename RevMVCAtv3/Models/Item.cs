using System;
using System.Collections.Generic;

namespace RevMVCAtv3.Models;

public partial class Item
{
    public int IdItem { get; set; }

    public string NomeItem { get; set; } = null!;

    public double Preco { get; set; }

    public string? Descricao { get; set; }

    public byte[]? ImagemItem { get; set; }
}
