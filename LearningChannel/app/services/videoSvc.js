angular.module('izzuiApp')
    .service('videoSvc', ['$http', '$rootScope', function ($http, $rootScope) {

	    var urlBase = $rootScope.baseApiUrl;
    	this.get = function (videoId) {
    		return $http.get(urlBase + 'videos/' + videoId);
    	};

    }]);
