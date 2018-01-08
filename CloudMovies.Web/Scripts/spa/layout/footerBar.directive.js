(function (app) {
	'use strict';

	app.directive('footerBar', function () {
		return {
			restict: 'E',
			replace: true,
			templateUrl: '/scripts/spa/layout/footerBar.html',
			//link: function (scope,  element, attrs) {
			//    console.log(scope);
			//    //console.log(indexCtrl);
			//    scope.NowTime = new Date().toLocaleTimeString();
			//    //$interval(function () {

			//    //    $scope.theTime = new Date().toLocaleTimeString() + "-----" + new Date().getSeconds(2);     //类似js中的setInterval()函数，每1秒重新调用当前时间
			//    //    // console.log($scope.theTime);


			//    //}, 100);
			//},
			controller: function ($scope,$interval) {
			    $scope.NowTime = new Date().toLocaleString();
			    $interval(function () {
			        $scope.NowTime = new Date().toLocaleString();
			    }, 1000);
			}
		}
	})
})(angular.module('common.ui'));