$(document).ready(function () {
    $('#add-personalitem-button').on('click', addUserItem);
});
function addUserItem() {
    $('#add-personalitem-error').hide();
    var newEmailAddress = $('#email_id_input').val();
    var newUsername = $('#username_id_input').val();
    var newPassword = $('#password_id_input').val();

    $.post('/User/SignUp', {
        Emailaddress: newEmailAddress,
        Username: newUsername,
        Password: newPassword
    }, function () {
        window.location = '/User/SignUp';
    })
        .fail(function (data) {
            if (data && data.responseJSON) {
                var firstError = data.responseJSON[Object.keys(data.responseJSON)[0]];
                $('#add-personalitem-error').text(firstError);
                $('#add-personalitem-error').show();
            }
        });
}
$(document).ready(function () {
    $('#ladd-personalitem-button').on('click', loginUserItem);
});
function loginUserItem() {
    $('#ladd-personalitem-error').hide();
    var newUsername = $('#lusername_id_input').val();
    var newPassword = $('#lpassword_id_input').val();

    $.post('/User/LogIn', {
        lusername: newUsername,
        lpassword: newPassword
    }, function () {
        window.location = '/User/LogIn';
    })
        .fail(function (data) {
            if (data && data.responseJSON) {
                var firstError = data.responseJSON[Object.keys(data.responseJSON)[0]];
                $('#ladd-personalitem-error').text(firstError);
                $('#ladd-personalitem-error').show();
            }
        });
}
