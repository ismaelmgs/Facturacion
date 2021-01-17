using Facturacion.Interfaces;
using FacturacionLinea.Objetos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacturacionLinea.Interfaces
{
    public interface IViewDatosUsuario : IBaseView
    {
        UsuarioFacturante oUserFact { get; set; }
        int iIdUsuario { set; get; }
        string sCorreo { get; }

        void RedireccionaATickets();
    }
}
