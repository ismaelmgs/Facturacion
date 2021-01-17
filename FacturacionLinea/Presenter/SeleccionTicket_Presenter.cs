using Facturacion.Interfaces;
using Facturacion.Presenter;
using FacturacionLinea.DomainModel;
using FacturacionLinea.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FacturacionLinea.Presenter
{
    public class SeleccionTicket_Presenter : BasePresenter<IViewSeleccionTickets>
    {
        private readonly DBSeleccionTickets oIGesCat;

        public SeleccionTicket_Presenter(IViewSeleccionTickets oView, DBSeleccionTickets oCI)
            : base(oView)
        {
            oIGesCat = oCI;

            oIView.eGetSucursales += eGetSucursales_Presenter;
            oIView.eGetUsosCFDI += eGetUsosCFDI_Presenter;
        }

        protected void eGetSucursales_Presenter(object sender, EventArgs e)
        {
            oIView.LoadSucursales(oIGesCat.DBGetObtieneSucursalesEmpresa(Clases.Utils.GetIdEmpresa));
        }

        protected override void ObjSelected_Presenter(object sender, EventArgs e)
        {
            oIView.LoadTicket(oIGesCat.DBGetObtieneTicketPorFiltros(oIView.oBusqueda));
        }

        protected void eGetUsosCFDI_Presenter(object sender, EventArgs e)
        {
            oIView.LoadUsosCFDI(oIGesCat.DBGetObtieneClavesUsoCFDI());
        }
    }
}