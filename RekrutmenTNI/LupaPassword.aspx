<%@ Page Title="" Language="C#" MasterPageFile="~/MainDefault.Master" AutoEventWireup="true" CodeBehind="LupaPassword.aspx.cs" Inherits="RekrutmenTNI.LupaPassword" %>

<%@ Register Assembly="DevExpress.Web.v23.2, Version=23.2.3.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web" TagPrefix="dx" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="contentMain" runat="server">
    <h3>Lupa Kata Sandi?</h3>
    <table>
        <tr>
            <td>Masukkan alamat e-mail Anda: <dx:ASPxTextBox ID="txtEmail" runat="server" Width="170px"></dx:ASPxTextBox></td>
        </tr>
        <tr>
            <td>Masukkan pangkat Anda: <dx:ASPxComboBox ID="cboPangkat" runat="server">
                <Items>
                    <dx:ListEditItem Text="Taruna" Value="Taruna" />
                    <dx:ListEditItem Text="Bintara" Value="Bintara" />
                    <dx:ListEditItem Text="Tamtama" Value="Tamtama" />
                </Items>
                </dx:ASPxComboBox>
            </td>
        </tr>
        <tr>
            <td></td>
        </tr>
        <tr>
            <td colspan="3">
                <dx:ASPxButton ID="btnKonfirmasi" runat="server" Text="Kirim" Width="100%" OnClick="btnKonfirmasi_Click"></dx:ASPxButton>
            </td>
        </tr>
    </table>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="contentFill" runat="server">
</asp:Content>
