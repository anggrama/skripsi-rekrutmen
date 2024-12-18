﻿<%@ Page Title="" Language="C#" MasterPageFile="~/MainDefault.Master" AutoEventWireup="true" CodeBehind="DaftarLogin.aspx.cs" Inherits="RekrutmenTNI.DaftarLogin" %>

<%@ Register Assembly="DevExpress.Web.v23.2, Version=23.2.3.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web" TagPrefix="dx" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="contentMain" runat="server">
    <h1>Pendaftaran Berhasil</h1>
    <div class="box1">
        <div class="fillpadding">
            <table>
                <tr>
                    <td colspan="2">Terima kasih telah melakukan pendaftaran online TNI AU. Silahkan login untuk melengkapi data - data pribadi anda.
                    </td>
                </tr>
                <tr>
                    <td>Username    :</td>
                    <td>
                        <dx:ASPxTextBox ID="txtEmail" runat="server" Width="170px" NullText="Email" AutoCompleteType="Disabled">
                            <ValidationSettings ErrorDisplayMode="ImageWithTooltip" ValidationGroup="valLogin2">
                                <RegularExpression ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" />
                                <RequiredField IsRequired="True" />
                            </ValidationSettings>
                        </dx:ASPxTextBox>
                    </td>
                </tr>
                <tr>
                    <td>Password    :</td>
                    <td>
                        <dx:ASPxTextBox ID="txtPassword" runat="server" Width="170px" Password="True" NullText="Password" AutoCompleteType="Disabled">
                            <ValidationSettings ErrorDisplayMode="ImageWithTooltip" ValidationGroup="valLogin2">
                                <RequiredField IsRequired="True" />
                            </ValidationSettings>
                        </dx:ASPxTextBox>
                    </td>
                </tr>
                <tr>
                    <td></td>
                    <td>
                        <dx:ASPxHyperLink ID="hypLupaPassword" runat="server" Text="Lupa Password" />
                    </td>
                </tr>
                <tr>
                    <td colspan="2">
                        <dx:ASPxLabel ID="lblSalah" runat="server" Text="Maaf Email/Password yang anda masukkan salah." ForeColor="Red" Visible="False"></dx:ASPxLabel>
                    </td>
                </tr>
                <tr>
                    <td colspan="2" align="center">
                        <dx:ASPxButton ID="btnLogin" runat="server" Text="Login" ValidationGroup="valLogin2" OnClick="btnLogin_Click" CssClass="btn btn-small btn-primary"></dx:ASPxButton>
                    </td>
                </tr>
            </table>
        </div>
    </div>
</asp:Content>
