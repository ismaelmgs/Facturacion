using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace Facturacion.DomainModel
{
    public class DBEmpresa : DBBase
    {
        public DataTable DBGetObtieneEmpresaPorId(int iIdEmpresa)
        {
            try
            {
                return oDB_SP.EjecutarDT("[dbo].[spS_FL_ConsultaEmpresaPorId]", "@IdEmpresa", iIdEmpresa);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}