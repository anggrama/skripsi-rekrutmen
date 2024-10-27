<%@ Page Title="" Language="C#" MasterPageFile="~/Administrator/MainAdministrator.Master" AutoEventWireup="true" CodeBehind="MainAdm.aspx.cs" Inherits="RekrutmenTNI.Admin.MainAdm" %>

<%@ Register TagPrefix="uc" TagName="ucFilter" Src="~/Administrator/ucFilter.ascx" %>
<%@ Register Assembly="DevExpress.Web.v23.2, Version=23.2.3.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web" TagPrefix="dx" %>


<asp:Content ID="Content1" ContentPlaceHolderID="contentHead" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="contentForm" runat="server">
    <uc:ucFilter ID="ucFilter" runat="server" />
    <br />
    <dx:ASPxCallbackPanel ID="callData" runat="server" Width="100%" ClientInstanceName="callData" OnCallback="callData_Callback">
        <PanelCollection>
            <dx:PanelContent runat="server">
                <h2>Statistik Wilayah</h2>
                <table>
                    <tr>
                        <td>Total Animo</td>
                        <td>:</td>
                        <td>
                            <dx:ASPxLabel ID="lblTotAnimo" runat="server" Text="[lblTotAnimo]"></dx:ASPxLabel>
                            orang / Laki-laki :  <dx:ASPxLabel ID="lblTotAnimoL" runat="server" Text="[lblTotNasAnimo]" /> orang
                            / Perempuan : <dx:ASPxLabel ID="lblTotAnimoP" runat="server" Text="[lblTotNasAnimo]" /> orang
                            (nasional:<dx:ASPxLabel ID="lblTotNasAnimo" runat="server" Text="[lblTotNasAnimo]" />
                            orang)</td>
                    </tr>
                    <tr>
                        <td>Total Peserta</td>
                        <td>:</td>
                        <td>
                            <dx:ASPxLabel ID="lblTotPeserta" runat="server" Text="[lblTotPeserta]"></dx:ASPxLabel>
                            orang / Laki-laki : <dx:ASPxLabel ID="lblTotPesertaL" runat="server" Text="[lblTotNasPeserta]" /> orang 
                            / Perempuan : <dx:ASPxLabel ID="lblTotPesertaP" runat="server" Text="[lblTotNasPeserta]" /> orang  (nasional:<dx:ASPxLabel ID="lblTotNasPeserta" runat="server" Text="[lblTotNasPeserta]" />
                            orang)</td>
                    </tr>
                    <tr>
                        <td>Total Lulus Daerah</td>
                        <td>:</td>
                        <td>
                            <dx:ASPxLabel ID="lblTotLulusDaerah" runat="server" Text="[lblTotLulusDaerah]"></dx:ASPxLabel>
                            orang (nasional:<dx:ASPxLabel ID="lblTotNasLulusDaerah" runat="server" Text="[lblTotNasLulusDaerah]"></dx:ASPxLabel>
                            orang)</td>
                    </tr>
                    <tr>
                        <td>Total Lulus Peserta</td>
                        <td>:</td>
                        <td>
                            <dx:ASPxLabel ID="lblTotLulusPeserta" runat="server" Text="[lblTotLulusPeserta]"></dx:ASPxLabel>
                            orang (nasional:<dx:ASPxLabel ID="lblTotNasLulusPeserta" runat="server" Text="[lblTotNasLulusPeserta]"></dx:ASPxLabel>
                            orang)</td>
                    </tr>
                </table>
                <br />
                <h2>Statistik Nasional Per Panda</h2>
                <dx:ASPxGridView ID="gvStats" runat="server" AutoGenerateColumns="False" ClientInstanceName="gvStats" Theme="BlackGlass" Width="100%" OnDataBinding="gvStats_DataBinding">
                    <Columns>
                        <dx:GridViewDataTextColumn Caption="Kode Panda" Name="clmKodePanda" VisibleIndex="0" FieldName="PandaId">
                        </dx:GridViewDataTextColumn>
                        <dx:GridViewDataTextColumn Caption="Nama Panda" VisibleIndex="1" FieldName="WilayahName" CellStyle-CssClass="hidden-phone" HeaderStyle-CssClass="hidden-phone" FilterCellStyle-CssClass="hidden-phone">
                        </dx:GridViewDataTextColumn>
                        <dx:GridViewDataTextColumn Caption="Animo" VisibleIndex="2" FieldName="Animo" CellStyle-HorizontalAlign="Center">
                        </dx:GridViewDataTextColumn>
                        <dx:GridViewDataTextColumn Caption="(A) L" VisibleIndex="3" FieldName="AnimoL"  CellStyle-HorizontalAlign="Center">
                        </dx:GridViewDataTextColumn>
                        <dx:GridViewDataTextColumn Caption="(A) P" VisibleIndex="4" FieldName="AnimoP"  CellStyle-HorizontalAlign="Center">
                        </dx:GridViewDataTextColumn>
                        <dx:GridViewDataTextColumn Caption="Peserta" VisibleIndex="5" FieldName="Peserta"  CellStyle-HorizontalAlign="Center">
                        </dx:GridViewDataTextColumn>
                         <dx:GridViewDataTextColumn Caption="(P) L" VisibleIndex="6" FieldName="PesertaL"  CellStyle-HorizontalAlign="Center">
                        </dx:GridViewDataTextColumn>
                         <dx:GridViewDataTextColumn Caption="(P) P" VisibleIndex="7" FieldName="PesertaP"  CellStyle-HorizontalAlign="Center">
                        </dx:GridViewDataTextColumn>
                        <dx:GridViewDataTextColumn Caption="Lulus Daerah" VisibleIndex="8" FieldName="LulusD"  CellStyle-HorizontalAlign="Center">
                        </dx:GridViewDataTextColumn>
                         <dx:GridViewDataTextColumn Caption="(LD) L" VisibleIndex="9" FieldName="LulusDL"  CellStyle-HorizontalAlign="Center">
                        </dx:GridViewDataTextColumn>
                         <dx:GridViewDataTextColumn Caption="(LD) P" VisibleIndex="10" FieldName="LulusDP"  CellStyle-HorizontalAlign="Center">
                        </dx:GridViewDataTextColumn>
                        <dx:GridViewDataTextColumn Caption="Lulus Pusat" VisibleIndex="11" FieldName="LulusP"  CellStyle-HorizontalAlign="Center">
                        </dx:GridViewDataTextColumn>
                         <dx:GridViewDataTextColumn Caption="(LP) L" VisibleIndex="12" FieldName="LulusPL"  CellStyle-HorizontalAlign="Center">
                        </dx:GridViewDataTextColumn>
                         <dx:GridViewDataTextColumn Caption="(LP) P" VisibleIndex="13" FieldName="LulusPP"  CellStyle-HorizontalAlign="Center">
                        </dx:GridViewDataTextColumn>
                    </Columns>
                    <SettingsPager Visible="False" Mode="ShowAllRecords">
                    </SettingsPager>
                    <Settings ShowFilterRow="True" />
                    <SettingsDataSecurity AllowDelete="False" AllowEdit="False" AllowInsert="False" />
                </dx:ASPxGridView>
            </dx:PanelContent>
        </PanelCollection>
    </dx:ASPxCallbackPanel>

</asp:Content>
