using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FacturacionLinea.Objetos
{
    public class UsuarioFacturante
    {
        private int _iIdUsuario = 0;
        private string _sCorreo = string.Empty;
        private string _sRFC = string.Empty;
        private int _iTipoUsuario = 0;
        private string _sNombre = string.Empty;
        private string _sApellidoPat = string.Empty;
        private string _sApellidoMat = string.Empty;
        private string _sRazonSocial = string.Empty;
        private string _sNombreCompleto = string.Empty;
        private string _sCalle = string.Empty;
        private string _sNoExt = string.Empty;
        private string _sNoInt = string.Empty;
        private string _sColonia = string.Empty;
        private string _sMunicipio = string.Empty;
        private string _sCodigoPostal = string.Empty;
        private string _sCiudad = string.Empty;
        private string _sEstado = string.Empty;
        private string _sCorreoContacto = string.Empty;
        private string _sTelefono = string.Empty;
        private string _sCelular = string.Empty;
        private string _sMetodoPago = string.Empty;

        
        public int iIdUsuario { set { _iIdUsuario = value; } get { return _iIdUsuario; } }
        public string sCorreo { set { _sCorreo = value; } get { return _sCorreo; } }
        public string sRFC { set { _sRFC = value; } get { return _sRFC; } }
        public int iTipoUsuario { set { _iTipoUsuario = value; } get { return _iTipoUsuario; } }
        public string sNombre { set { _sNombre = value; } get { return _sNombre; } }
        public string sApellidoPat { set { _sApellidoPat = value; } get { return _sApellidoPat; } }
        public string sApellidoMat { set { _sApellidoMat = value; } get { return _sApellidoMat; } }
        public string sRazonSocial { set { _sRazonSocial = value; } get { return _sRazonSocial; } }
        public string sNombreCompleto { set { _sNombreCompleto = value; } get { return _sNombreCompleto; } }
        public string sCalle { set { _sCalle = value; } get { return _sCalle; } }
        public string sNoExt { set { _sNoExt = value; } get { return _sNoExt; } }
        public string sNoInt { set { _sNoInt = value; } get { return _sNoInt; } }
        public string sColonia { set { _sColonia = value; } get { return _sColonia; } }
        public string sMunicipio { set { _sMunicipio = value; } get { return _sMunicipio; } }
        public string sCodigoPostal { set { _sCodigoPostal = value; } get { return _sCodigoPostal; } }
        public string sCiudad { set { _sCiudad = value; } get { return _sCiudad; } }
        public string sEstado { set { _sEstado = value; } get { return _sEstado; } }
        public string sCorreoContacto { set { _sCorreoContacto = value; } get { return _sCorreoContacto; } }
        public string sTelefono { set { _sTelefono = value; } get { return _sTelefono; } }
        public string sCelular { set { _sCelular = value; } get { return _sCelular; } }
        public string sMetodoPago { set { _sMetodoPago = value; } get { return _sMetodoPago; } }
    }
}