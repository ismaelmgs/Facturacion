using Facturacion.Objetos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facturacion.Interfaces
{
    public interface IViewConfiguracionEmpresa : IBaseView
    {
        int iIdEmpresa { set; get; }
        Empresa oEmpresa { set; get; }
        UsuariosPlataforma oUser { set; get; }
        int iIdUsuarioPlat { set; get; }

        void MostrarMensaje(string sMensaje, string sCaption);
        void LoadUsuariosPlat(DataTable dt);


        event EventHandler eUpdUsuarioPlat;
    }
}
