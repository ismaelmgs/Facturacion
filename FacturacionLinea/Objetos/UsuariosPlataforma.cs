using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Facturacion.Objetos
{
    public class UsuariosPlataforma
    {
        private int _iEmpresa = 0;
        private string _sNombre = string.Empty;
        private string _sCorreo = string.Empty;
        private string _sPassword = string.Empty;
        private string _sTelefono = string.Empty;
        private int _iEstatus = 0;

        public int iEmpresa { set { _iEmpresa = value; } get { return _iEmpresa; } }
        public string sNombre { set { _sNombre = value; } get { return _sNombre; } }
        public string sCorreo { set { _sCorreo = value; } get { return _sCorreo; } }
        public string sPassword { set { _sPassword = value; } get { return _sPassword; } }
        public string sTelefono { set { _sTelefono = value; } get { return _sTelefono; } }
        public int iEstatus { set { _iEstatus = value; } get { return _iEstatus; } }
    }
}