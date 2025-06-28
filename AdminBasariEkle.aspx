<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.master" AutoEventWireup="true" CodeFile="AdminBasariEkle.aspx.cs" Inherits="AdminBasariEkle" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="Server">

    <form id="Form1" runat="server">
        <div class="form-group">

            <h3>Başarı Ekle</h3>
            <br />

            <div>
                <asp:Label ID="Label1" runat="server" Text="Başarı"></asp:Label>
                <asp:TextBox ID="TxtBasari" runat="server" CssClass="form-control"></asp:TextBox>
            </div>

            <br />

            <asp:Button ID="Button1" runat="server" Text="Kaydet" CssClass="btn btn-success" OnClick="Button1_Click" />

        </div>
    </form>

</asp:Content>

