angular.module('izzuiApp')
    .controller('courseCtrl', function ($scope, $routeParams, coursesService) {
        function getCourse() {
            coursesService.getCourse($routeParams.courseId)
                .success(function (data) {
                    $scope.course = data;
                })
                .error(function (error) {
                    $scope.status = 'Unable to load customer data: ' + error.message;
                });
        }

        getCourse();
    });