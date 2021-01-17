<%@ Page Title="" Language="C#" MasterPageFile="~/FactMaster.master" AutoEventWireup="true" CodeBehind="frmConfiguracionEmpresa.aspx.cs" Inherits="Facturacion.frmConfiguracionEmpresa" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script type="text/javascript">
        function onFilesUploadStart(s, e) {
            dxbsDemo.uploadedFilesContainer.hide();
        }
        function onFileUploadComplete(s, e) {
            if (e.callbackData) {
                var fileData = e.callbackData.split('|');
                var fileName = fileData[0],
                    fileUrl = fileData[1],
                    fileSize = fileData[2];
                dxbsDemo.uploadedFilesContainer.addFile(s, fileName, fileUrl, fileSize);
            }
        }
        function ConfirmaEliminaUsuario(s, e) {
            if (!confirm('¿Realmente deseas eliminar al usuario?'))
                return;
        }
    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="mainContent" runat="server">
    <div class="container-fluid">
        <div class="row">
            <p class="col-12 demo-content-title">Ingrese la información de la empresa</p>
        </div>
        <br />
        <br />
        <fieldset runat="server" style="padding: 15px; margin-top: -40px; margin-bottom:25px; width:1000px" class="card mb-4;">
            <header>
                Datos de la empresa
            </header>
            <table style="width: 100%">
                <tr>
                    <td style="width: 2%"></td>
                    <td style="width: 94%">
                        <div class="row">
                            <div class="col-lg-4">
                                <dx:BootstrapTextBox ID="txtRFC" runat="server" Caption="RFC:">
                                    <ValidationSettings RequiredField-IsRequired="true" ErrorText="El campo es requerido."></ValidationSettings>
                                </dx:BootstrapTextBox>
                            </div>
                            <div class="col-lg-8">
                                <dx:BootstrapTextBox ID="txtRazonSocial" runat="server" Caption="Razón social:">
                                    <ValidationSettings RequiredField-IsRequired="true" ErrorText="El campo es requerido."></ValidationSettings>
                                </dx:BootstrapTextBox>
                            </div>
                        </div>
                        <div class="row">
                            <div class="col-lg-4">
                                <dx:BootstrapTextBox ID="txtRFCExpedicion" runat="server" Caption="RFC expedición:" Enabled="false">
                                    <ValidationSettings RequiredField-IsRequired="true" ErrorText="El campo es requerido."></ValidationSettings>
                                </dx:BootstrapTextBox>
                            </div>
                            <div class="col-lg-4">
                                <dx:BootstrapTextBox ID="txtCPExpedicion" runat="server" Caption="CP expedición:" Enabled="false">
                                    <ValidationSettings RequiredField-IsRequired="true" ErrorText="El campo es requerido."></ValidationSettings>
                                </dx:BootstrapTextBox>
                            </div>
                            <div class="col-lg-4">
                                <dx:BootstrapTextBox ID="txtSerie" runat="server" Caption="Serie facturación:" Enabled="false">
                                    <ValidationSettings RequiredField-IsRequired="true" ErrorText="El campo es requerido."></ValidationSettings>
                                </dx:BootstrapTextBox>
                            </div>
                        </div>
                        <div class="row">
                            <div class="col-lg-4">
                                <dx:BootstrapTextBox ID="txtNombreCorto" runat="server" Caption="Nombre corto:">
                                    <ValidationSettings RequiredField-IsRequired="true" ErrorText="El campo es requerido."></ValidationSettings>
                                </dx:BootstrapTextBox>
                            </div>
                            <div class="col-lg-8">
                                <dx:BootstrapTextBox ID="txtDireccion" runat="server" Caption="Dirección:">
                                    <ValidationSettings RequiredField-IsRequired="true" ErrorText="El campo es requerido."></ValidationSettings>
                                </dx:BootstrapTextBox>
                            </div>
                        </div>
                        <div class="row">
                            <div class="col-lg-8">
                                <dx:BootstrapMemo ID="txtMision" runat="server" Rows="3" Caption="Misión:">
                                    <ValidationSettings RequiredField-IsRequired="true" ErrorText="El campo es requerido."></ValidationSettings>
                                </dx:BootstrapMemo>
                            </div>
                            <div class="col-lg-4">
                            </div>
                        </div>
                        <div class="row">
                            <div class="col-lg-8">
                                <dx:BootstrapMemo ID="txtVision" runat="server" Rows="3" Caption="Visión:">
                                    <ValidationSettings RequiredField-IsRequired="true" ErrorText="El campo es requerido."></ValidationSettings>
                                </dx:BootstrapMemo>
                            </div>
                            <div class="col-lg-4">
                            </div>
                        </div>
                        <div class="row">
                            <div class="col-lg-6">
                                <dx:BootstrapListBox runat="server" SelectionMode="CheckColumn" Caption="Valores:" EnableSelectAll="true">
                                    <Items>
                                        <dx:BootstrapListEditItem Text="Honestidad" Value="Honestidad" />
                                        <dx:BootstrapListEditItem Text="Confianza" Value="Confianza" />
                                        <dx:BootstrapListEditItem Text="Responsabilidad" Value="Responsabilidad" />
                                        <dx:BootstrapListEditItem Text="Compromiso" Value="Compromiso" />
                                        <dx:BootstrapListEditItem Text="Excelencia" Value="Excelencia" />
                                    </Items>
                                </dx:BootstrapListBox>
                            </div>
                            <div class="col-lg-6">
                            </div>
                        </div>
                        <br />
                        <div class="row">
                            <div class="col-lg-6">
                                <dx:ASPxLabel ID="lblLogotipo" runat="server" Text="Logotipo:"></dx:ASPxLabel>
                            </div>
                            <div class="col-lg-6">
                            </div>
                        </div>

                        <div class="row">
                            <div class="col-lg-6">
                                <dx:BootstrapUploadControl ID="uplLogotipo" runat="server" ShowUploadButton="true" Width="70%" NullText="Seleccione un archivo..."
                                    OnFileUploadComplete="uplLogotipo_FileUploadComplete" OnFilesUploadComplete="uplLogotipo_FilesUploadComplete">
                                    <ClientSideEvents FileUploadComplete="onFileUploadComplete" FilesUploadStart="onFilesUploadStart" />
                                    <ValidationSettings MaxFileSize="4194304" AllowedFileExtensions=".jpg,.jpeg,.gif,.png" />
                                    <%--<AdvancedModeSettings EnableMultiSelect="true" EnableFileList="true" />--%>
                                </dx:BootstrapUploadControl>
                            </div>
                            <div class="col-lg-6">
                            </div>
                        </div>

                        <div class="row">
                            <div class="col-lg-12" style="text-align: center">
                                <dx:BootstrapButton ID="btnGuardar" runat="server" Text="Guardar/Actualizar" OnClick="btnGuardar_Click">
                                    <SettingsBootstrap RenderOption="Success" />
                                </dx:BootstrapButton>
                            </div>
                        </div>
                    </td>
                    <td style="width: 2%"></td>
                </tr>
            </table>
        </fieldset>
        <br />
        <fieldset runat="server" style="padding: 15px; margin-top: -40px;" class="card mb-4">
            <header>
                Usuarios de la plataforma
            </header>
            <div class="row">
                <div class="col-lg-10" style="text-align: right">
                    <dx:BootstrapButton ID="btnAgregarUsuarioPlat" runat="server" Text="Agregar usuario" OnClick="btnAgregarUsuarioPlat_Click">
                        <SettingsBootstrap RenderOption="Success" />
                    </dx:BootstrapButton>
                </div>
                <div class="col-lg-2"></div>
            </div>
            <br />
            <div class="row">
                <div class="col-lg-10">
                    <dx:BootstrapGridView ID="gvUsuariosPlataforma" runat="server" KeyFieldName="IdUsuario"
                        OnRowCommand="gvUsariosPlataforma_RowCommand">
                        <SettingsAdaptivity AdaptivityMode="HideDataCells" AllowOnlyOneAdaptiveDetailExpanded="true"></SettingsAdaptivity>
                        <Columns>
                            <dx:BootstrapGridViewDataColumn FieldName="Correo" Caption="Correo" VisibleIndex="1" CssClasses-HeaderCell="" CssClasses-DataCell="" HorizontalAlign="Center" Settings-AllowCellMerge="True"/>
                            <dx:BootstrapGridViewDataColumn FieldName="NombreCompleto" Caption="Nombre" VisibleIndex="2" SortIndex="0" CssClasses-HeaderCell="" CssClasses-DataCell="" HorizontalAlign="Center" Settings-AllowCellMerge="True" />
                            <dx:BootstrapGridViewDataColumn FieldName="Telefono" Caption="Telefono" VisibleIndex="3" CssClasses-HeaderCell="" CssClasses-DataCell="" HorizontalAlign="Center" Settings-AllowCellMerge="True" />
                            <dx:BootstrapGridViewDataColumn FieldName="Password" Caption="Password" VisibleIndex="4" Visible="false" CssClasses-HeaderCell="" CssClasses-DataCell="" HorizontalAlign="Center" Settings-AllowCellMerge="True" />
                            <dx:BootstrapGridViewDataColumn VisibleIndex="11" HorizontalAlign="Center">
                                <DataItemTemplate>
                                    <dx:BootstrapButton ID="btnActualizarUsuario" runat="server" Text="Actualizar" CommandName="Actualizar" CommandArgument='<%# Eval("IdUsuario").ToString()%>'></dx:BootstrapButton>
                                    <dx:BootstrapButton ID="btnEliminarUsuario" runat="server" Text="Eliminar" CommandName="Eliminar"
                                        CommandArgument='<%# Eval("IdUsuario").ToString()%>'>
                                        <ClientSideEvents Click="function(s, e){  e.processOnServer = confirm('¿Está seguro que desea eliminar el registro?');}" />
                                    </dx:BootstrapButton>
                                </DataItemTemplate>
                            </dx:BootstrapGridViewDataColumn>
                        </Columns>
                        <Templates>
                            <EmptyDataRow>
                                Aún no se han registrado usuarios para esta empresa.
                            </EmptyDataRow>
                        </Templates>
                    </dx:BootstrapGridView>
                </div>
                <div class="col-lg-2"></div>
            </div>
        </fieldset>
        <br />
        <fieldset runat="server" style="padding: 15px; margin-top: -40px;" class="card mb-4">
            <header>
                Usuarios de la plataforma
            </header>
            <div class="row">
                <div class="col-lg-6">
                    <dx:ASPxLabel ID="lblExtKey" runat="server" Text="Seleccione archivo .Key"></dx:ASPxLabel>
                </div>
                <div class="col-lg-6">
                    <dx:ASPxLabel ID="lblExtCer" runat="server" Text="Seleccione archivo .Cer"></dx:ASPxLabel>
                </div>
            </div>
            <div class="row">
                <div class="col-lg-6">
                    <dx:BootstrapUploadControl ID="uplKey" runat="server" ShowUploadButton="true" Width="70%">
                        <ClientSideEvents FileUploadComplete="onFileUploadComplete" FilesUploadStart="onFilesUploadStart" />
                        <ValidationSettings MaxFileSize="4194304" AllowedFileExtensions=".key" />
                    </dx:BootstrapUploadControl>
                    <small>Extensión permitida: .key</small>
                    <br />
                    <small>Tamaño máximo del archivo: 4 MB.</small>
                </div>
                <div class="col-lg-6">
                    <dx:BootstrapUploadControl ID="uplCer" runat="server" ShowUploadButton="true" Width="70%">
                        <ClientSideEvents FileUploadComplete="onFileUploadComplete" FilesUploadStart="onFilesUploadStart" />
                        <ValidationSettings MaxFileSize="4194304" AllowedFileExtensions=".cer" />
                    </dx:BootstrapUploadControl>
                    <small>Extensión permitida: .cer</small>
                    <br />
                    <small>Tamaño máximo del archivo: 4 MB.</small>
                </div>
            </div>
            <div class="row">
                <div class="col-lg-6">
                    <dx:ASPxLabel ID="ASPxLabel1" runat="server" Text="Seleccione archivo .Key"></dx:ASPxLabel>
                </div>
                <div class="col-lg-6">
                    <dx:ASPxLabel ID="ASPxLabel2" runat="server" Text="Seleccione archivo .Cer"></dx:ASPxLabel>
                </div>
            </div>
        </fieldset>

        <br />

    </div>

    <%--<div id="default-popup-control-1" class="popup-target popup-target-sm"></div>--%>
    <dx:BootstrapPopupControl ID="mpMensaje" runat="server" ShowOnPageLoad="true" PopupElementCssSelector="#default-popup-control-1"
        ShowHeader="true" PopupHorizontalAlign="Center" PopupVerticalAlign="Middle" Width="500px" CloseAction="CloseButton">
        <ContentCollection>
            <dx:ContentControl>
                <p>
                    <dx:ASPxLabel ID="lblMensajeModal" runat="server"></dx:ASPxLabel>
                </p>
            </dx:ContentControl>
        </ContentCollection>
    </dx:BootstrapPopupControl>

    <dx:BootstrapPopupControl ID="ppAltaUsuario" runat="server" ClientInstanceName="ppAltaUsuario" CloseAnimationType="Fade" PopupAnimationType="Fade"
        PopupHorizontalAlign="WindowCenter" PopupVerticalAlign="WindowCenter" Width="350px" Height="350px" HeaderText="Alta de usuarios"
        AllowDragging="true" Modal="true" CloseAction="CloseButton" ShowCloseButton="true" AllowResize="true">
        <ContentCollection>
            <dx:ContentControl>
                <div class="row">
                    <div class="col-lg-12">
                        <dx:BootstrapTextBox ID="txtNombreUsuariosPlat" runat="server" Caption="Nombre completo:">
                            <ValidationSettings ValidationGroup="VGAltaUsuPlat" RequiredField-IsRequired="true" RequiredField-ErrorText="El nombre es requerido."></ValidationSettings>
                        </dx:BootstrapTextBox>
                    </div>
                </div>
                <div class="row">
                    <div class="col-lg-12">
                        <dx:BootstrapButtonEdit ID="txtUsuarioUsuPlat" ClearButton-DisplayMode="OnHover" NullText="Ingrese su e-mail aquí" Caption="E-mail:"
                            runat="server">
                            <ValidationSettings ValidationGroup="VGAltaUsuPlat">
                                <RequiredField IsRequired="true" ErrorText="El e-mail es requerido" />
                                <RegularExpression ErrorText="Ingrese un e-mail válido" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" />
                            </ValidationSettings>
                            <Buttons>
                                <dx:BootstrapEditButton IconCssClass="fa fa-envelope" />
                            </Buttons>
                        </dx:BootstrapButtonEdit>
                    </div>
                    <div class="col-lg-12">
                        <dx:BootstrapTextBox ID="txtPassword" runat="server" Caption="Password:" Password="true">
                            <ValidationSettings ValidationGroup="VGAltaUsuPlat" RequiredField-IsRequired="true" ErrorText="El campo es requerido."></ValidationSettings>
                        </dx:BootstrapTextBox>
                    </div>
                </div>
                <div class="row">
                    <div class="col-lg-12">
                        <dx:BootstrapTextBox ID="txtTelefonoUsuPlat" runat="server" Caption="Telefono:" MaxLength="10">
                            <ValidationSettings ValidationGroup="VGAltaUsuPlat" RequiredField-IsRequired="true" ErrorText="El campo es requerido."></ValidationSettings>
                        </dx:BootstrapTextBox>
                    </div>
                </div>
                <br />
                <div class="row">
                    <div class="col-lg-12" style="text-align: center">
                        <dx:BootstrapButton ID="btnGuardarUsuarioPlat" runat="server" Text="Aceptar" OnClick="btnGuardarUsuarioPlat_Click">
                            <SettingsBootstrap RenderOption="Success" />
                        </dx:BootstrapButton>
                        <dx:BootstrapButton ID="btnCancelarUsuarioPlat" runat="server" Text="Cancelar" OnClick="btnCancelarUsuarioPlat_Click">
                            <SettingsBootstrap RenderOption="Warning" />
                        </dx:BootstrapButton>
                    </div>
                </div>
            </dx:ContentControl>
        </ContentCollection>
    </dx:BootstrapPopupControl>
</asp:Content>
