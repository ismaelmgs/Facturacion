using Facturacion.Presenter;
using FacturacionLinea.DomainModel;
using FacturacionLinea.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FacturacionLinea.Presenter
{
    public class Ticket_Presenter : BasePresenter<IViewTicket>
    {
        private readonly DBTicket oIGesCat;

        public Ticket_Presenter(IViewTicket oView, DBTicket oCI)
            : base(oView)
        {
            oIGesCat = oCI;

        }
    }
}