var LoginURL = 'http://localhost:52774/api/GreenLogin/TestMethod';
var RegisterURL = 'http://localhost:52774/api/GreenLogin/GreenRegister';


function CallGreenAPI(request, url, type, async) {
    debugger;
    var returndata;
    $.ajax({
        type: type,
        dataType: "Json",
        url: url,
        data: request,
        success: function (data) {
            returndata = data;
        },
        async: async,
        error: function (error) {
            debugger;
            alert(error)
            throw error;
        }

    });
    return returndata;
} 