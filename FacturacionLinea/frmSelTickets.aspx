<%@ Page Title="" Language="C#" MasterPageFile="~/FactMaster.Master" AutoEventWireup="true" CodeBehind="frmSelTickets.aspx.cs" Inherits="FacturacionLinea.frmSelTickets" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script type="text/javascript">
        function onTabWithBadgeClick(s, e) {
            if(e.tab.GetBadgeText())
                e.tab.SetBadgeText("");
        }
    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="mainContent" runat="server">
    <div class="container-fluid">
        <div class="row">
            <p class="col-12 demo-content-title">Selección de Tickets</p>
        </div>
        <br />
        <br />

        <%--<fieldset style="padding: 15px; margin-top: -40px; width: 100%" class="card mb-4;">
            <dx:ASPxPageControl ID="tabFacturacion" Width="100%" runat="server" CssClass="dxtcFixed" ActiveTabIndex="0" EnableHierarchyRecreation="True">
                <TabPages>
                    <dx:TabPage Text="1.- Selección de tickets">
                        <ContentCollection>
                            <dx:ContentControl ID="ccTickets" runat="server">
                                
                            </dx:ContentControl>
                        </ContentCollection>
                    </dx:TabPage>

                    <dx:TabPage Text="2.- Vista previa" Enabled="false">
                        <ContentCollection>
                            <dx:ContentControl ID="ContentControl2" runat="server">
                                <div class="row">
                                    <div class="col-lg-8">
                                        <dx:BootstrapComboBox ID="BootstrapComboBox1" runat="server" Caption="Sucursal:"></dx:BootstrapComboBox>
                                    </div>
                                    <div class="col-lg-4"></div>
                                </div>
                            </dx:ContentControl>
                        </ContentCollection>
                    </dx:TabPage>

                    <dx:TabPage Text="3.- Descarga de archivos" Enabled="false">
                        <ContentCollection>
                            <dx:ContentControl ID="ContentControl1" runat="server">
                            </dx:ContentControl>
                        </ContentCollection>
                    </dx:TabPage>
                </TabPages>
            </dx:ASPxPageControl>
        </fieldset>--%>

        <fieldset style="padding: 15px; margin-top: -40px; width: 1000px" class="card mb-4;">
            <dx:BootstrapPageControl ID="tabConFacturacion" runat="server" TabAlign="Justify">
                <TabPages>
                    <dx:BootstrapTabPage Text="1.- Selección de tickets">
                        <ContentCollection>
                            <dx:ContentControl runat="server" SupportsDisabledAttribute="True">
                                <div class="row">
                                    <div class="col-lg-8">
                                        <dx:BootstrapComboBox ID="ddlSucursal" runat="server" Caption="Sucursal:"></dx:BootstrapComboBox>
                                    </div>
                                    <div class="col-lg-4"></div>
                                </div>
                                <div class="row">
                                    <div class="col-lg-4">
                                        <dx:BootstrapTextBox ID="txtNoTicket" runat="server" Caption="No. Ticket:"></dx:BootstrapTextBox>
                                    </div>
                                    <div class="col-lg-4">
                                        <dx:BootstrapTextBox ID="txtMonto" runat="server" Caption="Monto Ticket:"></dx:BootstrapTextBox>
                                    </div>
                                    <div class="col-lg-4"></div>
                                </div>
                                <div class="row">
                                    <div class="col-lg-4"></div>
                                    <div class="col-lg-4"></div>
                                    <div class="col-lg-4" style="vertical-align: top; text-align: left">
                                        <dx:BootstrapButton ID="btnBuscarTicket" runat="server" Text="Buscar ticket" OnClick="btnBuscarTicket_Click">
                                            <SettingsBootstrap RenderOption="Primary" />
                                        </dx:BootstrapButton>
                                    </div>
                                </div>
                                <br />
                                <div class="row">
                                    <div class="col-lg-12">
                                        <dx:BootstrapGridView ID="gvTickets" runat="server" AutoGenerateColumns="false" Width="100%"
                                            OnRowCommand="gvTickets_RowCommand">
                                            <SettingsAdaptivity AdaptivityMode="HideDataCells" AllowOnlyOneAdaptiveDetailExpanded="true"></SettingsAdaptivity>
                                            <Columns>
                                                <dx:BootstrapGridViewDataColumn FieldName="Cantidad" Caption="Cantidad" VisibleIndex="1" />
                                                <dx:BootstrapGridViewDataColumn FieldName="UnidadMedida" Caption="UnidadMedida" VisibleIndex="2" SortIndex="0" CssClasses-HeaderCell="" CssClasses-DataCell="" HorizontalAlign="Center" Settings-AllowCellMerge="True" />
                                                <dx:BootstrapGridViewDataColumn FieldName="Descripcion" Caption="Descripcion" VisibleIndex="3" CssClasses-HeaderCell="" CssClasses-DataCell="" HorizontalAlign="Center" Settings-AllowCellMerge="True" />
                                                <dx:BootstrapGridViewDataColumn FieldName="PrecioUnitario" Caption="PrecioUnitario" VisibleIndex="4" CssClasses-HeaderCell="" CssClasses-DataCell="" HorizontalAlign="Center" Settings-AllowCellMerge="True" />
                                                <dx:BootstrapGridViewTextColumn FieldName="Importe" Caption="Importe" VisibleIndex="5" CssClasses-HeaderCell="" CssClasses-DataCell="" HorizontalAlign="Center" Settings-AllowCellMerge="True">
                                                    <PropertiesTextEdit DisplayFormatString="c" />
                                                </dx:BootstrapGridViewTextColumn>
                                                <dx:BootstrapGridViewTextColumn FieldName="Descuento" Caption="Descuento" VisibleIndex="6" CssClasses-HeaderCell="" CssClasses-DataCell="" HorizontalAlign="Center" Settings-AllowCellMerge="True">
                                                    <PropertiesTextEdit DisplayFormatString="c" />
                                                </dx:BootstrapGridViewTextColumn>
                                                <dx:BootstrapGridViewTextColumn FieldName="SubTotal" Caption="SubTotal" VisibleIndex="7" CssClasses-HeaderCell="" CssClasses-DataCell="" HorizontalAlign="Center" Settings-AllowCellMerge="True">
                                                    <PropertiesTextEdit DisplayFormatString="c" />
                                                </dx:BootstrapGridViewTextColumn>
                                                <dx:BootstrapGridViewTextColumn FieldName="Impuestos" Caption="Impuestos" VisibleIndex="8" CssClasses-HeaderCell="" CssClasses-DataCell="" HorizontalAlign="Center" Settings-AllowCellMerge="True">
                                                    <PropertiesTextEdit DisplayFormatString="c" />
                                                </dx:BootstrapGridViewTextColumn>
                                                <dx:BootstrapGridViewTextColumn FieldName="Total" Caption="Total" VisibleIndex="9" UnboundType="Decimal">
                                                    <PropertiesTextEdit DisplayFormatString="c" />
                                                </dx:BootstrapGridViewTextColumn>
                                                <dx:BootstrapGridViewDataColumn VisibleIndex="10">
                                                    <DataItemTemplate>
                                                        <dx:BootstrapButton ID="btnEliminarUsuario" runat="server" Text="Eliminar" CommandName="Eliminar"
                                                            CommandArgument='<%# Eval("IdTicket").ToString()%>'>
                                                            <ClientSideEvents Click="function(s, e){  e.processOnServer = confirm('¿Está seguro que desea eliminar el registro?');}" />
                                                        </dx:BootstrapButton>
                                                    </DataItemTemplate>
                                                </dx:BootstrapGridViewDataColumn>
                                            </Columns>
                                        </dx:BootstrapGridView>
                                    </div>
                                </div>
                                <br />
                                <div class="row">
                                    <div class="col-lg-4"></div>
                                    <div class="col-lg-1">
                                        <dx:BootstrapButton ID="btnContinuarSelTickets" runat="server" Text="Siguiente" OnClick="btnContinuarSelTickets_Click"
                                            Visible="false">
                                            <SettingsBootstrap RenderOption="Success" />
                                        </dx:BootstrapButton>
                                    </div>
                                    <div class="col-lg-7"></div>
                                </div>
                            </dx:ContentControl>
                        </ContentCollection>
                    </dx:BootstrapTabPage>
                    <dx:BootstrapTabPage Text="2.- Vista previa" Enabled="false">
                        <ContentCollection>
                            <dx:ContentControl runat="server" SupportsDisabledAttribute="True">
                                <div class="row">
                                    <div class="col-lg-1"></div>
                                    <div class="col-lg-10">
                                        <dx:BootstrapTextBox ID="txtNombreFac" runat="server" Caption="Nombre/Razón social:" Enabled="false" Width="100%"></dx:BootstrapTextBox>
                                    </div>
                                    <div class="col-lg-1"></div>
                                </div>
                                <div class="row">
                                    <div class="col-lg-1"></div>
                                    <div class="col-lg-5">
                                        <dx:BootstrapTextBox ID="txtRFC" runat="server" Caption="RFC:" Enabled="false"></dx:BootstrapTextBox>
                                    </div>
                                    <div class="col-lg-5" style="vertical-align:central">
                                        <dx:BootstrapComboBox ID="ddlUsoCFDI" runat="server" Caption="Uso CFDI:" NullText=".:Seleccione:."></dx:BootstrapComboBox>
                                    </div>
                                    <div class="col-lg-1"></div>
                                </div>
                                <br />
                                <div class="row">
                                    <div class="col-lg-1"></div>
                                    <div class="col-lg-10">
                                        <dx:BootstrapGridView ID="gvVistaPrevia" runat="server" AutoGenerateColumns="false" Width="100%">
                                            <SettingsAdaptivity AdaptivityMode="HideDataCells" AllowOnlyOneAdaptiveDetailExpanded="true"></SettingsAdaptivity>
                                            <Settings ShowFooter="True" />
                                            <Columns>
                                                <dx:BootstrapGridViewDataColumn FieldName="Cantidad" Caption="Cantidad" VisibleIndex="1" />
                                                <dx:BootstrapGridViewDataColumn FieldName="UnidadMedida" Caption="UnidadMedida" VisibleIndex="2" SortIndex="0" CssClasses-HeaderCell="" CssClasses-DataCell="" HorizontalAlign="Center" Settings-AllowCellMerge="True" />
                                                <dx:BootstrapGridViewDataColumn FieldName="Descripcion" Caption="Descripcion" VisibleIndex="3" CssClasses-HeaderCell="" CssClasses-DataCell="" HorizontalAlign="Center" Settings-AllowCellMerge="True" />
                                                <dx:BootstrapGridViewDataColumn FieldName="PrecioUnitario" Caption="PrecioUnitario" VisibleIndex="4" CssClasses-HeaderCell="" CssClasses-DataCell="" HorizontalAlign="Center" Settings-AllowCellMerge="True" />
                                                <dx:BootstrapGridViewTextColumn FieldName="SubTotal" Caption="SubTotal" VisibleIndex="7" CssClasses-HeaderCell="" CssClasses-DataCell="" HorizontalAlign="Center" Settings-AllowCellMerge="True">
                                                    <PropertiesTextEdit DisplayFormatString="c" />
                                                </dx:BootstrapGridViewTextColumn>
                                                <dx:BootstrapGridViewTextColumn FieldName="Impuestos" Caption="Impuestos" VisibleIndex="8" CssClasses-HeaderCell="" CssClasses-DataCell="" HorizontalAlign="Center" Settings-AllowCellMerge="True">
                                                    <PropertiesTextEdit DisplayFormatString="c" />
                                                </dx:BootstrapGridViewTextColumn>
                                                <dx:BootstrapGridViewTextColumn FieldName="Total" Caption="Total" VisibleIndex="9" UnboundType="Decimal">
                                                    <PropertiesTextEdit DisplayFormatString="c" />
                                                </dx:BootstrapGridViewTextColumn>
                                            </Columns>
                                            <TotalSummary>
                                                <dx:ASPxSummaryItem FieldName="Total" SummaryType="Sum" />
                                            </TotalSummary>
                                        </dx:BootstrapGridView>
                                    </div>
                                    <div class="col-lg-1"></div>
                                </div>
                                <br />
                                <div class="row">
                                    <div class="col-lg-1"></div>
                                    <div class="col-lg-10" style="text-align:right">
                                        <dx:BootstrapButton ID="btnContinuarVistaP" runat="server" Text="Facturar" OnClick="btnContinuarVistaP_Click">
                                            <SettingsBootstrap RenderOption="Success" />
                                        </dx:BootstrapButton>
                                    </div>
                                    <div class="col-lg-1"></div>
                                </div>
                            </dx:ContentControl>
                        </ContentCollection>
                    </dx:BootstrapTabPage>
                    <dx:BootstrapTabPage Text="3.- Descarga de archivos" Enabled="false">
                        <ContentCollection>
                            <dx:ContentControl runat="server" SupportsDisabledAttribute="True">
                                <p>Aenean gravida tristique velit ac ornare. Maecenas ultricies metus sit amet ligula malesuada, in faucibus nulla cursus. Aenean sit amet vulputate lorem, commodo suscipit nulla. Nunc non vulputate nibh. Nam sapien magna, accumsan id dui sit amet, euismod rhoncus nulla. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla quis feugiat augue. Sed turpis nibh, porta quis congue ut, mattis id purus. Donec auctor felis sit amet orci ornare, aliquet ultrices ipsum lacinia.</p>
                            </dx:ContentControl>
                        </ContentCollection>
                    </dx:BootstrapTabPage>
                </TabPages>
                <ClientSideEvents TabClick="onTabWithBadgeClick" />
            </dx:BootstrapPageControl>
            <br />
            <br />
            <dx:BootstrapProgressBar ID="progressbar" runat="server" Minimum="0" Maximum="100" Position="0" >
                <SettingsBootstrap Striped="true" />
            </dx:BootstrapProgressBar>
            <br />
        </fieldset>
    </div>
</asp:Content>
