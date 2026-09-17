using System;
using System.Collections.Generic;

namespace RevisaoMVCAtividade2.Models;

public partial class Usuario
{
    public int IdUsuario { get; set; }

    public string Nome { get; set; } = null!;

    public string Email { get; set; } = null!;

    public byte[] Senha { get; set; } = null!;

    public virtual ICollection<Item> Items { get; set; } = new List<Item>();
}
