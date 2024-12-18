﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Administrator/MainAdministrator.Master" AutoEventWireup="true" CodeBehind="InboxCreate.aspx.cs" Inherits="RekrutmenTNI.Admin.InboxCreate" %>

<%@ Register Assembly="DevExpress.Web.v23.2, Version=23.2.3.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web" TagPrefix="dx" %>
<%@ Register Assembly="DevExpress.Web.ASPxHtmlEditor.v23.2, Version=23.2.3.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web.ASPxHtmlEditor" TagPrefix="dx" %>
<%@ Register Assembly="DevExpress.Web.ASPxSpellChecker.v23.2, Version=23.2.3.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web.ASPxSpellChecker" TagPrefix="dx" %>
<asp:Content ID="Content1" ContentPlaceHolderID="contentHead" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="contentForm" runat="server">
    <h1>Pesan Baru</h1>
    <div class="box1 pad_left20 pad_right20">
        <div class="row">
            <div class="span8">
                <label>Judul Pesan : </label>
                <dx:ASPxTextBox ID="txtJudul" runat="server" Width="100%">
                </dx:ASPxTextBox>
            </div>
        </div>

        <div class="row">
            <div class="span6">
                <label>Dikirim Ke : </label>
                <dx:ASPxTokenBox ID="tokenTo" runat="server" Width="100%" ItemValueType="System.String" Theme="BlackGlass" ClientInstanceName="tokenTo"></dx:ASPxTokenBox>
            </div>
            <div class="span1">
                <label>&nbsp;</label>
                <dx:ASPxButton ID="btnSelectAll" runat="server" Text="Semua" CssClass="btn btn-primary btn-small" AutoPostBack="False">
                    <ClientSideEvents Click="function(s, e) {var itemCount = tokenTo.GetItemCount();for (var i = 0; i < itemCount; i++) {
        tokenTo.AddToken(tokenTo.GetItem(i).text);
    }}" />
                </dx:ASPxButton>
            </div>
            <div class="span1">
                <label>&nbsp;</label>
                <dx:ASPxButton ID="btnUnSelectAll" runat="server" Text="Bersih" CssClass="btn btn-warning btn-small" AutoPostBack="False">
                    <ClientSideEvents Click="function(s, e) {
	tokenTo.ClearTokenCollection();
}" />
                </dx:ASPxButton>
            </div>
        </div>
        <div class="row">
            <div class="span8">
                <dx:ASPxHtmlEditor ID="txtPesan" runat="server" Width="100%" Theme="BlackGlass">
                    <Toolbars>
                        <dx:HtmlEditorToolbar Name="Toolbar">
                            <Items>
                                <dx:ToolbarUndoButton>
                                </dx:ToolbarUndoButton>
                                <dx:ToolbarRedoButton>
                                </dx:ToolbarRedoButton>
                                <dx:ToolbarBoldButton BeginGroup="True">
                                </dx:ToolbarBoldButton>
                                <dx:ToolbarItalicButton>
                                </dx:ToolbarItalicButton>
                                <dx:ToolbarUnderlineButton>
                                </dx:ToolbarUnderlineButton>
                                <dx:ToolbarStrikethroughButton>
                                </dx:ToolbarStrikethroughButton>
                                <dx:ToolbarInsertLinkDialogButton BeginGroup="True">
                                </dx:ToolbarInsertLinkDialogButton>
                            </Items>
                        </dx:HtmlEditorToolbar>
                    </Toolbars>
                    <Settings AllowPreview="False" />
               </dx:ASPxHtmlEditor>
            </div>
        </div>
        <div class="row">
            <div class="span1">
                <label>Attachment</label>
            </div>
            <div class="span4">
                <dx:ASPxUploadControl ID="uploadInfo" ClientInstanceName="uploadInfo" runat="server" UploadMode="Auto" Width="280px" FileUploadMode="OnPageLoad" Theme="BlackGlass" ShowProgressPanel="True" OnFileUploadComplete="uploadInfo_FileUploadComplete">
                    <ClientSideEvents FilesUploadComplete="function(s, e) {
     showToast('Pesan berhasil dikirim.','success');
     setTimeout(function(){ window.location.replace('inbox.aspx'); }, 3000);
}" />
                    <AdvancedModeSettings EnableMultiSelect="True" TemporaryFolder="~\Administrator\Upload\Temp\" EnableFileList="True">
                        <FileListItemStyle CssClass="pending dxucFileListItem"></FileListItemStyle>
                    </AdvancedModeSettings>
                </dx:ASPxUploadControl>
            </div>
        <div class="span3">
            <div class="pull-right">
                <dx:ASPxButton ID="btnSend" runat="server" CssClass="btn btn-primary btn-small" Text="Kirim" Theme="BlackGlass" AutoPostBack="False">
                    <ClientSideEvents Click="function(s, e) {

                       var tokens = tokenTo.GetTokenCollection();
                         if (tokens.length == 0)
                            showToast('anda belum memasukan lanud','error');
                         else
                            callMessage.PerformCallback();
}" />
                </dx:ASPxButton>
            </div>

        </div>
        </div>
    </div>
    <dx:ASPxCallback ID="callMessage" runat="server" ClientInstanceName="callMessage" OnCallback="callMessage_Callback">
        <ClientSideEvents CallbackComplete="function(s, e) {
	var res = e.result.split(&quot;;&quot;); 
	if (res=='')
		return;
	
	hfMessage.Set('InfoId',s.cp_InfoId);
	
	if (res[1]=='success')
           if(uploadInfo.GetText() == '')
    {
            showToast(res[0],res[1]);
            setTimeout(function(){ window.location.replace('inbox.aspx'); }, 3000);
    }
         else
            uploadInfo.Upload();
            
       
}" />
    </dx:ASPxCallback>
    <dx:ASPxHiddenField ID="hfMessage" runat="server" ClientInstanceName="hfMessage">
    </dx:ASPxHiddenField>
    <br />
</asp:Content>
