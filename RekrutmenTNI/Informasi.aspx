<%@ Page Title="" Language="C#" MasterPageFile="~/MainDefault.Master" AutoEventWireup="true" CodeBehind="Informasi.aspx.cs" Inherits="RekrutmenTNI.Panduan" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="contentMain" runat="server">
    <h1>Informasi</h1>
    <div class="box1">

        <h2>Hasil Seleksi</h2>
        <div class="accordion" id="accordion1">
            <%

                DataAccess.DataAccessDashboardUser oDa = new DataAccess.DataAccessDashboardUser();
                System.Data.DataTable dtRiwayat = oDa.getDataTable_Riwayat(((RekrutmenTNI.cSessionUser)Session["-- user struct --"]).UserEmail);

                foreach (System.Data.DataRow rowRiwayat in dtRiwayat.Rows)
                {
                    string noPeserta = Convert.ToString(rowRiwayat["NoPeserta"]);
                    if (noPeserta == "")
                        continue;

            %>


            <div class="accordion-group">
                <div class="accordion-heading">
                    <a class="accordion-toggle" data-toggle="collapse" data-parent="#accordion1" href="#collapse1">No Peserta : <% Response.Write(rowRiwayat["NoPeserta"].ToString()); %>
                    </a>
                </div>
                <div id="collapse1" class="accordion-body collapse in">
                    <div class="accordion-inner">



                        <table class="table">
                            <thead>
                                <tr>
                                    <th>No.
                                    </th>
                                    <th>Seleksi
                                    </th>
                                    <th>Hasil
                                    </th>
                                    <th>Keterangan
                                    </th>
                                </tr>
                            </thead>
                            <%
                                int i = 1;
                                System.Data.DataTable dtNilai = oDa.getDataTable_NilaiPeserta(noPeserta);
                                foreach (System.Data.DataRow rowNilai in dtNilai.Rows)
                                {
                            %>
                            <tbody>
                                <tr>
                                    <td><% Response.Write(i);%></td>
                                    <td><% Response.Write(rowNilai["keterangan"].ToString());%></td>
                                    <td><% Response.Write(rowNilai["Hasil"].ToString());%></td>
                                    <td></td>
                                </tr>
                            </tbody>
                            <%
                                    i++;
                                }
                            %>
                        </table>
                    </div>
                </div>
            </div>
            <%
                }
            %>
        </div>
    </div>
</asp:Content>
