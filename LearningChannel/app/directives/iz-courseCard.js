izzuiApp.directive("izCoursecard", function () {
    return {
        restrict: 'E',
        scope: {
            course: '=',
            pageTo: '@',
            progress: '@'
        },
        replace: true,
        templateUrl: '/app/directives/iz-courseCard.html'
    }
});