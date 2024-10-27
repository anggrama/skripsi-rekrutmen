<%@ Page Title="" Language="C#" MasterPageFile="~/MainDefault.Master" AutoEventWireup="true" CodeBehind="NotFound.aspx.cs" Inherits="RekrutmenTNI.NotFound" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="contentMain" runat="server">
    <h1>Not Found</h1>
    <div class="box1">
			<div class="pad_left20 pad_right20">

				<div class="page_notfound clearfix">
					<div class="block1">
						<div class="page-404">
							<p class="txt1"><asp:Label ID="txt1" runat="server"></asp:Label></p>
							<p class="txt2"><asp:Label ID="txt2" runat="server"></asp:Label></p>
						</div>
					</div>
					<div class="block2">
						<p>
                            <asp:Literal ID="litMessage" runat="server"></asp:Literal>
						</p>
					</div>
				</div>
			</div>
		</div>
</asp:Content>
