//VideoPlayer
angular.module('izzuiApp')
	.controller('notesCtrl', ['$scope',
		function ($scope) {

			$scope.notes = [ 'Lembrar de visitar www.vivo.com.br constantemente para me manter atualizado.',
				'Falar com a Helena sobre o assunto do vídeo em 2:34.' ];
			
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