angular.module('izzuiApp')
    .service('videoService', ['$http', function ($http) {

    	var urlBase = 'http://local-learningchannelapi.izzui.com/';

    	this.get = function (videoId) {
    		return $http.get(urlBase + 'video/' + videoId);
    	};

    }]);
