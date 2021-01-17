<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Navigation.ascx.cs" Inherits="Facturacion.Navigation" %>

<a href="https://www.devexpress.com/products/try/" target="_blank" class="demo-try-now-link bg-primary text-white">Try it now</a>
<dx:BootstrapTreeView runat="server">
    <CssClasses
        IconExpandNode="demo-icon demo-icon-col m-0"
        IconCollapseNode="demo-icon demo-icon-ex m-0"
        NodeList="demo-treeview-nodes m-0" Node="demo-treeview-node" Control="demo-treeview" />
    <Nodes>
        <dx:BootstrapTreeViewNode Text="Quienes somos" NavigateUrl="~/frmQuienesSomos.aspx"></dx:BootstrapTreeViewNode>
        <dx:BootstrapTreeViewNode Text="Estación" Expanded="true">
            <Nodes>
                <dx:BootstrapTreeViewNode Text="Facturación electrónica" NavigateUrl="~/frmDatosUsuario.aspx"></dx:BootstrapTreeViewNode>
                <dx:BootstrapTreeViewNode Text="Ubicación" NavigateUrl="~/EventScheduling.aspx"></dx:BootstrapTreeViewNode>
            </Nodes>
        </dx:BootstrapTreeViewNode>
        <dx:BootstrapTreeViewNode Text="Contacto" NavigateUrl="https://docs.devexpress.com/AspNetBootstrap/118796/getting-started" Target="_blank"></dx:BootstrapTreeViewNode>
        <dx:BootstrapTreeViewNode Text="Configuracion Empresa" NavigateUrl="~/frmConfiguracionEmpresa.aspx"></dx:BootstrapTreeViewNode>  <%--Target="_blank"--%>
    </Nodes>
</dx:BootstrapTreeView>