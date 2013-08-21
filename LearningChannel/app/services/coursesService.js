angular.module('izzuiApp')
    .service('coursesService', ['$http', function ($http) {

        var urlBase = 'http://local-learningchannelapi.izzui.com/';

        this.getEnrolledCourses = function (userId) {
            return $http.get(urlBase + 'users/' + userId + '/courses');
        };

        this.getRecentCourses = function () {
            return $http.get(urlBase + 'courses/?sort=PublishDate');
        };

        this.getCourse = function (id) {
            return $http.get(urlBase + 'courses/' + id);
        };
    }]);
