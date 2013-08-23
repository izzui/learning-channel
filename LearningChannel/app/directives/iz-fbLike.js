angular.module('izzuiApp').directive("fbLike", function () {
	return {
		restrict: 'A',
		link: function (scope, element, attrs) {
			attrs.$observe('href', function (value) {
				//attrs.id = "fbLike" + new Date().getTime();
				//element.attr('id', attrs.id);
				if (attrs.href.indexOf('/', attrs.href.length - 1) === -1) {
					return typeof FB !== "undefined" && FB !== null ? FB.XFBML.parse(element.parent()[0]) : void 0;
				}
			});
		}
	};
});