angular.module('learningchannel', [])
  .config(['$routeProvider', function ($routeProvider) {
      $routeProvider.
          when('/course', { templateUrl: 'app/views/course.html' }).
          when('/', { templateUrl: 'app/views/home.html' }).
          otherwise({ redirectTo: '/' });
  }])
  .run(function ($rootScope) {
      $rootScope.$on('$includeContentLoaded', initEnquire);
      $rootScope.$on('$viewContentLoaded', initEnquire);
   });