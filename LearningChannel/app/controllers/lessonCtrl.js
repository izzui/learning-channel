//VideoPlayer
angular.module('izzuiApp')
	.controller('lessonCtrl', ['$scope', '$routeParams', '$location', 'videoSvc',
		function ($scope, $routParams, $location, videosvc) {
			var video = null;
			videosvc.get($routParams.lessonId)
				.success(function(data) {
					
				})
				.eoor(function(error) {
					$scope.status = 'Unable to load customer data: ' + error.message;
				});

			//var youtubeVideo = {
			//	id: 1,
			//	width: 640,
			//	height: 360,
			//	poster: '',
			//	dataSetup: '{ "techOrder": ["youtube"], "src": "' + $location.protocol() + '://www.youtube.com/watch?v=xjS6SftYQaQ&list=SPA60DCEB33156E51F" }',
			//	sources: null,
			//	type: 'youtube'
			//};

			//var vimeoVideo = {
			//	id: 2,
			//	width: 640,
			//	height: 360,
			//	poster: '',
			//	dataSetup: '{ "techOrder": ["vimeo"], "src": "' + $location.protocol() + '://vimeo.com/71761288", "loop": false, "autoplay": false }',
			//	source: null,
			//	type: 'vimeo'
			//};

			//var regularVideo = {
			//	id: 3,
			//	width: 640,
			//	height: 264,
			//	poster: $location.protocol() + '://local-learningchannel.izzui.com/oceans-clip.png',
			//	dataSetup: '',
			//	sources: [{ src: $location.protocol() + '://local-learningchannel.izzui.com/oceans-clip.mp4', type: 'video/mp4' },
			//		{ src: $location.protocol() + '://local-learningchannel.izzui.com/oceans-clip.webm', type: 'video/webm' },
			//		{ src: $location.protocol() + '://local-learningchannel.izzui.com/oceans-clip.ogv', type: 'video/ogg' }
			//	],
			//	type: 'regular'
			//};

			//$scope.chapter = {
			//	title: 'Video 1 Title',
			//	index: 1,
			//	courseProgress: { lessonsTotal: 10, lessonsFinished: 3 },
			//	video: regularVideo
			//};
			//var video = {
			//	id: 1,
			//	thumb: "//img.youtube.com/vi/4ukpG_iPx1Q/0.jpg",
			//	url: "//www.youtube.com/embed/4ukpG_iPx1Q",
			//	title: "Video 1 Title",
			//	progress: 0
			//};

			//var type = 'regular';
			//if (video.url.indexOf('youtube') != -1 || video.url.indexOf('youtu.be'))
			//	type = 'youtube';
			//else if (video.url.indexOf('vimeo'))
			//	type = 'vimeo';

			//var lesson = {				

			//}

		}])