using System;
using System.Collections.Generic;

namespace RevisaoMVCAtividade2.Models;

public partial class Item
{
    public int IdItem { get; set; }

    public string Nome { get; set; } = null!;

    public int Quantidade { get; set; }

    public bool Comprado { get; set; }

    public int IdUsuario { get; set; }

    public virtual Usuario IdUsuarioNavigation { get; set; } = null!;
}
