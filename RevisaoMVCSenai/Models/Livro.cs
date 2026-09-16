using System;
using System.Collections.Generic;

namespace RevisaoMVCSenai.Models;

public partial class Livro
{
    public int IdLivro { get; set; }

    public string NomeLivro { get; set; } = null!;

    public string Descricao { get; set; } = null!;

    public DateOnly DataLivro { get; set; }

    public byte[]? Foto { get; set; }
}
