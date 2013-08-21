angular.module('izzuiApp')
    .service('videoSvc', ['$http', function ($http) {

    	var urlBase = 'http://local-learningchannelapi.izzui.com/';

    	this.get = function (videoId) {
    		return  {
    				id: 1,
    				thumb: "//img.youtube.com/vi/4ukpG_iPx1Q/0.jpg",
    				url: "//www.youtube.com/embed/4ukpG_iPx1Q",
    				title: "Video 1 Title",
    				progress: 0,
    				previousVideoId: null,
    				nextVideoId: 2,
    				videosViewed: 3,
    				totalVideos: 9
    			};
    		//$http.get(urlBase + 'video/' + videoId);
    	};

    }]);
