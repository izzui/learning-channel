var FacebookRequest = function () {
	FB.ui({
		method: 'apprequests',
		message: 'Request Friends'
	}, FacebookRequestCallback);
}

var FacebookRequestCallback = function (data) {

}