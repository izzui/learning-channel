izzuiApp.directive("izCoursecard", function () {
    return {
        restrict: 'E',
        scope: {
            course: '='
        },
        replace: true,
        templateUrl: '/app/directives/iz-courseCard.html'
    }
});