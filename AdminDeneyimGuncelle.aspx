﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.master" AutoEventWireup="true" CodeFile="AdminDeneyimGuncelle.aspx.cs" Inherits="AdminDeneyimGuncelle" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="Server">

    <form id="Form1" runat="server">
        <div class="form-group">

            <div>
                <asp:Label ID="Label5" runat="server" Text="ID"></asp:Label>
                <asp:TextBox ID="TxtId" runat="server" CssClass="form-control"></asp:TextBox>
            </div>

            <br />

            <div>
                <asp:Label ID="Label1" runat="server" Text="Başlık"></asp:Label>
                <asp:TextBox ID="TxtBaslik" runat="server" CssClass="form-control"></asp:TextBox>
            </div>

            <br />

            <div>
                <asp:Label ID="Label2" runat="server" Text="Alt Başlık"></asp:Label>
                <asp:TextBox ID="TxtAltBaslik" runat="server" CssClass="form-control"></asp:TextBox>
            </div>

            <br />

            <div>
                <asp:Label ID="Label3" runat="server" Text="Açıklama"></asp:Label>
                <asp:TextBox ID="TxtAciklama" runat="server" CssClass="form-control" Height="150px" TextMode="MultiLine"></asp:TextBox>
            </div>

            <br />

            <div>
                <asp:Label ID="Label4" runat="server" Text="Tarih"></asp:Label>
                <asp:TextBox ID="TxtTarih" runat="server" CssClass="form-control"></asp:TextBox>
            </div>

            <br />

            <asp:Button ID="BtnGuncelle" runat="server" Text="Güncelle" CssClass="btn btn-success" onclick="BtnGuncelle_Click"/>

        </div>
    </form>

</asp:Content>

