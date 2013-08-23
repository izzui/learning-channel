angular.module('izzuiApp').directive("fbComments", function () {
	return {
		restrict: 'A',
		link: function (scope, element, attrs) {
			attrs.$observe('href', function (value) {
				if (attrs.href.indexOf('/', attrs.href.length - 1) === -1) {
					return typeof FB !== "undefined" && FB !== null ? FB.XFBML.parse(element.parent()[0]) : void 0;
				}
			});
		}
	};
});