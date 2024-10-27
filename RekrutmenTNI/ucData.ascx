<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ucData.ascx.cs" Inherits="RekrutmenTNI.ucData" %>

<%@ Register Assembly="DevExpress.Web.v23.2, Version=23.2.3.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web" TagPrefix="dx" %>


<style type="text/css">
    .auto-style1 {
        height: 27px;
    }
</style>

<div class="row">
    <div class="fillpadding">
        <h2>Data Diri</h2>
        <div class="span4">
            <div class="row">
                <div class="span2">
                    Nama Lengkap *
                </div>
                <div class="span2">
                    <dx:ASPxTextBox ID="txtNama" runat="server" Width="170px" MaxLength="50">
                        <ValidationSettings ErrorDisplayMode="ImageWithTooltip" ValidationGroup="valSave">
                            <RequiredField IsRequired="True" />
                        </ValidationSettings>
                    </dx:ASPxTextBox>
                </div>
            </div>
            <div class="row">
                <div class="span2">
                    Jenis Kelamin *
                </div>
                <div class="span2">
                    <dx:ASPxComboBox ID="cboJenisKelamin" runat="server" Width="170px" Theme="BlackGlass">
                        <ValidationSettings ErrorDisplayMode="ImageWithTooltip" ValidationGroup="valSave">
                            <RequiredField IsRequired="True" />
                        </ValidationSettings>
                    </dx:ASPxComboBox>
                </div>
            </div>
            <div class="row">
                <div class="span2">
                    Tempat Lahir *
                </div>
                <div class="span2">
                    <dx:ASPxTextBox ID="txtTempatLahir" runat="server" Width="170px" MaxLength="50">
                        <ValidationSettings ErrorDisplayMode="ImageWithTooltip" ValidationGroup="valSave">
                            <RequiredField IsRequired="True" />
                        </ValidationSettings>
                    </dx:ASPxTextBox>
                </div>
            </div>
            <div class="row">
                <div class="span2">
                    Tanggal Lahir *
                </div>
                <div class="span2">
                    <dx:ASPxTextBox ID="txtTglLahir" runat="server" NullText="( dd-mm-yyyy )" Width="170px">
                        <ValidationSettings ErrorDisplayMode="ImageWithTooltip" ValidationGroup="valSave">
                            <RequiredField IsRequired="True" />
                        </ValidationSettings>
                    </dx:ASPxTextBox>
                </div>
            </div>
            <div class="row">
                <div class="span2">
                    Agama *
                </div>
                <div class="span2">
                    <dx:ASPxComboBox ID="cboAgama" runat="server" Width="170px" Theme="BlackGlass">
                        <ValidationSettings ErrorDisplayMode="ImageWithTooltip" ValidationGroup="valSave">
                            <RequiredField IsRequired="True" />
                        </ValidationSettings>
                    </dx:ASPxComboBox>
                </div>
            </div>
            <div class="row">
                <div class="span2">
                    Suku *
                </div>
                <div class="span2">
                    <dx:ASPxTextBox ID="txtSuku" runat="server" Width="170px" MaxLength="20">
                        <ValidationSettings ErrorDisplayMode="ImageWithTooltip" ValidationGroup="valSave">
                            <RequiredField IsRequired="True" />
                        </ValidationSettings>
                    </dx:ASPxTextBox>
                </div>
            </div>
            <div class="row">
                <div class="span2">
                    Alamat *
                </div>
                <div class="span2">
                    <dx:ASPxMemo ID="txtAlamat" runat="server" Height="71px" Width="170px" Theme="BlackGlass">
                        <ValidationSettings ErrorDisplayMode="ImageWithTooltip" ValidationGroup="valSave">
                            <RequiredField IsRequired="True" />
                        </ValidationSettings>
                    </dx:ASPxMemo>
                </div>
            </div>
        </div>
        <div class="span4">
            <div class="row">
                <div class="span2">
                    Kabupaten/Kota *
                </div>
                <div class="span2">
                    <dx:ASPxTextBox ID="txtKabupaten" runat="server" Width="170px" MaxLength="50">
                        <ValidationSettings ErrorDisplayMode="ImageWithTooltip" ValidationGroup="valSave">
                            <RequiredField IsRequired="True" />
                        </ValidationSettings>
                    </dx:ASPxTextBox>
                </div>
            </div>
            <div class="row">
                <div class="span2">
                    Propinsi *
                </div>
                <div class="span2">
                    <dx:ASPxTextBox ID="txtPropinsi" runat="server" Width="170px" MaxLength="50">
                        <ValidationSettings ErrorDisplayMode="ImageWithTooltip" ValidationGroup="valSave">
                            <RequiredField IsRequired="True" />
                        </ValidationSettings>
                    </dx:ASPxTextBox>
                </div>
            </div>
            <div class="row">
                <div class="span2">
                    No. Telepon *
                </div>
                <div class="span2">
                    <dx:ASPxTextBox ID="txtNoTelp" runat="server" Width="170px" MaxLength="20">
                        <ValidationSettings ErrorDisplayMode="ImageWithTooltip" ValidationGroup="valSave">
                            <RequiredField IsRequired="True" />
                        </ValidationSettings>
                    </dx:ASPxTextBox>
                </div>
            </div>
            <div class="row">
                <div class="span2">
                    No. KTP *
                </div>
                <div class="span2">
                    <dx:ASPxTextBox ID="txtNoKTP" runat="server" Width="170px" MaxLength="20">
                        <ValidationSettings ErrorDisplayMode="ImageWithTooltip" ValidationGroup="valSave">
                            <RequiredField IsRequired="True" />
                        </ValidationSettings>
                    </dx:ASPxTextBox>
                </div>
            </div>
            <div class="row">
                <div class="span2">
                    Tinggi Badan *
                </div>
                <div class="span2">
                    <dx:ASPxSpinEdit ID="spnTinggiBadan" runat="server" Number="170" MaxLength="3" Width="80px" MinValue="100" MaxValue="200" AllowNull="False" AllowMouseWheel="False" EnableTheming="True" Theme="BlackGlass">
                        <ValidationSettings ErrorDisplayMode="ImageWithTooltip" ValidationGroup="valSave">
                            <RequiredField IsRequired="true" />
                        </ValidationSettings>
                    </dx:ASPxSpinEdit>
                </div>
            </div>
            <div class="row">
                <div class="span2">
                    Berat Badan *
                </div>
                <div class="span2">
                    <dx:ASPxSpinEdit ID="spnBeratBadan" runat="server" Number="70" MaxLength="3" Width="80px" Theme="BlackGlass">
                        <ValidationSettings ErrorDisplayMode="ImageWithTooltip" ValidationGroup="valSave">
                            <RequiredField IsRequired="True" />
                        </ValidationSettings>
                    </dx:ASPxSpinEdit>
                </div>
            </div>
        </div>
    </div>
