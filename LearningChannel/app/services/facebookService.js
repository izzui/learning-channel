angular.module('izzuiApp')
    .service('facebookService', function ($http, $cookies) {
        var urlBase = 'https://graph.facebook.com/';
        var userId = $cookies.iz_izzui_userId;
        var token = $cookies.iz_izzui_accessToken;
        var appId = '212553442202383';
        var appSecret = 'ff40b6ef7832dd50df6a73068b2c9b88';

        this.urlFor = function (id, path, options) {
            var url = urlBase + id + "/" + path + "?access_token=" + token + "&";
            return url + this.encodeOptions(options);
        }

        this.encodeOptions = function (options) {
            arr = [];
            for (option in options) { arr.push(option + "=" + options[option]); }
            return arr.join('&');
        }

        this.getFriends = function (limit) {
            return $http.get(urlFor(userId, 'friends', { fields: 'id,picture,name', limit: limit } ));
        }

        this.getAppToken = function () {
            $http.get(urlBase + '/oauth/access_token?' +
                        this.encodeOptions(
                            {client_id: appId, client_secret: appSecret,
                            grant_type: 'client_credentials'
                            })
            ).success(function (data) {
                return data.split("=")[1]
            }).error(function (error) {
                return null;
           });
        }

        this.getGroups = function () {
            return $http.get(urlFor(appId, 'groups'));
        }
    });