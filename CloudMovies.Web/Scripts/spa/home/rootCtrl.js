(function (app) {
    'use strict';

    console.log("start rootCtrl");
    app.controller('rootCtrl', ['$scope', '$location', '$rootScope',
        function ($scope, $location, membershipService, $rootScope) {
            $scope.userData = {};
            $scope.userData.displayUserInfo = displayUserInfo;
            $scope.logout = logout;
            function displayUserInfo() {

            }
            function logout() {

            }
            $scope.userData.displayUserInfo();
            
    }]);
})(angular.module('cloudMovies'))