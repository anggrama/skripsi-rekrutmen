<%@ Page Title="" Language="C#" MasterPageFile="~/Administrator/MainAdministrator.master" AutoEventWireup="true" CodeBehind="Gelombang.aspx.cs" Inherits="RekrutmenTNI.Admin.Gelombang" %>

<%@ Register TagPrefix="uc" TagName="ucFilter" Src="~/Administrator/ucFilterPangkat.ascx" %>
<%@ Register Assembly="DevExpress.Web.v23.2, Version=23.2.3.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web" TagPrefix="dx" %>

<asp:Content ID="Content1" ContentPlaceHolderID="contentHead" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="contentForm" runat="server">
    <uc:ucFilter ID="ucFilter" runat="server" />
    <br />
    <dx:ASPxCallbackPanel ID="callData" runat="server" Width="100%" OnCallback="callData_Callback" ClientInstanceName="callData">
        <PanelCollection>
            <dx:PanelContent runat="server">
                <h2>Gelombang
                    <asp:Literal ID="litPangkat" runat="server" Text=""></asp:Literal></h2>
                <dx:ASPxGridView ID="gvGelombang" runat="server" AutoGenerateColumns="False" EnableTheming="True" Theme="BlackGlass" Width="100%" KeyFieldName="GelombangID" OnRowInserting="gvGelombang_RowInserting" OnRowUpdating="gvGelombang_RowUpdating" OnDataBinding="gvGelombang_DataBinding">
                    <Columns>
                        <dx:GridViewCommandColumn ShowEditButton="True" ShowNewButtonInHeader="True" VisibleIndex="0">
                        </dx:GridViewCommandColumn>
                        <dx:GridViewDataTextColumn Caption="Gelombang Ke" FieldName="GelombangKe" VisibleIndex="1">
                        </dx:GridViewDataTextColumn>
                        <dx:GridViewDataTextColumn Caption="Tahun Pendaftaran" FieldName="TahunPendaftaran" VisibleIndex="2">
                        </dx:GridViewDataTextColumn>
                        <dx:GridViewDataDateColumn Caption="Dari Tanggal" FieldName="RangeFrom" VisibleIndex="3">
                            <PropertiesDateEdit DisplayFormatString="dd-MM-yyyy" DisplayFormatInEditMode="True">
                            </PropertiesDateEdit>
                        </dx:GridViewDataDateColumn>
                        <dx:GridViewDataDateColumn Caption="Sampai Tanggal" FieldName="RangeTo" VisibleIndex="4">
                            <PropertiesDateEdit DisplayFormatString="dd-MM-yyyy" DisplayFormatInEditMode="True">
                            </PropertiesDateEdit>
                        </dx:GridViewDataDateColumn>
                        <dx:GridViewDataTextColumn Caption="GelombangID" FieldName="GelombangID" Name="clmGelombangId" Visible="False" VisibleIndex="8">
                        </dx:GridViewDataTextColumn>
                        <dx:GridViewDataCheckColumn Caption="IsActive" FieldName="IsActive" VisibleIndex="7">
                        </dx:GridViewDataCheckColumn>
                        <dx:GridViewDataDateColumn Caption="Lahir dari Tanggal" FieldName="BornFrom" VisibleIndex="5">
                            <PropertiesDateEdit DisplayFormatString="dd-MM-yyyy" DisplayFormatInEditMode="True">
                            </PropertiesDateEdit>
                        </dx:GridViewDataDateColumn>
                        <dx:GridViewDataDateColumn Caption="Lahir sampai Tanggal" FieldName="BornTo" VisibleIndex="6">
                            <PropertiesDateEdit DisplayFormatString="dd-MM-yyyy" DisplayFormatInEditMode="True">
                            </PropertiesDateEdit>
                        </dx:GridViewDataDateColumn>
                    </Columns>
                    <SettingsPager Visible="False">
                    </SettingsPager>
                    <SettingsDataSecurity AllowDelete="False" />
                </dx:ASPxGridView>
            </dx:PanelContent>
        </PanelCollection>
    </dx:ASPxCallbackPanel>
</asp:Content>
