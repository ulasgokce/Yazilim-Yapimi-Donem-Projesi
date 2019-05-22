<%@ Page Title="" Language="C#" MasterPageFile="~/main.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Yazılım_Yapımı_Dönem_Projesi.Login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="cphCSS" runat="server">
    <link href="asset/css/Custom/adminLogin.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cphContent" runat="server">
    <img class="mb-4 logo" src="asset/img/logo.jpg" alt="EWL Logo" />
    <h1 class="h3 mb-3 font-weight-normal text-light">HOŞGELDİNİZ</h1>

    <div class="form-group">
        <input type="text" name="Username" class="form-control" placeholder="Kullanıcı Adı" autofocus>
        <input type="password" name="Password" class="form-control" placeholder="Şifre">
    </div>
    <button type="button" class="btn btn-lg btn-block btn-outline btn-rounded btn-quaternary btn-with-arrow mb-2" onclick="Login()">Giriş<span><i class="fa fa-check"></i></span></button>

    <p class="mt-5 mb-3 text-muted">Created By <a class="createdBy" href="https://github.com/ArdanucAKAR" target="_blank">Ardanuc AKAR</a> - <a class="createdBy" href="https://github.com/ulasgokce" target="_blank">Ulaş GÖKÇE</a></p>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="cphJS" runat="server">
    <script src="asset/js/JQuery-Validation/jquery.validate.min.js"></script>
    <script src="asset/js/Custom/adminLogin.js"></script>
</asp:Content>
