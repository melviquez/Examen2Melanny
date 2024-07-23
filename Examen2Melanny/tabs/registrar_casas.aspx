<%@ Page Title="" Language="C#" MasterPageFile="~/tabs/menu.Master" AutoEventWireup="true" CodeBehind="registrar_casas.aspx.cs" Inherits="Examen2Melanny.tabs.registrar_casas" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <h1 style="font-size: 36px;">Ingresar Nueva Casa de Game of Thrones</h1>
    <br />
    Casa
    <asp:TextBox ID ="field_casa" runat="server"></asp:TextBox>
    Señor o Señora de la Casa:
    <asp:TextBox ID ="field_lord" runat="server"></asp:TextBox>
    <br />
    <asp:Button ID="Banadir" runat="server" Text="Ingresar" OnClick="click_on_anadir" />
    <br />
    <asp:Button ID="Bborrar" runat="server" Text="Borrar" OnClick="click_on_borrar" />
    <br />
    Casas Actuales<br />
&nbsp;&nbsp;
    <asp:GridView ID="grid_casas_nobles" runat="server" Height="135px" Width="227px">
    </asp:GridView>
    <br />
    <br />
</asp:Content>
