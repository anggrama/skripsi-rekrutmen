﻿<%@ Page Title="" Language="C#" MasterPageFile="~/MainDefault.Master" AutoEventWireup="true" CodeBehind="Dashboard.aspx.cs" Inherits="RekrutmenTNI.Dashboard" %>
<%@ Register assembly="DevExpress.Web.v23.2, Version=23.2.3.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web" tagprefix="dx" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="contentMain" runat="server">
    <h1>Pendaftaran</h1>
    <div class="box1">
        <div class="fillpadding">
        <h2>Riwayat Daftar</h2>
        <dx:ASPxGridView ID="gvHistory" runat="server" AutoGenerateColumns="False" Width="100%" Theme="BlackGlass">
            <Columns>
                <dx:GridViewDataTextColumn Caption="No Peserta" FieldName="NoPeserta" Name="clmNoPeserta" VisibleIndex="1">
                </dx:GridViewDataTextColumn>
                <dx:GridViewDataTextColumn Caption="Tahun" FieldName="TahunPendaftaran" Name="clmTahun" VisibleIndex="2">
                </dx:GridViewDataTextColumn>
                <dx:GridViewDataTextColumn Caption="Pangkat" FieldName="Pangkat" Name="clmPangkat" VisibleIndex="3">
                </dx:GridViewDataTextColumn>
                <dx:GridViewDataTextColumn Caption="Gelombang" FieldName="GelombangKe" Name="clmGelombang" VisibleIndex="4">
                </dx:GridViewDataTextColumn>
                <dx:GridViewDataTextColumn Caption="Panda" FieldName="WilayahName" Name="clmPanda" VisibleIndex="5">
                </dx:GridViewDataTextColumn>
                <dx:GridViewDataTextColumn Caption="No Animo" FieldName="NoAnimo" Name="clmNoAnimo" VisibleIndex="0">
                    <PropertiesTextEdit DisplayFormatString="{0}">
                    </PropertiesTextEdit>
                </dx:GridViewDataTextColumn>
                <dx:GridViewDataCheckColumn Caption="Lulus Daerah" FieldName="LulusDaerah" Name="clmLulusDaerah" VisibleIndex="6">
                </dx:GridViewDataCheckColumn>
                <dx:GridViewDataCheckColumn Caption="Lulus Pusat" FieldName="LulusPusat" Name="clmLulusPusat" VisibleIndex="7">
                </dx:GridViewDataCheckColumn>
                <dx:GridViewDataHyperLinkColumn Caption="Kartu Pendaftaran" FieldName="NoAnimo" Name="clmPrint" VisibleIndex="9">
                                    <PropertiesHyperLinkEdit NavigateUrlFormatString="~/ReportViewer.aspx?id={0}&amp;type=Pendaftaran" Text="Cetak" Target="_blank">
                                    </PropertiesHyperLinkEdit>
                                </dx:GridViewDataHyperLinkColumn>
            </Columns>
            <SettingsPager Visible="False">
            </SettingsPager>
            <SettingsDataSecurity AllowDelete="False" AllowEdit="False" AllowInsert="False" />
            </dx:ASPxGridView>
        <br />
        <dx:ASPxLabel ID="lblError" runat="server" Text="" CssClass="text-error">
        </dx:ASPxLabel>
            <dx:ASPxButton ID="btnRegister" CssClass="btn btn-primary" runat="server" Text="Daftar" ClientVisible="false" Theme="BlackGlass"></dx:ASPxButton>
            </div>
    </div>
</asp:Content>
