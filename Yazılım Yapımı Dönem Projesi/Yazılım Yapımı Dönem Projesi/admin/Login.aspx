<%@ Page Title="" Language="C#" MasterPageFile="~/main.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Yazılım_Yapımı_Dönem_Projesi.admin.Login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="cphCSS" runat="server">
    <link href="<%# Page.ResolveUrl("~") %>/asset/css/Custom/AdminLogin.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cphContent" runat="server">
    <h1 class="h3 mb-3 font-weight-normal text-light" id="WelcomeMessage">ADMİN PANEL</h1>

    <div class="form-group">
        <input type="text" name="Username" class="form-control" placeholder="Kullanıcı Adı" autofocus>
        <input type="password" name="Password" class="form-control" placeholder="Şifre">
        <button type="button" class="mt-3 btn btn-lg btn-block btn-outline btn-rounded btn-quaternary btn-with-arrow mb-2" onclick="Login()">Giriş<span><i class="fa fa-check"></i></span></button>
    </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="cphJS" runat="server">
    <script src="<%# Page.ResolveUrl("~") %>/asset/js/JQuery-Validation/jquery.validate.min.js"></script>
    <script src="<%# Page.ResolveUrl("~") %>/asset/js/Custom/AdminLogin.js"></script>
</asp:Content>
