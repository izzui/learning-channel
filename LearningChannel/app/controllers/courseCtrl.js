angular.module('izzuiApp')
    .controller('courseCtrl', function ($scope, $routeParams, $location, coursesService, notificationService) {
        function getCourse() {
            coursesService.getCourse($routeParams.courseId)
                .success(function (data) {
                    $scope.course = data;
                })
                .error(function (error) {
                    $scope.status = 'Unable to load customer data: ' + error.message;
                });
        } 
        $scope.subscribe = function () {
            notificationService.notify({ layout: 'topCenter', type: 'information', badge: 'interested' });
            $location.path('/course/' + $routeParams.courseId);
        }; 
        getCourse();
    });