</div>
<div class="row">
    <div class="fillpadding">
        <h2>Latar Belakang Pendidikan &amp; Sumber Rekrutmen</h2>
        <div class="span4">
            <div class="row">
                <div class="span4">
                    <strong>1. SD</strong>
                </div>

            </div>
            <div class="row">
                <div class="span2">
                    Status SD
                </div>
                <div class="span2">
                    <dx:ASPxComboBox ID="cboStatusSD" runat="server" Theme="BlackGlass">
                        <Items>
                            <dx:ListEditItem Text="Negeri" Value="Negeri" />
                            <dx:ListEditItem Text="Swasta" Value="Swasta" />
                            <dx:ListEditItem Text="Terakreditasi A" Value="Terakreditasi A" />
                            <dx:ListEditItem Text="Terakreditasi B" Value="Terakreditasi B" />
                            <dx:ListEditItem Text="Disamakan" Value="Disamakan" />
                            <dx:ListEditItem Text="Diakui" Value="Diakui" />
                        </Items>
                        <ValidationSettings ValidationGroup="valSave">
                            <RegularExpression ValidationExpression="[\w\d\s]{0,50}" />
                        </ValidationSettings>
                    </dx:ASPxComboBox>
                </div>
            </div>
            <div class="row">
                <div class="span2">
                    Nama SD
                </div>
                <div class="span2">
                    <dx:ASPxTextBox ID="txtNamaSD" runat="server" Width="170px" MaxLength="50">
                        <ValidationSettings ErrorDisplayMode="ImageWithTooltip">
                            <RegularExpression ValidationExpression="[\w\d\s]{0,50}" />
                        </ValidationSettings>
                    </dx:ASPxTextBox>
                </div>
            </div>
            <div class="row">
                <div class="span2">
                    Kota Asal
                </div>
                <div class="span2">
                    <dx:ASPxTextBox ID="txtKotaAsalSD" runat="server" Width="170px" MaxLength="50">
                        <ValidationSettings ErrorDisplayMode="ImageWithTooltip">
                            <RegularExpression ValidationExpression="[\w\d\s]{0,50}" />
                        </ValidationSettings>
                    </dx:ASPxTextBox>
                </div>
            </div>
            <div class="row">
                <div class="span2">
                    Propinsi
                </div>
                <div class="span2">
                    <dx:ASPxTextBox ID="txtPropinsiSD" runat="server" Width="170px" MaxLength="50">
                        <ValidationSettings ErrorDisplayMode="ImageWithTooltip">
                            <RegularExpression ValidationExpression="[\w\d\s]{0,50}" />
                        </ValidationSettings>
                    </dx:ASPxTextBox>
                </div>
            </div>
            <div class="row">
                <div class="span2">
                    Tahun Lulus
                </div>
                <div class="span2">
                    <dx:ASPxTextBox ID="spnTahunLulusSD" runat="server" Width="60px" MaxLength="4">
                        <ValidationSettings ErrorDisplayMode="ImageWithTooltip">
                            <RegularExpression ValidationExpression="[\d]{0,4}" />
                        </ValidationSettings>
                    </dx:ASPxTextBox>
                </div>
            </div>
            <div class="row">
                <div class="span2">
                    NEM SD
                </div>
                <div class="span2">
                    <dx:ASPxTextBox ID="spnNemSD" runat="server" Width="60px">
                        <ValidationSettings ErrorDisplayMode="ImageWithTooltip">
                            <RegularExpression ValidationExpression="[\d\.]{0,4}" />
                        </ValidationSettings>
                    </dx:ASPxTextBox>
                </div>
            </div>
        </div>
        <div class="span4">
            <div class="row">
                <div class="span4">
                    <strong>2. SLTP</strong>
                </div>

            </div>
            <div class="row">
                <div class="span2">
                    Status SLTP
                </div>
                <div class="span2">
                    <dx:ASPxComboBox ID="cboStatusSMP" runat="server" Theme="BlackGlass">
                        <Items>
                            <dx:ListEditItem Text="Negeri" Value="Negeri" />
                            <dx:ListEditItem Text="Swasta" Value="Swasta" />
                            <dx:ListEditItem Text="Terakreditasi A" Value="Terakreditasi A" />
                            <dx:ListEditItem Text="Terakreditasi B" Value="Terakreditasi B" />
                            <dx:ListEditItem Text="Disamakan" Value="Disamakan" />
                            <dx:ListEditItem Text="Diakui" Value="Diakui" />
                        </Items>
                        <ValidationSettings ValidationGroup="valSave">
                            <RegularExpression ValidationExpression="[\w\d\s]{0,50}" />
                        </ValidationSettings>
                    </dx:ASPxComboBox>
                </div>
            </div>
            <div class="row">
                <div class="span2">
                    Nama SLTP
                </div>
                <div class="span2">
                    <dx:ASPxTextBox ID="txtNamaSMP" runat="server" Width="170px" MaxLength="50">
                        <ValidationSettings ErrorDisplayMode="ImageWithTooltip">
                            <RegularExpression ValidationExpression="[\w\d\s]{0,50}" />
                        </ValidationSettings>
                    </dx:ASPxTextBox>
                </div>
            </div>
            <div class="row">
                <div class="span2">
                    Kota Asal
                </div>
                <div class="span2">
                    <dx:ASPxTextBox ID="txtKotaAsalSMP" runat="server" Width="170px" MaxLength="50">
                        <ValidationSettings ErrorDisplayMode="ImageWithTooltip">
                            <RegularExpression ValidationExpression="[\w\d\s]{0,50}" />
                        </ValidationSettings>
                    </dx:ASPxTextBox>
                </div>
            </div>
            <div class="row">
                <div class="span2">
                    Propinsi
                </div>
                <div class="span2">
                    <dx:ASPxTextBox ID="txtPropinsiSMP" runat="server" Width="170px" MaxLength="50">
                        <ValidationSettings ErrorDisplayMode="ImageWithTooltip">
                            <RegularExpression ValidationExpression="[\w\d\s]{0,50}" />
                        </ValidationSettings>
                    </dx:ASPxTextBox>
                </div>
            </div>
            <div class="row">
                <div class="span2">
                    Tahun Lulus
                </div>
                <div class="span2">
                    <dx:ASPxTextBox ID="spnTahunLulusSMP" runat="server">
                        <ValidationSettings ErrorDisplayMode="ImageWithTooltip">
                            <RegularExpression ValidationExpression="[\d]{0,4}" />
                        </ValidationSettings>
                    </dx:ASPxTextBox>
                </div>
            </div>
            <div class="row">
                <div class="span2">
                    NEM SMP
                </div>
                <div class="span2">
                    <dx:ASPxTextBox ID="spnNemSMP" runat="server" Width="60px">
                        <ValidationSettings ErrorDisplayMode="ImageWithTooltip">
                            <RegularExpression ValidationExpression="[\d\.]{0,5}" />
                        </ValidationSettings>
                    </dx:ASPxTextBox>
                </div>
            </div>
        </div>
    </div>
