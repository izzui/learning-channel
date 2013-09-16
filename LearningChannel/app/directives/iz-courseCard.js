izzuiApp.directive("izCourseCard", function () {
    return {
        restrict: 'E',
        scope: {
            course: '=',
            pageTo: '@',
            progress: '@'
        },
        //replace: true,
        templateUrl: '/app/directives/iz-courseCard.html'
    }
});