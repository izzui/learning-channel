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
			when('/user', { templateUrl: 'app/views/user-home.html' }).
			when('/topic', { templateUrl: 'app/views/topic-home.html' }).
			when('/search', { templateUrl: 'app/views/search-result.html' }).
			otherwise({ redirectTo: '/' });

		delete $httpProvider.defaults.headers.common['X-Requested-With'];
	})
	.run(function ($rootScope, $location) {
		$rootScope.$on('$includeContentLoaded', initEnquire);
		$rootScope.$on('$viewContentLoaded', initEnquire);
		$rootScope.baseApiUrl = 'http://acmeapi.elasticbeanstalk.com/';
		$rootScope.facebookAppId = '559705870746076';
		$rootScope.appAccessToken = '559705870746076|sTT4N_8z9HYa2b-IdqBHJb9HtW8';
		$rootScope.facebookChanelUrl = '//acme.elasticbeanstalk.com/channel.html';
	}
);