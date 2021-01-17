using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FacturacionLinea.Objetos
{
    [Serializable]
    public class LoginTimbrado
    {
        private DetalleLoginTimbrado _foo = new DetalleLoginTimbrado();

        public DetalleLoginTimbrado foo { get { return _foo; } set { _foo = value; } }
    }

    [Serializable]
    public class DetalleLoginTimbrado
    {
        private int _ID = 0;
        private int _IDcuenta = 0;
        private int _IDempresa = 0;
        private string _email = string.Empty;
        private string _api = string.Empty;
        private int _status = 0;
        private string _msg = string.Empty;


        public int ID { get { return _ID; } set { _ID = value; } }
        public int IDcuenta { get { return _IDcuenta; } set { _IDcuenta = value; } }
        public int IDempresa { get { return _IDempresa; } set { _IDempresa = value; } }
        public string email { get { return _email; } set { _email = value; } }
        public string api { get { return _api; } set { _api = value; } }
        public int status { get { return _status; } set { _status = value; } }
        public string msg { get { return _msg; } set { _msg = value; } }
    }

    [Serializable]
    public class Timbrado33
    {
        private string _RFCemisor = string.Empty;
        private string _expedicion = string.Empty;
        private string _serieid = string.Empty;
        private string _RFCreceptor = string.Empty;
        private string _razonsocial = string.Empty;
        private string _numext = string.Empty;
        private string _numint = string.Empty;
        private string _calle = string.Empty;
        private string _colonia = string.Empty;
        private string _ciudad = string.Empty;
        private string _estado = string.Empty;
        private string _codigopostal = string.Empty;
        private string _pais = string.Empty;
        private string _telefono = string.Empty;
        private string _contacto = string.Empty;
        private string _email = string.Empty;
        private decimal _subTotal = 0;
        private decimal _Descuento = 0;
        private decimal _TipoCambio = 0;
        private string _Moneda = string.Empty;
        private decimal _total = 0;
        private string _tipoDeComprobante = string.Empty;
        private string _formaDePago = string.Empty;
        private string _NumCtaPago = string.Empty;
        private string _metodoDePago = string.Empty;
        private string _Confirmacion = string.Empty;
        private string _RegimenFiscal = string.Empty;
        private string _UsoCFDI = string.Empty;
        private string _condicionesDePago = string.Empty;
        private string _observaciones = string.Empty;
        private List<PartidasTimbrado> _partidas = new List<PartidasTimbrado>();

        public string RFCemisor { get { return _RFCemisor; } set { _RFCemisor = value; } }
        public string expedicion { get { return _expedicion; } set { _expedicion = value; } }
        public string serieid { get { return _serieid; } set { _serieid = value; } }
        public string RFCreceptor { get { return _RFCreceptor; } set { _RFCreceptor = value; } }
        public string razonsocial { get { return _razonsocial; } set { _razonsocial = value; } }
        public string numext { get { return _numext; } set { _numext = value; } }
        public string numint { get { return _numint; } set { _numint = value; } }
        public string calle { get { return _calle; } set { _calle = value; } }
        public string colonia { get { return _colonia; } set { _colonia = value; } }
        public string ciudad { get { return _ciudad; } set { _ciudad = value; } }
        public string estado { get { return _estado; } set { _estado = value; } }
        public string codigopostal { get { return _codigopostal; } set { _codigopostal = value; } }
        public string pais { get { return _pais; } set { _pais = value; } }
        public string telefono { get { return _telefono; } set { _telefono = value; } }
        public string contacto { get { return _contacto; } set { _contacto = value; } }
        public string email { get { return _email; } set { _email = value; } }
        public decimal subTotal { get { return _subTotal; } set { _subTotal = value; } }
        public decimal Descuento { get { return _Descuento; } set { _Descuento = value; } }
        public decimal TipoCambio { get { return _TipoCambio; } set { _TipoCambio = value; } }
        public string Moneda { get { return _Moneda; } set { _Moneda = value; } }
        public decimal total { get { return _total; } set { _total = value; } }
        public string tipoDeComprobante { get { return _tipoDeComprobante; } set { _tipoDeComprobante = value; } }
        public string formaDePago { get { return _formaDePago; } set { _formaDePago = value; } }
        public string NumCtaPago { get { return _NumCtaPago; } set { _NumCtaPago = value; } }
        public string metodoDePago { get { return _metodoDePago; } set { _metodoDePago = value; } }
        public string Confirmacion { get { return _Confirmacion; } set { _Confirmacion = value; } }
        public string RegimenFiscal { get { return _RegimenFiscal; } set { _RegimenFiscal = value; } }
        public string UsoCFDI { get { return _UsoCFDI; } set { _UsoCFDI = value; } }
        public string condicionesDePago { get { return _condicionesDePago; } set { _condicionesDePago = value; } }
        public string observaciones { get { return _observaciones; } set { _observaciones = value; } }
        public List<PartidasTimbrado> partidas { get { return _partidas; } set { _partidas = value; } }
    }

    [Serializable]
    public class PartidasTimbrado
    {
        private int _cantidad = 0;
        private string _unidad = string.Empty;
        private string _descripcion = string.Empty;
        private int _valorUnitario = 0;
        private decimal _importe = 0;
        private string _noIdentificacion = string.Empty;
        private string _comentario = string.Empty;
        private string _aduana = string.Empty;
        private string _pedimentonumero = string.Empty;
        private string _pedimentofecha = string.Empty;
        private string _cuentapredial = string.Empty;
        private string _extra1 = string.Empty;
        private string _extra2 = string.Empty;
        private string _extra3 = string.Empty;
        private string _extra4 = string.Empty;
        private string _extra5 = string.Empty;
        private string _ClaveProdServ = string.Empty;
        private string _ClaveUnidad = string.Empty;
        private decimal _Descuento = 0;
        private List<ImpuestosPartidas> _impuestos = new List<ImpuestosPartidas>();

        public int cantidad { get { return _cantidad; } set { _cantidad = value; } }
        public string unidad { get { return _unidad; } set { _unidad = value; } }
        public string descripcion { get { return _descripcion; } set { _descripcion = value; } }
        public string ClaveProdServ { get { return _ClaveProdServ; } set { _ClaveProdServ = value; } }
        public int valorUnitario { get { return _valorUnitario; } set { _valorUnitario = value; } }
        public decimal importe { get { return _importe; } set { _importe = value; } }
        public string noIdentificacion { get { return _noIdentificacion; } set { _noIdentificacion = value; } }
        public string ClaveUnidad { get { return _ClaveUnidad; } set { _ClaveUnidad = value; } }
        public decimal Descuento { get { return _Descuento; } set { _Descuento = value; } }
        public string comentario { get { return _comentario; } set { _comentario = value; } }
        public string aduana { get { return _aduana; } set { _aduana = value; } }
        public string pedimentonumero { get { return _pedimentonumero; } set { _pedimentonumero = value; } }
        public string pedimentofecha { get { return _pedimentofecha; } set { _pedimentofecha = value; } }
        public string cuentapredial { get { return _cuentapredial; } set { _cuentapredial = value; } }
        public string extra1 { get { return _extra1; } set { _extra1 = value; } }
        public string extra2 { get { return _extra2; } set { _extra2 = value; } }
        public string extra3 { get { return _extra3; } set { _extra3 = value; } }
        public string extra4 { get { return _extra4; } set { _extra4 = value; } }
        public string extra5 { get { return _extra5; } set { _extra5 = value; } }
        public List<ImpuestosPartidas> impuestos { get { return _impuestos; } set { _impuestos = value; } }
    }

    public class ImpuestosPartidas
    {
        private string _tipoimpuesto = string.Empty;
        private string _factorimpuesto = string.Empty;
        private string _valorimpuesto = string.Empty;
        private string _importeimpuesto = string.Empty;


        public string tipoimpuesto { get { return _tipoimpuesto; } set { _tipoimpuesto = value; } }
        public string factorimpuesto { get { return _factorimpuesto; } set { _factorimpuesto = value; } }
        public string valorimpuesto { get { return _valorimpuesto; } set { _valorimpuesto = value; } }
        public string importeimpuesto { get { return _importeimpuesto; } set { _importeimpuesto = value; } }
    }

}