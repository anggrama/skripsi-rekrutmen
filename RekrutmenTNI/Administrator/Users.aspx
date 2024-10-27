<%@ Page Title="" Language="C#" MasterPageFile="~/Administrator/MainAdministrator.master" AutoEventWireup="true" CodeBehind="Users.aspx.cs" Inherits="RekrutmenTNI.Admin.Users" %>

<%@ Register Assembly="DevExpress.Web.v23.2, Version=23.2.3.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web" TagPrefix="dx" %>

<%@ Register assembly="DevExpress.Web.v23.2, Version=23.2.3.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web" tagprefix="dx1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="contentHead" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="contentForm" runat="server">
    <br />
    <h1>Master Users</h1>
    <dx:ASPxHyperLink ID="hypNewUser" runat="server" Text="Buat User Baru" CssClass="btn btn-primary" ForeColor="White" NavigateUrl="~/Administrator/UsersDetail.aspx">
    </dx:ASPxHyperLink>
    <br />
    <br />
    <dx:ASPxGridView ID="gvUsers" runat="server" AutoGenerateColumns="False" Theme="BlackGlass" Width="100%" OnDataBinding="gvUsers_DataBinding">
        <Columns>
            <dx1:GridViewCommandColumn ShowClearFilterButton="True" VisibleIndex="0">
            </dx1:GridViewCommandColumn>
            <dx:GridViewDataTextColumn Caption="UserId" FieldName="UserId" Name="clmUserId" VisibleIndex="1">
            </dx:GridViewDataTextColumn>
            <dx:GridViewDataTextColumn Caption="Username" FieldName="UserName" Name="clmUserName" VisibleIndex="2">
            </dx:GridViewDataTextColumn>
            <dx:GridViewDataTextColumn Caption="Password" FieldName="Pass" Name="clmPassword" VisibleIndex="3" Visible="False">
            </dx:GridViewDataTextColumn>
            <dx:GridViewDataCheckColumn Caption="IsActive" FieldName="IsActive" Name="clmIsActive" VisibleIndex="6">
            </dx:GridViewDataCheckColumn>
            <dx:GridViewDataComboBoxColumn Caption="UserRole" FieldName="UserRole" Name="clmUserRole" VisibleIndex="4">
            </dx:GridViewDataComboBoxColumn>
            <dx:GridViewDataComboBoxColumn Caption="Panda" FieldName="PandaId" Name="clmPandaId" VisibleIndex="5">
            </dx:GridViewDataComboBoxColumn>
            <dx:GridViewDataHyperLinkColumn Caption="Aksi" Name="clmEdit" VisibleIndex="7">
                <DataItemTemplate>
                    <dx:ASPxHyperLink ID="hypEdit" runat="server" NavigateUrl='<%#Eval("UserId","~/Administrator/UsersDetail.aspx?id={0}") %>' Text="Edit" />
                </DataItemTemplate>
            </dx:GridViewDataHyperLinkColumn>
        </Columns>
        <SettingsPager PageSize="30" Position="TopAndBottom">
        </SettingsPager>
        <Settings ShowFilterRow="True" />
        <SettingsDataSecurity AllowDelete="False" AllowEdit="False" AllowInsert="False" />
    </dx:ASPxGridView>
</asp:Content>


