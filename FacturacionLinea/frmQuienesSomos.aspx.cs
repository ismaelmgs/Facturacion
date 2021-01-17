using Facturacion.DomainModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Facturacion
{
    public partial class frmQuienesSomos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                DataTable dt = new DBEmpresa().DBGetObtieneEmpresaPorId(1);
            }
        }

        public void LlenaTextos(DataTable dt)
        {

        }
    }
}