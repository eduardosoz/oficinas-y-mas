<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Clientes.aspx.cs" Inherits="Vistas.Clientes" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="body" runat="server">
    <div class="m-5"></div>
    <div class="container justify-content-center">
        <div class="card">
            <div class="card-header">
                <h3 class="card-title">Clientes</h3>
            </div>
            <div class="card-body py-3 text-right">
                <div class="d-flex">      
                    <div class="">
                        <a class="btn btn-primary btn-sm" href="AgregarCliente.aspx">Agregar Nuevo</a>
                    </div>
                    <div class="ms-auto text-muted">                        
                        <div class="input-group">
                            <div class="form-outline">                                
                                <input type="text" id="txtBuscar" class="form-control form-control-sm" placeholder="Buscar">
                            </div>                            
                            <asp:LinkButton runat="server" CssClass="btn btn-primary btn-sm"><i class="fas fa-search"></i></asp:LinkButton>                            
                        </div>
                    </div>
                </div>
            </div>            
            <div class="table-responsive">              
                <asp:GridView ID="tablaClientes" runat="server" AutoGenerateColumns="false" CssClass="table table-striped table-bordered">
                    <Columns>
                        <asp:BoundField DataField="idCliente" HeaderText="ID" InsertVisible="False" ReadOnly="true"/>
                        <asp:BoundField DataField="nombre" HeaderText="Nombre" InsertVisible="False" ReadOnly="true"/>
                        <asp:BoundField DataField="telefono" HeaderText="Telefono" InsertVisible="False" ReadOnly="true"/>
                        <asp:BoundField DataField="correo" HeaderText="Correo" InsertVisible="False" ReadOnly="true"/>                            
                        <asp:BoundField DataField="direccion" HeaderText="Dirección" InsertVisible="False" ReadOnly="true"/>
                        <asp:BoundField DataField="rfc" HeaderText="RFC" InsertVisible="False" ReadOnly="true"/>
                        <asp:BoundField DataField="direccionFiscal" HeaderText="Dirección Fiscal" InsertVisible="False" ReadOnly="true"/>
                        <asp:BoundField DataField="condicionesDePago" HeaderText="Condiciones de Pago" InsertVisible="False" ReadOnly="true"/>
                        <asp:BoundField DataField="observaciones" HeaderText="Observaciones" InsertVisible="False" ReadOnly="true"/>
                        <asp:BoundField DataField="idVendedor" HeaderText="Vendedor" InsertVisible="False" ReadOnly="true"/>
                        <asp:BoundField DataField="fechaCreacion" HeaderText="Fecha de Creación" InsertVisible="False" ReadOnly="true"/>
                        <asp:BoundField DataField="ultimaVisita" HeaderText="Ultima Vez Visto" InsertVisible="False" ReadOnly="true"/>
                        <asp:TemplateField>
                            <ItemTemplate>
                                <asp:LinkButton runat="server" CssClass="btn btn-primary btn-sm" CommandArgument="<%# ((Modelo.Cliente)(Container.DataItem)).idCliente%>" ID="btnEditar" OnCommand="btnEditar_Command" ><i class="fas fa-edit"></i></asp:LinkButton>
                                <asp:LinkButton runat="server" CssClass="btn btn-danger btn-sm" CommandArgument="<%# ((Modelo.Cliente)(Container.DataItem)).idCliente%>" ID="btnEliminar" OnCommand="btnEliminar_Command"><i class="fas fa-trash"></i></asp:LinkButton>
                            </ItemTemplate>
                        </asp:TemplateField>
                    </Columns>
                </asp:GridView>   
                
            </div>
            <div class="card-footer d-flex align-items-center">
                <p class="m-0 text-muted"> Mostrando 10 Clientes</p>
                <ul class="pagination m-0 ms-auto">
                    <li class="page-item disabled">
                        <a class="page-link" href="#">Anterior</a>
                    </li>
                    <li class="page-item active"><a class="page-link" href="#">1</a></li>
                    <li class="page-item"><a class="page-link" href="#">2</a></li>
                    <li class="page-item"><a class="page-link" href="#">3</a></li>
                    <li class="page-item"><a class="page-link" href="#">4</a></li>
                    <li class="page-item"><a class="page-link" href="#">5</a></li>
                    <li class="page-item">
                        <a class="page-link" href="#">Siguiente</a>
                    </li>
                </ul>
            </div>            
        </div>        
    </div>     
</asp:Content>
