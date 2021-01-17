using Facturacion.Presenter;
using FacturacionLinea.DomainModel;
using FacturacionLinea.Interfaces;
using FacturacionLinea.Objetos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FacturacionLinea.Presenter
{
    public class DatosUsuario_Presenter : BasePresenter<IViewDatosUsuario>
    {
        private readonly DBDatosUsuario oIGesCat;

        public DatosUsuario_Presenter(IViewDatosUsuario oView, DBDatosUsuario oCI)
            : base(oView)
        {
            oIGesCat = oCI;

        }

        protected override void SaveObj_Presenter(object sender, EventArgs e)
        {
            if (oIGesCat.DBSetInsertaActualizaUsuarioFacturante(oIView.oUserFact))
            {
                oIView.RedireccionaATickets();
            }

        }

        protected override void ObjSelected_Presenter(object sender, EventArgs e)
        {
            UsuarioFacturante oUF = oIGesCat.ObtieneUsuarioFacturantePorCorreo(oIView.sCorreo);
            oIView.oUserFact = oUF;
            oIView.iIdUsuario = oUF.iIdUsuario;
        }
    }
}