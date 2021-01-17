using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Facturacion.Objetos
{
    public class UserIdentity
    {
        private string _sIdEmp = string.Empty;
        private string _sNombre = string.Empty;
        private string _sCorreoE = string.Empty;
        private int _iPerfil = 0; // 1.- Usuario 
                                  // 2.- Administrador
        private string _sPass = string.Empty;
        private int _iIdEmpresa = 0;
        private string _sEmpresa = string.Empty;
        private byte[] _bLogotipo = new byte[1];


        public string sIdEmp
        {
            get { return _sIdEmp; }
            set { _sIdEmp = value; }
        }

        public string sNombre
        {
            get { return _sNombre; }
            set { _sNombre = value; }
        }

        public string sCorreoE
        {
            get { return _sCorreoE; }
            set { _sCorreoE = value; }
        }

        public int iPerfil
        {
            get { return _iPerfil; }
            set { _iPerfil = value; }
        }

        public int iIdEmpresa
        {
            get { return _iIdEmpresa; }
            set { _iIdEmpresa = value; }
        }

        public string sPass
        {
            get { return _sPass; }
            set { _sPass = value; }
        }

        public string sEmpresa
        {
            get { return _sEmpresa; }
            set { _sEmpresa = value; }
        }

        public byte[] bLogotipo
        {
            get { return _bLogotipo; }
            set { _bLogotipo = value; }
        }
    }
}