</div>
<div class="row">
    <div class="fillpadding">
        <div class="span4">
            <div class="row">
                <div class="span4">
                    <strong>3. SLTA</strong>
                </div>

            </div>
            <div class="row">
                <div class="span2">
                    Status SLTA
                </div>
                <div class="span2">
                    <dx:ASPxComboBox ID="cboStatusSMA" runat="server" Theme="BlackGlass">
                        <Items>
                            <dx:ListEditItem Text="Negeri" Value="Negeri" />
                            <dx:ListEditItem Text="Swasta" Value="Swasta" />
                            <dx:ListEditItem Text="Terakreditasi A" Value="Terakreditasi A" />
                            <dx:ListEditItem Text="Terakreditasi B" Value="Terakreditasi B" />
                            <dx:ListEditItem Text="Disamakan" Value="Disamakan" />
                            <dx:ListEditItem Text="Diakui" Value="Diakui" />
                        </Items>
                        <ValidationSettings ValidationGroup="valSave">
                            <RegularExpression ValidationExpression="[\w\d\s]{0,50}" />
                        </ValidationSettings>
                    </dx:ASPxComboBox>
                </div>
            </div>
            <div class="row">
                <div class="span2">
                    Pendidikan
                </div>
                <div class="span2">
                    <dx:ASPxComboBox ID="cboPendidikanSMA" runat="server" ValueType="System.String" Theme="BlackGlass">
                        <ValidationSettings ErrorDisplayMode="ImageWithTooltip" ValidationGroup="valSave">
                            <RegularExpression ValidationExpression="[\w\d\s]{0,50}" />
                        </ValidationSettings>
                    </dx:ASPxComboBox>
                </div>
            </div>
            <div class="row">
                <div class="span2">
                    Nama SLTA/SMK/MTS
                </div>
                <div class="span2">
                    <dx:ASPxTextBox ID="txtNamaSMA" runat="server" Width="170px" MaxLength="50">
                        <ValidationSettings ErrorDisplayMode="ImageWithTooltip" ValidationGroup="valSave">
                            <RegularExpression ValidationExpression="[\w\d\s]{0,50}" />
                        </ValidationSettings>
                    </dx:ASPxTextBox>
                </div>
            </div>
            <div class="row">
                <div class="span2">
                    Jurusan
                </div>
                <div class="span2">
                    <dx:ASPxTextBox ID="txtJurusan" runat="server" Width="170px" MaxLength="50">
                        <ValidationSettings ErrorDisplayMode="ImageWithTooltip" ValidationGroup="valSave">
                            <RegularExpression ValidationExpression="[\w\d\s]{0,50}" />
                        </ValidationSettings>
                    </dx:ASPxTextBox>
                </div>
            </div>
            <div class="row">
                <div class="span2">
                    Kota Asal
                </div>
                <div class="span2">
                    <dx:ASPxTextBox ID="txtKotaAsalSMA" runat="server" Width="170px" MaxLength="50">
                        <ValidationSettings ErrorDisplayMode="ImageWithTooltip" ValidationGroup="valSave">
                            <RegularExpression ValidationExpression="[\w\d\s]{0,50}" />
                        </ValidationSettings>
                    </dx:ASPxTextBox>
                </div>
            </div>
        </div>
        <div class="span4">
            <div class="row">
                <div class="span4">
                    &nbsp;
                </div>
            </div>
            <div class="row">
                <div class="span2">
                    Propinsi
                </div>
                <div class="span2">
                    <dx:ASPxTextBox ID="txtPropinsiSMA" runat="server" Width="170px" MaxLength="50">
                        <ValidationSettings ErrorDisplayMode="ImageWithTooltip" ValidationGroup="valSave">
                            <RegularExpression ValidationExpression="[\w\d\s]{0,50}" />
                        </ValidationSettings>
                    </dx:ASPxTextBox>
                </div>
            </div>
            <div class="row">
                <div class="span2">
                    Tahun Lulus
                </div>
                <div class="span2">
                    <dx:ASPxTextBox ID="spnTahunLulusSMA" runat="server" Width="60px">
                        <ValidationSettings ErrorDisplayMode="ImageWithTooltip" ValidationGroup="valSave">
                            <RegularExpression ValidationExpression="[\d]{4}" />
                        </ValidationSettings>
                    </dx:ASPxTextBox>
                </div>
            </div>
            <div class="row">
                <div class="span2">
                    Nilai Rata-Rata
                </div>
                <div class="span2">
                    <dx:ASPxTextBox ID="spnNemSMA" runat="server" Width="60px">
                        <ValidationSettings ErrorDisplayMode="ImageWithTooltip">
                            <RegularExpression ValidationExpression="[\d\.]{0,6}" />
                        </ValidationSettings>
                    </dx:ASPxTextBox>
                </div>
            </div>
            <div class="row">
                <div class="span2">
                    Nilai UN
                </div>
                <div class="span2">
                    <dx:ASPxTextBox ID="spnNilaiUN" runat="server" Width="60px">
                        <ValidationSettings ErrorDisplayMode="ImageWithTooltip">
                            <RegularExpression ValidationExpression="[\d\.]{0,6}" />
                        </ValidationSettings>
                    </dx:ASPxTextBox>
                </div>
            </div>
        </div>

    </div>
