<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login1.aspx.cs" Inherits="Yazılım_Yapımı_Dönem_Projesi.Login1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />
    <link href="../asset/css/Bootstrap/bootstrap.min.css" rel="stylesheet" />
    <link href="../asset/css/Font-Awesome/font-awesome.min.css" rel="stylesheet" />
</head>
<body class="text-center">
    <form id="form1" runat="server" action="/">
        <table border="0" cellpadding="0" cellspacing="0">
            <tr>
                <td>Name:
                </td>
                <td>
                    <asp:TextBox ID="txtName" runat="server" Text="" />
                </td>
            </tr>
            <tr>
                <td>Age:
                </td>
                <td>
                    <asp:TextBox ID="txtAge" runat="server" Text="" />
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Button ID="btnSubmit" Text="Submit" runat="server" />
                </td>
            </tr>
        </table>
        <script type="text/javascript" src="http://ajax.googleapis.com/ajax/libs/jquery/1.8.3/jquery.min.js"></script>
        <script type="text/javascript">
            $.ajax({
                type: "POST",
                url: "Login1.aspx/GetCurrentTime",
                contentType: "application/json; charset=utf-8",
                dataType: "json",
                success: function (r) {
                    alert(r.d);
                },
                failure: function (r) {
                    alert(r.d);
                }
            });
            $(function () {
                $("[id*=btnSubmit]").click(function () {
                    var data = JSON.stringify({
                        member: {
                            Username: "Ardanuc",
                            Password: "Ardanuc",
                            Name: "Ardanuc",
                            Surname: "Ardanuc",
                            Language: 1
                        }
                    });
                    console.log(data);
                    $.ajax({
                        type: "POST",
                        url: "Login1.aspx/Login",
                        //data: data,
                        contentType: "application/json; charset=utf-8",
                        dataType: "json",
                        success: function (r) {
                            console.log(r.d);
                        },
                        error: function (r) {
                            console.log(r.responseText);
                        },
                        failure: function (r) {
                            console.log(r.responseText);
                        }
                    });
                    return false;
                });
            });
        </script>
    </form>
</body>
</html>
