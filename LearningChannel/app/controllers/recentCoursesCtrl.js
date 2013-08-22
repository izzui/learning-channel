angular.module('izzuiApp')
    .controller('recentCoursesCtrl', function ($scope, $cookies, coursesService) {
            function recentCourses() {
                var userId = $cookies.iz_izzui_userId;
                coursesService.getRecentCourses()
                    .success(function (data) {
                        $scope.courses = data;
                    })
                    .error(function (error) {
                        $scope.status = 'Unable to load customer data: ' + error.message;
                    });
            }
            recentCourses();
        });