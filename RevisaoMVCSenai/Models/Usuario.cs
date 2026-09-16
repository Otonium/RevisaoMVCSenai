using System;
using System.Collections.Generic;

namespace RevisaoMVCSenai.Models;

public partial class Usuario
{
    public int IdUsario { get; set; }

    public string Nome { get; set; } = null!;

    public string Email { get; set; } = null!;

    public byte[] Senha { get; set; } = null!;
}
