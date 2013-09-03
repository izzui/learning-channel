var izzuiApp = angular.module('izzuiApp', ['ngCookies'])
	.config(function ($routeProvider, $httpProvider,$locationProvider) {
		$locationProvider.html5Mode(false).hashPrefix('!');
		$routeProvider.
			when('/course/:courseId', { templateUrl: 'app/views/course.html' }).
			when('/', { templateUrl: 'app/views/home.html' }).
			when('/course', { templateUrl: 'app/views/course.html' }).
			when('/groups', { templateUrl: 'app/views/groups.html' }).
			when('/course-unsub/:courseId', { templateUrl: 'app/views/course-unsub.html' }).
			when('/video/:videoId', { templateUrl: 'app/views/video.html' }).
			otherwise({ redirectTo: '/' });

		delete $httpProvider.defaults.headers.common['X-Requested-With'];
	})
	.run(function ($rootScope, $location) {
		$rootScope.$on('$includeContentLoaded', initEnquire);
		$rootScope.$on('$viewContentLoaded', initEnquire);
		$rootScope.baseApiUrl = 'http://lc-fordummiesapi.elasticbeanstalk.com/';
		$rootScope.facebookAppId = '379015832228021';
		$rootScope.appAccessToken = '379015832228021|kM8x4wsWikny5YoEJjoQPg-q76g';
		$rootScope.facebookChanelUrl = '//lc-fordummies.elasticbeanstalk.com/channel.html';
	}
);