</div>
<div class="row">
    <div class="fillpadding">
        <h2>Data Orang Tua / Wali</h2>
        <div class="span4">


            <div class="row">
                <div class="span4">
                    <strong>1. Bapak Kandung</strong>
                </div>
            </div>
            <div class="row">
                <div class="span2">
                    Nama Bapak
                </div>
                <div class="span2">
                    <dx:ASPxTextBox ID="txtNamaBpk" runat="server" Width="170px" MaxLength="50">
                        <ValidationSettings ErrorDisplayMode="ImageWithTooltip">
                            <RegularExpression ValidationExpression="[\w\d\s]{0,50}" />
                        </ValidationSettings>
                    </dx:ASPxTextBox>
                </div>
            </div>
            <div class="row">
                <div class="span2">
                    Alamat
                </div>
                <div class="span2">
                    <dx:ASPxMemo ID="txtAlamatBapak" runat="server" Height="71px" Width="170px">
                        <ValidationSettings ErrorDisplayMode="ImageWithTooltip">
                        </ValidationSettings>


                    </dx:ASPxMemo>
                </div>
            </div>
            <div class="row">
                <div class="span2">
                    Pekerjaan
                </div>
                <div class="span2">
                    <dx:ASPxTextBox ID="txtPekerjaanBpk" runat="server" Width="170px" MaxLength="50">
                        <ValidationSettings ErrorDisplayMode="ImageWithTooltip">
                            <RegularExpression ValidationExpression="[\w\d\s]{0,50}" />
                        </ValidationSettings>
                    </dx:ASPxTextBox>
                </div>
            </div>
            <div class="row">
                <div class="span2">
                    Jabatan
                </div>
                <div class="span2">
                    <dx:ASPxTextBox ID="txtJabatanBpk" runat="server" Width="170px" MaxLength="50">
                        <ValidationSettings ErrorDisplayMode="ImageWithTooltip">
                            <RegularExpression ValidationExpression="[\w\d\s]{0,50}" />
                        </ValidationSettings>
                    </dx:ASPxTextBox>
                </div>
            </div>
            <div class="row">
                <div class="span2">
                    Nama Kantor
                </div>
                <div class="span2">
                    <dx:ASPxTextBox ID="txtNamaKantorBpk" runat="server" Width="170px" MaxLength="50">
                        <ValidationSettings ErrorDisplayMode="ImageWithTooltip">
                            <RegularExpression ValidationExpression="[\w\d\s]{0,50}" />
                        </ValidationSettings>
                    </dx:ASPxTextBox>
                </div>
            </div>
        </div>
        <div class="span4">
            <div class="row">
                <div class="span4">
                    2. Ibu Kandung
                </div>
            </div>
            <div class="row">
                <div class="span2">
                    Nama
                </div>
                <div class="span2">
                    <dx:ASPxTextBox ID="txtNamaIbu" runat="server" Width="170px" MaxLength="50">
                        <ValidationSettings ErrorDisplayMode="ImageWithTooltip">
                            <RegularExpression ValidationExpression="[\w\d\s]{0,50}" />
                        </ValidationSettings>
                    </dx:ASPxTextBox>
                </div>
            </div>
            <div class="row">
                <div class="span2">
                    Alamat
                </div>
                <div class="span2">
                    <dx:ASPxMemo ID="txtAlamatIbu" runat="server" Height="71px" Width="170px">
                        <ValidationSettings ErrorDisplayMode="ImageWithTooltip" ValidationGroup="valSave">
                        </ValidationSettings>
                        <%--<ValidationSettings ValidationGroup="valSave">
                                        <RegularExpression ValidationExpression="[\w\d\s]{0,1000}" ErrorText="Isian tidak boleh menggunakan symbol." />
                                    </ValidationSettings>--%>
                    </dx:ASPxMemo>
                </div>
            </div>
            <div class="row">
                <div class="span2">
                    Pekerjaan
                </div>
                <div class="span2">
                    <dx:ASPxTextBox ID="txtPekerjaanIbu" runat="server" Width="170px" MaxLength="50">
                        <ValidationSettings ErrorDisplayMode="ImageWithTooltip">
                            <RegularExpression ValidationExpression="[\w\d\s]{0,50}" />
                        </ValidationSettings>
                    </dx:ASPxTextBox>
                </div>
            </div>
            <div class="row">
                <div class="span2">
                    Jabatan
                </div>
                <div class="span2">
                    <dx:ASPxTextBox ID="txtJabatanIbu" runat="server" Width="170px" MaxLength="50">
                        <ValidationSettings ErrorDisplayMode="ImageWithTooltip">
                            <RegularExpression ValidationExpression="[\w\d\s]{0,50}" />
                        </ValidationSettings>
                    </dx:ASPxTextBox>
                </div>
            </div>
            <div class="row">
                <div class="span2">
                    Nama Kantor
                </div>
                <div class="span2">
                    <dx:ASPxTextBox ID="txtNamaKantorIbu" runat="server" Width="170px" MaxLength="50">
                        <ValidationSettings ErrorDisplayMode="ImageWithTooltip">
                            <RegularExpression ValidationExpression="[\w\d\s]{0,50}" />
                        </ValidationSettings>
                    </dx:ASPxTextBox>
                </div>
            </div>
        </div>
    </div>
