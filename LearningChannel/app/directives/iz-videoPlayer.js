/// <reference path="app.ts" />

app.directive("iz-videoPlayer", function () {
	return {
		restrict: 'E',
		replace: true,
		transclude: true,
		templateUrl: '/app/directives/iz-videoPlayer.html',
		scope: {
			model: '='
		}
	};
});