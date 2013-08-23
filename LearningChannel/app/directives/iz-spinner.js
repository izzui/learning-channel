izzuiApp
	.directive('izSpinner', ['$window', function ($window) {
	    return {
	        scope: true,
	        link: function (scope, element, attr) {
	            function createSpinner(options) {
	                if (scope.spinner) {
	                    scope.spinner.stop();
	                }
	                scope.spinner = new $window.Spinner(scope.options);
	                scope.spinner.spin(element[0]);
	            }

	            scope.spinner = null;

	            scope.$watch(attr.izSpinner, function (options) {
	                scope.options = options;
	                createSpinner();
	            }, true);

	            scope.$watch(attr.hideSpinner, function (val) {
	                if (!val) {
	                    createSpinner();
	                }
	                else {
                        if (scope.spinner)
                            scope.spinner.stop();
                    }
	            }, true);

	        }
	    };
	}]);