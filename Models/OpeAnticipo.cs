﻿using System;
using System.Collections.Generic;

#nullable disable

namespace PLANTILLA_API_ODATA.Models
{
    public partial class OpeAnticipo
    {
        public string TipoDocumento { get; set; }
        public string NumeroDocu { get; set; }
        public string TipoDocumento2 { get; set; }
        public string NumeroDocu2 { get; set; }
        public string RucCli { get; set; }
        public decimal ValorOriginal { get; set; }
        public decimal ValorAplicado { get; set; }
    }
}
