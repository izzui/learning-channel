﻿//VideoPlayer
angular.module('izzuiApp')
	.controller('videoCtrl', ['$scope', '$routeParams', 'videoSvc',
		function ($scope, $routParams, videosvc) {
			function get() {
				videosvc.get($routParams.videoId)
					.success(function (data) {
						console.log('controller success');
						$scope.video = data;
						var dataSetup = '{ "techOrder": ["html5"] }';
						if (data.type == 'youtube')
							dataSetup = '{ "techOrder": ["youtube"], "src": "' + data.url + '" }';
						else if (data.type == 'vimeo')
							dataSetup = '{ "techOrder": ["vimeo"], "src": "' + data.url + '", "loop": true, "autoplay": false }';
						$scope.dataSetup = dataSetup;
						console.log($scope.video.id );
					})
					.error(function (error) {
						console.log('controller error');
						$scope.status = 'Unable to load customer data: ' + error.message;
					});
			}

			get();

		}])