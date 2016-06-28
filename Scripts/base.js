var apiUrl = 'api/users';

$(document).ready(function () {
    $.getJSON(apiUrl).done(function (data) {
        $.each(data, function (key, item) {
            $('<li>', { text: formatItem(item) }).appendTo($('#users'));
        })
    });
})

function formatItem(item) {
    return item.Username + ':' + item.Age;
}