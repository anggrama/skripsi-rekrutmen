<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ucFilter.ascx.cs" Inherits="RekrutmenTNI.Administrator.ucFilter" %>
<%@ Register Assembly="DevExpress.Web.v23.2, Version=23.2.3.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web" TagPrefix="dx" %>

<div id="filterPanel" runat="server">
    <h2>
        <asp:Literal ID="litFilter" runat="server"></asp:Literal></h2>
    <div class="box1">
        <div class="fillpadding">
            <dx:ASPxCallbackPanel ID="callFilter" runat="server" Width="100%" ClientInstanceName="callFilter" OnCallback="callFilter_Callback">
                <PanelCollection>
                    <dx:PanelContent runat="server">
                        <div class="row">
                            <div class="span4" style="text-align: center; vertical-align: central">
                                <dx:ASPxRadioButtonList ID="radPangkat" ClientInstanceName="radPangkat" runat="server" ValueType="System.String" RepeatDirection="Horizontal" Border-BorderStyle="None">
                                    <ClientSideEvents SelectedIndexChanged="function(s, e) {
	callFilter.PerformCallback('pangkat;' + radPangkat.GetValue().toString());
}" />
                                    <Items>
                                        <dx:ListEditItem Text="Taruna" Value="Taruna" ImageUrl="../images/Letda_pdh_au.png" />
                                        <dx:ListEditItem Text="Bintara" Value="Bintara" ImageUrl="../images/Serda_pdh_au.png" Selected="True" />
                                        <dx:ListEditItem Text="Tamtama" Value="Tamtama" ImageUrl="../images/Prada_pdh_au.png" />
                                    </Items>

                                    <Border BorderStyle="None"></Border>
                                </dx:ASPxRadioButtonList>
                            </div>
                            <div class="span1" style="vertical-align: central">
                                <label>Tahun:</label>
                                <dx:ASPxComboBox ID="cboTahun" runat="server" ClientInstanceName="cboTahun" Width="90px" Theme="BlackGlass" DropDownStyle="DropDown">

                                    <ClientSideEvents SelectedIndexChanged="function(s, e) {
	callFilter.PerformCallback('tahun;' + cboTahun.GetValue().toString());
}" />

                                </dx:ASPxComboBox>
                            </div>
                            <div class="span1"  style="vertical-align: central">
                                <label>Gelombang:</label>
                                <dx:ASPxComboBox ID="cboGelombang" runat="server" ClientInstanceName="cboGelombang" Width="90px" Theme="BlackGlass" DropDownStyle="DropDown">
                                </dx:ASPxComboBox>
                            </div>
                            <div class="span1"  style="vertical-align: central">
                                <label>&nbsp;</label>
                                    <dx:ASPxButton ID="btnLoad" runat="server" Text="Load" ClientInstanceName="btnLoad" CssClass="btn btn-primary btn-small" Theme="BlackGlass" AutoPostBack="False">
                                        <ClientSideEvents Click="function(s, e) {
    callData.PerformCallback('load');
}" />
                                    </dx:ASPxButton>
                            </div>
                        </div>
                    </dx:PanelContent>
                </PanelCollection>
            </dx:ASPxCallbackPanel>
        </div>
    </div>
</div>
<dx:ASPxHiddenField ID="hfFilter" runat="server" ClientInstanceName="hfFilter"></dx:ASPxHiddenField>
