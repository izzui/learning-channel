izzuiApp
    .controller('popularCoursesCtrl', function ($scope, coursesService) {
        $scope.cardOptions = { progress: false, pageTo: 'course-unsub' };

        function popularCourses() {
            coursesService.getPopularCourses()
                .success(function (data) {
                    $scope.courses = data;
                })
                .error(function (error) {
                    $scope.status = 'Unable to load customer data: ' + error.message;
                });
        }
        popularCourses();
    });