using Facturacion.DomainModel;
using FacturacionLinea.Objetos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace FacturacionLinea.DomainModel
{
    public class DBSeleccionTickets : DBBase
    {
        public DataTable DBGetObtieneClavesUsoCFDI()
        {
            try
            {
                return oDB_SP.EjecutarDT("[dbo].[spS_FL_ObtieneClavesUsoCFDI]");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable DBGetObtieneSucursalesEmpresa(int iIdEmpresa)
        {
            try
            {
                return oDB_SP.EjecutarDT("[dbo].[spS_FL_ObtieneSucursalesPorEmpresa]", "@IdEmpresa", iIdEmpresa);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable DBGetObtieneTicketPorFiltros(BusquedaTickets oBus)
        {
            try
            {
                return oDB_SP.EjecutarDT("[dbo].[spS_FL_BusquedaDeTicketPorFiltros]", "@IdEmpresa", Clases.Utils.GetIdEmpresa,
                                                                                        "@Folio", oBus.sFolioTicket,
                                                                                        "@Monto", oBus.dMonto);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}