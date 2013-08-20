angular.module('izzuiApp')
    .controller('coursesController', ['$scope', '$cookies', 'coursesService',
        function ($scope, $cookies, coursesService) {

            $scope.enrolledCourses;
            $scope.recentCourses;

            function enrolledCourses() {
                var userId = $cookies.iz_izzui_userId;
                coursesService.getEnrolledCourses(userId)
                    .success(function (data) {
                        $scope.enrolledCourses = data;
                    })
                    .error(function (error) {
                        $scope.status = 'Unable to load customer data: ' + error.message;
                    });
            }

            function recentCourses() {
                var userId = $cookies.iz_izzui_userId;
                coursesService.getRecentCourses()
                    .success(function (data) {
                        $scope.recentCourses = data;
                    })
                    .error(function (error) {
                        $scope.status = 'Unable to load customer data: ' + error.message;
                    });
            }
            enrolledCourses();
            recentCourses();
        }]);