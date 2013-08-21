angular.module('izzuiApp')
    .controller('coursesController', ['$scope', '$cookies', 'coursesService',
        function ($scope, $cookies, coursesService) {

            $scope.enrolledCourses;
            $scope.recentCourses;
            $scope.selectCourseId = 2;

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

            function getCourse() {
                coursesService.getCourse($scope.selectCourseId)
                    .success(function (data) {
                        $scope.course = data;
                    })
                    .error(function (error) {
                        $scope.status = 'Unable to load customer data: ' + error.message;
                    });
            }

            getCourse();
            enrolledCourses();
            recentCourses();
        }]);