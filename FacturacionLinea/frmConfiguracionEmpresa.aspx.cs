using DevExpress.Web;
using Facturacion.DomainModel;
using Facturacion.Interfaces;
using Facturacion.Objetos;
using Facturacion.Presenter;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using NucleoBase.Core;
using FacturacionLinea.Clases;
using System.Data;

namespace Facturacion
{
    public partial class frmConfiguracionEmpresa : System.Web.UI.Page, IViewConfiguracionEmpresa
    {
        #region EVENTOS
        protected void Page_Load(object sender, EventArgs e)
        {
            mpMensaje.ShowOnPageLoad = false;

            //if (Session["UserIdentity"] == null)
            //    Response.Redirect("login.aspx");

            UserIdentity oUs = new UserIdentity();
            oUs.sIdEmp = "1";
            oUs.sNombre = "Ismael Morato";
            oUs.sCorreoE = "maick.mor@gmail.com";
            oUs.iPerfil = 1;
            oUs.sPass = "123";

            oUs.iIdEmpresa = 2;
            oUs.sEmpresa = "MORVEL IT S.A. DE C.V.";

            iIdEmpresa = 2;
            Session["UserIdentity"] = oUs;


            oPresenter = new ConfiguracionEmpresa_Presenter(this, new DBConfiguracionEmpresa());

            if (!IsPostBack)
            {

                iIdUsuarioPlat = 0;

                if (iIdEmpresa.S().I() > 0)
                {
                    if (eObjSelected != null)
                        eObjSelected(sender, e);

                    if (eSearchObj != null)
                        eSearchObj(sender, e);
                }
            }
        }

        protected void uplLogotipo_FileUploadComplete(object sender, DevExpress.Web.FileUploadCompleteEventArgs e)
        {
            UploadedFile uploadedFile = e.UploadedFile;
            vbLogo = uploadedFile.FileBytes;
            //string fileName = uploadedFile.FileName;
            //string resultExtension = Path.GetExtension(fileName);
            //string resultFileName = Path.ChangeExtension(Path.GetRandomFileName(), resultExtension);
            //string resultFileUrl = "~/Editors/UploadImages/" + resultFileName;
            //string resultFilePath = MapPath(resultFileUrl);
            //uploadedFile.SaveAs(resultFilePath);
            ////UploadingUtils.RemoveFileWithDelay(resultFileName, resultFilePath, 5);
            //string url = ResolveClientUrl(resultFileUrl);
            //var sizeInKilobytes = uploadedFile.ContentLength / 1024;
            //string sizeText = sizeInKilobytes.ToString() + " KB";
            //e.CallbackData = fileName + "|" + url + "|" + sizeText;
        }

        protected void uplLogotipo_FilesUploadComplete(object sender, FilesUploadCompleteEventArgs e)
        {
            //var file = e.Uploadedfile;
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            if (iIdEmpresa > 0)
            {
                if (eSaveObj != null)
                    eSaveObj(sender, e);
            }
            else if (iIdEmpresa == 0)
            {
                if (eNewObj != null)
                    eNewObj(sender, e);
            }

        }

