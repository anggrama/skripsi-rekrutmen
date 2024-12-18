﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Administrator/MainAdministrator.master" AutoEventWireup="true" CodeBehind="RekapData.aspx.cs" Inherits="RekrutmenTNI.Admin.RekapDataAnimo" %>

<%@ Register Assembly="DevExpress.Web.v23.2, Version=23.2.3.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web" TagPrefix="dx" %>

<%@ Register TagPrefix="uc" TagName="ucFilter" Src="~/Administrator/ucFilter.ascx" %>


<asp:Content ID="Content1" ContentPlaceHolderID="contentHead" runat="server">
   
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="contentForm" runat="server">
    <uc:ucFilter ID="ucFilter" runat="server" />
    <br />
    <dx:ASPxCallbackPanel ID="callData" runat="server" Width="100%" OnCallback="callData_Callback" ClientInstanceName="callData">
    <PanelCollection>
        <dx:PanelContent runat="server">
    <h2>Rekap Data</h2>
    <table width="100%">
        <tr>
            <td width="20%">
                <dx:ASPxRadioButtonList ID="radioList" runat="server" ClientInstanceName="radioList" Theme="BlackGlass">
                    <ClientSideEvents SelectedIndexChanged="function(s, e) {
	callbackgv.PerformCallback(radioList.GetValue().toString());
}" />
                    <Items>
                        <dx:ListEditItem Text="Suku Bangsa" Value="Suku" />
                        <dx:ListEditItem Text="Tahun Lulus" Value="TahunLulusSMA" />
                        <dx:ListEditItem Text="Pendidikan" Value="Pendidikan" />
                        <dx:ListEditItem Text="Tinggi Badan" Value="TinggiBadan" />
                        <dx:ListEditItem Text="Agama" Value="Agama" />
                    </Items>
                </dx:ASPxRadioButtonList>
            </td>
            <td style="vertical-align:top;width:auto">
                        <dx:ASPxCallbackPanel ID="callbackgv" runat="server" Width="100%" ClientInstanceName="callbackgv" OnCallback="callbackgv_Callback">
                            <PanelCollection>
<dx:PanelContent runat="server">
    <dx:ASPxGridView ID="gvAnimo" runat="server" AutoGenerateColumns="False" ClientInstanceName="gvAnimo" Theme="BlackGlass" Width="100%">
        <Columns>
            <dx:GridViewDataTextColumn Caption="[clmParameter]" FieldName="Parameter" Name="clmParameter" ShowInCustomizationForm="True" VisibleIndex="0" UnboundType="String">
            </dx:GridViewDataTextColumn>
            <dx:GridViewDataTextColumn Caption="Animo" FieldName="Animo" Name="clmAnimo" ShowInCustomizationForm="True" VisibleIndex="1">
            </dx:GridViewDataTextColumn>
            <dx:GridViewDataTextColumn Caption="Peserta" FieldName="Peserta" Name="clmPeserta" ShowInCustomizationForm="True" VisibleIndex="2">
            </dx:GridViewDataTextColumn>
            <dx:GridViewDataTextColumn Caption="Lulus Pusat" FieldName="LulusPusat" Name="clmLulusPusat" ShowInCustomizationForm="True" VisibleIndex="4">
            </dx:GridViewDataTextColumn>
            <dx:GridViewDataTextColumn Caption="Lulus Daerah" FieldName="LulusDaerah" Name="clmLulusDaerah" ShowInCustomizationForm="True" VisibleIndex="3">
            </dx:GridViewDataTextColumn>
        </Columns>
        <SettingsPager Visible="False" Mode="ShowAllRecords">
        </SettingsPager>
        <SettingsDataSecurity AllowDelete="False" AllowEdit="False" AllowInsert="False" />
    </dx:ASPxGridView>
                                </dx:PanelContent>
</PanelCollection>
        </dx:ASPxCallbackPanel>
            </td>
        </tr>
    </table>
    <dx:ASPxLabel ID="lblError" runat="server" CssClass="text-error"></dx:ASPxLabel>
            </dx:PanelContent>
        </PanelCollection>
    </dx:ASPxCallbackPanel>
</asp:Content>