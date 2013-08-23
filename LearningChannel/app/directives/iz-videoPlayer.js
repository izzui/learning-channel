//angular.module('izzuiApp').directive("izVideoplayer", function ($compile) {
//	return {
//		restrict: 'E',
//		template: '<video id="{{model.id}}" class="video-js vjs-default-skin {{model.type}}" ' +
//			'controls preload="auto" poster="{{model.thumb}}" data-setup="">' +
//			'<source ng-repeat="x in model.sources" src="{{x.url}}" type="{{x.type}}" />' +
//			'</iz-videoplayer>',
//		scope: {model: '='}
//	};
//});

angular.module('izzuiApp').directive("izVideoplayer", function () {
	return {
		link: function (scope, element, attrs) {
			
			attrs.$observe('id', function (value) {
				if (attrs.id) {
					attrs.dataSetup = {};
					var dataSetup = {
						'techOrder': [attrs.type],
						'src': attrs.url,
						'controls': true,
						'preload': 'auto',
						'autoplay': false,
						'height': 360,
						'width': 640,
						'poster': attrs.poster
					};

					dataSetup = angular.extend(dataSetup, attrs.dataSetup);
					element.attr('id', attrs.id);

					var player = _V_(attrs.id, dataSetup, function () {
						this.src[{ type: attrs.type, src: attrs.src }];
					});
				}		
			});

			
		}
	};
});


////attrs.type = attrs.type || "video/mp4";
//attrs.id = attrs.id || "videojs" + Math.floor(Math.random() * 100);
//attrs['data-setup'] = attrs['data-setup'] || {};

//console.log('attrs.id: ' + attrs.id);

//datasetup = angular.extend(datasetup, attrs['data-setup']);
//element.attr('id', attrs.id);
//var player = _V_(attrs.id, datasetup, function() {
//	this.src[{ type: attrs.type, src: attrs.src}];
//});




//	function () {
//	return {
//		restrict: 'E',
//		replace: true,
//		transclude: true,
//		templateUrl: '/app/directives/iz-videoPlayer.html',
//		scope: {
//			model: '='
//		}
//	};
//});