</div>
<br />
<div class="row">
    <div class="fillpadding">
        <div class="span4">
            <div class="row">
                <div class="span4">
                    3. Wali ( Isi jika mempunyai Wali )
                </div>
            </div>
            <div class="row">
                <div class="span2">
                    Nama
                </div>
                <div class="span2">
                    <dx:ASPxTextBox ID="txtNamaWali" runat="server" Width="170px" MaxLength="50">
                        <ValidationSettings ErrorDisplayMode="ImageWithTooltip">
                            <RegularExpression ValidationExpression="[\w\d\s]{0,50}" />
                        </ValidationSettings>
                    </dx:ASPxTextBox>
                </div>
            </div>
            <div class="row">
                <div class="span2">
                    Alamat
                </div>
                <div class="span2">
                    <dx:ASPxMemo ID="txtAlamatWali" runat="server" Height="71px" Width="170px">
                        <ValidationSettings ErrorDisplayMode="ImageWithTooltip" ValidationGroup="valSave">
                        </ValidationSettings>
                        <%--<ValidationSettings ValidationGroup="valSave">
                                        <RegularExpression ValidationExpression="[\w\d\s]{0,1000}" ErrorText="Isian tidak boleh menggunakan symbol." />
                                    </ValidationSettings>--%>
                    </dx:ASPxMemo>
                </div>
            </div>
            <div class="row">
                <div class="span2">
                    Pekerjaan
                </div>
                <div class="span2">
                    <dx:ASPxTextBox ID="txtPekerjaanWali" runat="server" Width="170px" MaxLength="50">
                        <ValidationSettings ErrorDisplayMode="ImageWithTooltip">
                            <RegularExpression ValidationExpression="[\w\d\s]{0,50}" />
                        </ValidationSettings>
                    </dx:ASPxTextBox>
                </div>
            </div>
            <div class="row">
                <div class="span2">
                    Jabatan
                </div>
                <div class="span2">
                    <dx:ASPxTextBox ID="txtJabatanWali" runat="server" Width="170px" MaxLength="50">
                        <ValidationSettings ErrorDisplayMode="ImageWithTooltip">
                            <RegularExpression ValidationExpression="[\w\d\s]{0,50}" />
                        </ValidationSettings>
                    </dx:ASPxTextBox>
                </div>
            </div>
            <div class="row">
                <div class="span2">
                    Nama Kantor
                </div>
                <div class="span2">
                    <dx:ASPxTextBox ID="txtNamaKantorWali" runat="server" Width="170px" MaxLength="50">
                        <ValidationSettings ErrorDisplayMode="ImageWithTooltip">
                            <RegularExpression ValidationExpression="[\w\d\s]{0,50}" />
                        </ValidationSettings>
                    </dx:ASPxTextBox>
                </div>
            </div>
        </div>
    </div>
