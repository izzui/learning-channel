angular.module('izzuiApp')
    .service('boardsService', ['$http', function ($http) {

        var urlBase = 'http://local-learningchannelapi.izzui.com/';

        this.getBoard = function (lastMonth) {
            return $http.get(urlBase + 'board?lastMonth=' + lastMonth);
        };
    }]);


