var izzuiApp = angular.module('izzuiApp', ['ngCookies','seo'])
  .config(function ($routeProvider, $httpProvider) {
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
      $rootScope.baseApiUrl = $location.protocol() + "://local-learningchannelapi.izzui.com/";
  });