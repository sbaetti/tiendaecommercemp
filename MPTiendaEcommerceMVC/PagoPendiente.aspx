﻿<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="PagoPendiente.aspx.vb" Inherits="MPTiendaEcommerceMVC.PagoPendiente" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="page-header">
        <h1>Pago pendiente</h1>
    </div>
    <div class="alert alert-warning alert-dismissible" style="margin-top:20px;" role="alert">
          <strong>Pago pendiente!</strong> El pago se encuentra en un estado pendiente, proximamente te avisaremos su estado
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
