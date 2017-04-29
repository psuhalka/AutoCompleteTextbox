

$(document).ready(function () {
    $('#INPUT').on('input', sayhello);
});


function sayhello()
{
    $('#SWORD').empty();
    var str = $('#INPUT').val();
    if (str.trim().length > 0) {
        $.ajax({
            type: "POST",
            url: '/Home/GetTopSuggestionWords',
            data: '{searchString: "' + str + '"}',
            datatype: "json",
            contentType: "application/json; charset=utf-8",
            success: function (data) {

                if (data == '#ERROR LOADING DICTIONARY') {
                    var strLI = '<li>ERROR LOADING DICTIONARY</li>'
                    $('#SWORD').append(strLI);
                }
                else {
                    for (var index = 0; index < data.length; index++) {
                        var strLI = '<li><input type="radio" name="sugWord" onclick="selectWord();" value= "' + data[index] + '" />' + data[index] + '</li>'
                        $('#SWORD').append(strLI);
                    }
                }
            },
            failure: function (response)
            { alert("failure") },
            error: function (response)
            { alert("error") }
        })
    }
}

function selectWord(e)
{
    var str = $('input[name=sugWord]:checked').val();
    $('#INPUT').val(str);
    $('#SWORD').empty();
}