$(document).ready(function () {

    $('[name=Login]').change(function () {//change-срабатыват когда мы покинули поле Login
        var name = $(this).val();

        var url = '/User/IsUserExist?name=' + name;

        showIcon('spinner');
        $.get(url).done(function (answer) {
            //Когда придет ответ
            console.log("answer = " + answer);
            if (answer) {
                showIcon('close');
                $('#registration-block .icon.close').text(" Такой пользователь уже существует");
            } else {
                showIcon('ok');
            }
        });

        function showIcon(iconName) {
            $('#registration-block .icon').addClass('hide');
            $(`#registration-block .icon.${iconName}`).removeClass('hide');
        }
    });
});