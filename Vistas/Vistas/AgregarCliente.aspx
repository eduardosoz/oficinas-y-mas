<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="AgregarCliente.aspx.cs" Inherits="Vistas.AgregarCliente" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="body" runat="server">
     <div class="container justify-content-center">
        <div class="mb-5"></div>
        <div class="card container-fluid" style="width: 65%;">
            <div class="mb-3"></div>
            <h3 class="form-label text-center">Agregar Nuevo Cliente</h3>
            <div class="mb-3"></div>
            <div class="mb-3">
                 <asp:TextBox runat="server" ID="txtNombre" CssClass="form-control" placeholder="Nombre" required="required" type="text"/>
            </div>            
            <div class="mb-3">
                <asp:TextBox runat="server" ID="txtTelefono" CssClass="form-control" placeholder="Teléfono" required="required" type="number"/>
            </div>
            <div class="mb-3">
                <asp:TextBox runat="server" ID="txtCorreo" CssClass="form-control" placeholder="Correo" required="required" type="email"/>
            </div>
            <div class="mb-3">
                <asp:TextBox runat="server" ID="txtDireccion" CssClass="form-control" placeholder="Dirección" required="required" type="text"/>
            </div> 
            <div class="mb-3">
                <asp:TextBox runat="server" ID="txtRfc" CssClass="form-control" placeholder="RFC" required="required" type="text"/>
            </div>
            <div class="mb-3">
                <asp:TextBox runat="server" ID="txtDireccionFiscal" CssClass="form-control" placeholder="Dirección Fiscal" required="required" type="text"/>
            </div>                       
            <div class="mb-3">
                <asp:TextBox runat="server" ID="txtCondiciones" CssClass="form-control" placeholder="Condiciones de Pago" required="required" type="text"/>
            </div>
             <div class="mb-3">
                <asp:TextBox runat="server" ID="txtObservaciones" CssClass="form-control" placeholder="Observaciones" required="required" type="text"/>
            </div>
            <div class="mb-1"></div>
            <div>
                <a href="Contactos.aspx" class="btn btn-secondary">Volver</a>
                <asp:Button runat="server" Text ="Agregar Cliente" CssClass="btn btn-success" ID="btnAgregarCliente" OnClick="btnAgregarCliente_Click"/>
            </div>
            <div class="mb-3"></div>
        </div>
    </div>
</asp:Content>
