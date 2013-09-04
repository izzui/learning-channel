//VideoPlayer
angular.module('izzuiApp')
	.controller('notesCtrl', ['$scope',
		function ($scope) {

			$scope.notes = [ 'Remind to read the first chapter of the book over again. ',
				'Show Helena this video at 2:34.' ];
			
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