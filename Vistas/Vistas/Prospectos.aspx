<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Prospectos.aspx.cs" Inherits="Vistas.Prospectos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="body" runat="server">
     <div class="m-5"></div>
    <div class="container justify-content-center">
        <div class="card">
            <div class="card-header">
                <h3 class="card-title">Prospectos</h3>
            </div>
            <div class="card-body py-3 text-right">
                <div class="d-flex">                          
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
                <asp:GridView ID="tablaContactos" runat="server" AutoGenerateColumns="false" CssClass="table table-striped table-bordered">
                    <Columns>
                        <asp:BoundField DataField="idContacto" HeaderText="ID" InsertVisible="False" ReadOnly="true"/>
                        <asp:BoundField DataField="nombre" HeaderText="Nombre" InsertVisible="False" ReadOnly="true"/>
                        <asp:BoundField DataField="telefono" HeaderText="Telefono" InsertVisible="False" ReadOnly="true"/>
                        <asp:BoundField DataField="correo" HeaderText="Correo" InsertVisible="False" ReadOnly="true"/>                            
                        <asp:BoundField DataField="empresa" HeaderText="Empresa" InsertVisible="False" ReadOnly="true"/>
                        <asp:BoundField DataField="direccion" HeaderText="Dirección" InsertVisible="False" ReadOnly="true"/>
                        <asp:BoundField DataField="observaciones" HeaderText="Observaciones" InsertVisible="False" ReadOnly="true"/>
                        <asp:BoundField DataField="valoracion" HeaderText="Valoración" InsertVisible="False" ReadOnly="true"/>
                        <asp:BoundField DataField="cotizacion" HeaderText="Cotización" InsertVisible="False" ReadOnly="true"/>
                        <asp:BoundField DataField="idVendedor" HeaderText="Vendedor" InsertVisible="False" ReadOnly="true"/>
                        <asp:TemplateField>
                            <ItemTemplate>
                                <asp:LinkButton runat="server" CssClass="btn btn-success btn-sm" CommandArgument="<%# ((Modelo.Contacto)(Container.DataItem)).idContacto%>" ID="btnMejorar" OnCommand="btnMejorar_Command"><i class="fas fa-arrow-up"></i></asp:LinkButton>                                
                            </ItemTemplate>
                        </asp:TemplateField>
                    </Columns>
                </asp:GridView>   
                
            </div>
            <div class="card-footer d-flex align-items-center">
                <p class="m-0 text-muted"> Mostrando 10 Prospectos</p>
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
