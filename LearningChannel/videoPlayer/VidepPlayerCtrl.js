//VideoPlayer
function VideoPlayerCtrl($scope) {
	//var video = {
	//	id: 1,
	//	thumb: "//img.youtube.com/vi/4ukpG_iPx1Q/0.jpg",
	//	url: "//www.youtube.com/embed/4ukpG_iPx1Q",
	//	progress: 0
	//};
	//var youtube = url.indexOf('youtube') != -1 || url.indexOf('youtu.be');
	$scope.video = {
		id: 1,
		width: 640,
		height: 360,
		poster: '',
		dataSetup: '{ "techOrder": ["youtube"], "src": "http://www.youtube.com/watch?v=xjS6SftYQaQ&list=SPA60DCEB33156E51F" }',
		sourceMp4: '',
		sourceWebm: '',
		sourceOgv: ''
	};
}