﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Administrator/MainAdministrator.master" AutoEventWireup="true" CodeBehind="UsersDetail.aspx.cs" Inherits="RekrutmenTNI.Admin.UsersEdit" %>

<%@ Register Assembly="DevExpress.Web.v23.2, Version=23.2.3.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web" TagPrefix="dx" %>
<asp:Content ID="Content1" ContentPlaceHolderID="contentHead" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="contentForm" runat="server">
    <br />
    <h2>
        <asp:Literal ID="lblTitle" runat="server" Text=""></asp:Literal>
    </h2>
       <div class="span4">
            <div class="row">
               <div class="span2">
                   <label>User Id</label>
               </div>
               <div class="span2">
                    <dx:ASPxTextBox ID="txtUserId" runat="server" Width="170px" MaxLength="30">
                    <ValidationSettings ValidationGroup="valUser">
                        <RequiredField IsRequired="True" />
                    </ValidationSettings>
                </dx:ASPxTextBox>
               </div>
           </div>
            <div class="row">
               <div class="span2">
                   <label>Username</label>
               </div>
               <div class="span2">
                     <dx:ASPxTextBox ID="txtUserName" runat="server" Width="170px" MaxLength="50">
                    <ValidationSettings ValidationGroup="valUser">
                        <RequiredField IsRequired="True" />
                    </ValidationSettings>
                </dx:ASPxTextBox>
               </div>
           </div>
            <div class="row">
               <div class="span2">
                   <label>Password</label>
               </div>
               <div class="span2">
                    <dx:ASPxTextBox ID="txtPassword" runat="server" Width="170px" Password="True" MaxLength="50">
                    <ValidationSettings ValidationGroup="valUser">
                        <RequiredField IsRequired="True" />
                    </ValidationSettings>
                </dx:ASPxTextBox>
               </div>
           </div>
            <div class="row">
               <div class="span2">
                   <label>Confirm Password</label>
               </div>
               <div class="span2">
                   
                <dx:ASPxTextBox ID="txtConfPassword" runat="server" Width="170px" MaxLength="50" Password="True">
                    <ValidationSettings CausesValidation="True" ValidationGroup="valUser">
                        <RequiredField IsRequired="True" />
                    </ValidationSettings>
                </dx:ASPxTextBox>
                    <asp:CompareValidator ID="cmpvalPassword" runat="server" ControlToCompare="txtConfPassword" ControlToValidate="txtPassword" ErrorMessage="Password tidak sama." ForeColor="Red"></asp:CompareValidator>
               </div>
           </div>
               <div class="row">
               <div class="span2">
                   <label>User Role</label>
               </div>
               <div class="span2">
                   <dx:ASPxComboBox ID="cboUserRole" runat="server" ClientInstanceName="cboUserRole" Theme="BlackGlass">

                       <ClientSideEvents SelectedIndexChanged="function(s, e) {
if(cboUserRole.GetValue().toString() == 'Admin')
	{	
cboPanda.SetEnabled(false);
cboPanda.SetText('');
	}
	else
	{
	cboPanda.SetEnabled(true);
	}
}" />

                    <Items>
                        <dx:ListEditItem Text="Admin" Value="Admin" />
                        <dx:ListEditItem Text="Lanud" Value="Lanud" />
                    </Items>
                    <ValidationSettings ValidationGroup="valUser">
                        <RequiredField IsRequired="True" />
                    </ValidationSettings>
                </dx:ASPxComboBox>
               </div>
           </div>
            <div class="row">
               <div class="span2">

               </div>
                <div class="span2">
                      <dx:ASPxComboBox ID="cboPanda" runat="server" ClientInstanceName="cboPanda" OnCallback="cboPanda_Callback" Theme="BlackGlass">
                </dx:ASPxComboBox>
               </div>

       </div>
            <div class="row">
               <div class="span2">

               </div>
                <div class="span2">
                      <dx:ASPxCheckBox ID="chkIsActive" runat="server" Checked="True" CheckState="Checked" Text=" " Theme="BlackGlass">
                </dx:ASPxCheckBox>
               </div>

       </div>
            <div class="row">
               <div class="span2">

               </div>
                <div class="span2">
                      <dx:ASPxButton ID="btnSimpan" runat="server" Text="Simpan" OnClick="btnSimpan_Click" ValidationGroup="valUser" Theme="BlackGlass"></dx:ASPxButton>
                <dx:ASPxButton ID="btnBatal" runat="server" Text="Batal" OnClick="btnBatal_Click" Theme="BlackGlass">
                </dx:ASPxButton>
               </div>

       </div>
   
</asp:Content>
