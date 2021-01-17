using FacturacionLinea.DomainModel;
using FacturacionLinea.Interfaces;
using FacturacionLinea.Objetos;
using FacturacionLinea.Presenter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using NucleoBase.Core;

namespace Facturacion
{
    public partial class frmDatosUsuario : System.Web.UI.Page, IViewDatosUsuario
    {
        #region EVENTOS
        protected void Page_Load(object sender, EventArgs e)
        {
            oPresenter = new DatosUsuario_Presenter(this, new DBDatosUsuario());

            if (!IsPostBack)
            {

            }
        }

        protected void btnSiguiente_Click(object sender, EventArgs e)
        {
            if (eSaveObj != null)
                eSaveObj(sender, e);
        }

        protected void txtCorreo_ValueChanged(object sender, EventArgs e)
        {
            txtCorreoContacto.Text = txtCorreo.Text;

            if (eObjSelected != null)
                eObjSelected(sender, e);
        }

        protected void txtCorreo_TextChanged(object sender, EventArgs e)
        {

        }
        #endregion


        #region METODOS
        public void RedireccionaATickets()
        {
            Session["UserFact"] = oUserFact;
            Response.Redirect("frmSelTickets.aspx");
        }
        #endregion


        #region VARIABLES Y PROPIEDADES
        DatosUsuario_Presenter oPresenter;
        public event EventHandler eNewObj;
        public event EventHandler eObjSelected;
        public event EventHandler eSaveObj;
        public event EventHandler eDeleteObj;
        public event EventHandler eSearchObj;
        public event EventHandler eGetSucursales;

        public int iIdUsuario
        {
            set { ViewState["VSIdUsuario"] = value; }
            get { return (int)ViewState["VSIdUsuario"]; }
        }

        public string sCorreo
        {
            get
            {
                return txtCorreo.Text.S();
            }
        }

        public UsuarioFacturante oUserFact
        {
            get
            {
                UsuarioFacturante oUsu = new UsuarioFacturante();
                oUsu.sCorreo = txtCorreo.Text.S();
                oUsu.sRFC = txtRFC.Text.S();
                oUsu.iTipoUsuario = rblTipoPersona.Value.S().I();
                oUsu.sNombre = txtNombre.Text.S();
                oUsu.sApellidoPat = txtApellidoPat.Text.S();
                oUsu.sApellidoMat = txtApellidoMat.Text.S();
                oUsu.sRazonSocial = "";
                oUsu.sNombreCompleto = txtNombre.Text.S() + " " + oUsu.sApellidoPat + " " + oUsu.sApellidoMat;
                oUsu.sCalle = txtCalle.Text.S();
                oUsu.sNoExt = txtNoExt.Text.S();
                oUsu.sNoInt = txtNoInt.Text.S();
                oUsu.sColonia = txtColonia.Text.S();
                oUsu.sMunicipio = txtDelMun.Text.S();
                oUsu.sCodigoPostal = txtCP.Text.S();
                oUsu.sCiudad = txtCiudadDis.Text.S();
                oUsu.sEstado = txtEstado.Text.S();
                oUsu.sTelefono = txtTelefono.Text.S();
                oUsu.sCelular = txtCelular.Text.S();

                return oUsu;
            }
            set
            {
                UsuarioFacturante oUsu = value;

                txtRFC.Text = oUsu.sRFC;
                rblTipoPersona.Value = oUsu.iTipoUsuario.S();
                txtNombre.Text = oUsu.sNombre;
                txtApellidoPat.Text = oUsu.sApellidoPat;
                txtApellidoMat.Text = oUsu.sApellidoMat;
                // oUsu.sRazonSocial;
                txtCalle.Text = oUsu.sCalle;
                txtNoExt.Text = oUsu.sNoExt;
                txtNoInt.Text = oUsu.sNoInt;
                txtColonia.Text = oUsu.sColonia;
                txtDelMun.Text = oUsu.sMunicipio;
                txtCP.Text = oUsu.sCodigoPostal;
                txtCiudadDis.Text = oUsu.sCiudad;
                txtEstado.Text = oUsu.sEstado;
                txtTelefono.Text = oUsu.sTelefono;
                txtCelular.Text = oUsu.sCelular;
            }
        }

        #endregion

        
    }
}