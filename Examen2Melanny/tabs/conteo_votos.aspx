<%@ Page Title="" Language="C#" MasterPageFile="~/tabs/menu.Master" AutoEventWireup="true" CodeBehind="conteo_votos.aspx.cs" Inherits="Examen2Melanny.tabs.conteo_votos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    Conteo de Votos
    <br />
    EL ganador es
    <asp:GridView ID="grid_ganador" runat="server">
    </asp:GridView>
    <br />
    Resultados Generales
    <asp:GridView ID="grid_conteo_votos" runat="server">
    </asp:GridView>
    <br />
    <br />
</asp:Content>
