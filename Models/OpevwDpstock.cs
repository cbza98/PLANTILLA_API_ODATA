﻿using System;
using System.Collections.Generic;

#nullable disable

namespace PLANTILLA_API_ODATA.Models
{
    public partial class OpevwDpstock
    {
        public decimal IdDocumento { get; set; }
        public string CodigoSucursal { get; set; }
        public string TipoGuia { get; set; }
        public int IdProducto { get; set; }
        public string Lote { get; set; }
        public string Serie { get; set; }
        public string CodigoUnidad { get; set; }
        public decimal? Ingreso { get; set; }
        public decimal? Salida { get; set; }
        public DateTime FechaVencimiento { get; set; }
    }
}
