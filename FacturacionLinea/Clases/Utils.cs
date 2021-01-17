using Facturacion.Objetos;
using FacturacionLinea.Objetos;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Security.Cryptography;
using System.Text;
using System.Web;
using System.Web.Script.Serialization;
using NucleoBase.Core;
using System.IO;

namespace FacturacionLinea.Clases
{
    public static class Utils
    {
        /// <summary>
        /// Obtiene el Id Empleado del usuario en session
        /// </summary>
        public static string GetIdEmpUsuario
        {
            get
            {
                if (System.Web.HttpContext.Current.Session["UserIdentity"] == null)
                {
                    UserIdentity oUsuario = new UserIdentity();
                    oUsuario.sIdEmp = "9";
                    System.Web.HttpContext.Current.Session["UserIdentity"] = oUsuario;
                }

                return ((UserIdentity)System.Web.HttpContext.Current.Session["UserIdentity"]).sIdEmp;
            }
        }

        /// <summary>
        /// Obtiene el nombre del usuario en session
        /// </summary>
        public static string GetNombreUsuario
        {
            get
            {
                if (System.Web.HttpContext.Current.Session["UserIdentity"] == null)
                {
                    UserIdentity oUsuario = new UserIdentity();
                    oUsuario.sNombre = "(usuario)";
                    System.Web.HttpContext.Current.Session["UserIdentity"] = oUsuario;
                }

                return ((UserIdentity)System.Web.HttpContext.Current.Session["UserIdentity"]).sNombre;
            }
        }
        /// <summary>
        /// Obtiene el Id de la empresa
        /// </summary>
        public static int GetIdEmpresa
        {
            get
            {
                if (System.Web.HttpContext.Current.Session["UserIdentity"] == null)
                {
                    UserIdentity oUsuario = new UserIdentity();
                    oUsuario.iIdEmpresa = 0;
                    System.Web.HttpContext.Current.Session["UserIdentity"] = oUsuario;
                }

                return ((UserIdentity)System.Web.HttpContext.Current.Session["UserIdentity"]).iIdEmpresa;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="cadena a convertir"></param>
        /// <returns></returns>
        public static string GetSHA1(String texto)
        {
            SHA1 sha1 = SHA1CryptoServiceProvider.Create();
            Byte[] textOriginal = ASCIIEncoding.Default.GetBytes(texto);
            Byte[] hash = sha1.ComputeHash(textOriginal);
            StringBuilder cadena = new StringBuilder();
            foreach (byte i in hash)
            {
                cadena.AppendFormat("{0:x2}", i);
            }
            return cadena.ToString();
        }

        //public static string ObtieneLoginFactupronto()
        //{
        //    JavaScriptSerializer ser = new JavaScriptSerializer();


        //    string sToken = string.Empty;
        //    string url = "https://mexjet.chudro.com/api/rest-ws/firm-token";
        //    ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
        //    using (var client = new HttpClient())
        //    {
        //        var request = new DatosToken()
        //        {
        //            privateKey = "1Pk0tlR1xcO2kinPeRZ5"
        //        };

        //        string sPathWSApp = url;

        //        var response = client.PostAsync(sPathWSApp,
        //            new StringContent(JsonConvert.SerializeObject(request).ToString(), Encoding.UTF8, "application/json")).Result;

        //        if (response.IsSuccessStatusCode)
        //        {
        //            sToken = response.Content.ReadAsStringAsync().Result.S();
        //        }
        //    }

        //    LoginTimbrado oFoo = ser.Deserialize<LoginTimbrado>(sToken);
            
        //}

        //public static void ObtieneLoginFactupronto()
        //{
        //    try
        //    {
        //        string sCad = string.Empty;
        //        string sPathWS = "http://sistemademo.fpronto.com/morpheus/ng_jer/ws/login";
        //        string sPassSHA = GetSHA1("ASKJHGD913$");

        //        using (var client = new HttpClient())
        //        {

        //            client.DefaultRequestHeaders.Add("user", "morato186@gmail.com");
        //            client.DefaultRequestHeaders.Add("pass", sPassSHA);

        //            var response = client.GetAsync(sPathWS, HttpCompletionOption.ResponseContentRead);
        //            //var response = client.PostAsync(sPathWS, new StringContent(sCad, Encoding.UTF8, "application/json")).Result;

        //            HttpResponseMessage oRes = response.Result;
        //            string sRes = response.Result.Content.ReadAsStringAsync().Result.S();
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //}

        
    }
}