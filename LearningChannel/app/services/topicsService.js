angular.module('izzuiApp')
    .service('topicsService', ['$http','$rootScope', function ($http,$rootScope) {

    	var urlBase = $rootScope.baseApiUrl;

        this.getTopics = function () {
            return $http.get(urlBase + 'topics');
        };
    }]);