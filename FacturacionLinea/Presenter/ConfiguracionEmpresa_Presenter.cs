using Facturacion.DomainModel;
using Facturacion.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Facturacion.Presenter
{
    public class ConfiguracionEmpresa_Presenter : BasePresenter<IViewConfiguracionEmpresa>
    { 
        private readonly DBConfiguracionEmpresa oIGesCat;

        public ConfiguracionEmpresa_Presenter(IViewConfiguracionEmpresa oView, DBConfiguracionEmpresa oCI)
            : base(oView)
        {
            oIGesCat = oCI;

            oIView.eUpdUsuarioPlat += eUpdUsuarioPlat_Presenter;
        }

        protected override void ObjSelected_Presenter(object sender, EventArgs e)
        {
            oIView.oEmpresa = oIGesCat.DBGetObtieneEmpresaPorId(oIView.iIdEmpresa);
        }

        protected override void SearchObj_Presenter(object sender, EventArgs e)
        {
            oIView.LoadUsuariosPlat(oIGesCat.DBGetObtieneUsuariosPlataformaPorEmpresa(oIView.iIdEmpresa));
        }

        protected override void NewObj_Presenter(object sender, EventArgs e)
        {
            if (oIGesCat.DBSetInsertaEmpresa(oIView.oEmpresa))
                oIView.MostrarMensaje("La empresa se insertó con exito.", "Aviso");
            else
                oIView.MostrarMensaje("Ocurrio un error al insertar la empresa.", "Aviso");
        }

        protected override void SaveObj_Presenter(object sender, EventArgs e)
        {
            try
            {
                int iRes = oIGesCat.DBSetInsertaUsuariosEnLaPlataforma(oIView.oUser);
                if (iRes > 0)
                {
                    SearchObj_Presenter(sender, e);
                }
                else
                    oIView.MostrarMensaje("Ocurrio un error al insertar la empresa.", "Aviso");
            }
            catch (Exception ex)
            {
                oIView.MostrarMensaje("Ocurrio un error: " + ex.Message, "Aviso");
            }
        }

        protected void eUpdUsuarioPlat_Presenter(object sender, EventArgs e)
        {
            try
            {
                int iUsu = oIGesCat.DBSetActualizaUsuarioPlataforma(oIView.oUser, oIView.iIdUsuarioPlat);
                if(iUsu > 0)
                    SearchObj_Presenter(sender, e);
                else
                    oIView.MostrarMensaje("Ocurrio un error al actualizar al usuario.", "Aviso");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        protected override void DeleteObj_Presenter(object sender, EventArgs e)
        {
            try
            {
                int iUsu = oIGesCat.DBSetEliminaUsuarioPlataforma(oIView.iIdUsuarioPlat);
                if (iUsu > 0)
                    SearchObj_Presenter(sender, e);
                else
                    oIView.MostrarMensaje("Ocurrio un error al eliminar al usuario.", "Aviso");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}