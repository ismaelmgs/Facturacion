using Facturacion.Objetos;
using FacturacionLinea.DomainModel;
using FacturacionLinea.Interfaces;
using FacturacionLinea.Objetos;
using FacturacionLinea.Presenter;
using Newtonsoft.Json;
using NucleoBase.Core;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Web;
using System.Web.Script.Serialization;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FacturacionLinea
{
    public partial class frmSelTickets : System.Web.UI.Page, IViewSeleccionTickets
    {
        #region EVENTOS
        protected void Page_Load(object sender, EventArgs e)
        {
            oPresenter = new SeleccionTicket_Presenter(this, new DBSeleccionTickets());

            if (!IsPostBack)
            {
                if (Session["UserFact"] == null)
                    Response.Redirect("frmDatosUsuario.aspx");

                UserIdentity oUs = new UserIdentity();
                oUs.sIdEmp = "1";
                oUs.sNombre = "Ismael Morato";
                oUs.sCorreoE = "maick.mor@gmail.com";
                oUs.iPerfil = 1;
                oUs.sPass = "123";
                oUs.iIdEmpresa = 2;
                oUs.sEmpresa = "MORVEL IT S.A. DE C.V.";

                
                Session["UserIdentity"] = oUs;

                if (eGetSucursales != null)
                    eGetSucursales(sender, e);
            }
        }

        protected void btnBuscarTicket_Click(object sender, EventArgs e)
        {
            if (eObjSelected != null)
                eObjSelected(sender, e);
        }

        protected void btnContinuarSelTickets_Click(object sender, EventArgs e)
        {
            tabConFacturacion.TabIndex = 1;
            tabConFacturacion.ActiveTabIndex = 1;
            tabConFacturacion.TabPages[1].Enabled = true;

            progressbar.Position = 33;

            if (eGetUsosCFDI != null)
                eGetUsosCFDI(sender, e);

            UsuarioFacturante oUsr = (UsuarioFacturante)Session["UserFact"];

            txtNombreFac.Text = oUsr.sNombreCompleto;
            txtRFC.Text = oUsr.sRFC;

            gvVistaPrevia.DataSource = dtTicket;
            gvVistaPrevia.DataBind();


            ddlUsoCFDI.Focus();
        }

        protected void gvTickets_RowCommand(object sender, DevExpress.Web.ASPxGridViewRowCommandEventArgs e)
        {

        }

        protected void btnContinuarVistaP_Click(object sender, EventArgs e)
        {
            progressbar.Position = 66;
            tabConFacturacion.TabIndex = 2;
            tabConFacturacion.ActiveTabIndex = 2;
            tabConFacturacion.TabPages[2].Enabled = true;

            JavaScriptSerializer ser = new JavaScriptSerializer();
            string receiveContent = string.Empty;
            HttpStatusCode code = ObtieneLoginFactupronto(out receiveContent);
            LoginTimbrado pF = ser.Deserialize<LoginTimbrado>(receiveContent);

            Timbrado33 oTim = ArmaObjetoTimbrado();
            string sCadEnvio = JsonConvert.SerializeObject(oTim).ToString();
            string sRespuestaTimbrado = string.Empty;
            HttpStatusCode stsTimb = TimbraFactura(out sRespuestaTimbrado, pF.foo.api, sCadEnvio);
        }
        #endregion


        #region METODOS
        public void LoadSucursales(DataTable dt)
        {
            try
            {
                ddlSucursal.DataSource = dt;
                ddlSucursal.TextField = "Nombre";
                ddlSucursal.ValueField = "IdSucursal";
                ddlSucursal.DataBind();

                ddlSucursal.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void LoadTicket(DataTable dt)
        {
            if (dtTicket == null)
            {
                dtTicket = dt.Clone();
            }

            foreach (DataRow row in dt.Rows)
            {
                if(!VerificaExisteRow(row, dtTicket))
                dtTicket.ImportRow(row);
            }

            if (dtTicket.Rows.Count > 0)
            {
                btnContinuarSelTickets.Visible = true;

                gvTickets.DataSource = dtTicket;
                gvTickets.DataBind();
            }
        }

        private bool VerificaExisteRow(DataRow row, DataTable dt)
        {
            bool ban = false;

            foreach (DataRow dr in dt.Rows)
            {
                if (dr["FolioTicket"].S() == row["FolioTicket"].S())
                    ban = true;
            }

            return ban;
        }

        public void LoadUsosCFDI(DataTable dt)
        {
            ddlUsoCFDI.DataSource = dt;
            ddlUsoCFDI.TextField = "DescripcionEsp";
            ddlUsoCFDI.ValueField = "ClaveUso";
            ddlUsoCFDI.DataBind();
        }

        public static HttpStatusCode ObtieneLoginFactupronto(out string receiveContent)
        {
            string requestUrl = "http://sistemademo.fpronto.com/morpheus/ng_jer/ws/login";
            string sPassSHA = FacturacionLinea.Clases.Utils.GetSHA1("ASKJHGD913$");

            var request = (HttpWebRequest)WebRequest.Create(requestUrl);
            request.Method = "GET";

            request.Headers.Add("user", "morato186@gmail.com");
            request.Headers.Add("pass", sPassSHA);

            try
            {
                using (WebResponse response = request.GetResponse())
                {
                    var responseStream = response.GetResponseStream();
                    if (responseStream != null)
                    {
                        var reader = new StreamReader(responseStream);
                        receiveContent = reader.ReadToEnd();
                        reader.Close();

                        return ((HttpWebResponse)response).StatusCode;
                    }
                }
            }
            catch (Exception ex)
            {
                receiveContent = string.Format("{0}\n{1}\nposted content = \n{2}", ex, "Desc error: ", ex.Message);
                return HttpStatusCode.BadRequest;
            }

            receiveContent = null;
            return 0;
        }

        protected Timbrado33 ArmaObjetoTimbrado()
        {
            try
            {
                UsuarioFacturante oUserFac = (UsuarioFacturante)Session["UserFact"];

                Empresa oEmp = new Empresa();
                oEmp.sRFC = "MITF20160820J92";
                oEmp.sRazonSocial = "MORVEL IT S.A. DE C.V.";

                oEmp.sRFCEmision = "EKU9003173C9";
                oEmp.sCPExpedicion = "67190";
                oEmp.sSerieId = "A";



                Timbrado33 oTim = new Timbrado33();
                oTim.RFCemisor = oEmp.sRFCEmision;
                oTim.expedicion = oEmp.sCPExpedicion;
                oTim.serieid = oEmp.sSerieId;

                oTim.RFCreceptor = oUserFac.sRFC;
                oTim.razonsocial = oUserFac.sNombreCompleto;
                oTim.numext = oUserFac.sNoExt;
                oTim.numint = oUserFac.sNoInt;
                oTim.calle = oUserFac.sCalle;
                oTim.colonia = oUserFac.sColonia;
                oTim.ciudad = oUserFac.sCiudad;
                oTim.estado = oUserFac.sEstado;
                oTim.codigopostal = oUserFac.sCodigoPostal;
                oTim.pais = "México";
                oTim.telefono = oUserFac.sCelular;
                oTim.contacto = oUserFac.sNombreCompleto;
                oTim.email = oUserFac.sCorreo;
                oTim.Moneda = "MXN";
                oTim.TipoCambio = 1;
                oTim.Confirmacion = string.Empty;
                oTim.condicionesDePago = string.Empty;
                oTim.observaciones = string.Empty;
                oTim.RegimenFiscal = "601";
                oTim.tipoDeComprobante = "I";

                foreach (DataRow row in dtTicket.Rows)
                {
                    PartidasTimbrado oPar = new PartidasTimbrado();
                    oTim.subTotal = row["SubTotal"].S().D();
                    oTim.formaDePago = row["FormaPago"].S();        // Efectivo
                    oTim.metodoDePago = row["MetodoPago"].S();      // Catalogo
                    oTim.UsoCFDI = ddlUsoCFDI.Value.S();


                    oPar.cantidad = 10; // row["Cantidad"].S().D();
                    oPar.unidad = row["UnidadMedida"].S();
                    oPar.descripcion = row["Descripcion"].S();
                    oPar.valorUnitario = 15; //row["PrecioUnitario"].S().D();
                    oPar.importe = row["Importe"].S().D();
                    oPar.noIdentificacion = row["CveProdServicio"].S();
                    oPar.comentario = string.Empty;
                    oPar.ClaveProdServ = row["CveProdServicio"].S();
                    oPar.ClaveUnidad = row["UnidadMedida"].S();
                    

                    ImpuestosPartidas oImpPar = new ImpuestosPartidas();
                    oImpPar.tipoimpuesto = "IVA";
                    oImpPar.factorimpuesto = "Tasa";
                    oImpPar.valorimpuesto = "0.16";
                    oImpPar.importeimpuesto = row["Impuestos"].S();

                    oPar.impuestos.Add(oImpPar);

                    oTim.partidas.Add(oPar);
                }
                
                return oTim;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public HttpStatusCode TimbraFactura(out string receiveContent, string api, string postContent)
        {
            string requestUrl = "http://sistemademo.fpronto.com/morpheus/ng_jer/ws/timbrar33";
            string sPassSHA = FacturacionLinea.Clases.Utils.GetSHA1("ASKJHGD913$");

            var request = (HttpWebRequest)WebRequest.Create(requestUrl);
            request.Method = "POST";

            request.Headers.Add("user", "morato186@gmail.com");
            request.Headers.Add("pass", sPassSHA);
            request.Headers.Add("api", api);

            if (!string.IsNullOrEmpty(postContent))
            {
                byte[] byteArray = Encoding.UTF8.GetBytes(postContent);
                request.ContentType = "application/json; charset=utf-8";
                request.ContentLength = byteArray.Length;
                var dataStream = request.GetRequestStream();
                dataStream.Write(byteArray, 0, byteArray.Length);
                dataStream.Close();
            }

            try
            {
                using (WebResponse response = request.GetResponse())
                {
                    var responseStream = response.GetResponseStream();
                    if (responseStream != null)
                    {
                        var reader = new StreamReader(responseStream);
                        receiveContent = reader.ReadToEnd();
                        reader.Close();

                        return ((HttpWebResponse)response).StatusCode;
                    }
                }
            }
            catch (Exception ex)
            {
                receiveContent = string.Format("{0}\n{1}\nposted content = \n{2}", ex, ex.Message);
                return HttpStatusCode.BadRequest;
            }

            receiveContent = null;
            return 0;
        }
        #endregion


        #region VARIABLES Y PROPIEDADES
        SeleccionTicket_Presenter oPresenter;
        public event EventHandler eNewObj;
        public event EventHandler eObjSelected;
        public event EventHandler eSaveObj;
        public event EventHandler eDeleteObj;
        public event EventHandler eSearchObj;
        public event EventHandler eGetSucursales;
        public event EventHandler eGetUsosCFDI;

        public BusquedaTickets oBusqueda
        {
            get
            {
                BusquedaTickets oBus = new BusquedaTickets();
                oBus.iIdSucursal = ddlSucursal.Value.S().I();
                oBus.sFolioTicket = txtNoTicket.Text.S();
                oBus.dMonto = txtMonto.Text.S().D();

                return oBus;
            }
            set
            {
                BusquedaTickets oBus = value;

                ddlSucursal.Value = oBus.iIdSucursal.S();
                txtNoTicket.Text = oBus.sFolioTicket.S();
                txtMonto.Text = oBus.dMonto.S();
            }
        }
        
        public DataTable dtTicket
        {
            set { ViewState["VSTicket"] = value; }
            get { return (DataTable)ViewState["VSTicket"]; }
        }

        #endregion

        
    }
}