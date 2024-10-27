<%@ Page Title="" Language="C#" MasterPageFile="~/Administrator/MainAdministrator.master" AutoEventWireup="true" CodeBehind="Panda.aspx.cs" Inherits="RekrutmenTNI.Admin.Panda" %>

<%@ Register Assembly="DevExpress.Web.v23.2, Version=23.2.3.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web" TagPrefix="dx" %>

<asp:Content ID="Content1" ContentPlaceHolderID="contentHead" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="contentForm" runat="server">
    <br />
    <h1>Master Panda</h1>
    <div class="box1 pad_left20 pad_right20">
    <dx:ASPxGridView ID="gvPanda" runat="server" AutoGenerateColumns="False" Theme="BlackGlass" KeyFieldName="WilayahId" OnRowInserting="gvPanda_RowInserting" OnRowUpdating="gvPanda_RowUpdating" ClientInstanceName="gvPanda" Width="100%">
        <Columns>
            <dx:GridViewCommandColumn ShowEditButton="True" ShowNewButtonInHeader="True" VisibleIndex="0" Width="50px">
            </dx:GridViewCommandColumn>
            <dx:GridViewDataTextColumn Caption="Kode Panda" FieldName="WilayahId" VisibleIndex="2" Name="clmWilayahId"  Width="50px">
            </dx:GridViewDataTextColumn>
            <dx:GridViewDataTextColumn Caption="Nama Panda" FieldName="WilayahName" VisibleIndex="3">
            </dx:GridViewDataTextColumn>
            <dx:GridViewDataCheckColumn Caption="Taruna" FieldName="IsTaruna" VisibleIndex="4"   Width="40px">
                <EditFormSettings ColumnSpan="2" />
                <HeaderStyle HorizontalAlign="Center" />
            </dx:GridViewDataCheckColumn>
            <dx:GridViewDataCheckColumn Caption="Bintara" FieldName="IsBintara" VisibleIndex="7"  Width="40px">
                <EditFormSettings ColumnSpan="2" />
                <HeaderStyle HorizontalAlign="Center" />
            </dx:GridViewDataCheckColumn>
            <dx:GridViewDataCheckColumn Caption="Tamtama" FieldName="IsTamtama" VisibleIndex="10"  Width="40px">
                <EditFormSettings ColumnSpan="2" />
                <HeaderStyle HorizontalAlign="Center" />
            </dx:GridViewDataCheckColumn>
            <dx:GridViewDataCheckColumn Caption="Aktif" Name="IsActive" VisibleIndex="13" FieldName="IsActive" Width="40px">
            </dx:GridViewDataCheckColumn>
            <dx:GridViewDataCheckColumn Caption="L" FieldName="IsLakiTaruna" VisibleIndex="5" Width="40px">
                <EditFormSettings Caption="Laki - laki Taruna" />
                <HeaderStyle HorizontalAlign="Center" />
            </dx:GridViewDataCheckColumn>
            <dx:GridViewDataCheckColumn Caption="P" FieldName="IsPerempuanTaruna" VisibleIndex="6" Width="40px">
                <EditFormSettings Caption="Perempuan Taruna" />
                <HeaderStyle HorizontalAlign="Center" />
            </dx:GridViewDataCheckColumn>
            <dx:GridViewDataTextColumn Caption="Kotama" FieldName="Kotama" VisibleIndex="1">
                <PropertiesTextEdit EnableFocusedStyle="False">
                </PropertiesTextEdit>
            </dx:GridViewDataTextColumn>
            <dx:GridViewDataCheckColumn Caption="L" FieldName="IsLakiBintara" VisibleIndex="8" Width="40px">
                <EditFormSettings Caption="Laki - laki Bintara" />
                <HeaderStyle HorizontalAlign="Center" />
            </dx:GridViewDataCheckColumn>
            <dx:GridViewDataCheckColumn Caption="P" FieldName="IsPerempuanBintara" VisibleIndex="9" Width="40px">
                <EditFormSettings Caption="Perempuan Bintara" />
                <HeaderStyle HorizontalAlign="Center" />
            </dx:GridViewDataCheckColumn>
            <dx:GridViewDataCheckColumn Caption="L" FieldName="IsLakiTamtama" VisibleIndex="11" Width="40px">
                <EditFormSettings Caption="Laki - laki Tamtama" />
                <HeaderStyle HorizontalAlign="Center" />
            </dx:GridViewDataCheckColumn>
            <dx:GridViewDataCheckColumn Caption="P" FieldName="IsPerempuanTamtama" VisibleIndex="12" Width="40px">
                <EditFormSettings Caption="Perempuan Tamtama" />
                <HeaderStyle HorizontalAlign="Center" />
            </dx:GridViewDataCheckColumn>
        </Columns>
        <SettingsPager Visible="False" Mode="ShowAllRecords">
        </SettingsPager>
        <SettingsDataSecurity AllowDelete="False" />
    </dx:ASPxGridView>
        </div>
</asp:Content>
