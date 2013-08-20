angular.module('izzuiApp')
    .service('facebookService', function ($http, $cookies) {
        var urlBase = 'https://graph.facebook.com/';
        var userId = $cookies.iz_izzui_userId;
        var token = $cookies.iz_izzui_accessToken;

        this.getFriends = function (limit) {
            var url = urlBase + userId + '/friends?fields=id,picture,name&limit=' + limit + '&access_token=' + token;
            return $http.get(url);
        };
    });


