<%@ Page Title="" Language="C#" MasterPageFile="~/Administrator/MainAdministrator.Master" AutoEventWireup="true" CodeBehind="InboxRead.aspx.cs" Inherits="RekrutmenTNI.Admin.InboxRead" %>
<asp:Content ID="Content1" ContentPlaceHolderID="contentHead" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="contentForm" runat="server">
    <h1>Pesan</h1>
    <br />
    <h2><asp:Literal ID="litJudul" runat="server"></asp:Literal></h2>
    <div class="box1 pad_left20 pad_right20">
        <asp:Literal ID="litMessage" runat="server"></asp:Literal>
    </div>
    <br />
    <h3>Attachment</h3>
    <div class="box1 pad_left20 pad_right20">
        <asp:Literal ID="litFiles" runat="server"></asp:Literal>
    </div>

</asp:Content>
