<%@ Page Title="" Language="C#" MasterPageFile="~/Administrator/MainAdministrator.Master" AutoEventWireup="true" CodeBehind="DataProfil.aspx.cs" Inherits="RekrutmenTNI.Admin.DataProfil" %>
<%@ Register TagPrefix="uc" TagName="DataProfil" Src="../ucData.ascx" %>
<%@ Register Assembly="DevExpress.Web.v23.2, Version=23.2.3.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web" TagPrefix="dx" %>


<asp:Content ID="Content1" ContentPlaceHolderID="contentHead" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="contentForm" runat="server">
    <h1>Profil Pendaftar</h1>
    <div class="box1">
       <uc:DataProfil ID="ucDataProfil" runat="server" />
        <br />
        <table>
            <tr>
                <td colspan="2">
                    <dx:ASPxLabel ID="lblError" Text="" runat="server" CssClass="text-error"></dx:ASPxLabel>
                </td>
            </tr>
            <tr>
                <td>
                    <dx:ASPxButton ID="btnSimpan" runat="server" Text="Ya, Saya Yakin Ingin Menyimpan Data Ini" Width="250px" OnClick="btnSimpan_Click" CssClass="btn btn-primary" Theme="BlackGlass">
                    </dx:ASPxButton>
                </td>
                <td>
                    <dx:ASPxButton ID="btnRegis" runat="server" Text="Daftarkan &amp; Cetak kartu peserta" Width="250px" CssClass="btn btn-success" Theme="BlackGlass" AutoPostBack="False">
                        <ClientSideEvents Click="function(s, e) {
	printCallback.PerformCallback();
}" />
                    </dx:ASPxButton>
                </td>
            </tr>
        </table>

    </div>
    <dx:ASPxCallback ID="printCallback" runat="server" ClientInstanceName="printCallback" OnCallback="printCallback_Callback">
        <ClientSideEvents CallbackComplete="function(s, e) {
	window.open('../ReportViewer.aspx?id=' + e.result + '&amp;type=Surat');
}" />
        
    </dx:ASPxCallback>
</asp:Content>
