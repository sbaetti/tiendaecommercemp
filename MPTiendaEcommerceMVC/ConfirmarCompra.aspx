<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="ConfirmarCompra.aspx.vb" Inherits="MPTiendaEcommerceMVC.ConfirmarCompra" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
<div class="page-header">
  <h1>Confirmar compra</h1>
</div>
    <div class="col-lg-12" style="margin-top:20px;">
            <table class="table table-striped">
              <thead>
                <tr>
                  <th scope="col">Nombre</th>
                  <th scope="col">Descripcion</th>
                  <th scope="col">Cantidad</th>
                  <th scope="col">Precio</th>
                </tr>
              </thead>
              <tbody>
                <tr>
                  <td>Samsung a10</td>
                  <td>Dispositivo móvil Tienda e-commerce</td>
                  <td>1</td>
                  <td>$10000</td>
                </tr>
              </tbody>
             </table>
        </div>
        <div class="row">
            <div class="col-lg-6">
                <div class="form-horizontal">
                    <h3>Ingrese sus datos personales</h3>
                     <div class="form-group">
                        <label class="control-label col-sm-2" for="txtnombre">Nombre:</label>
                        <div class="col-sm-10">
                          <input readonly type="email" class="form-control" id="txtnombre" value="Lalo" placeholder="Ingresa el nombre">
                        </div>
                      </div>
                      <div class="form-group">
                        <label class="control-label col-sm-2" for="txtapellido">Apellido:</label>
                        <div class="col-sm-10">
                          <input readonly type="text" class="form-control" id="txtapellido" value="Landa" placeholder="Ingresa el apellido">
                        </div>
                      </div>
                     <div class="form-group">
                        <label class="control-label col-sm-2" for="txtemail">Email:</label>
                        <div class="col-sm-10">
                          <input readonly type="text" class="form-control" id="txtemail" value="Landa" value="test_user_63274575@testuser.com">
                        </div>
                      </div>
                     <div class="form-group">
                        <label class="control-label col-sm-2" for="txtarea">Telefono:</label>
                        <div class="col-sm-2">
                          <input readonly type="text" class="form-control" id="txtarea" value="11" >
                        </div>
                        <div class="col-sm-4">
                          <input readonly type="text" class="form-control" id="txttelefono" value="22223333" >
                        </div>
                      </div>
                 </div>
             </div> 
             <div class="col-lg-6">
                <div class="form-horizontal">
                  <h3>Direccion de envio</h3>
                      <div class="form-group">
                            <label class="control-label col-sm-2" for="txtcalle">Calle:</label>
                            <div class="col-sm-10">
                              <input readonly type="email" class="form-control" id="txtcalle" value="False">
                            </div>
                          </div>
                      <div class="form-group">
                            <label class="control-label col-sm-2" for="txtnumero">Numero:</label>
                            <div class="col-sm-10">
                              <input readonly type="email" class="form-control" id="txtnumero" value="123">
                            </div>
                          </div>
                      <div class="form-group">
                            <label class="control-label col-sm-2" for="txtcodigopostal">Codigo postal:</label>
                            <div class="col-sm-10">
                              <input readonly type="email" class="form-control" id="txtcodigopostal" value="1111">
                            </div>
                          </div>
                 </div>
              </div>
            <div class="form-group">
                <div class="col-sm-offset-2 col-sm-10">
                     <asp:Literal runat="server" ID="ltMercadoPago"></asp:Literal>
                </div>
             </div>
        </div>
        <script src="https://www.mercadopago.com/v2/security.js" view="" ></script>
</asp:Content>
