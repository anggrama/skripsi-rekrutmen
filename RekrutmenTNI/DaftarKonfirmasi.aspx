﻿<%@ Page Title="" Language="C#" MasterPageFile="~/MainDefault.Master" AutoEventWireup="true" CodeBehind="DaftarKonfirmasi.aspx.cs" Inherits="RekrutmenTNI.DaftarKonfirmasi" %>

<%@ Register Assembly="DevExpress.Web.v23.2, Version=23.2.3.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web" TagPrefix="dx" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="contentMain" runat="server">
    <h1>Pendaftaran Berhasil</h1>
    <div class="box1">
        <div class="fillpadding">
    <table>
        <tr>
            <td colspan ="2">
            Terima kasih telah melakukan pendaftaran online TNI AU. Catat / simpan email dan password yang anda dapatkan, dan silahkan melengkapi data - data pribadi anda.
            </td>
        </tr>
        <tr>
            <td>Username    :</td>
            <td>
                <dx:ASPxLabel ID="lblEmail" runat="server" Text="[lblEmail]"></dx:ASPxLabel>
            </td>
        </tr>
        <tr>
            <td>Password    :</td>
            <td>
                <dx:ASPxLabel ID="lblPassword"  runat="server" Text="[lblPassword]" Font-Names="Times New Roman"></dx:ASPxLabel>
            </td>
        </tr>
        <tr>
            <td colspan = "2" align="center">

                <a href="DataProfil.aspx" class="btn btn-primary btn-small">
                    Lengkapi Profil
                </a>
            </td>
        </tr>
    </table>
            </div>
        </div>
</asp:Content>
