﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Administrator/MainAdministrator.master" AutoEventWireup="true" CodeBehind="Pengaturan.aspx.cs" Inherits="RekrutmenTNI.Admin.Pengaturan" %>

<%@ Register Assembly="DevExpress.Web.v23.2, Version=23.2.3.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web" TagPrefix="dx" %>
<%@ Register TagPrefix="uc" TagName="ucFilter" Src="~/Administrator/ucFilterPangkat.ascx" %>
<%@ Register Assembly="DevExpress.Web.ASPxHtmlEditor.v23.2, Version=23.2.3.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web.ASPxHtmlEditor" TagPrefix="dx" %>

<%@ Register Assembly="DevExpress.Web.ASPxSpellChecker.v23.2, Version=23.2.3.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web.ASPxSpellChecker" TagPrefix="dx" %>

<asp:Content ID="Content1" ContentPlaceHolderID="contentHead" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="contentForm" runat="server">
    <uc:ucFilter ID="ucFilter" runat="server" />
    <br />
    <dx:ASPxCallbackPanel ID="callData" runat="server" Width="100%" OnCallback="callData_Callback" ClientInstanceName="callData">
    <PanelCollection>
        <dx:PanelContent runat="server">
                <h2>Pengaturan
                    <asp:Literal ID="litPangkat" runat="server" Text=""></asp:Literal></h2>
    <table>
        <tr>
            <td>
                <dx:ASPxPageControl ID="pgPengaturan" runat="server" ActiveTabIndex="5" Theme="BlackGlass">
                    <TabPages>
                        <dx:TabPage Name="tabPengumuman" Text="Pengumuman">
                            <ContentCollection>
                                <dx:ContentControl runat="server" SupportsDisabledAttribute="True">
                                    <h3>Pengumuman</h3>
                                    <dx:ASPxHtmlEditor ID="htmlPengumuman" runat="server" Theme="BlackGlass">
                                    </dx:ASPxHtmlEditor>
                                </dx:ContentControl>
                            </ContentCollection>
                        </dx:TabPage>
                        <dx:TabPage Name="tabPersyaratan" Text="Persyaratan">
                            <ContentCollection>
                                <dx:ContentControl runat="server" SupportsDisabledAttribute="True">
                                    <h3>Persyaratan</h3>
                                    <dx:ASPxHtmlEditor ID="htmlPersyaratan" runat="server" Theme="BlackGlass">
                                    </dx:ASPxHtmlEditor>
                                </dx:ContentControl>
                            </ContentCollection>
                        </dx:TabPage>
                        <dx:TabPage Name="tabLokasi" Text="Lokasi">
                            <ContentCollection>
                                <dx:ContentControl runat="server" SupportsDisabledAttribute="True">
                                    <h3>Lokasi</h3>
                                    <dx:ASPxHtmlEditor ID="htmlLokasi" runat="server" Theme="BlackGlass">
                                    </dx:ASPxHtmlEditor>
                                </dx:ContentControl>
                            </ContentCollection>
                        </dx:TabPage>
                        <dx:TabPage Name="tabJadwal" Text="Jadwal">
                            <ContentCollection>
                                <dx:ContentControl runat="server" SupportsDisabledAttribute="True">
                                    <h3>Jadwal</h3>
                                    <dx:ASPxHtmlEditor ID="htmlJadwal" runat="server" Theme="BlackGlass">
                                    </dx:ASPxHtmlEditor>
                                </dx:ContentControl>
                            </ContentCollection>
                        </dx:TabPage>
                        <dx:TabPage Name="tabMateri" Text="Materi Seleksi">
                            <ContentCollection>
                                <dx:ContentControl runat="server" SupportsDisabledAttribute="True">
                                    <h3>Materi</h3>
                                    <dx:ASPxHtmlEditor ID="htmlMateri" runat="server" Theme="BlackGlass">
                                    </dx:ASPxHtmlEditor>
                                </dx:ContentControl>
                            </ContentCollection>
                        </dx:TabPage>
                        <dx:TabPage Name="tabPanduan" Text="File Upload">
                            <ContentCollection>
                                <dx:ContentControl runat="server" SupportsDisabledAttribute="True">
                                    <h3>Blanko Administrasi</h3>
                                    <div class="row">
                                        <div class="span5">
                                        <label>Klik tombol browse di bawah ini untuk mengunggah blanko Administrasi.</label>
                                            </div>
                                    </div>
                                    <div class="row">
                                        <div class="span5">
                                        <dx:ASPxUploadControl ID="uploadPanduan" runat="server" UploadMode="Auto" Width="280px" Theme="BlackGlass" AddUploadButtonsHorizontalPosition="Right" OnFileUploadComplete="uploadPanduan_FileUploadComplete" ShowProgressPanel="True" ShowUploadButton="True">
                                            <AdvancedModeSettings TemporaryFolder="Upload\Temp\">
                                            </AdvancedModeSettings>
                                            </dx:ASPxUploadControl>
                                            </div>
                                    </div>
                                    <div class="row">
                                    </div>
                                </dx:ContentControl>
                            </ContentCollection>
                        </dx:TabPage>
                        <dx:TabPage Name="tabSyaratPendaftaran" Text="Syarat Pendaftaran" Visible="False">
                            <ContentCollection>
                                <dx:ContentControl runat="server">
                                    Syarat Minimal Tinggi Badan:<br />
                                    <table>
                                        <tr>
                                            <td>Laki-laki</td>
                                            <td>:</td>
                                            <td>
                                                <dx:ASPxSpinEdit ID="spnLaki" runat="server" Number="70" Theme="BlackGlass">
                                                </dx:ASPxSpinEdit>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td>Perempuan</td>
                                            <td>:</td>
                                            <td>
                                                <dx:ASPxSpinEdit ID="spnPerempuan" runat="server" Number="70" Theme="BlackGlass">
                                                </dx:ASPxSpinEdit>
                                            </td>
                                        </tr> 
                                    </table>
                                </dx:ContentControl>
                            </ContentCollection>
                        </dx:TabPage>
                    </TabPages>
                </dx:ASPxPageControl>
            </td>
        </tr>
        <tr>
            <td align="center">
                <dx:ASPxButton ID="btnSimpan" runat="server" Text="Simpan Perubahan" OnClick="btnSimpan_Click" CssClass="btn btn-primary btn-small" Theme="BlackGlass"></dx:ASPxButton>
            </td>
        </tr>
    </table>
            </dx:PanelContent>
        </PanelCollection>
    </dx:ASPxCallbackPanel>
</asp:Content>
