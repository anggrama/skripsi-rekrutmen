<%@ Page Title="" Language="C#" MasterPageFile="~/MainDefault.Master" AutoEventWireup="true" CodeBehind="Jadwal.aspx.cs" Inherits="RekrutmenTNI.Jadwal" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="contentMain" runat="server">
    <h1>Jadwal &amp; Lokasi Pendaftaran</h1>
    <div class="box1">
        <div class="fillpadding">
            <h2>Jadwal Pendaftaran</h2>

            <asp:Literal ID="litJadwal" runat="server"></asp:Literal>
            <br />
            <br />
            <h2>Lokasi Pendaftaran</h2>

            <asp:Literal ID="litLokasi" runat="server"></asp:Literal>
        </div>
    </div>
</asp:Content>