</div>
<div class="row">
    <div class="fillpadding">
        <h2>Data Pelengkap</h2>
        <div class="span4">
            <div class="row">
                <p>Ini adalah pendaftaran masuk&nbsp;anda yang keberapa kalinya ?</p>
                <dx:ASPxComboBox ID="cboPendaftaranKe" SelectedIndex="0" runat="server" ValueType="System.String" Width="200px" Theme="BlackGlass">
                    <ValidationSettings ValidationGroup="valSave">
                        <RequiredField IsRequired="True" />
                    </ValidationSettings>
                </dx:ASPxComboBox>
            </div>
        </div>
        <div class="span4">
            <div class="row">
                <p>Dari mana anda mengetahui adanya pendaftaran online ini ?</p>
                <dx:ASPxComboBox ID="cboPendaftaranDari" runat="server" ValueType="System.String" Width="200px" Theme="BlackGlass">
                </dx:ASPxComboBox>
            </div>
        </div>
    </div>
</div>
<br />
<div class="row">
    <div class="fillpadding">
        <div class="span8">
            <div class="row">
                Jika anda pernah berprestasi dalam suatu lomba / kompetisi / olimpiade, isilah data berikut (jika tidak ada prestasi, abaikan saja / isi dengan &quot;Tidak Ada atau tanda &quot;-&quot; )     
            </div>
        </div>
        <br />
        <div class="span4">
            <strong>Prestasi 1</strong>
                <div class="row">
                    <div class="span2">
                        Prestasi
                    </div>
                    <div class="span2">
                        <dx:ASPxTextBox ID="txtPrestasi1" runat="server">
                            <ValidationSettings ErrorDisplayMode="ImageWithTooltip">
                                <RegularExpression ValidationExpression="[\w\d\s]{0,50}" />
                            </ValidationSettings>
                        </dx:ASPxTextBox>
                    </div>
                </div>
            <div class="row">
                <div class="span2">
                    Juara ke-
                </div>
                <div class="span2">
                    <dx:ASPxComboBox ID="cboPrestasi1_Juara" runat="server" ValueType="System.String" Theme="BlackGlass">
                        <ValidationSettings ErrorDisplayMode="ImageWithTooltip">
                            <RegularExpression ValidationExpression="[\w\d\s]{0,50}" />
                        </ValidationSettings>
                    </dx:ASPxComboBox>
                </div>
            </div>
            <div class="row">
                <div class="span2">
                    Tingkatan
                </div>
                <div class="span2">
                    <dx:ASPxComboBox ID="cboPrestasi1_Tingkat" runat="server" ValueType="System.String" Theme="BlackGlass">
                        <ValidationSettings ErrorDisplayMode="ImageWithTooltip">
                            <RegularExpression ValidationExpression="[\w\d\s]{0,50}" />
                        </ValidationSettings>
                    </dx:ASPxComboBox>
                </div>
            </div>
        </div>
        <div class="span4">
            <strong>Prestasi 2</strong>
                 <div class="row">
                     <div class="span2">
                         Prestasi
                     </div>
                     <div class="span2">
                         <dx:ASPxTextBox ID="txtPrestasi2" runat="server">
                             <ValidationSettings ErrorDisplayMode="ImageWithTooltip">
                                 <RegularExpression ValidationExpression="[\w\d\s]{0,50}" />
                             </ValidationSettings>
                         </dx:ASPxTextBox>
                     </div>
                 </div>
            <div class="row">
                <div class="span2">
                    Juara ke-
                </div>
                <div class="span2">
                    <dx:ASPxComboBox ID="cboPrestasi2_Juara" runat="server" ValueType="System.String" Theme="BlackGlass">
                        <ValidationSettings ErrorDisplayMode="ImageWithTooltip">
                            <RegularExpression ValidationExpression="[\w\d\s]{0,50}" />
                        </ValidationSettings>
                    </dx:ASPxComboBox>
                </div>
            </div>
            <div class="row">
                <div class="span2">
                    Tingkatan
                </div>
                <div class="span2">
                    <dx:ASPxComboBox ID="cboPrestasi2_Tingkat" runat="server" ValueType="System.String" Theme="BlackGlass">
                        <ValidationSettings ErrorDisplayMode="ImageWithTooltip">
                            <RegularExpression ValidationExpression="[\w\d\s]{0,50}" />
                        </ValidationSettings>
                    </dx:ASPxComboBox>
                </div>
            </div>
        </div>
    </div>
