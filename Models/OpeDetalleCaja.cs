﻿using System;
using System.Collections.Generic;

#nullable disable

namespace PLANTILLA_API_ODATA.Models
{
    public partial class OpeDetalleCaja
    {
        public string CdgArea { get; set; }
        public string NumCaja { get; set; }
        public string NumCor { get; set; }
        public string CdgMcja { get; set; }
        public DateTime FecDcja { get; set; }
        public string DocDcja { get; set; }
        public string CncDcja { get; set; }
        public decimal? ImpDcja { get; set; }
        public string NumOrig { get; set; }
        public string NumVouc { get; set; }
        public decimal? IdProveedor { get; set; }
        public string RucPrv { get; set; }
        public string CdgTdoc { get; set; }
        public string NumDocu { get; set; }
        public string MonDocu { get; set; }
        public DateTime? FecDocu { get; set; }
        public decimal ImpPag { get; set; }
        public decimal TipCmb { get; set; }
        public string SwtAct { get; set; }
        public string CdgCct { get; set; }
        public string CdgTana { get; set; }
        public string CdgAnal { get; set; }
        public string UsuarioCreacion { get; set; }
        public DateTime FechaCreacion { get; set; }
        public string Referencia1 { get; set; }
        public DateTime? FechaLiquida { get; set; }
        public string MonCaja { get; set; }
        public int IdCc { get; set; }
        public string CdgPedido { get; set; }
        public string CdgSucursal { get; set; }
        public string NumRequi { get; set; }
        public string ScdgCc { get; set; }
        public decimal? IdSd { get; set; }

        public virtual OpeCaja OpeCaja { get; set; }
    }
}
