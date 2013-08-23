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
			
			attrs.$observe('videodata', function (value) {
				if (attrs.videodata) {
					attrs.id = attrs.id || "videojs" + Math.floor(Math.random() * 100);
					attrs.dataSetup = attrs.dataSetup || {};
					console.log(attrs.videodata);
					var video = angular.fromJson(attrs.videodata);
					console.log(video);
					//attrs.dataSetup = {};
					console.log(video.type, video.url);
					var dataSetup;
					var sources = [];
					if (video.type == 'youtube' || video.type == 'vimeo') {
						dataSetup = {
							'techOrder': [video.type],
							'src': video.url,
							'controls': true,
							'preload': 'auto',
							'autoplay': false,
							'height': 360,
							'width': 640,
							'poster': video.thumb
						};
					} else {
						dataSetup = {
							'techOrder': [video.type],
							'controls': true,
							'preload': 'auto',
							'autoplay': false,
							'height': 360,
							'width': 640
						};
						sources = [{ type: video.sources[0].type, src: video.sources[0].url },
							{ type: video.sources[1].type, src: video.sources[1].url },
							{ type: video.sources[2].type, src: video.sources[2].url }];
					}
					dataSetup = angular.extend(dataSetup, attrs.dataSetup);
					element.attr('id', attrs.id);

					var player = _V_(attrs.id, dataSetup, function () {
						this.src(sources);
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