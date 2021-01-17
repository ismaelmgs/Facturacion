<%@ Page Title="" Language="C#" MasterPageFile="~/FactMaster.master" AutoEventWireup="true" CodeBehind="frmDatosUsuario.aspx.cs" Inherits="Facturacion.frmDatosUsuario" %>


<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="mainContent" runat="server">
    <div class="container-fluid">

        <div class="row">
            <p class="col-12 demo-content-title">Ingrese su información</p>
        </div>
        <br />
        <br />
        <fieldset style="width: 100%; padding: 15px; margin-top: -40px;" class="card mb-4">
            <header>
                <%--Datos personales--%>
            </header>
            <table style="width: 100%">
                <tr>
                    <td style="width: 2%"></td>
                    <td style="width: 94%">

                        <div class="row">
                            <div class="col-lg-6">
                                <dx:BootstrapButtonEdit ID="txtCorreo" runat="server" ClearButton-DisplayMode="OnHover" NullText="ejemplo@dominio.com" Caption="E-mail:"
                                    AutoPostBack="true" OnValueChanged="txtCorreo_ValueChanged" OnTextChanged="txtCorreo_TextChanged">
                                    <ValidationSettings>
                                        <RequiredField IsRequired="true" ErrorText="El e-mail es requerido" />
                                        <RegularExpression ErrorText="Ingrese un e-mail válido" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" />
                                    </ValidationSettings>
                                    <Buttons>
                                        <dx:BootstrapEditButton IconCssClass="fa fa-envelope"  />
                                    </Buttons>
                                </dx:BootstrapButtonEdit>
                            </div>
                            <div class="col-lg-6">
                            </div>
                        </div>
                        <br />
                        <div class="row">
                            <div class="col-lg-3"></div>
                            <div class="col-lg-6" style="text-align: center">
                                <dx:BootstrapRadioButtonList ID="rblTipoPersona" runat="server" RepeatColumns="3">
                                    <Items>
                                        <dx:BootstrapListEditItem Text="Persona fisica      " Value="1" Selected="true"></dx:BootstrapListEditItem>
                                        <dx:BootstrapListEditItem Text="Persona moral      " Value="2"></dx:BootstrapListEditItem>
                                        <dx:BootstrapListEditItem Text="Extranjero       " Value="2"></dx:BootstrapListEditItem>
                                    </Items>
                                </dx:BootstrapRadioButtonList>
                            </div>
                            <div class="col-lg-3"></div>
                        </div>

                        <div class="row">
                            <div class="col-lg-3">
                                <dx:BootstrapTextBox ID="txtRFC" runat="server" Caption="RFC:">
                                    <ValidationSettings RequiredField-IsRequired="true" ErrorText="El campo es requerido."></ValidationSettings>
                                </dx:BootstrapTextBox>
                            </div>
                            <div class="col-lg-3">
                                <dx:BootstrapTextBox ID="txtNombre" runat="server" Caption="Nombre(s):">
                                    <ValidationSettings RequiredField-IsRequired="true" ErrorText="El campo es requerido."></ValidationSettings>
                                </dx:BootstrapTextBox>
                            </div>
                            <div class="col-lg-3">
                                <dx:BootstrapTextBox ID="txtApellidoPat" runat="server" Caption="Apellido paterno:"></dx:BootstrapTextBox>
                            </div>
                            <div class="col-lg-3">
                                <dx:BootstrapTextBox ID="txtApellidoMat" runat="server" Caption="Apellido materno:"></dx:BootstrapTextBox>
                            </div>
                        </div>
                    </td>
                    <td style="width: 2%"></td>
                </tr>
            </table>
        </fieldset>
        <br />
        <fieldset style="width: 100%; padding: 15px; margin-top: -40px;" class="card mb-4">
            <header>
                Dirección facturación:
            </header>
            <table style="width: 100%">
                <tr>
                    <td style="width: 2%"></td>
                    <td style="width: 94%">
                        <div class="row">
                            <div class="col-lg-6">
                                <dx:BootstrapTextBox ID="txtCalle" runat="server" Caption="Calle:" NullText="Ingrese el nombre de la calle">
                                </dx:BootstrapTextBox>
                            </div>
                            <div class="col-lg-3">
                                <dx:BootstrapTextBox ID="txtNoExt" runat="server" Caption="No. exterior:" NullText="">
                                </dx:BootstrapTextBox>
                            </div>
                            <div class="col-lg-3">
                                <dx:BootstrapTextBox ID="txtNoInt" runat="server" Caption="No. Interior:" NullText="">
                                </dx:BootstrapTextBox>
                            </div>
                        </div>
                        <div class="row">
                            <div class="col-lg-6">
                                <dx:BootstrapTextBox ID="txtColonia" runat="server" Caption="Colonia:" NullText="">
                                </dx:BootstrapTextBox>
                            </div>
                            <div class="col-lg-6">
                                <dx:BootstrapTextBox ID="txtDelMun" runat="server" Caption="Delegación / Municipio:" NullText="">
                                </dx:BootstrapTextBox>
                            </div>
                        </div>
                        <div class="row">
                            <div class="col-lg-4">
                                <dx:BootstrapTextBox ID="txtCP" runat="server" Caption="Código postal:" NullText="">
                                </dx:BootstrapTextBox>
                            </div>
                            <div class="col-lg-4">
                                <dx:BootstrapTextBox ID="txtCiudadDis" runat="server" Caption="Ciudad:" NullText="">
                                </dx:BootstrapTextBox>
                            </div>
                            <div class="col-lg-4">
                                <dx:BootstrapTextBox ID="txtEstado" runat="server" Caption="Estado:" NullText="">
                                </dx:BootstrapTextBox>
                            </div>
                        </div>
                    </td>
                    <td style="width: 2%"></td>
                </tr>
            </table>
        </fieldset>
        <br />
        <fieldset style="width: 100%; padding: 15px; margin-top: -40px;" class="card mb-4">
            <header>
                Datos de contacto:
            </header>
            <table style="width: 100%">
                <tr>
                    <td style="width: 2%"></td>
                    <td style="width: 94%">
                        <div class="row">
                            <div class="col-lg-4">
                                <dx:BootstrapTextBox ID="txtCorreoContacto" runat="server" Caption="Correo:" NullText="ejemplo@dominio.com">
                                    <ValidationSettings RequiredField-IsRequired="true"></ValidationSettings>
                                </dx:BootstrapTextBox>
                            </div>
                            <div class="col-lg-4">
                                <dx:BootstrapTextBox ID="txtTelefono" runat="server" Caption="Teléfono:">
                                    <MaskSettings Mask="(999) 000-0000" IncludeLiterals="None" ErrorText="Por favor, ingrese un número válido." />
                                </dx:BootstrapTextBox>
                            </div>
                            <div class="col-lg-4">
                                <dx:BootstrapTextBox ID="txtCelular" runat="server" Caption="Celular:"></dx:BootstrapTextBox>
                            </div>
                        </div>
                        <br />
                        <div class="row">
                            <div class="col-lg-6" style="text-align:right">
                                <dx:BootstrapButton ID="btnLimpiar" runat="server" Text="Limpiar/Cancelar">
                                    <SettingsBootstrap RenderOption="Warning" />
                                </dx:BootstrapButton>
                            </div>
                            <div class="col-lg-6">
                                <dx:BootstrapButton ID="btnSiguiente" runat="server" Text="Siguiente" OnClick="btnSiguiente_Click">
                                    <SettingsBootstrap RenderOption="Success" />
                                </dx:BootstrapButton>
                            </div>
                        </div>
                    </td>
                    <td style="width: 2%"></td>
                </tr>
            </table>
        </fieldset>
    </div>
</asp:Content>
