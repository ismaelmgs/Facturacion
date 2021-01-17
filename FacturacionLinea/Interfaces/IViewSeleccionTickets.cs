using Facturacion.Interfaces;
using FacturacionLinea.Objetos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacturacionLinea.Interfaces
{
    public interface IViewSeleccionTickets : IBaseView
    {
        BusquedaTickets oBusqueda { set; get; }

        void LoadSucursales(DataTable dt);
        void LoadTicket(DataTable dt);
        void LoadUsosCFDI(DataTable dt);

        event EventHandler eGetSucursales;
        event EventHandler eGetUsosCFDI;
    }
}
