angular.module('izzuiApp')
    .service('boardsService', ['$http', '$rootScope', function ($http, $rootScope) {

    	var urlBase = $rootScope.baseApiUrl;

        this.getBoard = function (lastMonth) {
            return $http.get(urlBase + 'board?lastMonth=' + lastMonth);
        };
    }]);


