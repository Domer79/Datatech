﻿var query = {};

var myApplication = {};

myApplication.enableTooltip = true;


query.doQuery = function (url, options) {
    if (typeof (url) == "object") {
        options = url;
        url = options.url;
    }

    //#region Options

    var async = options.async || true;
    var cache = options.cache || true;
    var contentType = options.contextType || "application/x-www-form-urlencoded; charset=UTF-8";
    var data = options.data || undefined;
    var method = options.method || options.type || "GET";
    var error = options.error;
    var success = options.success;
    var uri = url || options.url;
    var errorUrl = options.errorUrl || query.errorUrl;
    var dataType = options.dataType || "*";

    //#endregion

    //#region Variables

    var downloadBar;

    //#endregion

    //#region private functions

    function downloadBarDestroy() {
        if (downloadBar != undefined) {
            downloadBar.children("#progressbar").progressbar({ value: false });
            downloadBar.remove();
        }
    }

    //#endregion

    $.ajax(uri, {
        async: async,
        cache: cache,
        contentType: contentType,
        data: data,
        method: method,
        dataType: dataType,
        beforeSend: function () {
            downloadBar = $(".downloadModalBase").clone().appendTo($("body")).attr("id", "downloadBar");
            downloadBar.children("#progressbar").progressbar({ value: false });
        },
        error: function (jqXhr, textStatus, errorThrown) {
            try {
                if (error == undefined || typeof (error) != "function") {
                    showDialog("Ошибка!", getErrorMessage(errorUrl, textStatus, errorThrown));
                    return;
                }

                error(jqXhr, textStatus, errorThrown);
            } finally {
                downloadBarDestroy();
            }
        },
        success: function(ajaxData, textStatus, jqXhr) {
                if (success != undefined && typeof (success) == "function") {
                    success(ajaxData, textStatus, jqXhr);
                }
        },
        complete: function() {
            downloadBarDestroy();
        }
    });
};

query.errorUrl = undefined;


var showDialog = function(title, message) {
    var messageDialog = $("#messageDialog");
    if (messageDialog.length == 0)
        return;

    $("#messageDialogTitle").text(title);
    $("#messageDialogText").text(message);

    messageDialog = messageDialog.clone().appendTo($("body"));
    messageDialog.on("hidden.bs.modal", function (e) {
        $(this).remove();
    });
    messageDialog.modal();
};

var getErrorMessage = function (url, textStatus, errorThrown) {
    var lastError = textStatus + ". " + errorThrown;
    $.ajax({
        url: url || "http://localhost/nourl/noquery",
        type: "POST",
        async: false,
        cache: false,
        success: function (data) {
            lastError = data;
        }
    });

    return lastError;
};

(function ($) {

    $(document).ready(function () {
//        $("#progressbar").progressbar({ value: false });
    });
    
})(jQuery);