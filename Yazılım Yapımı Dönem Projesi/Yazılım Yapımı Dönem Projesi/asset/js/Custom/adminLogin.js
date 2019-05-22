$(document).ready(function () {
    $("#EWL").addClass("form-signin").attr("action", "/").attr("name", "login");
    $("form[name='login']").validate({
        errorElement: 'div',
        rules: {
            Username: 'required',
            Password: {
                required: true
            }
        },
        messages: {
            Username: 'Kullanıcı Adı Boş Geçilemez',
            Password: {
                required: "Şifre Boş Geçilez"
            }
        }
    });
});
function Login() {
    if ($("form[name='login']").valid()) {
        var data = JSON.stringify({
            member: {
                Username: $("input[name='Username']").val(),
                Password: $("input[name='Password']").val()
            }
        });
        $.ajax({
            type: "POST",
            url: "../../../MemberAPI.asmx/MemberLogin",
            data: data,
            contentType: "application/json; charset=utf-8",
            dataType: "json",
            success: function (r) {
                alert(r.d);
            },
            failure: function (r) {
                console.log(r.d);
                alert(r.responseText);
            }
        });
    }
    return false;
}