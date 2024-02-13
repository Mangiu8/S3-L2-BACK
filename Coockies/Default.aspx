<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Coockies._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <main>
        <asp:TextBox ID="Username" runat="server" placeholder="Username"></asp:TextBox>
        <asp:TextBox ID="Password" runat="server" placeholder="Password"></asp:TextBox>
        <asp:Button ID="Button1" runat="server" Text="Registrati" OnClick="Button1_Click" />
    </main>

</asp:Content>
