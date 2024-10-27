<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ucFilterPangkat.ascx.cs" Inherits="RekrutmenTNI.Administrator.ucFilterPangkat" %>
<%@ Register Assembly="DevExpress.Web.v23.2, Version=23.2.3.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web" TagPrefix="dx" %>

<div id="filterPanel" runat="server">
    <h2>
        <asp:Literal ID="litFilter" runat="server"></asp:Literal></h2>
    <div class="box1">
        <div class="fillpadding">
                        <div class="row">
                            <div class="span4" style="text-align:center;vertical-align:central">
                                <dx:ASPxRadioButtonList ID="radPangkat" ClientInstanceName="radPangkat" runat="server" ValueType="System.String" RepeatDirection="Horizontal" Border-BorderStyle="None">
                                    <ClientSideEvents SelectedIndexChanged="function(s, e) {
                                        callData.PerformCallback(radPangkat.GetValue().toString());
                                        
}" />
                                    <Items>
                                        <dx:ListEditItem Text="Taruna" Value="Taruna" ImageUrl="../images/Letda_pdh_au.png" />
                                        <dx:ListEditItem Text="Bintara" Value="Bintara" ImageUrl="../images/Serda_pdh_au.png" Selected="True" />
                                        <dx:ListEditItem Text="Tamtama" Value="Tamtama" ImageUrl="../images/Prada_pdh_au.png" />
                                    </Items>

<Border BorderStyle="None"></Border>
                                </dx:ASPxRadioButtonList>
                            </div>
                            <div class="span1">
                                <div style="padding-top: 17px">
                                </div>
                            </div>
                        </div>
        </div>
    </div>
</div>
<dx:ASPxHiddenField ID="hfFilter" runat="server" ClientInstanceName="hfFilter"></dx:ASPxHiddenField>
