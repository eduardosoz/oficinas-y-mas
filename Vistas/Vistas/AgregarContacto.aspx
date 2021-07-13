<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="AgregarContacto.aspx.cs" Inherits="Vistas.AgregarContacto" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="body" runat="server">
    <div class="container justify-content-center">
        <div class="mb-5"></div>
        <div class="card container-fluid" style="width: 65%;">
            <div class="mb-3"></div>
            <h3 class="form-label text-center">Agregar Nuevo Contacto</h3>
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
                <asp:TextBox runat="server" ID="txtEmpresa" CssClass="form-control" placeholder="Empresa" required="required" type="text"/>
            </div> 
            <div class="mb-3">
                <asp:TextBox runat="server" ID="txtDireccion" CssClass="form-control" placeholder="Dirección" required="required" type="text"/>
            </div>           
            <div class="mb-3">
                <label class="text-sm-start">Valoración</label>
                <asp:DropDownList runat="server" CssClass="form-select form-select" AutoPostBack="true" ID="dplValoracion">
                  <asp:ListItem Selected="True" Value="Muy Buena"> Muy Buena </asp:ListItem>
                  <asp:ListItem Value="Buena"> Buena </asp:ListItem>
                  <asp:ListItem Value="Neutral"> Neutral </asp:ListItem>
                  <asp:ListItem Value="Mala"> Mala </asp:ListItem>
                  <asp:ListItem Value="Muy Mala"> Muy Mala </asp:ListItem>   
                </asp:DropDownList>               
            </div>
            <div class="mb-3">
                <asp:TextBox runat="server" ID="txtCotizacion" CssClass="form-control" placeholder="Cotización" required="required" type="text"/>
            </div>
             <div class="mb-3">
                <asp:TextBox runat="server" ID="txtObservaciones" CssClass="form-control" placeholder="Observaciones" required="required" type="text"/>
            </div>
            <div class="mb-1"></div>
            <div>
                <a href="Contactos.aspx" class="btn btn-secondary">Volver</a>
                <asp:Button runat="server" Text ="Agregar Contacto" CssClass="btn btn-success" ID="btnAgregarContacto" OnClick="btnAgregarContacto_Click"/>
            </div>
            <div class="mb-3"></div>
        </div>
    </div>
</asp:Content>
