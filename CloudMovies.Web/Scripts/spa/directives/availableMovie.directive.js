//(function (app) {
//    'use strict';

//    app.directive('availableMovie', function () {
//        return {
//            restrict: "E",
//            templateUrl: "/Scripts/spa/directives/availableMovie.html",
//            link: function ($scope,$element,$attrs) {
//            	$scope.getAvailableClass = function () {
//            		if ($attrs.isAvailable === 'true') {
//            			return 'lable lable-success';
//            		} else {
//            			return 'lable lable-danger';
//            		}
//            	};
//            		$scope.getAvailablity = function () {
//            			if ($attrs.isAvailable === 'true') {
//            				return 'Avalible!';
//            			} else {
//            				return 'Not Available';
//            			}
//            		}
//            }
//        };
//        //return {
//        //    restrict: "E",
//        //    templateUrl: "/Scripts/spa/directives/availableMovie.html",
            
//        //}
//    });
//})(angular.module('common.ui'));
(function (app) {
    'use strict';

    app.directive('availableMovie', availableMovie);

    function availableMovie() {
        return {
            restrict: 'E',
            templateUrl: "/Scripts/spa/directives/availableMovie.html",
            link: function ($scope, $element, $attrs) {
                console.log($attrs);
                $scope.getAvailableClass = function () {
                    if ($attrs.isAvailable === 'true')
                        return 'label label-success'
                    else
                        return 'label label-danger'
                };
                $scope.getAvailability = function () {
                    if ($attrs.isAvailable === 'true')
                        return 'Available!'
                    else
                        return 'Not Available'
                };
            }
        }
    }

})(angular.module('common.ui'));