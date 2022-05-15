﻿using System;
using System.Collections.Generic;

#nullable disable

namespace PLANTILLA_API_ODATA.Models
{
    public partial class VwFaelFacturaV04
    {
        public int? Ano { get; set; }
        public int? Mes { get; set; }
        public int? Dia { get; set; }
        public DateTime FechDocu { get; set; }
        public string ConfRazonSocial { get; set; }
        public string NombComercial { get; set; }
        public string Ubigeo { get; set; }
        public string ConfDireccion { get; set; }
        public string Urbanizacion { get; set; }
        public string Provincia { get; set; }
        public string Departamento { get; set; }
        public string Distrito { get; set; }
        public string Establecimiento { get; set; }
        public string Almacen { get; set; }
        public string Pais { get; set; }
        public string ConfRuc { get; set; }
        public string TipoDocuEmpr { get; set; }
        public string TipoDocu { get; set; }
        public string NumeDocu { get; set; }
        public string ClienteRuc { get; set; }
        public string TipoDocuClie { get; set; }
        public string ClienteNombre { get; set; }
        public string Unidad { get; set; }
        public decimal DvedvCantidad { get; set; }
        public string ExistenciaNombre { get; set; }
        public string ExistenciaNombre2 { get; set; }
        public double? ValoUnit { get; set; }
        public double? Precio { get; set; }
        public string TipoPrecio { get; set; }
        public double? IgvItem { get; set; }
        public double? IgvItem2 { get; set; }
        public string AfecIgv { get; set; }
        public string CodiIgv { get; set; }
        public string NombIgv { get; set; }
        public string NombIgvInt { get; set; }
        public string TotaOperGravTipo { get; set; }
        public double? ValoVentGravTota { get; set; }
        public string TotaOperInafTipo { get; set; }
        public decimal ValoVentInafTota { get; set; }
        public string TotaOperExonTipo { get; set; }
        public decimal ValoVentExonTota { get; set; }
        public double? ValoVentItem { get; set; }
        public double? SubtotalItem { get; set; }
        public decimal Subtotal { get; set; }
        public decimal Subtotaligv { get; set; }
        public decimal? APagar { get; set; }
        public decimal VedvMontoIgv { get; set; }
        public decimal VedvMontoIgv2 { get; set; }
        public double? VedvMontoIgv3 { get; set; }
        public string CodiIgvTota { get; set; }
        public string NombIgvTota { get; set; }
        public string NombIgvIntTota { get; set; }
        public string CodiDcto { get; set; }
        public int VedvMontoDescuento { get; set; }
        public decimal? VedvMonto { get; set; }
        public string Moneda { get; set; }
        public string Guias { get; set; }
        public string TipoGuia { get; set; }
        public string TipoLeyendaMonto { get; set; }
        public string LeyendaMonto { get; set; }
        public int DvedvSecuencia { get; set; }
        public string CodigoSunat { get; set; }
        public string ExistenciaCodactual { get; set; }
        public decimal ValoNoOnerItem { get; set; }
        public string TipoValoNoOnerItem { get; set; }
        public string VersionUbl { get; set; }
        public string VersionEstructura { get; set; }
        public string TotaOperGratTipo { get; set; }
        public decimal? ValoVentGratTota { get; set; }
        public string TipoDocuAnticipo { get; set; }
        public string Anticipos { get; set; }
        public string AnticipoRuc { get; set; }
        public string TipoDocuRucAnticipo { get; set; }
        public decimal? TotalAnticipo { get; set; }
        public decimal? TotalAnticipo2 { get; set; }
        public string TipoOper { get; set; }
        public decimal Detraccion { get; set; }
        public decimal PorcDetraccion { get; set; }
        public string CodiDetraccion { get; set; }
        public string LeyendaDetraccion { get; set; }
        public string DescripcionDetraccion { get; set; }
        public string LeyendaCtaBn { get; set; }
        public string DescripcionLeyendaCtaBn { get; set; }
        public string Vendedor { get; set; }
        public string OrdenCompra { get; set; }
        public string Pedido { get; set; }
        public string FormaPago { get; set; }
        public string VedvGlosa { get; set; }
        public string CodigoTipoDetraccion { get; set; }
        public string TipoDetraccion { get; set; }
        public string CorreoCliente { get; set; }
        public string ClienteUbigeo { get; set; }
        public string DireccionCliente { get; set; }
        public string FonoCliente { get; set; }
        public string TipoLeyendaTtg { get; set; }
        public string LeyendaTtg { get; set; }
        public string Usuario { get; set; }
        public string HoraEmision { get; set; }
        public DateTime? FechaVenc { get; set; }
        public int? AnoV { get; set; }
        public int? MesV { get; set; }
        public int? DiaV { get; set; }
        public string CodiInte { get; set; }
        public decimal? PorcentajeIgv { get; set; }
        public decimal? ValorInafectoItem { get; set; }
        public decimal? Icbper { get; set; }
        public decimal? IcbperTotal { get; set; }
        public string CodigoEmpresa { get; set; }
        public decimal? PorIgv { get; set; }
        public string Comentario { get; set; }
        public string NomUnidad { get; set; }
        public int Secuencia { get; set; }
        public string CodigoBarra { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Series { get; set; }
        public decimal IdDocumento { get; set; }
        public string DireccionSucursal { get; set; }
        public int? MesesGarantia { get; set; }
        public string Seccion { get; set; }
        public string Grado { get; set; }
        public string NivelAcademico { get; set; }
        public string ValorResumen { get; set; }
        public string SwtFe { get; set; }
        public string SwtBj { get; set; }
        public string Laborat0rio { get; set; }
        public string Lote { get; set; }
        public string Fecvenc { get; set; }
        public decimal PrecioUnitario { get; set; }
        public decimal SubTotal1 { get; set; }
        public string MExito { get; set; }
        public DateTime? FechaReferencia { get; set; }
        public string DocuRefe { get; set; }
        public string SwtImp2 { get; set; }
        public string RefeCorr { get; set; }
        public string SwtImp { get; set; }
        public decimal? CantKit { get; set; }
        public string CdgKit { get; set; }
        public string NomKit { get; set; }
        public string NomMoneda { get; set; }
        public string TipoAfecIgv { get; set; }
        public string TipoDocuIden { get; set; }
        public string NumPlaca { get; set; }
        public decimal? ImpCredito { get; set; }
        public byte[] Imgalm { get; set; }
        public decimal? PorRetencion { get; set; }
        public decimal? ImpRetencion { get; set; }
        public string CodigoRetencion { get; set; }
        public string CodigoAnticipo { get; set; }
    }
}
