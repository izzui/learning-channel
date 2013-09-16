angular.module('izzuiApp')
    .controller('recentCoursesCtrl', function ($scope, $cookies, coursesService) {
        $scope.cardOptions = { progress: false, pageTo: 'course-unsub' };
        function recentCourses() {
                var userId = $cookies.iz_izzui_userId;
                coursesService.getRecentCourses()
                    .success(function (data) {
                    	$scope.courses = data;
                    	console.log(data);
                    })
                    .error(function (error) {
                        $scope.status = 'Unable to load customer data: ' + error.message;
                    });
            }
            recentCourses();
        });