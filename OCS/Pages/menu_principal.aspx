<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="menu_principal.aspx.cs" Inherits="OCS.Pages.WebForm2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <br />
    <br />
    <br />
    <br />
    <h2>Menú principal</h2>
    <br />
    <br />
    <asp:Button ID="btnAdminUsuarios" runat="server" Text="Administración de usuarios" class="btn btn-primary btn-lg col-3 mx-auto" width="950px" OnClick="btnAdminUsuarios_Click" />
    <br />
    <br />
    <asp:Button ID="btnAdminMenu" runat="server" Text="Administración de la carta" class="btn btn-primary btn-lg col-4 mx-auto" width="300px" OnClick="btnAdminMenu_Click" />
    <br />
    <br />
    <asp:Button ID="btnAdminMesas" runat="server" Text="Administración de mesas" class="btn btn-primary btn-lg col-3 mx-auto" width="300px" OnClick="btnAdminMesas_Click" />
    <br />
    <br />
    <asp:Button ID="btnIngOrden" runat="server" Text="Ingresar orden" class="btn btn-primary btn-lg col-3 mx-auto" width="300px" />
    <br />
    <br />
    <asp:Button ID="btnModOrden" runat="server" Text="Modificar orden" class="btn btn-primary btn-lg col-3 mx-auto" width="300px" />
    <br />
    <br />
    <asp:Button ID="btnAnularOrden" runat="server" Text="Anular orden" class="btn btn-primary btn-lg col-3 mx-auto" width="300px" />
    <br />
    <br />
    <asp:Button ID="btnFinOrden" runat="server" Text="Finalizar orden" class="btn btn-primary btn-lg col-3 mx-auto" width="300px" />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
</asp:Content>
