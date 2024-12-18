﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Administrator/MainAdministrator.master" AutoEventWireup="true" CodeBehind="DataPeserta.aspx.cs" Inherits="RekrutmenTNI.Admin.DataAnimo" %>

<%@ Register TagPrefix="uc" TagName="ucFilter" Src="~/Administrator/ucFilter.ascx" %>
<%@ Register Assembly="DevExpress.Web.v23.2, Version=23.2.3.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web" TagPrefix="dx" %>

<asp:Content ID="Content1" ContentPlaceHolderID="contentHead" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="contentForm" runat="server">
    <uc:ucFilter ID="ucFilter" runat="server" />
    <br />
    <dx:ASPxCallbackPanel ID="callData" runat="server" Width="100%" OnCallback="callData_Callback" ClientInstanceName="callData">
        <PanelCollection>
            <dx:PanelContent runat="server">
                <h2>Daftar
                    <asp:Label ID="lblJenisData" runat="server" Text=""></asp:Label>
                    <asp:Label ID="lblPangkat" runat="server" Text=""></asp:Label></h2>
                <div class="box1">
                    <div class="fillpadding">
                        <dx:ASPxButton ID="btnDownload" runat="server" CssClass="btn btn-primary btn-small" Text="Download Data" OnClick="btnDownload_Click" Theme="BlackGlass"></dx:ASPxButton>
                        <br />
                        <dx:ASPxLabel ID="lblError" runat="server" Text="" CssClass="text-error"></dx:ASPxLabel>
                        <br />
                        <dx:ASPxGridView ID="gvAnimo" runat="server" AutoGenerateColumns="False" ClientInstanceName="gvAnimo" Theme="BlackGlass" Width="99%" OnDataBinding="gvAnimo_DataBinding">
                            <Columns>
                                <dx:GridViewCommandColumn ShowClearFilterButton="True" VisibleIndex="0">
                                </dx:GridViewCommandColumn>
                                <dx:GridViewDataTextColumn Caption="No Animo" Name="clmNoAnimo" VisibleIndex="1" FieldName="NoAnimo" Width="100px">
                                </dx:GridViewDataTextColumn>
                                <dx:GridViewDataTextColumn Caption="No Peserta" Name="clmNoPeserta" VisibleIndex="2" FieldName="NoPeserta" Width="100px">
                                </dx:GridViewDataTextColumn>
                                <dx:GridViewDataTextColumn Caption="Nama Lengkap" Name="clmNamaLengkap" VisibleIndex="3" FieldName="Nama">
                                </dx:GridViewDataTextColumn>
                                <dx:GridViewDataTextColumn Caption="TB" Name="clmTinggiBadan" VisibleIndex="4" FieldName="TinggiBadan" Width="50px">
                                </dx:GridViewDataTextColumn>
                                <dx:GridViewDataTextColumn Caption="BB" Name="clmBeratBadan" VisibleIndex="5" FieldName="BeratBadan" Width="50px">
                                </dx:GridViewDataTextColumn>
                                <dx:GridViewDataTextColumn Caption="Thn Lulus" Name="clmTahunLulus" VisibleIndex="6" FieldName="TahunLulus" Width="50px">
                                </dx:GridViewDataTextColumn>
                                <dx:GridViewDataTextColumn Caption="Nilai UN" Name="clmNilaiUN" VisibleIndex="7" FieldName="NilaiUN" Width="50px">
                                </dx:GridViewDataTextColumn>
                                <dx:GridViewDataHyperLinkColumn Caption="Detail" FieldName="NoAnimo" Name="clmAksi" VisibleIndex="8">
                                    <PropertiesHyperLinkEdit NavigateUrlFormatString="~/Administrator/DataProfil.aspx?ida={0}" Text="Lihat">
                                    </PropertiesHyperLinkEdit>
                                </dx:GridViewDataHyperLinkColumn>
                                <dx:GridViewDataHyperLinkColumn Caption="Kartu" FieldName="NoAnimo" Name="clmPrint" VisibleIndex="9">
                                    <PropertiesHyperLinkEdit NavigateUrlFormatString="~/ReportViewer.aspx?id={0}&amp;type=Surat" Text="Cetak" Target="_blank">
                                    </PropertiesHyperLinkEdit>
                                    <DataItemTemplate>
                                        <dx:ASPxHyperLink ID="hypCetak" runat="server" Text="Cetak Kartu" NavigateUrl='<%# Eval("NoAnimo","~/ReportViewer.aspx?id={0}&type=Surat") %>' Target="_blank" EnableTheming="True" Theme="Default">
                                            <ClientSideEvents Click="function(s, e) {
	callData.PerformCallback('load');
}" />
                                        </dx:ASPxHyperLink>
                                    </DataItemTemplate>
                                </dx:GridViewDataHyperLinkColumn>
                            </Columns>
                            <SettingsPager AlwaysShowPager="True" PageSize="50" Position="TopAndBottom">
                            </SettingsPager>
                            <Settings ShowFilterRow="True" />
                            <SettingsDataSecurity AllowDelete="False" AllowEdit="False" AllowInsert="False" />
                        </dx:ASPxGridView>
                    </div>
                </div>
            </dx:PanelContent>
        </PanelCollection>
    </dx:ASPxCallbackPanel>
</asp:Content>

