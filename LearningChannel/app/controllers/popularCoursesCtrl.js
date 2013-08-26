izzuiApp
    .controller('popularCoursesCtrl', function ($scope, coursesService) {
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