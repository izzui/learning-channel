angular.module('izzuiApp').directive("izVideoplayer", function () {
	return {
		link: function (scope, element, attrs) {
			
			attrs.$observe('videodata', function (value) {
				if (attrs.videodata) {
					var video = angular.fromJson(attrs.videodata);
					attrs.id = "videojs" + video.id + new Date().getTime();
					attrs.dataSetup = attrs.dataSetup || {};
					var dataSetup;
					var sources = [];
					if (video.type == 'youtube' || video.type == 'vimeo') {
						dataSetup = {
							'techOrder': [video.type],
							'src': video.url,
							'controls': true,
							'preload': 'auto',
							'autoplay': false,
							'height': video.height,
							'width': video.width,
							'poster': video.thumb
						};
					} else {
						dataSetup = {
							'techOrder': [video.type],
							'controls': true,
							'preload': 'auto',
							'autoplay': false,
							'height': video.height,
							'width': video.width
						};
						sources = [{ type: video.sources[0].type, src: video.sources[0].url },
							{ type: video.sources[1].type, src: video.sources[1].url },
							{ type: video.sources[2].type, src: video.sources[2].url }];
					}
					dataSetup = angular.extend(dataSetup, attrs.dataSetup);
					element.attr('id', attrs.id);
					element.addClass(video.type);
					var player = _V_(attrs.id, dataSetup, function () {
						this.src(sources);
					});
				}		
			});

			
		}
	};
});