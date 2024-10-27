<%@ Page Title="" Language="C#" MasterPageFile="~/MainDefault.Master" AutoEventWireup="true" CodeBehind="Daftar.aspx.cs" Inherits="RekrutmenTNI.Daftar" %>

<%@ Register Assembly="DevExpress.Web.v23.2, Version=23.2.3.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web" TagPrefix="dx" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="contentMain" runat="server">
    <h1>Daftar</h1>
    <div class="box1">
        <div style="padding: 0 0 0 30px">
            <h3>Isilah form pendaftaran dengan jujur dan sebenar - benarnya.</h3>
            <br />
            <div class="row">
                <div class="span4">

                    <div class="row">
                        <div class="span2">
                            <label>Email</label>
                        </div>
                        <div class="span2">
                            <dx:ASPxTextBox ID="txtEmail" runat="server" Width="170px" MaxLength="100">
                                <ValidationSettings CausesValidation="True" ErrorDisplayMode="ImageWithTooltip" ValidationGroup="valDaftar">
                                    <RegularExpression ErrorText="Format email anda salah." ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" />
                                    <RequiredField IsRequired="True" />
                                </ValidationSettings>
                            </dx:ASPxTextBox>
                        </div>
                    </div>
                    <div class="row">
                        <div class="span2">
                            <label>Nama Lengkap</label>
                        </div>
                        <div class="span2">
                            <dx:ASPxTextBox ID="txtNama" runat="server" Width="170px" MaxLength="50">
                                <ValidationSettings CausesValidation="True" ErrorDisplayMode="ImageWithTooltip" ValidationGroup="valDaftar">
                                    <RequiredField IsRequired="True" />
                                </ValidationSettings>
                            </dx:ASPxTextBox>
                        </div>
                    </div>
                    <div class="row">
                        <div class="span2">
                            <label>Tempat Lahir</label>
                        </div>
                        <div class="span2">
                            <dx:ASPxTextBox ID="txtTempatLahir" runat="server" Width="170px" MaxLength="50">
                                <ValidationSettings CausesValidation="True" ErrorDisplayMode="ImageWithTooltip" ValidationGroup="valDaftar">
                                    <RequiredField IsRequired="True" />
                                </ValidationSettings>
                            </dx:ASPxTextBox>
                        </div>
                    </div>
                    <div class="row">
                        <div class="span2">
                            <label>Tanggal Lahir</label>
                        </div>
                        <div class="span2">
                            <dx:ASPxDateEdit ID="dteTglLahir" runat="server" Theme="BlackGlass" Width="170px" DisplayFormatString="dd-MM-yyyy">
                                <ValidationSettings ValidationGroup="valDaftar" ErrorDisplayMode="ImageWithTooltip">
                                    <RequiredField IsRequired="True" />
                                </ValidationSettings>
                            </dx:ASPxDateEdit>
                        </div>
                    </div>
                    <div class="row">
                        <div class="span2">
                            <label>Jenis Kelamin</label>
                        </div>
                        <div class="span2">
                            <dx:ASPxComboBox ID="cboJenisKelamin" runat="server" ClientInstanceName="cboJenisKelamin" Theme="BlackGlass">
                                <ClientSideEvents ValueChanged="function(s, e) {
	cboWilayah.PerformCallback(cboJenisKelamin.GetValue().toString() );
}" />
                                <ValidationSettings CausesValidation="True" ErrorDisplayMode="ImageWithTooltip" ValidationGroup="valDaftar">
                                    <RequiredField IsRequired="True" />
                                </ValidationSettings>
                            </dx:ASPxComboBox>
                        </div>
                    </div>
                    <div class="row">
                        <div class="span2">
                            <label>Nomor KTP</label>
                        </div>
                        <div class="span2">
                            <dx:ASPxTextBox ID="txtNomorKTP" runat="server" Width="170px" MaxLength="20">
                                <ValidationSettings CausesValidation="True" ErrorDisplayMode="ImageWithTooltip" ValidationGroup="valDaftar">
                                    <RegularExpression ErrorText="Hanya dapat diisi angka." ValidationExpression="^(0|[1-9][0-9]*|[1-9][0-9]{0,2}(,[0-9]{3,3})*)$" />
                                    <RequiredField IsRequired="True" />
                                </ValidationSettings>
                            </dx:ASPxTextBox>
                        </div>
                    </div>
                    <div class="row">
                        <div class="span2">
                            Alamat
                        </div>
                        <div class="span2">
                            <dx:ASPxMemo ID="txtAlamat" runat="server" Height="71px" Width="170px" Theme="BlackGlass">
                                <ValidationSettings ErrorDisplayMode="ImageWithTooltip" ValidationGroup="valDaftar">
                                    <RequiredField IsRequired="True" />
                                </ValidationSettings>
                            </dx:ASPxMemo>
                        </div>
                    </div>
                    <div class="row">
                        <div class="span2">
                            Kabupaten/Kota
                        </div>
                        <div class="span2">
                            <dx:ASPxTextBox ID="txtKabupaten" runat="server" Width="170px" MaxLength="50">
                                <ValidationSettings ErrorDisplayMode="ImageWithTooltip" ValidationGroup="valDaftar">
                                    <RequiredField IsRequired="True" />
                                </ValidationSettings>
                            </dx:ASPxTextBox>
                        </div>
                    </div>
                    <div class="row">
                        <div class="span2">
                            Propinsi
                        </div>
                        <div class="span2">
                            <dx:ASPxTextBox ID="txtPropinsi" runat="server" Width="170px" MaxLength="50">
                                <ValidationSettings ErrorDisplayMode="ImageWithTooltip" ValidationGroup="valDaftar">
                                    <RequiredField IsRequired="True" />
                                </ValidationSettings>
                            </dx:ASPxTextBox>
                        </div>
                    </div>
                    <div class="row">
                        <div class="span2">
                            No. Telepon
                        </div>
                        <div class="span2">
                            <dx:ASPxTextBox ID="txtNoTelp" runat="server" Width="170px" MaxLength="20">
                                <ValidationSettings ErrorDisplayMode="ImageWithTooltip" ValidationGroup="valDaftar">
                                    <RequiredField IsRequired="True" />
                                </ValidationSettings>
                            </dx:ASPxTextBox>
                        </div>
                    </div>
                    <br />
                    <div class="row">
                        <div class="span4">
                            Blanko Administrasi dari Panpus, silahkan unduh disini :
				   <asp:LinkButton ID="lnkDownload" runat="server" OnClick="lnkDownload_Click">Unduh</asp:LinkButton>
                        </div>
                    </div>
                </div>
                <div class="span4">
                    <div class="row">
                        <div class="span2">
                            Agama
                        </div>
                        <div class="span2">
                            <dx:ASPxComboBox ID="cboAgama" runat="server" Width="170px" Theme="BlackGlass">
                                <ValidationSettings ErrorDisplayMode="ImageWithTooltip" ValidationGroup="valDaftar">
                                    <RequiredField IsRequired="True" />
                                </ValidationSettings>
                            </dx:ASPxComboBox>
                        </div>
                    </div>
                    <div class="row">
                        <div class="span2">
                            Suku
                        </div>
                        <div class="span2">
                            <dx:ASPxTextBox ID="txtSuku" runat="server" Width="170px" MaxLength="20">
                                <ValidationSettings ErrorDisplayMode="ImageWithTooltip" ValidationGroup="valDaftar">
                                    <RequiredField IsRequired="True" />
                                </ValidationSettings>
                            </dx:ASPxTextBox>
                        </div>
                    </div>
                    <div class="row">
                        <div class="span2">
                            Tinggi Badan / Berat Badan
                        </div>
                        <div class="span2">
                            <table>
                                <tr>
                                    <td>
                                        <dx:ASPxSpinEdit ID="spnTinggiBadan" runat="server" Number="170" MaxLength="3" Width="70px" MinValue="160" MaxValue="200" AllowNull="False" AllowMouseWheel="False" EnableTheming="True" Theme="BlackGlass">
                                            <ValidationSettings ErrorDisplayMode="ImageWithTooltip" ValidationGroup="valDaftar">
                                                <RequiredField IsRequired="true" />
                                            </ValidationSettings>
                                        </dx:ASPxSpinEdit>
                                    </td>
                                    <td>
                                        <dx:ASPxSpinEdit ID="spnBeratBadan" runat="server" Number="70" MaxLength="3" Width="70px" Theme="BlackGlass">
                                            <ValidationSettings ErrorDisplayMode="ImageWithTooltip" ValidationGroup="valDaftar">
                                                <RequiredField IsRequired="True" />
                                            </ValidationSettings>
                                        </dx:ASPxSpinEdit>
                                    </td>
                                </tr>
                            </table>


                        </div>
                    </div>
                    <div class="row">
                        <div class="span2">
                            <label>Pendidikan</label>
                        </div>
                        <div class="span2">
                            <dx:ASPxComboBox ID="cboPendidikan" runat="server" Theme="BlackGlass">
                                <ValidationSettings CausesValidation="True" ErrorDisplayMode="ImageWithTooltip" ValidationGroup="valDaftar">
                                    <RequiredField IsRequired="True" />
                                </ValidationSettings>
                            </dx:ASPxComboBox>
                        </div>
                    </div>
                    <div class="row">
                        <div class="span2">
                            <label>Nama Sekolah SLTA</label>
                        </div>
                        <div class="span2">
                            <dx:ASPxTextBox ID="txtNamaSekolah" runat="server" Width="170px" MaxLength="50">
                                <ValidationSettings CausesValidation="True" ErrorDisplayMode="ImageWithTooltip" ValidationGroup="valDaftar">
                                    <RequiredField IsRequired="True" />
                                </ValidationSettings>
                            </dx:ASPxTextBox>
                        </div>
                    </div>
                    <div class="row">
                        <div class="span2">
                            <label>Kota Asal Sekolah SLTA</label>
                        </div>
                        <div class="span2">
                            <dx:ASPxTextBox ID="txtKotaAsalSMA" runat="server" Width="170px">
                                <ValidationSettings ErrorDisplayMode="ImageWithTooltip" ValidationGroup="valDaftar">
                                    <RequiredField IsRequired="True" />
                                </ValidationSettings>
                            </dx:ASPxTextBox>
                        </div>
                    </div>
                    <div class="row">
                        <div class="span2">
                            <label>Provinsi Sekolah SLTA</label>
                        </div>
                        <div class="span2">
                            <dx:ASPxTextBox ID="txtPropinsiSMA" runat="server" Width="170px">
                                <ValidationSettings ErrorDisplayMode="ImageWithTooltip" ValidationGroup="valDaftar">
                                    <RequiredField IsRequired="True" />
                                </ValidationSettings>
                            </dx:ASPxTextBox>
                        </div>
                    </div>
                    <div class="row">
                        <div class="span2">
                            <label>Tahun Lulus SLTA</label>
                        </div>
                        <div class="span2">
                            <dx:ASPxTextBox ID="txtTahunLulusSMA" runat="server" MaxLength="4">
                                <ValidationSettings CausesValidation="True" ErrorDisplayMode="ImageWithTooltip" ValidationGroup="valDaftar">
                                    <RegularExpression ErrorText="Hanya dapat diisi angka." ValidationExpression="[\d]{4}" />
                                </ValidationSettings>
                            </dx:ASPxTextBox>
                        </div>
                    </div>
                    <div class="row">
                        <div class="span2">
                            <label>Tempat Pendaftaran</label>
                        </div>
                        <div class="span2">
                            <dx:ASPxComboBox ID="cboWilayah" runat="server" ClientInstanceName="cboWilayah" OnCallback="cboWilayah_Callback" Theme="BlackGlass">
                                <ValidationSettings CausesValidation="True" ErrorDisplayMode="ImageWithTooltip" ValidationGroup="valDaftar">
                                    <RequiredField IsRequired="True" />
                                </ValidationSettings>
                            </dx:ASPxComboBox>
                        </div>
                    </div>
                    <div class="row">
                        <div class="span4">
                            <dx:ASPxCaptcha ID="captchaValid" runat="server" Theme="BlackGlass" RefreshButton-Text="Ganti kode lain" TextBox-LabelText="Tuliskan kode yang tampil disamping:" TextBoxStyle-Width="150px">
                                <ValidationSettings SetFocusOnError="true" ErrorDisplayMode="Text" EnableValidation="true" ValidationGroup="valDaftar" ErrorText="Kode yang dimasukkan salah." />
                                <RefreshButton Text="Ganti kode lain"></RefreshButton>
                                <TextBox LabelText="Tuliskan kode yang tampil disamping:" Position="Right"></TextBox>
                                <ChallengeImage ForegroundColor="#000000"></ChallengeImage>
                            </dx:ASPxCaptcha>
                            <div class="pull-right">
                                <dx:ASPxButton ID="btnDaftar" runat="server" Text="Daftar" OnClick="btnDaftar_Click" CssClass="btn btn-small btn-primary" Theme="BlackGlass" ValidationGroup="valDaftar"></dx:ASPxButton>
                            </div>

                        </div>
                    </div>
                </div>
            </div>
            <br />
            <div class="row">
                <div class="span8">
                    <div class="pull-right">
                        <label id="lblError" runat="server" class="text-error"></label>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
