﻿using System;
using System.Collections.Generic;

#nullable disable

namespace PLANTILLA_API_ODATA.Models
{
    public partial class ContaSaldosa
    {
        public string AnoSld { get; set; }
        public string MesSld { get; set; }
        public string CdgCta { get; set; }
        public string CdgMon { get; set; }
        public string CdgTana { get; set; }
        public string CdgAnal { get; set; }
        public string CdgCct { get; set; }
        public decimal DebSld { get; set; }
        public decimal DebOfi { get; set; }
        public decimal DebPat { get; set; }
        public decimal HabSld { get; set; }
        public decimal HabOfi { get; set; }
        public decimal HabPat { get; set; }
        public decimal Venta { get; set; }
        public decimal Compra { get; set; }
    }
}
