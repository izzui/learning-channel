angular.module('izzuiApp', ['ngCookies'])
  .config(function ($routeProvider, $httpProvider) {
      $routeProvider.
          when('/course', { templateUrl: 'app/views/course.html' }).
          when('/', { templateUrl: 'app/views/home.html' }).
          when('/groups', { templateUrl: 'app/views/groups.html' }).
          otherwise({ redirectTo: '/' });

    delete $httpProvider.defaults.headers.common['X-Requested-With'];

  })
  .run(function ($rootScope) {
      $rootScope.$on('$includeContentLoaded', initEnquire);
      $rootScope.$on('$viewContentLoaded', initEnquire);
    })
  });