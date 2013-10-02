//VideoPlayer
angular.module('izzuiApp')
	.controller('notesCtrl', ['$scope',
		function ($scope) {

			$scope.notes = [ 'Visit www.acme.com to update about their products.',
				'Discuss with Helen about 2:34.' ];
			
			$scope.note = '';

			$scope.remove = function (index) {
				$scope.notes.splice(index,1);
			};

			$scope.add = function (note) {
				$scope.notes.push(note);
				console.log($scope.notes);
				$scope.note = '';
			};
		}])