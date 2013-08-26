izzuiApp
	.directive('izTopics', function (topicsService) {
	    return {
            restrict: 'E',
            scope: true,
            replace: true,
            templateUrl: '/app/directives/iz-topics.html',
            link: function (scope, element, attr) {
                topicsService.getTopics()
                    .success(function (data) {
                        scope.topics = data;
                    })
                    .error(function (error) {
                        scope.topics = ['Error on loading topics: ' + error ];
                    });
            }
	    }
	});