        protected void btnAgregarUsuarioPlat_Click(object sender, EventArgs e)
        {
            try
            {
                iIdUsuarioPlat = 0;
                ppAltaUsuario.ShowOnPageLoad = true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        protected void btnGuardarUsuarioPlat_Click(object sender, EventArgs e)
        {
            if (iIdUsuarioPlat == 0)
            {
                if (eSaveObj != null)
                    eSaveObj(sender, e);
            }
            else
            {
                if (eUpdUsuarioPlat != null)
                    eUpdUsuarioPlat(sender, e);
            }

            ppAltaUsuario.ShowOnPageLoad = false;
        }

        protected void btnCancelarUsuarioPlat_Click(object sender, EventArgs e)
        {
            ppAltaUsuario.ShowOnPageLoad = false;
        }

        protected void gvUsariosPlataforma_RowCommand(object sender, ASPxGridViewRowCommandEventArgs e)
        {
            try
            {
                string sOpcion = ((DevExpress.Web.ASPxButton)e.CommandSource).CommandName.S();
                iIdUsuarioPlat = e.CommandArgs.CommandArgument.S().I();

                if (sOpcion == "Actualizar")
                {
                    object cellValues = gvUsuariosPlataforma.GetRowValuesByKeyValue(iIdUsuarioPlat, new string[] { "Correo" //0
                                                                                                                ,"NombreCompleto" //1
                                                                                                                ,"Telefono" //2
                                                                                                                ,"Password" //3
                                                                });

                    UsuariosPlataforma oU = new UsuariosPlataforma();
                    oU.sCorreo = ((object[])cellValues)[0].S();
                    oU.sNombre = ((object[])cellValues)[1].S();
                    oU.sTelefono = ((object[])cellValues)[2].S();
                    oU.sPassword = ((object[])cellValues)[3].S();

                    oUser = oU;

                    ppAltaUsuario.ShowOnPageLoad = true;
                }
                else if (sOpcion == "Eliminar")
                {
                    if (eDeleteObj != null)
                        eDeleteObj(sender, e);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion



        #region METODOS
        public void MostrarMensaje(string sMensaje, string sCaption)
        {
            lblMensajeModal.Text = sMensaje;
            mpMensaje.HeaderText = sCaption;
            mpMensaje.ShowOnPageLoad = true;
        }

        public void LoadUsuariosPlat(DataTable dt)
        {
            gvUsuariosPlataforma.DataSource = dt;
            gvUsuariosPlataforma.DataBind();
        }
        #endregion



        #region VARIABLES Y PROPIEDADES
        ConfiguracionEmpresa_Presenter oPresenter;
        public event EventHandler eNewObj;
        public event EventHandler eObjSelected;
        public event EventHandler eSaveObj;
        public event EventHandler eDeleteObj;
        public event EventHandler eSearchObj;
        public event EventHandler eUpdUsuarioPlat;

        public int iIdEmpresa
        {
            set { ViewState["VSIdEmpresa"] = value; }
            get { return (int)ViewState["VSIdEmpresa"]; }
        }

        public Empresa oEmpresa
        {
            get
            {
                Empresa oEmp = new Empresa();
                oEmp.sRFC = txtRFC.Text.S();
                oEmp.sRazonSocial = txtRazonSocial.Text.S();
                oEmp.sNombreCorto = txtNombreCorto.Text.S();
                oEmp.sDireccion = txtDireccion.Text.S();
                oEmp.sMision = txtMision.Text.S();
                oEmp.sVision = txtVision.Text.S();
                oEmp.vbLogotipo = vbLogo;

                return oEmp;
            }
            set
            {
                Empresa oEmp = value;
                txtRFC.Text = oEmp.sRFC;
                txtRazonSocial.Text = oEmp.sRazonSocial;
                txtNombreCorto.Text = oEmp.sNombreCorto;
                txtDireccion.Text = oEmp.sDireccion;
                txtMision.Text = oEmp.sMision;
                txtVision.Text = oEmp.sVision;
                txtRFCExpedicion.Text = oEmp.sRFCEmision;
                txtCPExpedicion.Text = oEmp.sCPExpedicion;
                txtSerie.Text = oEmp.sSerieId;
            }
        }

        public byte[] vbLogo
        {
            set { ViewState["VSLogo"] = value; }
            get { return (byte[])ViewState["VSLogo"]; }
        }

        public UsuariosPlataforma oUser
        {
            get
            {
                return new UsuariosPlataforma()
                {
                    iEmpresa = iIdEmpresa,
                    sCorreo = txtUsuarioUsuPlat.Text,
                    sPassword = txtPassword.Text,
                    sNombre = txtNombreUsuariosPlat.Text,
                    sTelefono = txtTelefonoUsuPlat.Text,
                    iEstatus = 1
                };
            }
            set
            {
                UsuariosPlataforma oUs = value;

                txtUsuarioUsuPlat.Text = oUs.sCorreo;
                txtNombreUsuariosPlat.Text = oUs.sNombre;
                txtTelefonoUsuPlat.Text = oUs.sTelefono;

                //txtPassword.Password = false;
                //txtPassword.Text = oUs.sPassword;
                //txtPassword.Password = true;
            }
        }

        public int iIdUsuarioPlat
        {
            set { ViewState["VSIdUsuarioPlat"] = value; }
            get { return (int)ViewState["VSIdUsuarioPlat"]; }
        }
        #endregion


    }
}