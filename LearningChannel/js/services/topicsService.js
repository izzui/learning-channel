angular.module('izzuiApp')
    .service('topicsService', ['$http', function ($http) {

        var urlBase = 'http://local-learningchannelapi.izzui.com/';

        this.getTopics = function () {
            return $http.get(urlBase + 'topics');
        };
    }]);