angular.module('izzuiApp')
    .service('videoSvc', ['$http', function ($http) {

    	var urlBase = 'https://local-learningchannelapi.izzui.com/';

    	this.get = function (videoId) {
    		return $http.get(urlBase + 'videos/' + videoId);
    	};

    }]);
