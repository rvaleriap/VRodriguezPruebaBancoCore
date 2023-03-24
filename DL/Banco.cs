﻿using System;
using System.Collections.Generic;

namespace DL;

public partial class Banco
{
    public int IdBanco { get; set; }

    public string? Nombre { get; set; }

    public int? NoEmpleados { get; set; }

    public int? NoSucursales { get; set; }

    public decimal? Capital { get; set; }

    public int? NoClientes { get; set; }

    public int? IdPais { get; set; }

    public int? IdRazonSocial { get; set; }

    public virtual Pai? IdPaisNavigation { get; set; }

    public virtual RazonSocial? IdRazonSocialNavigation { get; set; }
}
