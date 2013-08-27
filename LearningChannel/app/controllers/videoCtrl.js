//VideoPlayer
angular.module('izzuiApp')
	.controller('videoCtrl', ['$scope', '$routeParams', 'videoSvc',
		function ($scope, $routParams, videosvc) {
			function get() {
				videosvc.get($routParams.videoId)
					.success(function (data) {
						$scope.video = data;
						var dataSetup = '{ "techOrder": ["html5"] }';
						if (data.type == 'youtube')
							dataSetup = '{ "techOrder": ["youtube"], "src": "' + data.url + '" }';
						else if (data.type == 'vimeo')
							dataSetup = '{ "techOrder": ["vimeo"], "src": "' + data.url + '", "loop": true, "autoplay": false }';
						$scope.dataSetup = dataSetup;
						$scope.previousId = $scope.video.previousId;
						$scope.nextId = $scope.video.nextId;
						$scope.progress = Math.floor(($scope.video.videosCompleted / $scope.video.videosCount) * 100);
						$scope.htmlReady();
					})
					.error(function (error) {
						$scope.status = 'Unable to load customer data: ' + error.message;
					});
			}

			get();

		}])