</div>
<div class="row">
    <div class="fillpadding">
        <div class="span4">
            <strong>Prestasi 3</strong>
                <div class="row">
                    <div class="span2">
                        Prestasi
                    </div>
                    <div class="span2">
                        <dx:ASPxTextBox ID="txtPrestasi3" runat="server">
                            <ValidationSettings ErrorDisplayMode="ImageWithTooltip">
                                <RegularExpression ValidationExpression="[\w\d\s]{0,50}" />
                            </ValidationSettings>
                        </dx:ASPxTextBox>
                    </div>
                </div>
            <div class="row">
                <div class="span2">
                    Juara ke-
                </div>
                <div class="span2">
                    <dx:ASPxComboBox ID="cboPrestasi3_Juara" runat="server" ValueType="System.String" Theme="BlackGlass">
                        <ValidationSettings ErrorDisplayMode="ImageWithTooltip">
                            <RegularExpression ValidationExpression="[\w\d\s]{0,50}" />
                        </ValidationSettings>
                    </dx:ASPxComboBox>
                </div>
            </div>
            <div class="row">
                <div class="span2">
                    Tingkatan
                </div>
                <div class="span2">
                    <dx:ASPxComboBox ID="cboPrestasi3_Tingkat" runat="server" ValueType="System.String" Theme="BlackGlass">
                        <ValidationSettings ErrorDisplayMode="ImageWithTooltip">
                            <RegularExpression ValidationExpression="[\w\d\s]{0,50}" />
                        </ValidationSettings>
                    </dx:ASPxComboBox>
                </div>
            </div>
        </div>
    </div>
</div>

<br />
<div class="fillpadding">
    <dx:ASPxTextBox ID="txtNoAnimo" runat="server" Width="170px" MaxLength="50" Enabled="false" ClientVisible="false">
    </dx:ASPxTextBox>
</div>
