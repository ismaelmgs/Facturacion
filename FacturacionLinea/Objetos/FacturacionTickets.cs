using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FacturacionLinea.Objetos
{
    public class BusquedaTickets
    {
        private int _iIdSucursal = 0;
        private string _sFolioTicket = string.Empty;
        private decimal _dMonto = 0;


        public int iIdSucursal
        {
            set { _iIdSucursal = value; }
            get { return _iIdSucursal; }
        }

        public string sFolioTicket
        {
            set { _sFolioTicket = value; }
            get { return _sFolioTicket; }
        }

        public decimal dMonto
        {
            set { _dMonto = value; }
            get { return _dMonto; }
        }
    }

}