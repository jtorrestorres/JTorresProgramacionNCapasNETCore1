using System;
using System.Collections.Generic;

namespace PL;

public partial class Semestre
{
    public byte IdSemestre { get; set; }

    public string? Nombre { get; set; }

    public virtual ICollection<Materium> Materia { get; set; } = new List<Materium>();
}
