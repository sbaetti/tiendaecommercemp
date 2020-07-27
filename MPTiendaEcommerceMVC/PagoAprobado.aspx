<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="PagoAprobado.aspx.vb" Inherits="MPTiendaEcommerceMVC.PagoAprobado" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="page-header">
        <h1>Pago aprobado</h1>
    </div>
    <div class="alert alert-success alert-dismissible" style="margin-top:20px;" role="alert">
          <strong>Perfecto!</strong> El pago fue aprobado
          <button type="button" class="close" data-dismiss="alert" aria-label="Close">
            <span aria-hidden="true">&times;</span>
          </button>
    </div>

    <div class="row">
        <label id="lblpaymentmethodid">payment_method_id:</label>
        <asp:Label runat="server" ID="txtpaymentmethodid"></asp:Label>
    </div>
     <div class="row">
        <label id="lblcollectionid">Status:</label>
        <asp:Label runat="server" ID="txtStatus"></asp:Label>
    </div>
    <div class="row">
        <label id="lblexternalreference">Referencia externa:</label>
        <asp:Label runat="server" ID="txtreferencia"></asp:Label>
    </div>


</asp:Content>
