using System;
using System.Collections.Generic;

namespace BlazorArchitecture.Shared.Models;

public partial class Medio
{
    public int MediosId { get; set; }

    public string? Titulo { get; set; }

    public string? Leyenda { get; set; }

    public string? Descripcion { get; set; }

    public string? Enlace { get; set; }
}
