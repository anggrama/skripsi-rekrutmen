<%@ Page Title="" Language="C#" MasterPageFile="~/Administrator/MainAdministrator.Master" AutoEventWireup="true" CodeBehind="Seleksi.aspx.cs" Inherits="RekrutmenTNI.Admin.Seleksi" %>
<%@ Register TagPrefix="uc" TagName="ucFilter" Src="~/Administrator/ucFilter.ascx" %>
<%@ Register assembly="DevExpress.Web.v23.2, Version=23.2.3.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web" tagprefix="dx" %>
<asp:Content ID="Content1" ContentPlaceHolderID="contentHead" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="contentForm" runat="server">
    <uc:ucFilter ID="ucFilter" runat="server" />
    <br />
    <dx:ASPxCallbackPanel ID="callData" runat="server" Width="100%" OnCallback="callData_Callback" ClientInstanceName="callData">
    <PanelCollection>
        <dx:PanelContent runat="server">
    <h2>Seleksi Pusat <asp:Literal ID="litPangkat" runat="server"></asp:Literal></h2>
    <dx:ASPxLabel ID="lblError" runat="server" CssClass="text-error"></dx:ASPxLabel>
        <dx:ASPxGridView ID="gvNilai" runat="server" AutoGenerateColumns="False" ClientInstanceName="gvNilai" EnableTheming="True" Theme="BlackGlass" Width="100%" KeyFieldName="NoPeserta">
            <Columns>
                <dx:GridViewDataTextColumn Caption="No Peserta" Name="clmNoPeserta" VisibleIndex="1" Width="10%" FieldName="NoPeserta">
                </dx:GridViewDataTextColumn>
                <dx:GridViewDataTextColumn Caption="Nama" Name="clmNama" VisibleIndex="2" Width="20%" FieldName="Nama">
                </dx:GridViewDataTextColumn>
                <dx:GridViewDataTextColumn Caption="Adm" Name="clmAdm1" VisibleIndex="3" Width="6%" FieldName="AdmPus"> 
                </dx:GridViewDataTextColumn>
                <dx:GridViewDataTextColumn Caption="Kes" VisibleIndex="4" Width="6%"  FieldName="KesPus">   
                </dx:GridViewDataTextColumn>
                <dx:GridViewDataTextColumn Caption="Jasmani" VisibleIndex="5" Width="6%" FieldName="JasPus">
                </dx:GridViewDataTextColumn>
                <dx:GridViewDataTextColumn Caption="Litpers" VisibleIndex="6" Width="6%"  FieldName="LitPus">  
                </dx:GridViewDataTextColumn>
                <dx:GridViewDataTextColumn Caption="POM" VisibleIndex="7" Width="6%"  FieldName="POMPus">
                </dx:GridViewDataTextColumn>
                <dx:GridViewDataTextColumn Caption="Psi" VisibleIndex="8" Width="6%" FieldName="PsiPus"> 
                </dx:GridViewDataTextColumn>
                <dx:GridViewDataTextColumn Caption="Pantukhirpus" VisibleIndex="12" Width="6%"  FieldName="Pantukhirpus">
                </dx:GridViewDataTextColumn>
            </Columns>
            <SettingsPager Mode="ShowAllRecords" Visible="False">
            </SettingsPager>
            <SettingsDataSecurity AllowDelete="False" AllowEdit="False" AllowInsert="False" />
        </dx:ASPxGridView>
            </dx:PanelContent>
        </PanelCollection>
    </dx:ASPxCallbackPanel>
    </asp:Content>
