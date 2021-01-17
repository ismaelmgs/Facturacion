<%@ Page Title="" Language="C#" MasterPageFile="~/FactMaster.master" AutoEventWireup="true" CodeBehind="frmQuienesSomos.aspx.cs" Inherits="Facturacion.frmQuienesSomos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="mainContent" runat="server">
    <div class="container-fluid">
        <div class="row">
            <p class="col-12 demo-content-title">¿Quienes somos?</p>
        </div>
        <br />
        <div class="row">
            <table style="width:100%">
                <tr>
                    <td style="width:50%; background-color:#F5F2F2; text-align:center">
                        <h3>Misión</h3>
                        <dx:ASPxLabel ID="lblMision" runat="server"></dx:ASPxLabel>
                    </td>
                    <td style="width:50%; background-color:#F5F2F2; text-align:center"></td>
                </tr>
                <tr>
                    <td style="width:50%; text-align:center"></td>
                    <td style="width:50%; text-align:center">
                        <h3>Visión</h3>
                    </td>
                </tr>
                <tr>
                    <td style="width:50%; background-color:#F5F2F2; text-align:center">
                        <h3>Valores</h3>
                    </td>
                    <td style="width:50%; background-color:#F5F2F2; text-align:center"></td>
                </tr>
            </table>

            <%--<asp:Repeater ID="repetidor1" runat="server">
                <ItemTemplate>--%>
                    <%--<div data-id="22"
                        data-lat="19.043017"
                        data-lng="-98.008079"
                        data-marker-image="https://cdn4.iconfinder.com/data/icons/small-n-flat/24/map-marker-32.png"
                        data-marker-width="35"
                        data-marker-height="43"
                        class="marker">
                        <div class="map-card">
                            <h1></h1>
                            <p></p>
                            <img src="http://develoteca.com/wp-content/themes/site/img/develoteca.png" />
                        </div>
                    </div>--%>
                <%--</ItemTemplate>
            </asp:Repeater>--%>
        </div>
    </div>
</asp:Content>
