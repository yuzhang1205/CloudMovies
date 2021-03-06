﻿(function (app) {
    'user strict';

    app.factory('notificationService', notifacationService);
    function notifacationService() {
        toastr.options = {
            "debug":false,
            "positionClass": "toast-top-right",
            "onclick": null,
            "fadeIn": 300,
            "fadeOut": 1000,
            "timeOut": 3000,
            "extendTimeOut":1000
        };
        var service = {
            displaySuccess: displaySuccess,
            displayError: displayError,
            displayWarning: displayWarning,
            displayInfo: displayInfo
        };
        return service;
        function displaySuccess(message) {
            toastr.displaySuccess(message);
        }
        function displayError(error) {
            if (Array.isArray(error)) {
                error.forEach(function (err) {
                    toastr.error(err);
                })
            } else {
                toastr.error(error);
            }
        }
        function displayWarning(message) {
            toastr.displayWarning(message);
        }
        function displayInfo(message) {
            toastr.displayInfo(message);
        }
    }
})(angular.module('common.core'));