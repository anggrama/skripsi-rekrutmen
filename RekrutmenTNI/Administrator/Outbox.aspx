﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Administrator/MainAdministrator.Master" AutoEventWireup="true" CodeBehind="Outbox.aspx.cs" Inherits="RekrutmenTNI.Admin.Outbox" %>
<%@ Register Assembly="DevExpress.Web.v23.2, Version=23.2.3.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web" TagPrefix="dx" %>
<asp:Content ID="Content1" ContentPlaceHolderID="contentHead" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="contentForm" runat="server">
       <br />
    <h1>Outbox</h1>
    <div class="box1 pad_left20 pad_right20">
       
    <dx:ASPxGridView ID="gvMessage" runat="server" AutoGenerateColumns="False" EnableTheming="True" Theme="BlackGlass" Width="100%" KeyFieldName="InfoId" OnDataBinding="gvMessage_DataBinding">
        <ClientSideEvents RowClick="function(s, e) {
window.location =&quot;inboxread.aspx?rt=out&amp;infoid=&quot; + s.GetRowKey(e.visibleIndex)
;
}" />
        <Columns>
            <dx:GridViewDataTextColumn Caption="Judul" VisibleIndex="2" FieldName="Judul">
                <PropertiesTextEdit EncodeHtml="False">
                </PropertiesTextEdit>
            </dx:GridViewDataTextColumn>
            <dx:GridViewDataTextColumn Caption="Dibuat Oleh" VisibleIndex="6" FieldName="CreatedBy" Name="clmCreatedBy">
            </dx:GridViewDataTextColumn>
            <dx:GridViewDataTextColumn Caption="InfoId" FieldName="InfoId" Visible="False" VisibleIndex="1">
            </dx:GridViewDataTextColumn>
            <dx:GridViewCommandColumn ShowDeleteButton="True" VisibleIndex="0" Name="clmCommand">
            </dx:GridViewCommandColumn>
            <dx:GridViewDataTextColumn Caption="Untuk" FieldName="ToPanda" VisibleIndex="5" Name="clmToPanda">
            </dx:GridViewDataTextColumn>
            <dx:GridViewDataDateColumn Caption="Tanggal" FieldName="CreatedDate" VisibleIndex="3">
                <PropertiesDateEdit DisplayFormatString="dd-MM-yyyy HH:mm:ss">
                </PropertiesDateEdit>
            </dx:GridViewDataDateColumn>
        </Columns>
        <SettingsBehavior AllowGroup="False" AllowSelectByRowClick="True" AllowSelectSingleRowOnly="True" ConfirmDelete="True" EnableRowHotTrack="True" />
        <SettingsPager NumericButtonCount="100" Mode="ShowAllRecords">
        </SettingsPager>
        <SettingsDataSecurity AllowEdit="False" AllowInsert="False" />
    </dx:ASPxGridView>
        </div>

</asp:Content>
