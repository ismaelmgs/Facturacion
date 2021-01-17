using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using Facturacion.Objetos;
using NucleoBase.BaseDeDatos;
using NucleoBase.Core;
using FacturacionLinea.Clases;


namespace Facturacion.DomainModel
{
    public class DBConfiguracionEmpresa : DBBase
    {
        public bool DBSetInsertaEmpresa(Empresa oEmp)
        {
            try
            {
                object oRes = oDB_SP.EjecutarValor("[dbo].[spI_FL_InsertaDatosEmpresa]", "@RFC", oEmp.sRFC,
                                                                                        "@RazonSocial", oEmp.sRazonSocial,
                                                                                        "@NombreCorto", oEmp.sNombreCorto,
                                                                                        "@Direccion", oEmp.sDireccion,
                                                                                        "@Logotipo", oEmp.vbLogotipo,
                                                                                        "@Mision", oEmp.sMision,
                                                                                        "@Vision", oEmp.sVision,
                                                                                        "@Valores", oEmp.sValores,
                                                                                        "@Usuario", Utils.GetNombreUsuario);

                return oRes.S().I() > 0 ? true : false;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Empresa DBGetObtieneEmpresaPorId(int iIdEmpresa)
        {
            try
            {
                return oDB_SP.EjecutarDT("[dbo].[spS_FL_ConsultaEmpresaPorId]", "@IdEmpresa", iIdEmpresa).AsEnumerable().Select(r => new Empresa
                {
                    sRFC = r["RFC"].S(),
                    sRazonSocial = r["RazonSocial"].S(),
                    sNombreCorto = r["NombreCorto"].S(),
                    sDireccion = r["Direccion"].S(),
                    //vbLogotipo = (byte[])r["Logotipo"],
                    sMision = r["Mision"].S(),
                    sVision = r["Vision"].S(),
                    sValores = r["Valores"].S(),
                    iEstatus = r["Estatus"].S().I(),
                    sRFCEmision = r["RFCEmisor"].S(),
                    sSerieId = r["SerieId"].S(),
                    sCPExpedicion = r["Expedicion"].S()
                }).Single();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int DBSetInsertaUsuariosEnLaPlataforma(UsuariosPlataforma oUser)
        {
            try
            {
                object oRes = oDB_SP.EjecutarValor("[dbo].[spI_FL_InsertaUsuariosEnLaPlataforma]", "@IdEmpresa", oUser.iEmpresa,
                                                                                                    "@Correo", oUser.sCorreo,
                                                                                                    "@Password", oUser.sPassword,
                                                                                                    "@NombreCompleto", oUser.sNombre,
                                                                                                    "@Telefono", oUser.sTelefono,
                                                                                                    "@UsuarioCreacion", Utils.GetNombreUsuario);

                return oRes.S().I();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable DBGetObtieneUsuariosPlataformaPorEmpresa(int iIdEmpresa)
        {
            try
            {
                return oDB_SP.EjecutarDT("[dbo].[spS_FL_ObtieneUsuariosPlataformaPorEmpresa]", "@IdEmpresa", iIdEmpresa);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int DBSetEliminaUsuarioPlataforma(int iIdUsuario)
        {
            try
            {
                object oRes = oDB_SP.EjecutarValor("[dbo].[spD_FL_EliminaUsuarioDePlataforma]", "@IdUsuario", iIdUsuario);

                return oRes.S().I();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int DBSetActualizaUsuarioPlataforma(UsuariosPlataforma oUser, int iIdUsuarioPlat)
        {
            try
            {
                object oRes = oDB_SP.EjecutarValor("[dbo].[spU_FL_ActualizaInformacionUsuarioPlataforma]", "@IdUsuario", iIdUsuarioPlat,
                                                                                                            "@Correo", oUser.sCorreo,
                                                                                                            "@Password", oUser.sPassword,
                                                                                                            "@NombreCompleto", oUser.sNombre,
                                                                                                            "@Telefono", oUser.sTelefono,
                                                                                                            "@UsuarioModificacion", Utils.GetNombreUsuario);

                return oRes.S().I();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}