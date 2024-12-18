﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Administrator/MainAdministrator.master" AutoEventWireup="true" CodeBehind="Nilai.aspx.cs" Inherits="RekrutmenTNI.Admin.Nilai" %>

<%@ Register TagPrefix="uc" TagName="ucFilter" Src="~/Administrator/ucFilter.ascx" %>
<%@ Register Assembly="DevExpress.Web.v23.2, Version=23.2.3.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web" TagPrefix="dx" %>

<asp:Content ID="Content1" ContentPlaceHolderID="contentHead" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="contentForm" runat="server">
    <uc:ucFilter ID="ucFilter" runat="server" />
    <br />
    <div>
            <label>Pilih Data Berdasarkan : </label>
            <dx:ASPxComboBox ID="cboJenisNilai" runat="server"></dx:ASPxComboBox>
    </div>
    <br />
    <dx:ASPxCallbackPanel ID="callData" runat="server" Width="100%" OnCallback="callData_Callback" ClientInstanceName="callData">
        <PanelCollection>
            <dx:PanelContent runat="server">
                <h2>Upload Nilai
                    <asp:Literal ID="litWilayah" runat="server"></asp:Literal></h2>
                <div class="box1 pad_left20 pad_right20"  id="boxLanud" runat="server" visible="false">
                    <dx:ASPxGridView ID="gvNilai" runat="server" AutoGenerateColumns="False" ClientInstanceName="gvNilai" EnableTheming="True" Theme="BlackGlass" Width="100%" KeyFieldName="NoPeserta" OnDataBinding="gvNilai_DataBinding">
                        <Columns>
                            <dx:GridViewDataTextColumn Caption="No Peserta" Name="clmNoPeserta" VisibleIndex="1" Width="10%" FieldName="NoPeserta">
                            </dx:GridViewDataTextColumn>
                            <dx:GridViewDataTextColumn Caption="Nama" Name="clmNama" VisibleIndex="2" Width="20%" FieldName="Nama">
                                <FooterTemplate>
                                    <dx:ASPxButton ID="btnDownload" runat="server" AutoPostBack="False" Text="Download Peserta" OnClick="btnDownload_Click">
                                    </dx:ASPxButton>
                                </FooterTemplate>
                            </dx:GridViewDataTextColumn>
                            <dx:GridViewDataTextColumn Caption="Adm1" Name="clmAdm1" VisibleIndex="3" Width="6%" FieldName="Adm1">
                                <FooterTemplate>
                                    <dx:ASPxButton ID="btnUploadAdm1" runat="server" AutoPostBack="False" Image-Url="../images/upload.png" Image-Height="16px" Image-Width="16px">
                                        <ClientSideEvents Click="function(s, e) {
	popUpUpload.Show();
    hfUploadType.Set('upType','Adm1');
    
}" />
                                        <Image Height="16px" Url="../images/upload.png" Width="16px">
                                        </Image>
                                    </dx:ASPxButton>
                                </FooterTemplate>
                            </dx:GridViewDataTextColumn>
                            <dx:GridViewDataTextColumn Caption="Kes1" VisibleIndex="4" Width="6%" FieldName="Kes1">
                                <FooterTemplate>
                                    <dx:ASPxButton ID="btnUploadKes1" runat="server" AutoPostBack="False" Text="" Image-Url="../images/upload.png" Image-Height="16px" Image-Width="16px">
                                        <ClientSideEvents Click="function(s, e) {
	popUpUpload.Show();
    hfUploadType.Set('upType','Kes1');
    
}" />
                                    </dx:ASPxButton>
                                </FooterTemplate>
                            </dx:GridViewDataTextColumn>
                            <dx:GridViewDataTextColumn Caption="Jasmani" VisibleIndex="5" Width="6%" FieldName="Jasmani">
                                <FooterTemplate>
                                    <dx:ASPxButton ID="btnUploadJas" runat="server" AutoPostBack="False" Text="" Image-Url="../images/upload.png" Image-Height="16px" Image-Width="16px">
                                        <ClientSideEvents Click="function(s, e) {
	popUpUpload.Show();
    hfUploadType.Set('upType','Jas');
    
}" />
                                    </dx:ASPxButton>
                                </FooterTemplate>
                            </dx:GridViewDataTextColumn>
                            <dx:GridViewDataTextColumn Caption="Litpers" VisibleIndex="6" Width="6%" FieldName="Litpers">
                                <FooterTemplate>
                                    <dx:ASPxButton ID="btnUploadLitpers" runat="server" AutoPostBack="False" Text="" Image-Url="../images/upload.png" Image-Height="16px" Image-Width="16px">
                                        <ClientSideEvents Click="function(s, e) {
	popUpUpload.Show();
    hfUploadType.Set('upType','Litpers');
    
}" />
                                    </dx:ASPxButton>
                                </FooterTemplate>
                            </dx:GridViewDataTextColumn>
                            <dx:GridViewDataTextColumn Caption="POM" VisibleIndex="7" Width="6%" FieldName="Pom">
                                <FooterTemplate>
                                    <dx:ASPxButton ID="btnUploadPOM" runat="server" AutoPostBack="False" Text="" Image-Url="../images/upload.png" Image-Height="16px" Image-Width="16px">
                                        <ClientSideEvents Click="function(s, e) {
	popUpUpload.Show();
    hfUploadType.Set('upType','Pom');
    
}" />
                                    </dx:ASPxButton>
                                </FooterTemplate>
                            </dx:GridViewDataTextColumn>
                            <dx:GridViewDataTextColumn Caption="Psi" VisibleIndex="8" Width="6%" FieldName="Psi">
                                <FooterTemplate>
                                    <dx:ASPxButton ID="btnUploadPsi" runat="server" AutoPostBack="False" Text="" Image-Url="../images/upload.png" Image-Height="16px" Image-Width="16px">
                                        <ClientSideEvents Click="function(s, e) {
	popUpUpload.Show();
    hfUploadType.Set('upType','Psi');
    
}" />
                                    </dx:ASPxButton>
                                </FooterTemplate>
                            </dx:GridViewDataTextColumn>
                            <dx:GridViewDataTextColumn Caption="Adm2" VisibleIndex="9" Width="6%" FieldName="Adm2">
                                <FooterTemplate>
                                    <dx:ASPxButton ID="btnUploadAdm2" runat="server" AutoPostBack="False" Text="" Image-Url="../images/upload.png" Image-Height="16px" Image-Width="16px">
                                        <ClientSideEvents Click="function(s, e) {
	popUpUpload.Show();
    hfUploadType.Set('upType','Adm2');
    
}" />
                                    </dx:ASPxButton>
                                </FooterTemplate>
                            </dx:GridViewDataTextColumn>
                            <dx:GridViewDataTextColumn Caption="Kes2" VisibleIndex="10" Width="6%" FieldName="Kes2">
                                <FooterTemplate>
                                    <dx:ASPxButton ID="btnUploadKes2" runat="server" AutoPostBack="False" Text="" Image-Url="../images/upload.png" Image-Height="16px" Image-Width="16px">
                                        <ClientSideEvents Click="function(s, e) {
	popUpUpload.Show();
    hfUploadType.Set('upType','Kes2');
    
}" />
                                    </dx:ASPxButton>
                                </FooterTemplate>
                            </dx:GridViewDataTextColumn>
                            <dx:GridViewDataTextColumn Caption="Kes3" VisibleIndex="11" Width="6%" FieldName="Kes3">
                                <FooterTemplate>
                                    <dx:ASPxButton ID="btnUploadKes3" runat="server" AutoPostBack="False" Text="" Image-Url="../images/upload.png" Image-Height="16px" Image-Width="16px">
                                        <ClientSideEvents Click="function(s, e) {
	popUpUpload.Show();
    hfUploadType.Set('upType','Kes3');
    
}" />
                                    </dx:ASPxButton>
                                </FooterTemplate>
                            </dx:GridViewDataTextColumn>
                            <dx:GridViewDataTextColumn Caption="Pantukhirda" VisibleIndex="12" Width="6%" FieldName="Pantukhirda">
                                <FooterTemplate>
                                    <dx:ASPxButton ID="btnUploadPantu" runat="server" AutoPostBack="False" Text="" Image-Url="../images/upload.png" Image-Height="16px" Image-Width="16px">
                                        <ClientSideEvents Click="function(s, e) {
	popUpUpload.Show();
    hfUploadType.Set('upType','Pantukhirda');
    
}" />
                                    </dx:ASPxButton>
                                </FooterTemplate>
                            </dx:GridViewDataTextColumn>
                            <dx:GridViewCommandColumn Caption="Pilih" ShowSelectCheckbox="True" VisibleIndex="0" Width="50px">
                            </dx:GridViewCommandColumn>
                        </Columns>
                        <SettingsPager Mode="ShowAllRecords" Visible="False">
                        </SettingsPager>
                        <Settings ShowFooter="True" />
                        <SettingsDataSecurity AllowDelete="False" AllowEdit="False" AllowInsert="False" />
                    </dx:ASPxGridView>
                </div>
                <dx:ASPxHiddenField ID="hfUploadType" runat="server" ClientInstanceName="hfUploadType">
                </dx:ASPxHiddenField>
                 <dx:ASPxLabel ID="lblError" runat="server" CssClass="text-error"></dx:ASPxLabel>
                <br />
                <div class="box1 pad_left20 pad_right20" id="boxPusat" runat="server" visible="false">
                    <dx:ASPxGridView ID="gvNilaiPusat" runat="server" AutoGenerateColumns="False" ClientInstanceName="gvNilai" EnableTheming="True" Theme="BlackGlass" Width="100%" KeyFieldName="NoPeserta" OnDataBinding="gvNilaiPusat_DataBinding">
                        <Columns>
                            <dx:GridViewDataTextColumn Caption="No Pusat" Name="clmNoPeserta" VisibleIndex="2" Width="10%" FieldName="NoPesertaPusat">
                                <FooterTemplate>
                                   
                                    <dx:ASPxButton ID="btnUploadPesertaPusat" runat="server" AutoPostBack="False">
                                        <ClientSideEvents Click="function(s, e) {
	popUpUpload.Show();
    hfUploadType.Set('upType','PesertaPusat');
    
}" />
                                      <Image Height="16px" Url="../images/upload.png" Width="16px">
                                        </Image>
                                    </dx:ASPxButton>
                                </FooterTemplate>
                            </dx:GridViewDataTextColumn>
                            <dx:GridViewDataTextColumn Caption="Nama" Name="clmNama" VisibleIndex="3" Width="40%" FieldName="Nama">
                                <FooterTemplate>
                                   <dx:ASPxButton ID="btnDownloadPesertaPusat" runat="server" AutoPostBack="False" Text="Download Peserta" OnClick="btnDownloadPusat_Click">
                                    </dx:ASPxButton>
                                </FooterTemplate>
                            </dx:GridViewDataTextColumn>
                            <dx:GridViewDataTextColumn Caption="Adm" Name="clmAdm" VisibleIndex="5" Width="6%" FieldName="AdmPus">
                                <FooterTemplate>
                                    <dx:ASPxButton ID="btnUploadAdm3" runat="server" AutoPostBack="False" Image-Url="../images/upload.png" Image-Height="16px" Image-Width="16px">
                                        <ClientSideEvents Click="function(s, e) {
	popUpUpload.Show();
    hfUploadType.Set('upType','AdmPus');
    
}" />
                                        <Image Height="16px" Url="../images/upload.png" Width="16px">
                                        </Image>
                                    </dx:ASPxButton>
                                </FooterTemplate>
                            </dx:GridViewDataTextColumn>
                            <dx:GridViewDataTextColumn Caption="Kes" VisibleIndex="6" Width="6%" FieldName="KesPus">
                                <FooterTemplate>
                                    <dx:ASPxButton ID="btnUploadKes4" runat="server" AutoPostBack="False" Text="" Image-Url="../images/upload.png" Image-Height="16px" Image-Width="16px">
                                        <ClientSideEvents Click="function(s, e) {
	popUpUpload.Show();
    hfUploadType.Set('upType','KesPus');
    
}" />
                                    </dx:ASPxButton>
                                </FooterTemplate>
                            </dx:GridViewDataTextColumn>
                            <dx:GridViewDataTextColumn Caption="Jas" VisibleIndex="7" Width="6%" FieldName="JasPus">
                                <FooterTemplate>
                                    <dx:ASPxButton ID="btnUploadJas0" runat="server" AutoPostBack="False" Text="" Image-Url="../images/upload.png" Image-Height="16px" Image-Width="16px">
                                        <ClientSideEvents Click="function(s, e) {
	popUpUpload.Show();
    hfUploadType.Set('upType','JasPus');
    
}" />
                                    </dx:ASPxButton>
                                </FooterTemplate>
                            </dx:GridViewDataTextColumn>
                            <dx:GridViewDataTextColumn Caption="Litp" VisibleIndex="8" Width="6%" FieldName="LitPus">
                                <FooterTemplate>
                                    <dx:ASPxButton ID="btnUploadLitpers0" runat="server" AutoPostBack="False" Text="" Image-Url="../images/upload.png" Image-Height="16px" Image-Width="16px">
                                        <ClientSideEvents Click="function(s, e) {
	popUpUpload.Show();
    hfUploadType.Set('upType','LitPus');
    
}" />
                                    </dx:ASPxButton>
                                </FooterTemplate>
                            </dx:GridViewDataTextColumn>
                            <dx:GridViewDataTextColumn Caption="Pom" VisibleIndex="9" Width="6%" FieldName="PomPus">
                                <FooterTemplate>
                                    <dx:ASPxButton ID="btnUploadPOM0" runat="server" AutoPostBack="False" Text="" Image-Url="../images/upload.png" Image-Height="16px" Image-Width="16px">
                                        <ClientSideEvents Click="function(s, e) {
	popUpUpload.Show();
    hfUploadType.Set('upType','PomPus');
}" />
                                    </dx:ASPxButton>
                                </FooterTemplate>
                            </dx:GridViewDataTextColumn>
                            <dx:GridViewDataTextColumn Caption="Psi" VisibleIndex="10" Width="6%" FieldName="PsiPus">
                                <FooterTemplate>
                                    <dx:ASPxButton ID="btnUploadPsi0" runat="server" AutoPostBack="False" Text="" Image-Url="../images/upload.png" Image-Height="16px" Image-Width="16px">
                                        <ClientSideEvents Click="function(s, e) {
	popUpUpload.Show();
    hfUploadType.Set('upType','PsiPus');
}" />
                                    </dx:ASPxButton>
                                </FooterTemplate>
                            </dx:GridViewDataTextColumn>
                            <dx:GridViewDataTextColumn Caption="Pantukhir" VisibleIndex="12" Width="6%" FieldName="Pantukhirpus">
                                <FooterTemplate>
                                    <dx:ASPxButton ID="btnUploadPantu0" runat="server" AutoPostBack="False" Text="" Image-Url="../images/upload.png" Image-Height="16px" Image-Width="16px">
                                        <ClientSideEvents Click="function(s, e) {
	popUpUpload.Show();
    hfUploadType.Set('upType','Pantukhirpus');
}" />
                                    </dx:ASPxButton>
                                </FooterTemplate>
                            </dx:GridViewDataTextColumn>
                            <dx:GridViewCommandColumn Caption="Pilih" ShowSelectCheckbox="True" VisibleIndex="0" Width="50px">
                            </dx:GridViewCommandColumn>
                            <dx:GridViewDataTextColumn Caption="Aka" ShowInCustomizationForm="True" VisibleIndex="4" FieldName="Aka">
                                <FooterTemplate>
                                    <dx:ASPxButton ID="btnUploadAdm3" runat="server" AutoPostBack="False" Image-Url="../images/upload.png" Image-Height="16px" Image-Width="16px">
                                        <ClientSideEvents Click="function(s, e) {
	popUpUpload.Show();
    hfUploadType.Set('upType','Aka');
    
}" />
                                        <Image Height="16px" Url="../images/upload.png" Width="16px">
                                        </Image>
                                    </dx:ASPxButton>
                                </FooterTemplate>
                            </dx:GridViewDataTextColumn>
                            <dx:GridViewDataTextColumn Caption="No Lanud" FieldName="NoPeserta" ShowInCustomizationForm="True" VisibleIndex="1">
                                <FooterTemplate>
                                 <dx:ASPxButton ID="btnDownloadPeserta" runat="server" AutoPostBack="False" OnClick="btnDownloadNoPeserta_Click">
                                      <Image Height="16px" Url="../images/download.png" Width="16px">
                                        </Image>
                                    </dx:ASPxButton>
                                    </FooterTemplate>
                            </dx:GridViewDataTextColumn>
                        </Columns>
                        <SettingsPager Mode="ShowAllRecords" Visible="False">
                        </SettingsPager>
                        <Settings ShowFooter="True" />
                        <SettingsDataSecurity AllowDelete="False" AllowEdit="False" AllowInsert="False" />
                    </dx:ASPxGridView>
                </div>
                <br />
                <dx:ASPxPopupControl ID="popUpUpload" runat="server" ClientInstanceName="popUpUpload" Width="300px" HeaderText="Upload" EnableTheming="True" Modal="True" PopupHorizontalAlign="WindowCenter" PopupVerticalAlign="WindowCenter" Theme="BlackGlass">
                    <ContentCollection>
                        <dx:PopupControlContentControl runat="server" SupportsDisabledAttribute="True">
                            <dx:ASPxUploadControl ID="uploadNilai" runat="server" FileUploadMode="OnPageLoad" ShowProgressPanel="True" ShowUploadButton="True" UploadMode="Auto" Width="250px" Theme="BlackGlass" OnFileUploadComplete="uploadNilai_FileUploadComplete">
                                <ValidationSettings AllowedFileExtensions=".xlsx">
                                </ValidationSettings>
                                <AdvancedModeSettings>
                                    <FileListItemStyle CssClass="pending dxucFileListItem">
                                    </FileListItemStyle>
                                </AdvancedModeSettings>
                            </dx:ASPxUploadControl>
                        </dx:PopupControlContentControl>
                    </ContentCollection>
                </dx:ASPxPopupControl>
                <br />
            </dx:PanelContent>
        </PanelCollection>
    </dx:ASPxCallbackPanel>
</asp:Content>
