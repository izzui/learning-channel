angular.module('izzuiApp').directive("gPlus", function () {
	return {
		restrict: 'A',
		link: function (scope, element, attrs) {
			console.log('gPlus directive');
			attrs.$observe('href', function (value) {
				console.log('opa gplus');
				if (attrs.href.indexOf('/', attrs.href.length - 1) === -1) {
					attrs.dataHref = attrs.href;
					element.attr('data-href', attrs.dataHref);
					gapi.plus.go();
				}
			});
		}
	};
});