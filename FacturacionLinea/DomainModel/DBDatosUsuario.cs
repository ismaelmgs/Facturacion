using Facturacion.DomainModel;
using FacturacionLinea.Objetos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using NucleoBase.Core;

namespace FacturacionLinea.DomainModel
{
    public class DBDatosUsuario : DBBase
    {
        public bool DBSetInsertaActualizaUsuarioFacturante(UsuarioFacturante oUsu)
        {
            try
            {
                bool ban = false;

                object oRes = oDB_SP.EjecutarValor("[dbo].[spIA_FL_InsertaActualizaUsuarioFacturante]", "@Correo", oUsu.sCorreo,
                                                                                                        "@RFC", oUsu.sRFC,
                                                                                                        "@TipoPersona", oUsu.iTipoUsuario,
                                                                                                        "@Nombre", oUsu.sNombre,
                                                                                                        "@ApellidoPat", oUsu.sApellidoPat,
                                                                                                        "@ApellidoMat", oUsu.sApellidoMat,
                                                                                                        "@RazonSocial", oUsu.sRazonSocial,
                                                                                                        "@Calle", oUsu.sCalle,
                                                                                                        "@NoExt", oUsu.sNoExt,
                                                                                                        "@NoInt", oUsu.sNoInt,
                                                                                                        "@Colonia", oUsu.sColonia,
                                                                                                        "@Delegacion", oUsu.sMunicipio,
                                                                                                        "@CP", oUsu.sCodigoPostal,
                                                                                                        "@Ciudad", oUsu.sCiudad,
                                                                                                        "@Estado", oUsu.sEstado,
                                                                                                        "@CorreoEnvio", oUsu.sCorreo,
                                                                                                        "@Telefono", oUsu.sTelefono,
                                                                                                        "@Celular", oUsu.sCelular);

                ban = oRes != null ? true : false;

                return ban;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public UsuarioFacturante ObtieneUsuarioFacturantePorCorreo(string sCorreo)
        {
            try
            {
                UsuarioFacturante oUF = new UsuarioFacturante();
                DataTable dt = oDB_SP.EjecutarDT("[dbo].[spS_FL_ObtienesUsuarioFacPorCorreo]", "@Correo", sCorreo);

                if (dt.Rows.Count > 0)
                {
                    DataRow row = dt.Rows[0];
                    oUF.iIdUsuario = row["IdUsuario"].S().I();
                    oUF.sCorreo = row["Correo"].S();
                    oUF.sRFC = row["RFC"].S();
                    oUF.iTipoUsuario = row["TipoPersona"].S().I();
                    oUF.sNombre = row["Nombre"].S();
                    oUF.sApellidoPat = row["ApellidoPat"].S();
                    oUF.sApellidoMat = row["ApellidoMat"].S();
                    oUF.sRazonSocial = row["RazonSocial"].S();
                    oUF.sCalle = row["Calle"].S();
                    oUF.sNoExt = row["NoExt"].S();
                    oUF.sNoInt = row["NoInt"].S();
                    oUF.sColonia = row["Colonia"].S();
                    oUF.sMunicipio = row["Delegacion"].S();
                    oUF.sCodigoPostal = row["CP"].S();
                    oUF.sCiudad = row["Ciudad"].S();
                    oUF.sEstado = row["Estado"].S();
                    oUF.sCorreoContacto = row["CorreoEnvio"].S();
                    oUF.sTelefono = row["Telefono"].S();
                    oUF.sCelular = row["Celular"].S();
                }
                return oUF;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}