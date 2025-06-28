<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.master" AutoEventWireup="true" CodeFile="AdminDeneyimler.aspx.cs" Inherits="AdminDeneyimler" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="Server">

    <form id="Form1" runat="server">
        <table class="table table-bordered">
            <tr>
                <th>ID</th>
                <th>BAŞLIK</th>
                <th>ALT BAŞLIK</th>
                <th>AÇIKLAMA</th>
                <th>TARİH</th>
                <th>İŞLEMLER</th>
            </tr>
            <tbody>
                <asp:Repeater ID="Repeater1" runat="server">
                    <itemtemplate>
                        <tr>
                            <th><%# Eval("id") %></th>
                            <td><%# Eval("baslik") %></td>
                            <td><%# Eval("altBaslik") %></td>
                            <td><%# Eval("aciklama") %></td>
                            <td><%# Eval("tarih") %></td>
                            <td>
                                <asp:HyperLink NavigateUrl='<%# "AdminDeneyimSil.aspx?id=" + Eval("id") %>' id="HyperLink1" runat="server" CssClass="btn btn-danger">Sil</asp:HyperLink>
                                <asp:HyperLink NavigateUrl='<%# "AdminDeneyimGuncelle.aspx?id=" + Eval("id") %>' id="HyperLink2" runat="server" CssClass="btn btn-success">Güncelle</asp:HyperLink>
                            </td>
                        </tr>
                    </itemtemplate>
                </asp:Repeater>
            </tbody>
        </table>
        <asp:HyperLink NavigateUrl="~/AdminDeneyimEkle.aspx" id="HyperLink3" runat="server" CssClass="btn btn-info">Deneyim Ekle</asp:HyperLink>
    </form>



</asp:Content>

