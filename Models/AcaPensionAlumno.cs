﻿using System;
using System.Collections.Generic;

#nullable disable

namespace PLANTILLA_API_ODATA.Models
{
    public partial class AcaPensionAlumno
    {
        public string Ano { get; set; }
        public decimal Mes { get; set; }
        public string NumModalidad { get; set; }
        public decimal IdProducto { get; set; }
        public decimal Secuencia { get; set; }
        public DateTime FechaVencimiento { get; set; }
        public string Nombre { get; set; }
        public decimal Inicial { get; set; }
        public decimal Primaria { get; set; }
        public decimal Secundaria { get; set; }
        public string Estado { get; set; }
        public string UsuarioCreacion { get; set; }
        public DateTime FechaCreacion { get; set; }
        public string UsuarioModificacion { get; set; }
        public DateTime? FechaModificacion { get; set; }
    }
}
