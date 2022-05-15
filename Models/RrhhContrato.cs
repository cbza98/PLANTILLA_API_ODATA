﻿using System;
using System.Collections.Generic;

#nullable disable

namespace PLANTILLA_API_ODATA.Models
{
    public partial class RrhhContrato
    {
        public decimal IdPersona { get; set; }
        public string TipoContrato { get; set; }
        public DateTime? InicioPrueba { get; set; }
        public DateTime? FinPrueba { get; set; }
        public DateTime FechaInscripcion { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
        public string Renovacion { get; set; }
        public byte[] Contrato { get; set; }
        public string UsuarioCreacion { get; set; }
        public DateTime FechaCreacion { get; set; }
        public string UsuarioModificacion { get; set; }
        public DateTime? FechaModificacion { get; set; }
    }
}
