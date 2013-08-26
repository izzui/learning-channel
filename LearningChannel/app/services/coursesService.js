angular.module('izzuiApp')
    .service('coursesService', ['$http','$rootScope', function ($http,$rootScope) {

    	var urlBase = $rootScope.baseApiUrl;
        this.getEnrolledCourses = function (userId) {
            return $http.get(urlBase + 'users/' + userId + '/courses');
        };

        this.getRecentCourses = function () {
            return $http.get(urlBase + 'courses/?sort=PublishDate');
        };

        this.getPopularCourses = function () {

            return $http.get(urlBase + 'courses/?sort=Subscriptions');
        };

        this.getCourse = function (id) {
            return $http.get(urlBase + 'courses/' + id);
        };
    }]);
