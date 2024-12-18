﻿<%@ Page Title="" Language="C#" MasterPageFile="~/MainDefault.Master" AutoEventWireup="true" CodeBehind="DataProfil.aspx.cs" Inherits="RekrutmenTNI.DataProfil" %>
<%@ Register TagPrefix="uc" TagName="DataProfil" Src="ucData.ascx" %>
<%@ Register Assembly="DevExpress.Web.v23.2, Version=23.2.3.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web" TagPrefix="dx" %>


<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="contentMain" runat="server">
    <h1>Profil Pendaftar</h1>
    <div class="box1">
      
        <asp:Panel ID="panelProfile" runat="server">
        <uc:DataProfil ID="ucDataProfil" runat="server" />
        </asp:Panel>

         <div class="row">
              <div class="span8">
                  <dx:ASPxLabel ID="lblError" Text="" runat="server" CssClass="text-error"></dx:ASPxLabel>
            </div>
             </div>
        <div class="row">
              <div class="span3">
                   <dx:ASPxButton ID="btnSimpan" Width="100%" runat="server" Text="Ya, Saya Yakin Ingin Menyimpan Data Ini" OnClick="btnSimpan_Click" CssClass="btn btn-primary" ValidationGroup="valSave">
                    </dx:ASPxButton>
            </div>
              <div class="span3">
                  <dx:ASPxButton ID="btnPrint" Width="100%"  runat="server" Text="Simpan & Cetak" CssClass="btn btn-danger" ValidationGroup="valSave" OnClick="btnPrint_Click">
                    </dx:ASPxButton>
            </div>
        </div>
    </div>
</asp:Content>
