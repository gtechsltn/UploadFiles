$(function () {
    $("form#data").submit(function (e) {
        e.preventDefault();
        var formData = new FormData(this);

        $.ajax({
            url: window.UrlActionUploadControllerHome,
            type: 'POST',
            data: formData,
            success: function (resp) {
                if (resp && resp.Success) {
                    console.log(resp);
                    alert('Succeeded');
                } else {
                    console.log(resp);
                    alert('Failed ');
                }
            },
            cache: false,
            contentType: false,
            processData: false
        });
    });
});