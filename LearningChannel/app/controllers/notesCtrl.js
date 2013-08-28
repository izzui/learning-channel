//VideoPlayer
angular.module('izzuiApp')
	.controller('notesCtrl', ['$scope',
		function ($scope) {

			$scope.notes = ['Remember to visit www.tyffany.com constantly to keep me updated',
				'Conduct a search about the pink diamonds'];
			
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