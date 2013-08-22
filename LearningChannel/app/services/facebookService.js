angular.module('izzuiApp')
    .service('facebookService', function ($http, $cookies) {
        var urlBase = 'https://graph.facebook.com/';
        var userId = $cookies.iz_izzui_userId;
        var userToken = $cookies.iz_izzui_accessToken;
        var appId = '212553442202383';
        var appToken = '212553442202383|zIGD114FUd3RihFP8ENA14NlsZE';

        var urlFor = function (id, path, token, options) {
            var url = urlBase + id + "/" + path + "?access_token=" + token + "&";
            return url + encodeOptions(options);
        }

        var encodeOptions = function (options) {
            arr = [];
            for (option in options) { arr.push(option + "=" + options[option]); }
            return arr.join('&');
        }

        this.getFriends = function (limit) {
            
            return $http.get(urlFor(userId, 'friends', userToken, { fields: 'id,picture,name', limit: limit } ));
        }

        this.getGroups = function () {
            // GET /212553442202383/groups?access_token=212553442202383|zIGD114FUd3RihFP8ENA14NlsZE
            return $http.get(urlFor(appId, 'groups', appToken));
        }

        this.createGroup = function (name, description, privacy) {
            // POST /212553442202383/groups?access_token=212553442202383|zIGD114FUd3RihFP8ENA14NlsZE&name=Novo Grupo&description=Mais um grupo&privacy=open&admin=790128571
            return $http.post(urlFor(appId, 'groups', appToken,
                { name: name, description: description || '', privacy: privacy || 'OPEN', admin: userId }));
        }

        this.getGroup = function (groupId) {
            // GET /213400282117699?access_token=212553442202383|zIGD114FUd3RihFP8ENA14NlsZE
            return $http.get(urlFor(groupId, "", appToken));
        }

        this.deleteGroup = function (groupId) {
            // DELETE /212553442202383/groups/213399078784486?access_token=212553442202383|zIGD114FUd3RihFP8ENA14NlsZE
            return $http.delete(urlFor(appId, 'groups/' + groupId, appToken));
        }
    });