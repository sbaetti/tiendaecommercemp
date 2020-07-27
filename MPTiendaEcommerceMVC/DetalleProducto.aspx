<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="DetalleProducto.aspx.vb" Inherits="MPTiendaEcommerceMVC.DetalleProducto" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
 <div class="container">
      <div class="page-header">
  <h1>Detalle del producto</h1>
</div>
<asp:Panel runat="server" ID="pnDetalleProducto" Visible="false">
   

    <div class="row" style="margin-top:20px;">
   <div class="col-lg-4">
        <div class="card mt-4">
            <div style="width:900px;">
                <img class="card-img-top img-fluid" src="Images/samsung10ac.jpg" alt="">
            </div>
        </div>
    </div>
      <div class="col-lg-8">
                    
          <div class="card-body">
            <h3 class="card-title">Samsung Galaxy A10 32 GB Negro 2 GB RAM</h3>
            <h4>$10000</h4>
            <span class="text-warning">&#9733; &#9733; &#9733; &#9733; &#9734;</span>
            4.0 stars
          </div>

        <!-- /.card -->
         <div style="margin:10px;"><a href="ConfirmarCompra.aspx" style="width:100%; margin: 0 auto; text-align:center;" class="btn btn-info">Comprar</a></div>
        <div class="card card-outline-secondary my-4">
          <div class="card-header">
            <strong style="font-size:17px;">Descripcion</strong>
          </div>
          <div class="card-body">
            <p>Dispositivo móvil tienda e-commerce</p>
    
            
          </div>
        </div>
        <!-- /.card -->

      </div>
      <!-- /.col-lg-9 -->

    </div>


</asp:Panel>
<asp:Panel runat="server" ID="pnErrorFormulario" Visible="false">
    <div class="alert alert-danger alert-dismissible" role="alert">
          <strong>Error!</strong> No contiene un id valido
          <button type="button" class="close" data-dismiss="alert" aria-label="Close">
            <span aria-hidden="true">&times;</span>
          </button>
    </div>
</asp:Panel>
  </div>
</asp:Content>
