izzuiApp
    .controller('enrolledCoursesCtrl', function ($scope, $cookies, coursesService) {
        $scope.cardOptions = { progress: true, pageTo: 'course' };
        function enrolledCourses() {
                var userId = $cookies.iz_izzui_userId;
                coursesService.getEnrolledCourses(userId)
                    .success(function (data) {
                        $scope.courses = data;
                    })
                    .error(function (error) {
                        $scope.status = 'Unable to load customer data: ' + error.message;
                    });
            }
            enrolledCourses();
        });