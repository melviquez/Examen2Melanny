<%@ Page Title="" Language="C#" MasterPageFile="~/tabs/menu.Master" AutoEventWireup="true" CodeBehind="registrar_votos.aspx.cs" Inherits="Examen2Melanny.tabs.registrar_votos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Registrar votos</h1>
    <br />
    <asp:DropDownList ID="dropdown_casas" runat="server"></asp:DropDownList>
    <br />
    <asp:Button ID="Banadir_voto" runat="server" Text="Registrar Voto" OnClick="click_on_anadir_voto" />
    <br />
&nbsp;&nbsp;
    <asp:GridView ID="grid_votos" runat="server" Height="135px" Width="227px">
    </asp:GridView>
    <br />

</asp:Content>
