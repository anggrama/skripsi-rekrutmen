﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ReportViewer.aspx.cs" Inherits="RekrutmenTNI.ReportPreview" %>

<%@ Register Assembly="DevExpress.XtraReports.v23.2.Web.WebForms, Version=23.2.3.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.XtraReports.Web" TagPrefix="dx" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Report Viewer</title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table style="width: 100%; height: 700px;">
                <tr>
                    <td class="auto-style1">
                        <dx:ASPxDocumentViewer ID="viewer" runat="server" EnableTheming="True" Height="100%" Theme="Metropolis" Width="100%">
                        </dx:ASPxDocumentViewer>
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
