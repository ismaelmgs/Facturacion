using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Facturacion.Objetos
{
    public class Empresa
    {
        private string _sRFC = string.Empty;
        private string _sRFCEmision = string.Empty;
        private string _sCPExpedicion = string.Empty;
        private string _sSerieId = string.Empty;
        private string _sRazonSocial = string.Empty;
        private string _sNombreCorto = string.Empty;
        private string _sDireccion = string.Empty;
        private string _sTelefono = string.Empty;
        private byte[] _vbLogotipo;
        private byte[] _vbArchivoKey;
        private byte[] _vbArchivoCer;
        private string _sMision = string.Empty;
        private string _sVision = string.Empty;
        private string _sValores = string.Empty;


        private int _iEstatus = 0;



        public string sRFC { get { return _sRFC; } set { _sRFC = value; } }
        public string sRFCEmision { get { return _sRFCEmision; } set { _sRFCEmision = value; } }
        public string sCPExpedicion { get { return _sCPExpedicion; } set { _sCPExpedicion = value; } }
        public string sSerieId { get { return _sSerieId; } set { _sSerieId = value; } }
        public string sRazonSocial { get { return _sRazonSocial; } set { _sRazonSocial = value; } }
        public string sNombreCorto { get { return _sNombreCorto; } set { _sNombreCorto = value; } }
        public string sDireccion { get { return _sDireccion; } set { _sDireccion = value; } }
        public string sTelefono { get { return _sTelefono; } set { _sTelefono = value; } }

        public byte[] vbLogotipo { get { return _vbLogotipo; } set { _vbLogotipo = value; } }
        public byte[] vbArchivoKey { get { return _vbArchivoKey; } set { _vbArchivoKey = value; } }
        public byte[] vbArchivoCer { get { return _vbArchivoCer; } set { _vbArchivoCer = value; } }

        public string sMision { get { return _sMision; } set { _sMision = value; } }
        public string sVision { get { return _sVision; } set { _sVision = value; } }
        public string sValores { get { return _sValores; } set { _sValores = value; } }
        public int iEstatus { get { return _iEstatus; } set { _iEstatus = value; } }
    }
}