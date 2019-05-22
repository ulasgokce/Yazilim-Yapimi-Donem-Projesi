$(document).ready(function () {
    alertify.set('notifier', 'position', 'top-center');
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
                if (r.d != null) {
                    $("#WelcomeMessage").fadeOut(250).html("HOŞGELDİNİZ<br/>" + r.d.Name + " " + r.d.Surname).fadeIn(250);
                    $(".form-group").fadeOut('slow');
                    setTimeout(function () {
                        location.replace("Home");
                    }, 1000);
                }
                else {
                    alertify.notify('Kullanıcı Adı veya Şifre Yalnış', 'customError', 5);
                    $("input[name='Password']").val("");
                    $("input[name='Username']").focus();
                }
            },
            error: function (r) {
                console.log(r.responseText);
            },
            failure: function (r) {
                console.log(r.responseText);
            }
        });
    }
    return false;
}